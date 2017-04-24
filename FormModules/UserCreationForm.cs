using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace inventory_control
{
    public partial class UserCreationForm : DevExpress.XtraEditors.XtraForm
    {
        clsGlobalValue InvclsGlobalValue = new clsGlobalValue();
        clsUserCreation InvclsUserCreate = new clsUserCreation();
        DataAccessLayer InvDataAccessLayer = new DataAccessLayer();
        clsTools InvTools = new clsTools();
        clsValidation InvUserCreateValidation = new clsValidation();
        ErrorProviderExtended MyErrorProvider = new ErrorProviderExtended();
        int rowHit = 0;


        public UserCreationForm()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (MyErrorProvider.CheckAndShowSummaryErrorMessage() == true)
            {
                try
                {
                    int usrgrpid = int.Parse(lookUpEditUserGroup.GetColumnValue("UserGroupID").ToString());

                    string msg = "Do You Want To Save?";
                    DialogResult result = MessageBox.Show(this, msg, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        InvclsUserCreate.UserName = InvTools.formatInputString(txtUserName.Text.Trim());
                        InvclsUserCreate.Password = InvTools.formatInputString(txtPassword.Text.Trim());
                        InvclsUserCreate.FirstName = InvTools.formatInputString(txtFirstName.Text.Trim());
                        InvclsUserCreate.LastName = InvTools.formatInputString(txtLastName.Text.Trim());
                        InvclsUserCreate.Address = InvTools.formatInputString(TxtAddress.Text);
                        InvclsUserCreate.ContactNo = InvTools.formatInputString(txtContactNo.Text);
                        InvclsUserCreate.UserGroupID = usrgrpid;
                        InvclsUserCreate.UserGroupIDItemIndex = lookUpEditUserGroup.ItemIndex;
                        InvclsUserCreate.UserLoginID = InvclsGlobalValue.Login_UserId;
                        InvclsUserCreate.EntryDate = DateTime.Now;
                        InvclsUserCreate.Status = true;

                        InvclsUserCreate.Mode = InvTools.formatInputString(txtMode.Text.Trim());

                        int i = InvclsUserCreate.UpdateData();

                        if (txtMode.Text.Trim() == "Insert")
                            msg = "New User Created Successfully.";
                        else
                            msg = "User Information Updated Successfully.";

                        if (i > 0)
                        {
                            MessageBox.Show(msg);
                            clearData();
                            Usergridpopulate(rowHit);
                        }
                        else
                        {
                            if (i == -1)
                            {
                                MessageBox.Show("Sorry!!! Duplicate UserName Found.");
                            }
                            else
                            {
                                MessageBox.Show("Error In Saving!!!!!!!!!!!");
                            }
                        }

                        if (result == DialogResult.No)
                        {
                            MessageBox.Show("Error In Saving !!!!!!!!!!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void UserCreationForm_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from tbl_UserGroup where Status=1";
            SqlDataAdapter InvDataAdapter = new SqlDataAdapter();
            InvDataAdapter = InvDataAccessLayer.PopulateData(strSQL);
            InvDataAdapter.Fill(dsPopulateData1.tbl_UserGroup);

            //        SetWaitDialogCaption("Loading User Groups...");
            //oleDBAdapter4.Fill(dsCategories1.Suppliers);

            MyErrorProvider.Controls.Add((object)txtFirstName, "First Name");
            MyErrorProvider.Controls.Add((object)txtLastName, "Last Name");
            MyErrorProvider.Controls.Add((object)TxtAddress, "Address");
            MyErrorProvider.Controls.Add((object)txtContactNo, "Contact No");
            MyErrorProvider.Controls.Add((object)txtUserName, "User Name");
            MyErrorProvider.Controls.Add((object)txtPassword, "Password");
            MyErrorProvider.Controls.Add((object)txtCPassword, "Confirm Password");
            MyErrorProvider.Controls.Add((object) lookUpEditUserGroup, "User Group");
            // Initially make emergency contact field as non mandatory
            MyErrorProvider.SummaryMessage = "Following fields are mandatory,";
            Usergridpopulate(0);
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            clearData();
            txtMode.Text = "Insert";
        }

        private void clearData()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            TxtAddress.Text = "";
            txtContactNo.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtCPassword.Text = "";
            lookUpEditUserGroup.Text = "";
        }

        private void Usergridpopulate(int focusrow)
        {
            try
            {
                int totrow = gridView2.RowCount;
                for (int i = 0; i < totrow; )
                {
                    DataRow row = gridView2.GetDataRow(i);
                    row.Delete();
                    totrow = gridView2.RowCount;
                }

                string strSQL = "select a.UserID,a.FirstName,a.LastName,a.UserName,a.Password,a.ContactNo,b.UserGroupName from tbl_MainUsers a inner join tbl_UserGroup b on a.usergroupid = b.usergroupid where a.Status=1";
                SqlDataAdapter InvDataUserAdapter = new SqlDataAdapter();
                InvDataUserAdapter = InvDataAccessLayer.PopulateData(strSQL);
                InvDataUserAdapter.Fill(dsUserList1.tbl_MainUsers);
                gridView2.FocusedRowHandle = focusrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int rowID = 0;

            try
            {
                foreach (int i in gridView3.GetSelectedRows())
                {
                    DataRow row = gridView3.GetDataRow(i);
                    rowID = Convert.ToInt16(row["UserID"]);
                    rowHit = i;
                }

                if (InvclsUserCreate.RetrieveData(rowID))
                {
                    txtFirstName.Text = InvclsUserCreate.FirstName;
                    txtLastName.Text = InvclsUserCreate.LastName;
                    TxtAddress.Text = InvclsUserCreate.Address;
                    txtContactNo.Text = InvclsUserCreate.ContactNo;
                    txtUserName.Text = InvclsUserCreate.UserName;
                    txtPassword.Text = InvclsUserCreate.Password;
                    txtCPassword.Text = InvclsUserCreate.Password;
                    lookUpEditUserGroup.ItemIndex = InvclsUserCreate.UserGroupIDItemIndex;
                    txtMode.Text = "Update";
                    InvclsUserCreate.UserID = rowID;
                    //lookUpEditUserGroup.DataBindings.Add("EditValue", "UserGroupID", "Administrator");
                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(txtFirstName.Text) == false)
            {
                errorProvider1.SetError(txtFirstName, "Please Provide First Name");
                CmdSave.Enabled = false;
                txtFirstName.Focus();
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
                CmdSave.Enabled = true;
            }
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(txtLastName.Text) == false)
            {
                errorProvider1.SetError(txtLastName, "Please Provide Last Name");
                CmdSave.Enabled = false;
                txtLastName.Focus();
            }
            else
            {
                errorProvider1.SetError(txtLastName, "");
                CmdSave.Enabled = true;
            }
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(txtLastName.Text) == false)
            {
                errorProvider1.SetError(TxtAddress, "Please Provide Address");
                CmdSave.Enabled = false;
                TxtAddress.Focus();
            }
            else
            {
                errorProvider1.SetError(TxtAddress, "");
                CmdSave.Enabled = true;
            }
        }

        private void txtContactNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(txtContactNo.Text) == false)
            {
                errorProvider1.SetError(txtContactNo, "Please Provide Contact No");
                CmdSave.Enabled = false;
                txtContactNo.Focus();
            }
            else
            {
                errorProvider1.SetError(txtContactNo, "");
                CmdSave.Enabled = true;
            }
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(txtUserName.Text) == false)
            {
                errorProvider1.SetError(txtUserName, "Please Provide UserName");
                CmdSave.Enabled = false;
                txtUserName.Focus();
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
                CmdSave.Enabled = true;
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(txtUserName.Text) == false)
            {
                errorProvider1.SetError(txtPassword, "Please Provide Password");
                CmdSave.Enabled = false;
                txtPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
                CmdSave.Enabled = true;
            }
        }

        private void txtCPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(txtCPassword.Text) == false)
            {
                errorProvider1.SetError(txtCPassword, "Please Confirm Password");
                CmdSave.Enabled = false;
                txtCPassword.Focus();
            }
            else
            {
                if (txtPassword.Text.Trim() != txtCPassword.Text.Trim())
                {                
                    errorProvider1.SetError(txtCPassword, "Password Should Be Matched With Confirm Password");
                    CmdSave.Enabled = false;
                    txtCPassword.Focus();
                }
                else
                {
                    errorProvider1.SetError(txtCPassword, "");
                    CmdSave.Enabled = true;
                }
            }
        }

        private void lookUpEditUserGroup_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvUserCreateValidation.IsEmptyValidate(lookUpEditUserGroup.Text) == false)
            {
                errorProvider1.SetError(lookUpEditUserGroup, "Please Select UserGroup");
                CmdSave.Enabled = false;
                lookUpEditUserGroup.Focus();
            }
            else
            {
                errorProvider1.SetError(lookUpEditUserGroup, "");
                CmdSave.Enabled = true;
            }
        }


    }
}