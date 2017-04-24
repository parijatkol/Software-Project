namespace inventory_control
{
    partial class BrandMaster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandMaster));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.txtMode = new DevExpress.XtraEditors.TextEdit();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtBrandDesc = new DevExpress.XtraEditors.MemoEdit();
            this.txtBrandName = new DevExpress.XtraEditors.TextEdit();
            this.txtBrandCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblBrandMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBrandMaster1 = new inventory_control.Data.dsBrandMaster();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brandedGridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBrandMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.cmdNew);
            this.groupControl1.Controls.Add(this.txtMode);
            this.groupControl1.Controls.Add(this.cmdSave);
            this.groupControl1.Controls.Add(this.txtBrandDesc);
            this.groupControl1.Controls.Add(this.txtBrandName);
            this.groupControl1.Controls.Add(this.txtBrandCode);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(7, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(454, 189);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Brand Master";
            // 
            // cmdNew
            // 
            this.cmdNew.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Appearance.Options.UseFont = true;
            this.cmdNew.Image = global::inventory_control.Properties.Resources.New_16x16;
            this.cmdNew.Location = new System.Drawing.Point(278, 162);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(73, 22);
            this.cmdNew.TabIndex = 4;
            this.cmdNew.TabStop = false;
            this.cmdNew.Text = "&New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // txtMode
            // 
            this.txtMode.EditValue = "Insert";
            this.txtMode.Location = new System.Drawing.Point(5, 159);
            this.txtMode.Name = "txtMode";
            this.txtMode.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMode.Properties.Appearance.Options.UseFont = true;
            this.txtMode.Size = new System.Drawing.Size(62, 20);
            this.txtMode.TabIndex = 7;
            this.txtMode.TabStop = false;
            this.txtMode.Visible = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Appearance.Options.UseFont = true;
            this.cmdSave.Image = global::inventory_control.Properties.Resources.Save_16x16;
            this.cmdSave.Location = new System.Drawing.Point(357, 162);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(73, 22);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.TabStop = false;
            this.cmdSave.Text = "&Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtBrandDesc
            // 
            this.txtBrandDesc.Location = new System.Drawing.Point(160, 87);
            this.txtBrandDesc.Name = "txtBrandDesc";
            this.txtBrandDesc.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandDesc.Properties.Appearance.Options.UseFont = true;
            this.txtBrandDesc.Size = new System.Drawing.Size(270, 68);
            this.txtBrandDesc.TabIndex = 1;
            this.txtBrandDesc.TabStop = false;
            this.txtBrandDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandDesc_KeyDown);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(160, 59);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.Properties.Appearance.Options.UseFont = true;
            this.txtBrandName.Size = new System.Drawing.Size(270, 20);
            this.txtBrandName.TabIndex = 0;
            this.txtBrandName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandName_KeyDown);
            this.txtBrandName.TextChanged += new System.EventHandler(this.txtBrandName_TextChanged);
            // 
            // txtBrandCode
            // 
            this.txtBrandCode.Enabled = false;
            this.txtBrandCode.Location = new System.Drawing.Point(160, 33);
            this.txtBrandCode.Name = "txtBrandCode";
            this.txtBrandCode.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBrandCode.Properties.Appearance.Options.UseFont = true;
            this.txtBrandCode.Properties.Appearance.Options.UseForeColor = true;
            this.txtBrandCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBrandCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBrandCode.Size = new System.Drawing.Size(69, 20);
            this.txtBrandCode.TabIndex = 3;
            this.txtBrandCode.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(18, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Brand Description";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(18, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Brand Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(17, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Brand Code ";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(7, 199);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(454, 252);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "List Of Brands";
            // 
            // gridControl1
            // 
            this.gridControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.gridControl1.DataSource = this.tblBrandMasterBindingSource;
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(5, 25);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(444, 219);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.TabStop = false;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // tblBrandMasterBindingSource
            // 
            this.tblBrandMasterBindingSource.DataMember = "tbl_BrandMaster";
            this.tblBrandMasterBindingSource.DataSource = this.dsBrandMaster1;
            // 
            // dsBrandMaster1
            // 
            this.dsBrandMaster1.DataSetName = "dsBrandMaster";
            this.dsBrandMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.Empty.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView2.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView2.Appearance.Preview.Options.UseFont = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bandedGridColumn1,
            this.brandedGridColumn3,
            this.bandedGridColumn2});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumn1.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumn1.Caption = "ID";
            this.bandedGridColumn1.FieldName = "BrandID";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn1.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridColumn1.Width = 66;
            // 
            // brandedGridColumn3
            // 
            this.brandedGridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandedGridColumn3.AppearanceHeader.Options.UseFont = true;
            this.brandedGridColumn3.Caption = "BrandCode";
            this.brandedGridColumn3.FieldName = "BrandCode";
            this.brandedGridColumn3.Name = "brandedGridColumn3";
            this.brandedGridColumn3.OptionsColumn.AllowEdit = false;
            this.brandedGridColumn3.OptionsColumn.AllowFocus = false;
            this.brandedGridColumn3.Visible = true;
            this.brandedGridColumn3.VisibleIndex = 0;
            this.brandedGridColumn3.Width = 100;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.bandedGridColumn2.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumn2.AppearanceCell.Options.UseFont = true;
            this.bandedGridColumn2.AppearanceCell.Options.UseForeColor = true;
            this.bandedGridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumn2.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumn2.Caption = "Brand Name";
            this.bandedGridColumn2.FieldName = "BrandName";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn2.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.VisibleIndex = 1;
            this.bandedGridColumn2.Width = 260;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserID,
            this.colFullName,
            this.colUserName,
            this.colPassword,
            this.colContactNo,
            this.colUserGroup});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUserID
            // 
            this.colUserID.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUserID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colUserID.AppearanceHeader.Options.UseFont = true;
            this.colUserID.AppearanceHeader.Options.UseForeColor = true;
            this.colUserID.Caption = "User ID";
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.OptionsColumn.AllowEdit = false;
            this.colUserID.OptionsColumn.AllowFocus = false;
            this.colUserID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.colFullName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.AppearanceCell.Options.UseForeColor = true;
            this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFullName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            this.colFullName.AppearanceHeader.Options.UseForeColor = true;
            this.colFullName.Caption = "Full Name";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.OptionsColumn.AllowFocus = false;
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colUserName
            // 
            this.colUserName.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUserName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colUserName.AppearanceHeader.Options.UseFont = true;
            this.colUserName.AppearanceHeader.Options.UseForeColor = true;
            this.colUserName.Caption = "UserName";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsColumn.AllowFocus = false;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            // 
            // colPassword
            // 
            this.colPassword.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPassword.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colPassword.AppearanceHeader.Options.UseFont = true;
            this.colPassword.AppearanceHeader.Options.UseForeColor = true;
            this.colPassword.Caption = "Password";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.AllowEdit = false;
            this.colPassword.OptionsColumn.AllowFocus = false;
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 3;
            // 
            // colContactNo
            // 
            this.colContactNo.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.colContactNo.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colContactNo.AppearanceHeader.Options.UseFont = true;
            this.colContactNo.AppearanceHeader.Options.UseForeColor = true;
            this.colContactNo.Caption = "Contact No";
            this.colContactNo.FieldName = "ContactNo";
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.OptionsColumn.AllowEdit = false;
            this.colContactNo.OptionsColumn.AllowFocus = false;
            this.colContactNo.Visible = true;
            this.colContactNo.VisibleIndex = 4;
            // 
            // colUserGroup
            // 
            this.colUserGroup.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.colUserGroup.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colUserGroup.AppearanceHeader.Options.UseFont = true;
            this.colUserGroup.AppearanceHeader.Options.UseForeColor = true;
            this.colUserGroup.Caption = "User Group";
            this.colUserGroup.FieldName = "UserGroupName";
            this.colUserGroup.Name = "colUserGroup";
            this.colUserGroup.OptionsColumn.AllowEdit = false;
            this.colUserGroup.OptionsColumn.AllowFocus = false;
            this.colUserGroup.Visible = true;
            this.colUserGroup.VisibleIndex = 5;
            this.colUserGroup.Width = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BrandMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 455);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrandMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Brand Master Creation ::";
            this.Load += new System.EventHandler(this.BrandMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBrandMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtBrandDesc;
        private DevExpress.XtraEditors.TextEdit txtBrandName;
        private DevExpress.XtraEditors.TextEdit txtBrandCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroup;
        private inventory_control.Data.dsBrandMaster dsBrandMaster1;
        private System.Windows.Forms.BindingSource tblBrandMasterBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn brandedGridColumn3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.TextEdit txtMode;
        private DevExpress.XtraEditors.SimpleButton cmdNew;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}