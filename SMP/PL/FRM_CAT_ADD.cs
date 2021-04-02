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
    public partial class FRM_CAT_ADD : Form
    {
        //init
        DB_SMPEntities db = new DB_SMPEntities();
        TB_CAT tb_cat = new TB_CAT();
        BL.Methods methods = new BL.Methods();
        PL.FRM_CAT frm_cat = new FRM_CAT();

        public int id;
        public FRM_CAT_ADD()
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
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.TB_CAT.Add(tb_cat);
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم اضافة صنف جديد";
                    toast.Show();
                    db = new DB_SMPEntities();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();
                }
                else
                {
                    //Edit
                    pic_cover.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tb_cat.CAT_Name = edt_name.Text;
                    tb_cat.ID = id;
                    tb_cat.CAT_Cover = methods.convert_byte();
                    db.Entry(tb_cat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txt_caption.Text = "تم تعديل الصنف ";
                    toast.Show();
                    db = new DB_SMPEntities();
                    frm_cat.gridControl1.DataSource = db.TB_CAT.ToList();
                    this.Close();

                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CAT_ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
