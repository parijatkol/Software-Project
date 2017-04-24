namespace inventory_control
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.Fin_Year = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.UserSection = new DevExpress.XtraNavBar.NavBarGroup();
            this.Master = new DevExpress.XtraNavBar.NavBarGroup();
            this.Supplier = new DevExpress.XtraNavBar.NavBarItem();
            this.Vendor = new DevExpress.XtraNavBar.NavBarItem();
            this.ItemGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.Fin_Year;
            this.navBarControl1.BackColor = System.Drawing.Color.White;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.Fin_Year,
            this.UserSection,
            this.Master});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.Supplier,
            this.Vendor,
            this.ItemGroup,
            this.navBarItem4});
            this.navBarControl1.Location = new System.Drawing.Point(17, 6);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 130;
            this.navBarControl1.Size = new System.Drawing.Size(146, 235);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Money Twins");
            // 
            // Fin_Year
            // 
            this.Fin_Year.Caption = "Financial Year";
            this.Fin_Year.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.Fin_Year.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.Fin_Year.Name = "Fin_Year";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "navBarItem2";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // UserSection
            // 
            this.UserSection.Caption = "Users";
            this.UserSection.Name = "UserSection";
            // 
            // Master
            // 
            this.Master.Caption = "Master";
            this.Master.Expanded = true;
            this.Master.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.Master.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.Supplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.Vendor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ItemGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.Master.Name = "Master";
            // 
            // Supplier
            // 
            this.Supplier.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Supplier.AppearancePressed.Options.UseBorderColor = true;
            this.Supplier.Caption = "Supplier";
            this.Supplier.LargeImage = global::inventory_control.Properties.Resources.Categories_16x16;
            this.Supplier.Name = "Supplier";
            this.Supplier.SmallImage = global::inventory_control.Properties.Resources.Categories_16x16;
            // 
            // Vendor
            // 
            this.Vendor.Caption = "Vendor";
            this.Vendor.Name = "Vendor";
            this.Vendor.SmallImage = global::inventory_control.Properties.Resources.TopCustomers_16x16;
            // 
            // ItemGroup
            // 
            this.ItemGroup.Caption = "ItemGroup";
            this.ItemGroup.Name = "ItemGroup";
            this.ItemGroup.SmallImage = global::inventory_control.Properties.Resources.Views_16x16;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ActiveCustomersList_32x32.png");
            this.imageList1.Images.SetKeyName(1, "Categories_16x16.png");
            this.imageList1.Images.SetKeyName(2, "CustomerFilmRentsList_16x16.png");
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "navBarItem4";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 318);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Form1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup Fin_Year;
        private DevExpress.XtraNavBar.NavBarGroup UserSection;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup Master;
        private DevExpress.XtraNavBar.NavBarItem Supplier;
        private DevExpress.XtraNavBar.NavBarItem Vendor;
        private DevExpress.XtraNavBar.NavBarItem ItemGroup;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
    }
}