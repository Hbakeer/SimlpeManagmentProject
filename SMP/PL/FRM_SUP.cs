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

namespace SMP.PL
{
    public partial class FRM_SUP : Form
    {
        DB_SMPEntities db = new SMP.DB_SMPEntities();
        TB_SUP tb_sup = new TB_SUP();
        BL.Methods methods = new BL.Methods();

        int id;
        public FRM_SUP()
        {


            InitializeComponent();

            // Instantiate a new DBContext
            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_SUP.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_SUP.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PL.FRM_SUP_ADD frm_add = new FRM_SUP_ADD();
            frm_add.id = 0;
            frm_add.btn_add.Text = "اضافة";
            frm_add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            update_data();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                try
                {

                    var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من هذه العملية", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {

                        tb_sup = db.TB_SUP.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tb_sup).State = EntityState.Deleted;
                        db.SaveChanges();
                        toast.txt_caption.Text = "تم حذف المورد";
                        toast.Show();
                        update_data();
                    }
                }
                catch
                {

                }
            }
            else
            {
                dialog.txt_caption.Text = "لا يوجد مورد لحذفه";
                dialog.Width = this.Width;
                dialog.Show();
            }



        }

        private void update_data()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.TB_SUP.ToList();
        }
        //edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            PL.FRM_SUP_ADD frm_add = new FRM_SUP_ADD();
            id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
            tb_sup = db.TB_SUP.Where(x => x.ID == id).FirstOrDefault();
            frm_add.edt_name.Text = tb_sup.Sup_Name.ToString();
            frm_add.edt_phone.Text = tb_sup.Sup_Phone.ToString();
            frm_add.edt_email.Text = tb_sup.Sup_Email.ToString();
            methods.by = tb_sup.Sup_image;
            frm_add.pic_cover.Image = Image.FromStream(methods.convert_image());

            frm_add.id = id;
            frm_add.btn_add.Text = "تعديل";
            frm_add.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var _search = edit_search.Text;
            gridControl1.DataSource = db.TB_SUP.Where(x => x.Sup_Name.Contains(_search) || x.Sup_Phone.Contains(_search) || x.Sup_Email.Contains(_search)).ToList();
        }
    }
}
