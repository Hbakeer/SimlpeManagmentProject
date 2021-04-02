
namespace SMP.PL
{
    partial class FRM_CUS_ADD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CUS_ADD));
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(511, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "اسم العميل";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(85, 99);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(337, 45);
            this.edt_name.TabIndex = 18;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(518, 702);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(161, 78);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(105, 395);
            this.pic_cover.Margin = new System.Windows.Forms.Padding(5);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.Appearance.BackColor = System.Drawing.Color.Gray;
            this.pic_cover.Properties.Appearance.Options.UseBackColor = true;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(337, 321);
            this.pic_cover.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(521, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "رقم الهاتف";
            // 
            // edt_phone
            // 
            this.edt_phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_phone.Location = new System.Drawing.Point(85, 180);
            this.edt_phone.Name = "edt_phone";
            this.edt_phone.Size = new System.Drawing.Size(337, 45);
            this.edt_phone.TabIndex = 18;
            this.edt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(569, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "العنوان";
            // 
            // edt_email
            // 
            this.edt_email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_email.Location = new System.Drawing.Point(85, 261);
            this.edt_email.Name = "edt_email";
            this.edt_email.Size = new System.Drawing.Size(337, 45);
            this.edt_email.TabIndex = 18;
            this.edt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(228, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "صورة";
            // 
            // FRM_CUS_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 803);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edt_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUS_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_phone;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox edt_email;
        private System.Windows.Forms.Label label4;
    }
}