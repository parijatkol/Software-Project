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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvclsGlobal = new clsGlobalValue();
        DataAccessLayer InvclsDataAccessLayer = new DataAccessLayer();
        clsUserLogin InvclsUserLogin = new clsUserLogin();
        clsTools InvTools = new clsTools();
        clsValidation UserLogin = new clsValidation();
        clsValidation InvCustValidation = new clsValidation();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            if ((MyErrorProvider.CheckAndShowSummaryErrorMessage() == true))
            {
                try
                {
                    InvclsUserLogin.UserName = InvTools.formatInputString(txtUserName.Text);
                    InvclsUserLogin.Password = InvTools.formatInputString(txtPassword.Text);
                    //InvclsCustomer.LoginUserID = clsGlobalValue._Login_UserId;
                    //InvclsCustomer.EntryDate = DateTime.Now;
                    //InvclsCustomer.Mode = InvTools.formatInputString(txtMode.Text.Trim());

                    int i = InvclsUserLogin.UserCheckLogin();

                    if (i > 0)
                    {
                        InvclsGlobal.Login_UserId = i;
                        InvclsGlobal.loggedusername = txtUserName.Text.Trim();
                        this.Close();
                        //CurrentAcctPeriod CAP = new CurrentAcctPeriod();
                        SelectFinYear CAP = new SelectFinYear();
                        CAP.Show();
                    }
                    else
                        MessageBox.Show("Sorry!!! Invalid User Name / Password.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void txtUserName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (UserLogin.IsEmptyValidate(txtUserName.Text) == false)
                {
                    errorProvider1.SetError(txtUserName, "Please Provide UserName");
                    CmdLogin.Enabled = false;
                    txtUserName.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtUserName, "");
                    txtPassword.Focus();
                }
            }
        }

        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (UserLogin.IsEmptyValidate(txtPassword.Text) == false)
                {
                    errorProvider1.SetError(txtPassword, "Please Provide Password");
                    CmdLogin.Enabled = false;
                    txtPassword.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtPassword, "");
                    CmdLogin.Enabled = true;
                    CmdLogin.Focus();
                }
            }
        }
    }
}