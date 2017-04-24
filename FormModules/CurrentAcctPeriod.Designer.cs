namespace inventory_control
{
    partial class CurrentAcctPeriod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentAcctPeriod));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbAcctPeriod = new DevExpress.XtraEditors.LookUpEdit();
            this.tblFinancialYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAcctPeriod1 = new inventory_control.Data.dsAcctPeriod();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdOpen = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAcctPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFinancialYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcctPeriod1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.cmbAcctPeriod);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(285, 77);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Choose Accounting Period";
            // 
            // cmbAcctPeriod
            // 
            this.cmbAcctPeriod.EditValue = "";
            this.cmbAcctPeriod.Location = new System.Drawing.Point(134, 36);
            this.cmbAcctPeriod.Name = "cmbAcctPeriod";
            this.cmbAcctPeriod.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcctPeriod.Properties.Appearance.Options.UseFont = true;
            this.cmbAcctPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAcctPeriod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AcctPeriod", "Financial Year", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StartDate", 60, "Start Date"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EndDate", 60, "End Date"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FinancialYrID", "ID", 5, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbAcctPeriod.Properties.DataSource = this.tblFinancialYearBindingSource;
            this.cmbAcctPeriod.Properties.DisplayMember = "AcctPeriod";
            this.cmbAcctPeriod.Properties.ValueMember = "FinancialYrID";
            this.cmbAcctPeriod.Size = new System.Drawing.Size(130, 20);
            this.cmbAcctPeriod.TabIndex = 6;
            // 
            // tblFinancialYearBindingSource
            // 
            this.tblFinancialYearBindingSource.DataMember = "tbl_FinancialYear";
            this.tblFinancialYearBindingSource.DataSource = this.dsAcctPeriod1;
            // 
            // dsAcctPeriod1
            // 
            this.dsAcctPeriod1.DataSetName = "dsAcctPeriod";
            this.dsAcctPeriod1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounting Period :";
            // 
            // cmdOpen
            // 
            this.cmdOpen.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpen.Appearance.Options.UseFont = true;
            this.cmdOpen.Image = global::inventory_control.Properties.Resources.Period_16x16;
            this.cmdOpen.Location = new System.Drawing.Point(219, 93);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(76, 23);
            this.cmdOpen.TabIndex = 1;
            this.cmdOpen.Text = "Open";
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // CurrentAcctPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 123);
            this.ControlBox = false;
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentAcctPeriod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Accounting Period ::";
            this.Load += new System.EventHandler(this.CurrentAcctPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAcctPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFinancialYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAcctPeriod1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton cmdOpen;
        private System.Windows.Forms.Label label1;
        private inventory_control.Data.dsAcctPeriod dsAcctPeriod1;
        private DevExpress.XtraEditors.LookUpEdit cmbAcctPeriod;
        private System.Windows.Forms.BindingSource tblFinancialYearBindingSource;
    }
}