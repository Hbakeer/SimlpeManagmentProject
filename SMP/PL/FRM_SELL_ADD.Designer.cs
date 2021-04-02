
namespace SMP.PL
{
    partial class FRM_SELL_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SELL_ADD));
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_sell = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sell = new System.Windows.Forms.Label();
            this.txt_qt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_buy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edt_cus = new System.Windows.Forms.ComboBox();
            this.edt_name = new System.Windows.Forms.ComboBox();
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(1018, 633);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(161, 78);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edt_qt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.edt_sell);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(549, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(630, 289);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيـــــــــــــــــــــــــــــــع";
            // 
            // edt_qt
            // 
            this.edt_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_qt.Location = new System.Drawing.Point(25, 198);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_qt.Properties.Appearance.Options.UseFont = true;
            this.edt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_qt.Size = new System.Drawing.Size(275, 34);
            this.edt_qt.TabIndex = 19;
            this.edt_qt.EditValueChanged += new System.EventHandler(this.edt_qt_EditValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(499, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "سعر البيع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(527, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "الكمية";
            // 
            // edt_sell
            // 
            this.edt_sell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_sell.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sell.Location = new System.Drawing.Point(25, 98);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(275, 37);
            this.edt_sell.TabIndex = 18;
            this.edt_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_sell.TextChanged += new System.EventHandler(this.edt_sell_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_sell);
            this.groupBox3.Controls.Add(this.txt_qt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_buy);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(469, 568);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("LBC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 75);
            this.label1.TabIndex = 18;
            this.label1.Text = "تفاصيل المادة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(149, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 42);
            this.label14.TabIndex = 17;
            this.label14.Text = "سعر الشراء";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(156, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 42);
            this.label10.TabIndex = 17;
            this.label10.Text = "سعر البيع";
            // 
            // txt_sell
            // 
            this.txt_sell.AutoSize = true;
            this.txt_sell.Font = new System.Drawing.Font("LBC", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sell.ForeColor = System.Drawing.Color.Red;
            this.txt_sell.Location = new System.Drawing.Point(202, 316);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(49, 55);
            this.txt_sell.TabIndex = 17;
            this.txt_sell.Text = "0";
            // 
            // txt_qt
            // 
            this.txt_qt.AutoSize = true;
            this.txt_qt.Font = new System.Drawing.Font("LBC", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qt.ForeColor = System.Drawing.Color.Red;
            this.txt_qt.Location = new System.Drawing.Point(200, 464);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Size = new System.Drawing.Size(49, 55);
            this.txt_qt.TabIndex = 17;
            this.txt_qt.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(173, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 42);
            this.label12.TabIndex = 17;
            this.label12.Text = "الكمية";
            // 
            // txt_buy
            // 
            this.txt_buy.AutoSize = true;
            this.txt_buy.Font = new System.Drawing.Font("LBC", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buy.ForeColor = System.Drawing.Color.Red;
            this.txt_buy.Location = new System.Drawing.Point(202, 197);
            this.txt_buy.Name = "txt_buy";
            this.txt_buy.Size = new System.Drawing.Size(49, 55);
            this.txt_buy.TabIndex = 17;
            this.txt_buy.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.edt_cus);
            this.groupBox1.Controls.Add(this.edt_name);
            this.groupBox1.Controls.Add(this.lb_titlepage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(643, 230);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات اساسية";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(314, 150);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(71, 31);
            this.linkLabel2.TabIndex = 20;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(314, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 31);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edt_cus
            // 
            this.edt_cus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_cus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_cus.FormattingEnabled = true;
            this.edt_cus.Location = new System.Drawing.Point(16, 147);
            this.edt_cus.Name = "edt_cus";
            this.edt_cus.Size = new System.Drawing.Size(275, 38);
            this.edt_cus.TabIndex = 19;
            // 
            // edt_name
            // 
            this.edt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.edt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.edt_name.FormattingEnabled = true;
            this.edt_name.Location = new System.Drawing.Point(16, 57);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(275, 38);
            this.edt_name.TabIndex = 19;
            this.edt_name.SelectedIndexChanged += new System.EventHandler(this.edt_name_SelectedIndexChanged);
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Location = new System.Drawing.Point(498, 57);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(118, 31);
            this.lb_titlepage.TabIndex = 17;
            this.lb_titlepage.Text = "اسم المادة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(540, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(513, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "الكمية غير كافية";
            this.label3.Visible = false;
            // 
            // FRM_SELL_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 740);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SELL_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_SELL_ADD_Activated);
            this.Load += new System.EventHandler(this.FRM_SELL_ADD_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox edt_sell;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label txt_sell;
        public System.Windows.Forms.Label txt_buy;
        public System.Windows.Forms.Label txt_qt;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_titlepage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ComboBox edt_cus;
        public System.Windows.Forms.ComboBox edt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}