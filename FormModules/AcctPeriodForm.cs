using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace inventory_control
{
    public partial class AcctPeriodForm : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        clsFinancialYear InvclsFinYear = new clsFinancialYear();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();

        public AcctPeriodForm()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (AcctPeriodDt1.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter StartDate");
                    AcctPeriodDt1.Focus();
                }

                if (AcctPeriodDt2.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter EndDate");
                    AcctPeriodDt2.Focus();
                }

                if (AcctPeriodDt1.Text.Trim() != "" && AcctPeriodDt2.Text.Trim() != "")
                {
                    string msg = "Do You Want To Save?";
                    DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        int startfinyr=0,endfinyr=0;
                        startfinyr =int.Parse( AcctPeriodDt1.Text.Trim().Substring(AcctPeriodDt1.Text.Trim().Length - 4));
                        endfinyr = startfinyr + 1;
                        InvclsFinYear.StartDate = AcctPeriodDt1.Text.Trim();
                        InvclsFinYear.EndDate = AcctPeriodDt2.Text.Trim();
                        InvclsFinYear.AcctPeriod = startfinyr.ToString() + "-" + endfinyr.ToString();
//                        clsFinancialYear.FinYear = txtFrom.Text.Trim() + "-" + txtTo.Text.Trim();
                        InvclsFinYear.Status = true;
                        InvclsFinYear.LoginUserID = InvclsGlobalValue.Login_UserId;
                        

                        InvclsFinYear.Mode = "Insert";
                        int i = InvclsFinYear.UpdateData();

                        if (i > 0)
                        {
                            MessageBox.Show("New Financial Year Created Successfully.");
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate Financial Year Found.");
                            }
                            else
                            {
                                MessageBox.Show("Error In Saving!!!!!!!!!!!");
                            }
                        }
 
                        if (result == DialogResult.No)
                        {
                            MessageBox.Show("Record does not save");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }

        private void AcctPeriodForm_Load(object sender, EventArgs e)
        {

        }

    }
}