using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP.EPL;
using System.Data.SqlClient;
using Microsoft.Web.Administration;

namespace SMP.PL
{
    public partial class FRM_SELL_ADD : Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_PUR tb_pur = new TB_PUR();
        TB_SELL tb_sell = new TB_SELL();
        BL.Methods methods = new BL.Methods();
        double qtp, qtn, qtr;

        SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=DB_SMP; Integrated Security=True");

        public int id;
        public FRM_SELL_ADD()
        {
            InitializeComponent();


        }


        // add or edit 
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            // Check if add or edit
            qtp = Convert.ToDouble(txt_qt.Text);
            qtn = Convert.ToDouble(edt_qt.Text);
            qtr = qtp - qtn;

            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم المادة المطلوب";
                dialog.Show();
            }
            else
            {
                //Check if add or edit
                if (id == 0)
                {
                    if (qtr >= 0)
                    {
                        //add
                        tb_sell.Sell_Name = edt_name.Text;
                        tb_sell.Sell_Cus = edt_cus.Text;
                        tb_sell.Sell_Price = Convert.ToDouble(edt_sell.Text);
                        tb_sell.Sell_Qt = Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_TPrice = (Convert.ToDouble(edt_sell.Text)) * Convert.ToDouble(edt_qt.Text);
                        tb_sell.Sell_Date = DateTime.Now;
                        db.TB_SELL.Add(tb_sell);
                        tb_pur.Pur_Qt = qtr;
                        db.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        toast.txt_caption.Text = "تم اجراء عملية الشراء";
                        toast.Show();
                        this.Close();
                    }
                    else
                    {
                        label14.Visible = true;
                    }

                }

            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edt_buy_TextChanged(object sender, EventArgs e)
        {
            pro_call();
        }

        private void edt_sell_TextChanged(object sender, EventArgs e)
        {
            pro_call();
        }

        private void edt_qt_EditValueChanged(object sender, EventArgs e)
        {
            pro_call();
        }

        private void edt_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_pur = db.TB_PUR.Where(x => x.Pur_Name == edt_name.Text).FirstOrDefault();
            txt_buy.Text = tb_pur.Pur_Buy.ToString();
            txt_sell.Text = tb_pur.Pur_Sell.ToString();
            txt_qt.Text = tb_pur.Pur_Qt.ToString();
            edt_sell.Text = tb_pur.Pur_Sell.ToString();
        }

        private void FRM_SELL_ADD_Activated(object sender, EventArgs e)
        {
            var rs1 = db.TB_PUR.Select(x => x.Pur_Name).ToList();
            var rs2 = db.TB_CUS.Select(x => x.Sup_Name).ToList();
            edt_name.DataSource = rs1;
            edt_cus.DataSource = rs2;
            AutoCompleteStringCollection ACSC1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2 = new AutoCompleteStringCollection();
            ACSC1.AddRange(rs1.ToArray());
            ACSC2.AddRange(rs2.ToArray());
            edt_name.AutoCompleteCustomSource = ACSC1;
            edt_cus.AutoCompleteCustomSource = ACSC2;




        }

        private void FRM_SELL_ADD_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("select (Pur_Name) from TB_PUR", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Pur_Name", typeof(string));
                dt.Load(reader);
                edt_name.ValueMember = "Pur_Name";
                edt_name.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("select (Sup_Name) from TB_CUS", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Sup_Name", typeof(string));
                dt.Load(reader);
                edt_name.ValueMember = "Sup_Name";
                edt_name.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        */
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_CAT_ADD frm_add = new FRM_CAT_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FRM_SUP_ADD frm_add = new FRM_SUP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void pro_call()
        {
            /*sell = Convert.ToDouble(edt_sell.Text);
            buy = Convert.ToDouble(edt_buy.Text);
            qt = Convert.ToDouble(edt_qt.Value);
            tsell = sell * qt;
            tbuy = buy * qt;
            trev = tsell - tbuy;
            txt_sell.Text = tsell.ToString();
            txt_buy.Text = tbuy.ToString();
            txt_qt.Text = trev.ToString();*/

        }
    }
}
