namespace inventory_control
{
    partial class ItemMaster
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
            this.Acctperiod = new DevExpress.XtraEditors.GroupControl();
            this.txtMode = new DevExpress.XtraEditors.TextEdit();
            this.CmbBrand = new DevExpress.XtraEditors.LookUpEdit();
            this.tblBrandMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBrandMaster1 = new inventory_control.Data.dsBrandMaster();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.tblUnitMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnitMaster1 = new inventory_control.Data.dsUnitMaster();
            this.ItemGroupCode = new DevExpress.XtraEditors.LookUpEdit();
            this.tblItemGroupMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsItemGroup1 = new inventory_control.Data.dsItemGroup();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtOpStock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LblPhone2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.LblPhone1 = new DevExpress.XtraEditors.LabelControl();
            this.LblAddress2 = new DevExpress.XtraEditors.LabelControl();
            this.LblEmail = new DevExpress.XtraEditors.LabelControl();
            this.LblAddress1 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.LblUserName = new DevExpress.XtraEditors.LabelControl();
            this.CmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblItemMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsItemMaster1 = new inventory_control.Data.dsItemMaster();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Acctperiod)).BeginInit();
            this.Acctperiod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBrandMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnitMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGroupCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemGroupMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemMaster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Acctperiod
            // 
            this.Acctperiod.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(254)))));
            this.Acctperiod.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acctperiod.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Acctperiod.Appearance.Options.UseBackColor = true;
            this.Acctperiod.Appearance.Options.UseFont = true;
            this.Acctperiod.Appearance.Options.UseForeColor = true;
            this.Acctperiod.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acctperiod.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.Acctperiod.AppearanceCaption.Options.UseFont = true;
            this.Acctperiod.AppearanceCaption.Options.UseForeColor = true;
            this.Acctperiod.Controls.Add(this.txtMode);
            this.Acctperiod.Controls.Add(this.CmbBrand);
            this.Acctperiod.Controls.Add(this.labelControl2);
            this.Acctperiod.Controls.Add(this.txtUnit);
            this.Acctperiod.Controls.Add(this.ItemGroupCode);
            this.Acctperiod.Controls.Add(this.txtItemDescription);
            this.Acctperiod.Controls.Add(this.txtOpStock);
            this.Acctperiod.Controls.Add(this.labelControl1);
            this.Acctperiod.Controls.Add(this.LblPhone2);
            this.Acctperiod.Controls.Add(this.txtPrice);
            this.Acctperiod.Controls.Add(this.LblPhone1);
            this.Acctperiod.Controls.Add(this.LblAddress2);
            this.Acctperiod.Controls.Add(this.LblEmail);
            this.Acctperiod.Controls.Add(this.LblAddress1);
            this.Acctperiod.Controls.Add(this.txtItemName);
            this.Acctperiod.Controls.Add(this.txtItemCode);
            this.Acctperiod.Controls.Add(this.LblUserName);
            this.Acctperiod.Location = new System.Drawing.Point(7, 6);
            this.Acctperiod.Name = "Acctperiod";
            this.Acctperiod.Size = new System.Drawing.Size(589, 206);
            this.Acctperiod.TabIndex = 1;
            this.Acctperiod.Text = "Item Configuration ";
            // 
            // txtMode
            // 
            this.txtMode.EditValue = "Insert";
            this.txtMode.Location = new System.Drawing.Point(6, 164);
            this.txtMode.Name = "txtMode";
            this.txtMode.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMode.Properties.Appearance.Options.UseFont = true;
            this.txtMode.Size = new System.Drawing.Size(108, 20);
            this.txtMode.TabIndex = 26;
            this.txtMode.Visible = false;
            // 
            // CmbBrand
            // 
            this.CmbBrand.EditValue = "";
            this.CmbBrand.Location = new System.Drawing.Point(131, 93);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBrand.Properties.Appearance.Options.UseFont = true;
            this.CmbBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "Brand Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandID", "Brand ID", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.CmbBrand.Properties.DataSource = this.tblBrandMasterBindingSource;
            this.CmbBrand.Properties.DisplayMember = "BrandName";
            this.CmbBrand.Properties.ValueMember = "BrandID";
            this.CmbBrand.Size = new System.Drawing.Size(150, 20);
            this.CmbBrand.TabIndex = 3;
            this.CmbBrand.TabStop = false;
            this.CmbBrand.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.CmbBrand_ItemChanged);
            this.CmbBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbBrand_KeyDown);
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(13, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Item Brand";
            // 
            // txtUnit
            // 
            this.txtUnit.EditValue = "";
            this.txtUnit.Location = new System.Drawing.Point(483, 63);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUnit.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Properties.Appearance.Options.UseBackColor = true;
            this.txtUnit.Properties.Appearance.Options.UseFont = true;
            this.txtUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "Unit Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitID", "Unit ID", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.txtUnit.Properties.DataSource = this.tblUnitMasterBindingSource;
            this.txtUnit.Properties.DisplayMember = "UnitName";
            this.txtUnit.Properties.ValueMember = "UnitID";
            this.txtUnit.Size = new System.Drawing.Size(82, 20);
            this.txtUnit.TabIndex = 2;
            this.txtUnit.TabStop = false;
            this.txtUnit.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.txtUnit_ItemChanged);
            this.txtUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnit_KeyDown);
            // 
            // tblUnitMasterBindingSource
            // 
            this.tblUnitMasterBindingSource.DataMember = "tbl_UnitMaster";
            this.tblUnitMasterBindingSource.DataSource = this.dsUnitMaster1;
            // 
            // dsUnitMaster1
            // 
            this.dsUnitMaster1.DataSetName = "dsUnitMaster";
            this.dsUnitMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemGroupCode
            // 
            this.ItemGroupCode.EditValue = "";
            this.ItemGroupCode.Location = new System.Drawing.Point(131, 62);
            this.ItemGroupCode.Name = "ItemGroupCode";
            this.ItemGroupCode.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemGroupCode.Properties.Appearance.Options.UseFont = true;
            this.ItemGroupCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemGroupCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemGroupName", "Item GroupName", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemGroupCode", "Group ID", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ItemGroupCode.Properties.DataSource = this.tblItemGroupMasterBindingSource;
            this.ItemGroupCode.Properties.DisplayMember = "ItemGroupName";
            this.ItemGroupCode.Properties.ValueMember = "ItemGroupCode";
            this.ItemGroupCode.Size = new System.Drawing.Size(282, 20);
            this.ItemGroupCode.TabIndex = 1;
            this.ItemGroupCode.TabStop = false;
            this.ItemGroupCode.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.ItemGroupCode_ItemChanged);
            this.ItemGroupCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemGroupCode_KeyDown);
            // 
            // tblItemGroupMasterBindingSource
            // 
            this.tblItemGroupMasterBindingSource.DataMember = "tbl_ItemGroupMaster";
            this.tblItemGroupMasterBindingSource.DataSource = this.dsItemGroup1;
            // 
            // dsItemGroup1
            // 
            this.dsItemGroup1.DataSetName = "dsItemGroup";
            this.dsItemGroup1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(131, 125);
            this.txtItemDescription.MaxLength = 255;
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(436, 71);
            this.txtItemDescription.TabIndex = 6;
            this.txtItemDescription.TabStop = false;
            this.txtItemDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemDescription_KeyDown);
            // 
            // txtOpStock
            // 
            this.txtOpStock.Location = new System.Drawing.Point(359, 93);
            this.txtOpStock.Name = "txtOpStock";
            this.txtOpStock.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpStock.Properties.Appearance.Options.UseFont = true;
            this.txtOpStock.Properties.Mask.EditMask = "n0";
            this.txtOpStock.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOpStock.Size = new System.Drawing.Size(54, 20);
            this.txtOpStock.TabIndex = 4;
            this.txtOpStock.TabStop = false;
            this.txtOpStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpStock_KeyDown);
            this.txtOpStock.TextChanged += new System.EventHandler(this.txtOpStock_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(301, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Op Stock";
            // 
            // LblPhone2
            // 
            this.LblPhone2.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone2.Location = new System.Drawing.Point(440, 96);
            this.LblPhone2.Name = "LblPhone2";
            this.LblPhone2.Size = new System.Drawing.Size(28, 13);
            this.LblPhone2.TabIndex = 20;
            this.LblPhone2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(483, 93);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrice.Properties.Mask.EditMask = "n";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(83, 20);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TabStop = false;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // LblPhone1
            // 
            this.LblPhone1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhone1.Location = new System.Drawing.Point(440, 66);
            this.LblPhone1.Name = "LblPhone1";
            this.LblPhone1.Size = new System.Drawing.Size(22, 13);
            this.LblPhone1.TabIndex = 18;
            this.LblPhone1.Text = "Unit";
            // 
            // LblAddress2
            // 
            this.LblAddress2.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress2.Location = new System.Drawing.Point(13, 125);
            this.LblAddress2.Name = "LblAddress2";
            this.LblAddress2.Size = new System.Drawing.Size(95, 13);
            this.LblAddress2.TabIndex = 16;
            this.LblAddress2.Text = "Item Description";
            // 
            // LblEmail
            // 
            this.LblEmail.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(13, 66);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(66, 13);
            this.LblEmail.TabIndex = 12;
            this.LblEmail.Text = "Item Group";
            // 
            // LblAddress1
            // 
            this.LblAddress1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress1.Location = new System.Drawing.Point(258, 36);
            this.LblAddress1.Name = "LblAddress1";
            this.LblAddress1.Size = new System.Drawing.Size(64, 13);
            this.LblAddress1.TabIndex = 10;
            this.LblAddress1.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(333, 33);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Properties.Appearance.Options.UseFont = true;
            this.txtItemName.Properties.MaxLength = 50;
            this.txtItemName.Size = new System.Drawing.Size(232, 20);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Location = new System.Drawing.Point(131, 33);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Properties.Appearance.Options.UseForeColor = true;
            this.txtItemCode.Size = new System.Drawing.Size(108, 20);
            this.txtItemCode.TabIndex = 1;
            this.txtItemCode.TabStop = false;
            // 
            // LblUserName
            // 
            this.LblUserName.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(13, 36);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(61, 13);
            this.LblUserName.TabIndex = 7;
            this.LblUserName.Text = "Item Code";
            // 
            // CmdSave
            // 
            this.CmdSave.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Appearance.Options.UseFont = true;
            this.CmdSave.Image = global::inventory_control.Properties.Resources.Save_16x16;
            this.CmdSave.Location = new System.Drawing.Point(520, 218);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(77, 25);
            this.CmdSave.TabIndex = 7;
            this.CmdSave.TabStop = false;
            this.CmdSave.Text = "&Save";
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 250);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(589, 258);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "List Of Items";
            // 
            // gridControl1
            // 
            this.gridControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Row;
            this.gridControl1.DataSource = this.tblItemMasterBindingSource;
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
            this.gridControl1.Size = new System.Drawing.Size(579, 228);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.TabStop = false;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // tblItemMasterBindingSource
            // 
            this.tblItemMasterBindingSource.DataMember = "tbl_ItemMaster";
            this.tblItemMasterBindingSource.DataSource = this.dsItemMaster1;
            // 
            // dsItemMaster1
            // 
            this.dsItemMaster1.DataSetName = "dsItemMaster";
            this.dsItemMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
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
            this.bandedGridColumn1.FieldName = "ItemNo";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn1.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.VisibleIndex = 0;
            this.bandedGridColumn1.Width = 40;
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
            this.bandedGridColumn2.Caption = "Item Code";
            this.bandedGridColumn2.FieldName = "ItemCode";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn2.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.VisibleIndex = 1;
            this.bandedGridColumn2.Width = 90;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.bandedGridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.bandedGridColumn3.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.bandedGridColumn3.Caption = "Item Name";
            this.bandedGridColumn3.FieldName = "ItemName";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn3.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.VisibleIndex = 2;
            this.bandedGridColumn3.Width = 226;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.AppearanceCell.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridColumn4.AppearanceCell.Options.UseFont = true;
            this.bandedGridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridColumn4.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn4.Caption = "Unit";
            this.bandedGridColumn4.FieldName = "UnitName";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn4.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.VisibleIndex = 3;
            this.bandedGridColumn4.Width = 64;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridColumn5.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn5.Caption = "Op Stock";
            this.bandedGridColumn5.FieldName = "OpStock";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn5.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.VisibleIndex = 4;
            this.bandedGridColumn5.Width = 74;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandedGridColumn6.AppearanceHeader.Options.UseFont = true;
            this.bandedGridColumn6.Caption = "Price";
            this.bandedGridColumn6.FieldName = "UnitPrice";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn6.OptionsColumn.AllowFocus = false;
            this.bandedGridColumn6.Visible = true;
            this.bandedGridColumn6.VisibleIndex = 5;
            this.bandedGridColumn6.Width = 66;
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
            // CmdNew
            // 
            this.CmdNew.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdNew.Appearance.Options.UseFont = true;
            this.CmdNew.Image = global::inventory_control.Properties.Resources.New_16x16;
            this.CmdNew.Location = new System.Drawing.Point(437, 218);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(77, 25);
            this.CmdNew.TabIndex = 9;
            this.CmdNew.TabStop = false;
            this.CmdNew.Text = "&New";
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 513);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Acctperiod);
            this.Controls.Add(this.CmdSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Item Master Creation ::";
            this.Load += new System.EventHandler(this.CreateItemMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Acctperiod)).EndInit();
            this.Acctperiod.ResumeLayout(false);
            this.Acctperiod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBrandMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBrandMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUnitMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGroupCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemGroupMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItemMaster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Acctperiod;
        private DevExpress.XtraEditors.LabelControl LblPhone2;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl LblPhone1;
        private DevExpress.XtraEditors.LabelControl LblAddress2;
        private DevExpress.XtraEditors.LabelControl LblEmail;
        private DevExpress.XtraEditors.LabelControl LblAddress1;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.LabelControl LblUserName;
        private DevExpress.XtraEditors.SimpleButton CmdSave;
        private DevExpress.XtraEditors.TextEdit txtOpStock;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtItemDescription;
        private DevExpress.XtraEditors.SimpleButton CmdNew;
        private DevExpress.XtraEditors.TextEdit txtMode;
        private DevExpress.XtraEditors.LookUpEdit ItemGroupCode;
        private DevExpress.XtraEditors.LookUpEdit txtUnit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroup;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private inventory_control.Data.dsUnitMaster dsUnitMaster1;
        private System.Windows.Forms.BindingSource tblUnitMasterBindingSource;
        private inventory_control.Data.dsItemGroup dsItemGroup1;
        private System.Windows.Forms.BindingSource tblItemGroupMasterBindingSource;
        private inventory_control.Data.dsItemMaster dsItemMaster1;
        private System.Windows.Forms.BindingSource tblItemMasterBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit CmbBrand;
        private inventory_control.Data.dsBrandMaster dsBrandMaster1;
        private System.Windows.Forms.BindingSource tblBrandMasterBindingSource;
    }
}