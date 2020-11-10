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
    public partial class Loadding : DevExpress.XtraEditors.XtraForm
    {
        public Loadding()
        {
            InitializeComponent();
        }

        private async void Loadding_Load(object sender, EventArgs e)
        {
            pb1.Hide();
            await Task.Delay(1000);
            pb1.Show();
            await Task.Delay(10000);
            WhenStartedcs ws = new WhenStartedcs();
            ws.check();
            this.Hide();
        }
    }
}