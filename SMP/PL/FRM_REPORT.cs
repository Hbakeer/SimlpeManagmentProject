using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SMP.EPL;
using DevExpress.XtraReports.UI;

namespace SMP.PL
{
    public partial class FRM_REPORT : Form
    {
        public FRM_REPORT()
        {
            InitializeComponent();


        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            PL.XtraReport1 report = new XtraReport1();
            report.ShowDesigner();
        }
    }
}
