
namespace SMP.PL
{
    partial class FRM_PUR_ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PUR_ADD));
            this.lb_titlepage = new System.Windows.Forms.Label();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_type = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_det = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edt_sup = new System.Windows.Forms.ComboBox();
            this.edt_cat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edt_qt = new DevExpress.XtraEditors.SpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_buy = new System.Windows.Forms.TextBox();
            this.edt_sell = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edt_tsell = new System.Windows.Forms.Label();
            this.edt_trev = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.edt_tbuy = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_titlepage
            // 
            this.lb_titlepage.AutoSize = true;
            this.lb_titlepage.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_titlepage.ForeColor = System.Drawing.Color.Gray;
            this.lb_titlepage.Location = new System.Drawing.Point(520, 57);
            this.lb_titlepage.Name = "lb_titlepage";
            this.lb_titlepage.Size = new System.Drawing.Size(118, 31);
            this.lb_titlepage.TabIndex = 17;
            this.lb_titlepage.Text = "اسم المادة";
            // 
            // edt_name
            // 
            this.edt_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_name.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(16, 54);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(275, 37);
            this.edt_name.TabIndex = 18;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(1034, 694);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(161, 78);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(575, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "النوع";
            // 
            // edt_type
            // 
            this.edt_type.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_type.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_type.Location = new System.Drawing.Point(16, 109);
            this.edt_type.Name = "edt_type";
            this.edt_type.Size = new System.Drawing.Size(275, 37);
            this.edt_type.TabIndex = 18;
            this.edt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(562, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "الصنف";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_det);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.edt_sup);
            this.groupBox1.Controls.Add(this.edt_cat);
            this.groupBox1.Controls.Add(this.edt_name);
            this.groupBox1.Controls.Add(this.lb_titlepage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(567, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(643, 450);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات اساسية";
            // 
            // edt_det
            // 
            this.edt_det.Location = new System.Drawing.Point(16, 291);
            this.edt_det.Multiline = true;
            this.edt_det.Name = "edt_det";
            this.edt_det.Size = new System.Drawing.Size(485, 131);
            this.edt_det.TabIndex = 21;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(314, 225);
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
            this.linkLabel1.Location = new System.Drawing.Point(314, 170);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 31);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edt_sup
            // 
            this.edt_sup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.edt_sup.FormattingEnabled = true;
            this.edt_sup.Location = new System.Drawing.Point(16, 222);
            this.edt_sup.Name = "edt_sup";
            this.edt_sup.Size = new System.Drawing.Size(275, 38);
            this.edt_sup.TabIndex = 19;
            // 
            // edt_cat
            // 
            this.edt_cat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.edt_cat.FormattingEnabled = true;
            this.edt_cat.Location = new System.Drawing.Point(16, 167);
            this.edt_cat.Name = "edt_cat";
            this.edt_cat.Size = new System.Drawing.Size(275, 38);
            this.edt_cat.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(558, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "تفاصيل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(560, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "المورد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edt_qt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.edt_buy);
            this.groupBox2.Controls.Add(this.edt_sell);
            this.groupBox2.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(567, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(630, 197);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيع و الشراء";
            // 
            // edt_qt
            // 
            this.edt_qt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.edt_qt.Location = new System.Drawing.Point(16, 145);
            this.edt_qt.Name = "edt_qt";
            this.edt_qt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_qt.Properties.Appearance.Options.UseFont = true;
            this.edt_qt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_qt.Size = new System.Drawing.Size(275, 34);
            this.edt_qt.TabIndex = 19;
            this.edt_qt.EditValueChanged += new System.EventHandler(this.edt_qt_EditValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(436, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "سعر الشراء (مفرد)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(449, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "سعر البيع (مفرد)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(542, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "الكمية";
            // 
            // edt_buy
            // 
            this.edt_buy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_buy.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buy.Location = new System.Drawing.Point(16, 42);
            this.edt_buy.Name = "edt_buy";
            this.edt_buy.Size = new System.Drawing.Size(275, 37);
            this.edt_buy.TabIndex = 18;
            this.edt_buy.Text = "0";
            this.edt_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_buy.TextChanged += new System.EventHandler(this.edt_buy_TextChanged);
            // 
            // edt_sell
            // 
            this.edt_sell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_sell.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sell.Location = new System.Drawing.Point(16, 95);
            this.edt_sell.Name = "edt_sell";
            this.edt_sell.Size = new System.Drawing.Size(275, 37);
            this.edt_sell.TabIndex = 18;
            this.edt_sell.Text = "0";
            this.edt_sell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_sell.TextChanged += new System.EventHandler(this.edt_sell_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.edt_tsell);
            this.groupBox3.Controls.Add(this.edt_trev);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.edt_tbuy);
            this.groupBox3.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(517, 421);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(95, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(329, 42);
            this.label14.TabIndex = 17;
            this.label14.Text = "المشتريات (السعر الكلي)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(105, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 42);
            this.label10.TabIndex = 17;
            this.label10.Text = "المبيعات (السعر الكلي)";
            // 
            // edt_tsell
            // 
            this.edt_tsell.AutoSize = true;
            this.edt_tsell.Font = new System.Drawing.Font("LBC", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tsell.ForeColor = System.Drawing.Color.Red;
            this.edt_tsell.Location = new System.Drawing.Point(235, 209);
            this.edt_tsell.Name = "edt_tsell";
            this.edt_tsell.Size = new System.Drawing.Size(49, 55);
            this.edt_tsell.TabIndex = 17;
            this.edt_tsell.Text = "0";
            // 
            // edt_trev
            // 
            this.edt_trev.AutoSize = true;
            this.edt_trev.Font = new System.Drawing.Font("LBC", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_trev.ForeColor = System.Drawing.Color.Red;
            this.edt_trev.Location = new System.Drawing.Point(235, 346);
            this.edt_trev.Name = "edt_trev";
            this.edt_trev.Size = new System.Drawing.Size(49, 55);
            this.edt_trev.TabIndex = 17;
            this.edt_trev.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("LBC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(187, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 42);
            this.label12.TabIndex = 17;
            this.label12.Text = "الارباح الكلية";
            // 
            // edt_tbuy
            // 
            this.edt_tbuy.AutoSize = true;
            this.edt_tbuy.Font = new System.Drawing.Font("LBC", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_tbuy.ForeColor = System.Drawing.Color.Red;
            this.edt_tbuy.Location = new System.Drawing.Point(235, 90);
            this.edt_tbuy.Name = "edt_tbuy";
            this.edt_tbuy.Size = new System.Drawing.Size(49, 55);
            this.edt_tbuy.TabIndex = 17;
            this.edt_tbuy.Text = "0";
            // 
            // FRM_PUR_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 792);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_add);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PUR_ADD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_PUR_ADD_Activated);
            this.Load += new System.EventHandler(this.FRM_PUR_ADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_qt.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_titlepage;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edt_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox edt_buy;
        public System.Windows.Forms.TextBox edt_sell;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox edt_sup;
        public System.Windows.Forms.ComboBox edt_cat;
        public System.Windows.Forms.TextBox edt_det;
        public System.Windows.Forms.Label edt_tsell;
        public System.Windows.Forms.Label edt_tbuy;
        public System.Windows.Forms.Label edt_trev;
        public DevExpress.XtraEditors.SpinEdit edt_qt;
    }
}