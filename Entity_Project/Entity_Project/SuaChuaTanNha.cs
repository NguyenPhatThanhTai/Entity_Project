using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Entity_Project
{
    public partial class SuaChuaTanNha : DevExpress.XtraEditors.XtraForm
    {
        public SuaChuaTanNha()
        {
            InitializeComponent();
        }

        private void DiSuaChua_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1, label1.Text.Length - 1) + label1.Text.Substring(0, 1);
        }
    }
}