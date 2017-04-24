namespace inventory_control
{
    partial class AcctPeriodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcctPeriodForm));
            this.Acctperiod = new DevExpress.XtraEditors.GroupControl();
            this.CmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.AcctPeriodDt2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.AcctPeriodDt1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Acctperiod)).BeginInit();
            this.Acctperiod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt1.Properties)).BeginInit();
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
            this.Acctperiod.Controls.Add(this.CmdSave);
            this.Acctperiod.Controls.Add(this.AcctPeriodDt2);
            this.Acctperiod.Controls.Add(this.labelControl2);
            this.Acctperiod.Controls.Add(this.labelControl1);
            this.Acctperiod.Controls.Add(this.AcctPeriodDt1);
            this.Acctperiod.Location = new System.Drawing.Point(12, 12);
            this.Acctperiod.Name = "Acctperiod";
            this.Acctperiod.Size = new System.Drawing.Size(243, 136);
            this.Acctperiod.TabIndex = 0;
            this.Acctperiod.Text = "Account Period";
            // 
            // CmdSave
            // 
            this.CmdSave.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.Appearance.Options.UseFont = true;
            this.CmdSave.Location = new System.Drawing.Point(147, 106);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(77, 22);
            this.CmdSave.TabIndex = 4;
            this.CmdSave.Text = "&Save";
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // AcctPeriodDt2
            // 
            this.AcctPeriodDt2.EditValue = null;
            this.AcctPeriodDt2.Location = new System.Drawing.Point(117, 73);
            this.AcctPeriodDt2.Name = "AcctPeriodDt2";
            this.AcctPeriodDt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AcctPeriodDt2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.AcctPeriodDt2.Size = new System.Drawing.Size(107, 20);
            this.AcctPeriodDt2.TabIndex = 3;
            this.AcctPeriodDt2.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(22, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "End Period :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(22, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Start Period :";
            // 
            // AcctPeriodDt1
            // 
            this.AcctPeriodDt1.EditValue = null;
            this.AcctPeriodDt1.Location = new System.Drawing.Point(117, 39);
            this.AcctPeriodDt1.Name = "AcctPeriodDt1";
            this.AcctPeriodDt1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.AcctPeriodDt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AcctPeriodDt1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.AcctPeriodDt1.Size = new System.Drawing.Size(108, 20);
            this.AcctPeriodDt1.TabIndex = 2;
            this.AcctPeriodDt1.TabStop = false;
            this.AcctPeriodDt1.ToolTip = "Please Put Start Period";
            this.AcctPeriodDt1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            // 
            // AcctPeriodForm
            // 
            this.AcceptButton = this.CmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 157);
            this.Controls.Add(this.Acctperiod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcctPeriodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Create Financial Year ::";
            this.Load += new System.EventHandler(this.AcctPeriodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Acctperiod)).EndInit();
            this.Acctperiod.ResumeLayout(false);
            this.Acctperiod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcctPeriodDt1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Acctperiod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit AcctPeriodDt2;
        private DevExpress.XtraEditors.SimpleButton CmdSave;
        private DevExpress.XtraEditors.DateEdit AcctPeriodDt1;
    }
}