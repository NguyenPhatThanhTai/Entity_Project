using Entity_Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Project
{
    class Data_LK
    {
        Data data = new Data();
        DateTime time = DateTime.Now;
        string day = DateTime.Now.ToString("dd");
        string Min = DateTime.Now.ToString("mm");
        string sec = DateTime.Now.ToString("ss");
        public List<Inf_WareHouse> Inf_WareHouse()
        {
            List<Inf_WareHouse> list = data.Inf_WareHouse.ToList();
            return list;
        }

        public List<Inf_LK> Inf_LK()
        {
            List<Inf_LK> list = data.Inf_LK.ToList();
            return list;
        }

        public List<Inf_LK> FillByWareHouse(string WareHouse_Id)
        {
            List<Inf_LK> list = data.Inf_LK.Where(p => p.WareHouse_Id == WareHouse_Id).ToList();
            return list;
        }

        public bool Add_LK(string LK_Name, string LK_Number, string LK_Producer, string LK_Price, string WareHouse_Id)
        {
            try
            {
                Inf_LK lk = new Inf_LK()
                {
                    LK_Id = "LK" + day + "" + Min + "" + sec,
                    LK_Name = LK_Name,
                    LK_Number = LK_Number,
                    LK_Producer = LK_Producer,
                    LK_Price = LK_Price,
                    LK_Time_Add = time,
                    WareHouse_Id = WareHouse_Id
                };
                data.Inf_LK.Add(lk);
                data.SaveChanges();
                time = DateTime.Now;
                day = DateTime.Now.ToString("dd");
                Min = DateTime.Now.ToString("mm");
                sec = DateTime.Now.ToString("ss");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update_LK(string LK_Name, string LK_Number, string LK_Producer, string LK_Price, string WareHouse_Id, string LK_Id)
        {
            try
            {
                Inf_LK lk = data.Inf_LK.FirstOrDefault(p => p.LK_Id == LK_Id);
                if (lk != null)
                {
                    lk.LK_Name = LK_Name;
                    lk.LK_Number = LK_Number;
                    lk.LK_Producer = LK_Producer;
                    lk.LK_Price = LK_Price;
                    lk.WareHouse_Id = WareHouse_Id;

                    data.SaveChanges();
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool Delete_LK(string LK_Id)
        {
            try
            {
                Inf_LK lk = data.Inf_LK.FirstOrDefault(p => p.LK_Id == LK_Id);
                if(lk != null)
                {
                    data.Inf_LK.Remove(lk);

                    data.SaveChanges();
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public void InsertExcelRecords(string path)
        {
            try
            {
                //  ExcelConn(_path);  
                string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", path);
                OleDbConnection Econ = new OleDbConnection(constr);
                string Query = string.Format("Select [Mã linh kiện],[Mã kho hàng],[Tên linh kiện],[Số lượng],[Nhà cung cấp],[Giá tiền],[Thời gian thêm] FROM [{0}]", "Trang_tính1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();

                DataSet ds = new DataSet();
                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                Econ.Close();
                oda.Fill(ds);
                DataTable Exceldt = ds.Tables[0];

                for (int i = Exceldt.Rows.Count - 1; i >= 0; i--)
                {
                    if (Exceldt.Rows[i]["Mã kho hàng"] == DBNull.Value || Exceldt.Rows[i]["Mã linh kiện"] == DBNull.Value)
                    {
                        Exceldt.Rows[i].Delete();
                    }
                }
                Exceldt.AcceptChanges();
                SqlConnection con = new SqlConnection();
                //creating object of SqlBulkCopy      
                SqlBulkCopy objbulk = new SqlBulkCopy(con);
                //assigning Destination table name      
                objbulk.DestinationTableName = "Inf_LK";
                //Mapping Table column    
                objbulk.ColumnMappings.Add("[Mã linh kiện]", "LK_Id");
                objbulk.ColumnMappings.Add("[Mã kho hàng]", "WareHouse_Id");
                objbulk.ColumnMappings.Add("Tên linh kiện", "LK_Name");
                objbulk.ColumnMappings.Add("Số lượng", "LK_Number");
                objbulk.ColumnMappings.Add("Nhà cung cấp", "LK_Producer");
                objbulk.ColumnMappings.Add("Giá tiền", "LK_Price");
                objbulk.ColumnMappings.Add("[Thời gian thêm]", "LK_Time_Add");

                //inserting Datatable Records to DataBase   
                con.ConnectionString = "Data Source=TAEITAEI\\SQLEXPRESS;Initial Catalog=ProjectOne;Integrated Security=True"; //Connection Details    
                con.Open();
                try
                {
                    objbulk.WriteToServer(Exceldt);
                    con.Close();
                    MessageBox.Show("Dữ liệu đã được thêm hoàn tất.", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Đã tồn tại một hoặc vài linh kiện bị trùng mã linh kiện!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Dữ liệu hiện tại vẫn chưa thể thêm được theo lỗi :{0}", ex.Message), "Lỗi khi thêm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
