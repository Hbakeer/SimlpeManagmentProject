
namespace SMP.PL
{
    partial class FRM_SUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SUP));
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition6 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition7 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition8 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement8 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colSup_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSup_Phone = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSup_Email = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSup_image = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pn_cat = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.pn_cat.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colSup_Name
            // 
            this.colSup_Name.FieldName = "Sup_Name";
            this.colSup_Name.MinWidth = 25;
            this.colSup_Name.Name = "colSup_Name";
            this.colSup_Name.Visible = true;
            this.colSup_Name.VisibleIndex = 1;
            this.colSup_Name.Width = 94;
            // 
            // colSup_Phone
            // 
            this.colSup_Phone.FieldName = "Sup_Phone";
            this.colSup_Phone.MinWidth = 25;
            this.colSup_Phone.Name = "colSup_Phone";
            this.colSup_Phone.Visible = true;
            this.colSup_Phone.VisibleIndex = 2;
            this.colSup_Phone.Width = 94;
            // 
            // colSup_Email
            // 
            this.colSup_Email.FieldName = "Sup_Email";
            this.colSup_Email.MinWidth = 25;
            this.colSup_Email.Name = "colSup_Email";
            this.colSup_Email.Visible = true;
            this.colSup_Email.VisibleIndex = 3;
            this.colSup_Email.Width = 94;
            // 
            // colSup_image
            // 
            this.colSup_image.FieldName = "Sup_image";
            this.colSup_image.MinWidth = 25;
            this.colSup_image.Name = "colSup_image";
            this.colSup_image.Visible = true;
            this.colSup_image.VisibleIndex = 4;
            this.colSup_image.Width = 94;
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
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1030, 720);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSup_Name,
            this.colSup_Phone,
            this.colSup_Email,
            this.colSup_image});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(440, 500);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition5.Length.Value = 58D;
            tableRowDefinition6.Length.Value = 61D;
            tableRowDefinition7.Length.Value = 58D;
            tableRowDefinition8.Length.Value = 301D;
            this.tileView1.TileRows.Add(tableRowDefinition5);
            this.tileView1.TileRows.Add(tableRowDefinition6);
            this.tileView1.TileRows.Add(tableRowDefinition7);
            this.tileView1.TileRows.Add(tableRowDefinition8);
            tileViewItemElement5.Appearance.Normal.Font = new System.Drawing.Font("LBC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement5.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement5.Column = this.colSup_Name;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.Text = "colSup_Name";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.Appearance.Normal.Font = new System.Drawing.Font("LBC", 13.8F);
            tileViewItemElement6.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement6.Column = this.colSup_Phone;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.RowIndex = 1;
            tileViewItemElement6.Text = "colSup_Phone";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.Appearance.Normal.Font = new System.Drawing.Font("LBC", 13.8F);
            tileViewItemElement7.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement7.Column = this.colSup_Email;
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 2;
            tileViewItemElement7.Text = "colSup_Email";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.Column = this.colSup_image;
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement8.RowIndex = 3;
            tileViewItemElement8.Text = "colSup_image";
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            this.tileView1.TileTemplate.Add(tileViewItemElement6);
            this.tileView1.TileTemplate.Add(tileViewItemElement7);
            this.tileView1.TileTemplate.Add(tileViewItemElement8);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // FRM_SUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 720);
            this.Controls.Add(this.pn_cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SUP";
            this.Text = "FRM_SUP";
            this.pn_cat.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
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
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colID;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSup_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSup_Phone;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSup_Email;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSup_image;
    }
}