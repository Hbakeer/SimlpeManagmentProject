
namespace SMP.PL
{
    partial class FRM_SELL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SELL));
            this.pn_cat = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSell_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_TPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pn_cat.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_cat
            // 
            this.pn_cat.Controls.Add(this.panel2);
            this.pn_cat.Controls.Add(this.gridControl1);
            this.pn_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_cat.Location = new System.Drawing.Point(0, 0);
            this.pn_cat.Name = "pn_cat";
            this.pn_cat.Size = new System.Drawing.Size(1030, 720);
            this.pn_cat.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.edit_search);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 103);
            this.panel2.TabIndex = 2;
            // 
            // edit_search
            // 
            this.edit_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edit_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_search.Location = new System.Drawing.Point(611, 28);
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(337, 45);
            this.edit_search.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_search.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_search.Location = new System.Drawing.Point(958, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 74);
            this.btn_search.TabIndex = 1;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_update.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.ImageOptions.Image")));
            this.btn_update.Location = new System.Drawing.Point(411, 13);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(123, 75);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "تحديث";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(282, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 75);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.Enabled = false;
            this.btn_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.ImageOptions.Image")));
            this.btn_edit.Location = new System.Drawing.Point(153, 13);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(123, 75);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.Appearance.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(24, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 75);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(SMP.TB_SELL);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 720);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSell_Name,
            this.colSell_Cus,
            this.colSell_Price,
            this.colSell_Qt,
            this.colSell_TPrice,
            this.colSell_Date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSell_Name
            // 
            this.colSell_Name.Caption = "اسم المادة";
            this.colSell_Name.FieldName = "Sell_Name";
            this.colSell_Name.MinWidth = 25;
            this.colSell_Name.Name = "colSell_Name";
            this.colSell_Name.Visible = true;
            this.colSell_Name.VisibleIndex = 0;
            this.colSell_Name.Width = 94;
            // 
            // colSell_Cus
            // 
            this.colSell_Cus.Caption = "اسم العميل";
            this.colSell_Cus.FieldName = "Sell_Cus";
            this.colSell_Cus.MinWidth = 25;
            this.colSell_Cus.Name = "colSell_Cus";
            this.colSell_Cus.Visible = true;
            this.colSell_Cus.VisibleIndex = 1;
            this.colSell_Cus.Width = 94;
            // 
            // colSell_Price
            // 
            this.colSell_Price.Caption = "السعر";
            this.colSell_Price.FieldName = "Sell_Price";
            this.colSell_Price.MinWidth = 25;
            this.colSell_Price.Name = "colSell_Price";
            this.colSell_Price.Visible = true;
            this.colSell_Price.VisibleIndex = 2;
            this.colSell_Price.Width = 94;
            // 
            // colSell_Qt
            // 
            this.colSell_Qt.Caption = "الكمية";
            this.colSell_Qt.FieldName = "Sell_Qt";
            this.colSell_Qt.MinWidth = 25;
            this.colSell_Qt.Name = "colSell_Qt";
            this.colSell_Qt.Visible = true;
            this.colSell_Qt.VisibleIndex = 3;
            this.colSell_Qt.Width = 94;
            // 
            // colSell_TPrice
            // 
            this.colSell_TPrice.Caption = "السعر الكلي";
            this.colSell_TPrice.FieldName = "Sell_TPrice";
            this.colSell_TPrice.MinWidth = 25;
            this.colSell_TPrice.Name = "colSell_TPrice";
            this.colSell_TPrice.Visible = true;
            this.colSell_TPrice.VisibleIndex = 4;
            this.colSell_TPrice.Width = 94;
            // 
            // colSell_Date
            // 
            this.colSell_Date.Caption = "التاريخ";
            this.colSell_Date.FieldName = "Sell_Date";
            this.colSell_Date.MinWidth = 25;
            this.colSell_Date.Name = "colSell_Date";
            this.colSell_Date.Visible = true;
            this.colSell_Date.VisibleIndex = 5;
            this.colSell_Date.Width = 94;
            // 
            // FRM_SELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SELL";
            this.Text = "FRM_SUP";
            this.pn_cat.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox edit_search;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        public System.Windows.Forms.Panel pn_cat;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Cus;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_TPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Date;
    }
}