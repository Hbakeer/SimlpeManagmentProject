using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class Main : Form
    {

        // init form
        PL.FRM_CAT frm_cat = new PL.FRM_CAT();
        PL.FRM_HOME frm_home = new PL.FRM_HOME();
        PL.FRM_SUP frm_sup = new PL.FRM_SUP();
        PL.FRM_PUR frm_pur = new PL.FRM_PUR();
        PL.FRM_CUS frm_cus = new PL.FRM_CUS();
        PL.FRM_SELL frm_sell = new PL.FRM_SELL();
        PL.FRM_REPORT frm_report = new PL.FRM_REPORT();
        PL.FRM_USER frm_user = new PL.FRM_USER();
        DB_SMPEntities db = new DB_SMPEntities();
        public Main()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Close App
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //App Min
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Colapse
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
            {
                pn_navbar.Width = 50;
                pn_titlenav.Visible = false;
                pn_headernavbar.Height = 200;
            }
            else
            {
                pn_navbar.Width = 250;
                pn_titlenav.Visible = true;
                pn_headernavbar.Height = 253;
            }
        }
        //Load home page
        private void btn_home_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_home.pn_home);
        }
        //load category
        private void btn_cat_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cat.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "الاصناف";

        }

        //load sup
        private void btn_sup_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sup.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "الموردين";
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_pur.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المشتريات";
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_cus.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "العملاء";
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_sell.pn_cat);
            db = new DB_SMPEntities();
            lb_titlepage.Text = "المبيعات";
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_report.pn_cat);
            lb_titlepage.Text = "التقارير";
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(frm_user.pn_cat);
            lb_titlepage.Text = "المستخدمين";
        }
    }
}
