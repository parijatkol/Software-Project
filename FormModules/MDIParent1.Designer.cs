namespace inventory_control
{
    partial class MDIParent1
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
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MdinavBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.Fin_Year = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarFinYear = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarCurrentFinYear = new DevExpress.XtraNavBar.NavBarItem();
            this.UserSection = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarUser = new DevExpress.XtraNavBar.NavBarItem();
            this.navuserpermission = new DevExpress.XtraNavBar.NavBarItem();
            this.navPasswordInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.Master = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemUnit = new DevExpress.XtraNavBar.NavBarItem();
            this.navitembrand = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.navSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.navcustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.navcreateproject = new DevExpress.XtraNavBar.NavBarItem();
            this.navprojectproposal = new DevExpress.XtraNavBar.NavBarItem();
            this.navprojectcompletion = new DevExpress.XtraNavBar.NavBarItem();
            this.navTransaction = new DevExpress.XtraNavBar.NavBarGroup();
            this.navPurchase = new DevExpress.XtraNavBar.NavBarItem();
            this.navChallan = new DevExpress.XtraNavBar.NavBarItem();
            this.navIssue = new DevExpress.XtraNavBar.NavBarItem();
            this.navitemreturn = new DevExpress.XtraNavBar.NavBarItem();
            this.navupdatechallan = new DevExpress.XtraNavBar.NavBarItem();
            this.navReport = new DevExpress.XtraNavBar.NavBarGroup();
            this.navcheckstock = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarClose = new DevExpress.XtraNavBar.NavBarItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MdinavBarControl)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MdinavBarControl
            // 
            this.MdinavBarControl.ActiveGroup = this.Fin_Year;
            this.MdinavBarControl.BackColor = System.Drawing.Color.White;
            this.MdinavBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.Fin_Year,
            this.UserSection,
            this.Master,
            this.navTransaction,
            this.navReport});
            this.MdinavBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navSupplier,
            this.navcustomer,
            this.navItemGroup,
            this.navItemUnit,
            this.navitembrand,
            this.navBarFinYear,
            this.navBarUser,
            this.navItemMaster,
            this.navuserpermission,
            this.navPasswordInfo,
            this.navcreateproject,
            this.navprojectproposal,
            this.navprojectcompletion,
            this.navPurchase,
            this.navChallan,
            this.navIssue,
            this.navitemreturn,
            this.navupdatechallan,
            this.navcheckstock,
            this.navBarClose,
            this.navBarCurrentFinYear});
            this.MdinavBarControl.Location = new System.Drawing.Point(0, -1);
            this.MdinavBarControl.Name = "MdinavBarControl";
            this.MdinavBarControl.OptionsNavPane.ExpandedWidth = 130;
            this.MdinavBarControl.Size = new System.Drawing.Size(176, 722);
            this.MdinavBarControl.TabIndex = 4;
            this.MdinavBarControl.Text = "navBarControl1";
            this.MdinavBarControl.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Money Twins");
            // 
            // Fin_Year
            // 
            this.Fin_Year.Caption = "Financial Year";
            this.Fin_Year.Expanded = true;
            this.Fin_Year.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarFinYear),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarCurrentFinYear)});
            this.Fin_Year.Name = "Fin_Year";
            // 
            // navBarFinYear
            // 
            this.navBarFinYear.Caption = "Financial Year Creation";
            this.navBarFinYear.Name = "navBarFinYear";
            this.navBarFinYear.SmallImage = global::inventory_control.Properties.Resources.View_16x16;
            this.navBarFinYear.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarCurrentFinYear
            // 
            this.navBarCurrentFinYear.Caption = "Choose Financial Year";
            this.navBarCurrentFinYear.Name = "navBarCurrentFinYear";
            this.navBarCurrentFinYear.SmallImage = global::inventory_control.Properties.Resources.Period_16x16;
            this.navBarCurrentFinYear.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // UserSection
            // 
            this.UserSection.Caption = "Users Maintenance";
            this.UserSection.Expanded = true;
            this.UserSection.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navuserpermission),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPasswordInfo)});
            this.UserSection.Name = "UserSection";
            // 
            // navBarUser
            // 
            this.navBarUser.Caption = "User Creation";
            this.navBarUser.Name = "navBarUser";
            this.navBarUser.SmallImage = global::inventory_control.Properties.Resources.TopFilmList_16x16;
            this.navBarUser.Visible = false;
            this.navBarUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navuserpermission
            // 
            this.navuserpermission.Caption = "User Permission";
            this.navuserpermission.Name = "navuserpermission";
            this.navuserpermission.SmallImage = global::inventory_control.Properties.Resources.CustomersKPI_16x16;
            this.navuserpermission.Visible = false;
            // 
            // navPasswordInfo
            // 
            this.navPasswordInfo.Caption = "Change Password";
            this.navPasswordInfo.Name = "navPasswordInfo";
            this.navPasswordInfo.SmallImage = global::inventory_control.Properties.Resources.Group_Administrator;
            // 
            // Master
            // 
            this.Master.Caption = "Master Maintenance";
            this.Master.Expanded = true;
            this.Master.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.Master.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemUnit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navitembrand),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemMaster),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSupplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navcustomer)});
            this.Master.Name = "Master";
            // 
            // navItemUnit
            // 
            this.navItemUnit.Caption = "Item Unit";
            this.navItemUnit.Name = "navItemUnit";
            this.navItemUnit.SmallImage = global::inventory_control.Properties.Resources.Home_16x16;
            this.navItemUnit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navitembrand
            // 
            this.navitembrand.Caption = "Item Brand";
            this.navitembrand.Name = "navitembrand";
            this.navitembrand.SmallImage = global::inventory_control.Properties.Resources.CustomersByDate_16x16;
            this.navitembrand.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navItemGroup
            // 
            this.navItemGroup.Caption = "ItemGroup";
            this.navItemGroup.Name = "navItemGroup";
            this.navItemGroup.SmallImage = global::inventory_control.Properties.Resources.Views_16x16;
            this.navItemGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navItemMaster
            // 
            this.navItemMaster.Caption = "Item Master";
            this.navItemMaster.Name = "navItemMaster";
            this.navItemMaster.SmallImage = global::inventory_control.Properties.Resources.RevenueSplit_16x16;
            this.navItemMaster.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navSupplier
            // 
            this.navSupplier.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navSupplier.AppearancePressed.Options.UseBorderColor = true;
            this.navSupplier.Caption = "Suppliers";
            this.navSupplier.LargeImage = global::inventory_control.Properties.Resources.Categories_16x16;
            this.navSupplier.Name = "navSupplier";
            this.navSupplier.SmallImage = global::inventory_control.Properties.Resources.Categories_16x16;
            this.navSupplier.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navcustomer
            // 
            this.navcustomer.Caption = "Customers";
            this.navcustomer.Name = "navcustomer";
            this.navcustomer.SmallImage = global::inventory_control.Properties.Resources.TopCustomers_16x16;
            this.navcustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navcreateproject
            // 
            this.navcreateproject.Caption = "Project Creation";
            this.navcreateproject.Name = "navcreateproject";
            this.navcreateproject.Visible = false;
            // 
            // navprojectproposal
            // 
            this.navprojectproposal.Caption = "Project Proposal";
            this.navprojectproposal.Name = "navprojectproposal";
            // 
            // navprojectcompletion
            // 
            this.navprojectcompletion.Caption = "Project Completion";
            this.navprojectcompletion.Name = "navprojectcompletion";
            // 
            // navTransaction
            // 
            this.navTransaction.Caption = "Transaction";
            this.navTransaction.Expanded = true;
            this.navTransaction.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPurchase),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navChallan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navIssue),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navitemreturn)});
            this.navTransaction.Name = "navTransaction";
            // 
            // navPurchase
            // 
            this.navPurchase.Caption = "Item Purchase";
            this.navPurchase.Name = "navPurchase";
            this.navPurchase.SmallImage = global::inventory_control.Properties.Resources.item_purchase;
            this.navPurchase.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navChallan
            // 
            this.navChallan.Caption = "Challan Preparation";
            this.navChallan.Name = "navChallan";
            this.navChallan.SmallImage = global::inventory_control.Properties.Resources.challan_prep;
            // 
            // navIssue
            // 
            this.navIssue.Caption = "Item Issue";
            this.navIssue.Name = "navIssue";
            this.navIssue.SmallImage = global::inventory_control.Properties.Resources.item_sale;
            this.navIssue.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navitemreturn
            // 
            this.navitemreturn.Caption = "Item Return";
            this.navitemreturn.Name = "navitemreturn";
            this.navitemreturn.Visible = false;
            // 
            // navupdatechallan
            // 
            this.navupdatechallan.Caption = "Update Challan";
            this.navupdatechallan.Name = "navupdatechallan";
            this.navupdatechallan.Visible = false;
            // 
            // navReport
            // 
            this.navReport.Caption = "Report Generation";
            this.navReport.Expanded = true;
            this.navReport.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navcheckstock),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarClose)});
            this.navReport.Name = "navReport";
            // 
            // navcheckstock
            // 
            this.navcheckstock.Caption = "View Stock Report";
            this.navcheckstock.Name = "navcheckstock";
            this.navcheckstock.SmallImage = global::inventory_control.Properties.Resources.CustomerInfoCards_16x16;
            this.navcheckstock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // navBarClose
            // 
            this.navBarClose.Caption = "Exit";
            this.navBarClose.Name = "navBarClose";
            this.navBarClose.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem_LinkClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 6;
            // 
            // statusStripLogin
            // 
            this.statusStripLogin.Name = "statusStripLogin";
            this.statusStripLogin.Size = new System.Drawing.Size(59, 17);
            this.statusStripLogin.Text = "Login As :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::inventory_control.Properties.Resources.WhitePaper_Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1028, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MdinavBarControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIParent1";
            this.Text = "I n v e n t o r y    C o n t r o l    S y s t e m ::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent1_FormClosing);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MdinavBarControl)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraNavBar.NavBarControl MdinavBarControl;
        private DevExpress.XtraNavBar.NavBarGroup Fin_Year;
        private DevExpress.XtraNavBar.NavBarGroup UserSection;
        private DevExpress.XtraNavBar.NavBarGroup Master;
        private DevExpress.XtraNavBar.NavBarItem navSupplier;
        private DevExpress.XtraNavBar.NavBarItem navcustomer;
        private DevExpress.XtraNavBar.NavBarItem navItemUnit;
        private DevExpress.XtraNavBar.NavBarItem navItemGroup;
        private DevExpress.XtraNavBar.NavBarItem navitembrand;
        private DevExpress.XtraNavBar.NavBarItem navBarFinYear;
        private DevExpress.XtraNavBar.NavBarItem navBarUser;
        private DevExpress.XtraNavBar.NavBarItem navItemMaster;
        private DevExpress.XtraNavBar.NavBarItem navuserpermission;
        private DevExpress.XtraNavBar.NavBarItem navPasswordInfo;
        private DevExpress.XtraNavBar.NavBarItem navcreateproject;
        private DevExpress.XtraNavBar.NavBarItem navprojectproposal;
        private DevExpress.XtraNavBar.NavBarItem navprojectcompletion;
        private DevExpress.XtraNavBar.NavBarGroup navTransaction;
        private DevExpress.XtraNavBar.NavBarItem navPurchase;
        private DevExpress.XtraNavBar.NavBarItem navChallan;
        private DevExpress.XtraNavBar.NavBarItem navIssue;
        private DevExpress.XtraNavBar.NavBarItem navitemreturn;
        private DevExpress.XtraNavBar.NavBarItem navupdatechallan;
        private DevExpress.XtraNavBar.NavBarGroup navReport;
        private DevExpress.XtraNavBar.NavBarItem navcheckstock;
        private DevExpress.XtraNavBar.NavBarItem navBarClose;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLogin;
        private DevExpress.XtraNavBar.NavBarItem navBarCurrentFinYear;
    }

}



