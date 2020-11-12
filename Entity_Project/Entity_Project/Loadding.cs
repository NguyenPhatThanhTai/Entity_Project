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
using System.Threading;

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
            await Task.Delay(1000);
            pb1.Show();
            WhenStartedcs ws = new WhenStartedcs();
            await Task.Delay(3000);
            ws.check();
            this.Hide();
        }
    }
}