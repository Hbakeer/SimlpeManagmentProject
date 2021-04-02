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
namespace SMP.PL
{
    public partial class FRM_USER_ADD : Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_SUP tb_sup = new TB_SUP();
        BL.Methods methods = new BL.Methods();

        public int id;
        public FRM_USER_ADD()
        {
            InitializeComponent();
        }
        // add or edit 
        private void btn_add_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            // Check if add or edit
            if (edt_name.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_caption.Text = "اسم الصنف المطلوب";
                dialog.Show();
            }
            else
            {
                //Check if add or edit
                if (id == 0)
                {
                    //add
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_sup.Sup_Name = edt_name.Text;
                    tb_sup.Sup_Phone = edt_phone.Text;
                    tb_sup.Sup_Email = edt_email.Text;
                    tb_sup.Sup_image = methods.convert_byte();
                    db.TB_SUP.Add(tb_sup);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافة مورد جديد";
                    toast.Show();
                    this.Close();
                }
                else
                {
                    //Edit 
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                    tb_sup.ID = id;
                    tb_sup.Sup_Name = edt_name.Text;
                    tb_sup.Sup_Phone = edt_phone.Text;
                    tb_sup.Sup_Email = edt_email.Text;
                    tb_sup.Sup_image = methods.convert_byte();
                    db.Entry(tb_sup).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل المورد";
                    toast.Show();
                    this.Close();

                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
