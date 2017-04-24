using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventory_control
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string HitMenu = e.Link.Item.Name;

            if (clsGlobalValue._Logged == true && clsGlobalValue._SelectFinYear==true)
            {
                switch (HitMenu)
                {
                    case "navBarFinYear":
                        AcctPeriodForm frmFinYear = new AcctPeriodForm();
                        frmFinYear.MdiParent = this;
                        frmFinYear.Show();
                        break;
                    case "navBarCurrentFinYear" :
                        SelectFinYear frmCurrentFinYear = new SelectFinYear();
                        frmCurrentFinYear.MdiParent = this;
                        frmCurrentFinYear.Show();
                        break;
                    case "navBarUser":
                        UserCreationForm frmUser1 = new UserCreationForm();
                        frmUser1.MdiParent = this;
                        frmUser1.Location = new Point(250, 80);
                        frmUser1.Show();
                        break;
                    case "navItemUnit":
                        UnitMaster frmMaster1 = new UnitMaster();
                        frmMaster1.MdiParent = this;
                        frmMaster1.Show();
                        break;
                    case "navitembrand":
                        BrandMaster frmMaster2 = new BrandMaster();
                        frmMaster2.MdiParent = this;
                        frmMaster2.Show();
                        break;
                    case "navItemGroup":
                        ItemGroupMaster frmMaster3 = new ItemGroupMaster();
                        frmMaster3.MdiParent = this;
                        frmMaster3.Show();
                        break;
                    case "navItemMaster":
                        ItemMaster frmMaster4 = new ItemMaster();
                        frmMaster4.MdiParent = this;
                        frmMaster4.Location = new Point(260, 110);
                        frmMaster4.Show();
                        break;
                    case "navSupplier":
                        CreateSupplierForm frmMaster5 = new CreateSupplierForm();
                        frmMaster5.MdiParent = this;
                        frmMaster5.Location = new Point(200, 100);
                        frmMaster5.Show();
                        break;
                    case "navcustomer":
                        CustomerMaster frmMaster6 = new CustomerMaster();
                        frmMaster6.MdiParent = this;
                        frmMaster6.Show();
                        break;
                    case "navPurchase":
                        ItemPurchase frmTrans1 = new ItemPurchase();
                        frmTrans1.MdiParent = this;
                        frmTrans1.Location = new Point(180, 10);
                        frmTrans1.Show();
                        break;
                    case "navIssue":
                        ItemIssue frmItemIssue = new ItemIssue();
                        frmItemIssue.MdiParent = this;
                        frmItemIssue.Location = new Point(180, 10);
                        frmItemIssue.Show();
                        break;
                    case "navcheckstock" :
                        ViewStock frmViewstock = new ViewStock();
                        frmViewstock.MdiParent = this;
                        frmViewstock.Location = new Point(200, 50);
                        frmViewstock.Show();
                        break;
                    case "navBarClose":
                        Application.Exit();
                        break;
                }
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            LoginForm FrmLogin = new LoginForm();
            FrmLogin.MdiParent = this;
            FrmLogin.Show();
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
//            DialogResult result = MessageBox.Show(this, "Are You Sure Want To Quit?", "Exit From System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

//            if (result == DialogResult.OK)
//            {
                Application.Exit();
//            }
        }

    }
}
