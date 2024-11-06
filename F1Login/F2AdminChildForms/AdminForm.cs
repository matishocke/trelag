using Abstraction.IModels;
using Abstraction.IService;
using BusinessLogic.Services;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Login.F2AdminChildForms
{
    public partial class AdminForm : Form
    {
        private readonly IAdminService _adminService;
        public AdminForm(IAdminService adminService)
        {
            InitializeComponent();
            _adminService = adminService;
        }



        private async void AdminForm_Load(object sender, EventArgs e)
        {
            await LoadAllAdminsInDataGridView();
        }




        private async Task LoadAllAdminsInDataGridView()
        {
            try
            {
                var customerList = await _adminService.GetAllAdmins();  //READ

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = customerList;

                DGV_Admins.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Admins:" +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task ShowAdminDetails(IAdmin admin)
        {
            LBL_ShowIDAdmin.Text = Convert.ToString(admin.AdminID);
            TXT_UserNameAdmin.Text = admin.UserName;
            TXT_Salary.Text = admin.Salary;
            TXT_PhonenumberAdmin.Text = admin.PhoneNumber;
            TXT_PasswordAdmin.Text = admin.Password;
            TXT_FirstNameAdmin.Text = admin.FirstName;
            TXT_LastNameAdmin.Text = admin.LastName;
            TXT_AddressAdmin.Text = admin.Address;
            TXT_EmailAdmin.Text = admin.Email;
        }
        private async void DGV_Admins_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Admins.SelectedRows.Count > 0)
                {
                    await ShowAdminDetails((IAdmin)DGV_Admins.SelectedRows[0].DataBoundItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SelectionChanged:" +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ClearTextBoxes()
        {
            LBL_ShowIDAdmin.Text = string.Empty;
            TXT_UserNameAdmin.Text = string.Empty;
            TXT_Salary.Text = string.Empty;
            TXT_PhonenumberAdmin.Text = string.Empty;
            TXT_PasswordAdmin.Text = string.Empty;
            TXT_FirstNameAdmin.Text = string.Empty;
            TXT_LastNameAdmin.Text = string.Empty;
            TXT_AddressAdmin.Text = string.Empty;
            TXT_EmailAdmin.Text = string.Empty;
        }




        //CREATE
        private async void BTN_CreateAdmin_Click(object sender, EventArgs e)
        {
            string userNameNeeded = TXT_UserNameAdmin.Text;
            string passwordNeeded = TXT_PasswordAdmin.Text;
            string userTypeNeeded = "admin";
            string firstNameNeeded = TXT_FirstNameAdmin.Text;
            string lastNameNeeded = TXT_LastNameAdmin.Text;
            string phoneNumberNeeded = TXT_PhonenumberAdmin.Text;
            string emailNeeded = TXT_EmailAdmin.Text;
            string addressNeeded = TXT_AddressAdmin.Text;
            string salaryNeeded = TXT_Salary.Text;

            try
            {
                IAdmin canThisAdminbeFound = _adminService.GetAdminByUserName(userNameNeeded);

                if (canThisAdminbeFound == null || canThisAdminbeFound.UserName != userNameNeeded)  //If that username was not the same as the found username so create
                {
                    await _adminService.CreateAdmin(userNameNeeded, passwordNeeded, userTypeNeeded,
                                                    firstNameNeeded, lastNameNeeded, phoneNumberNeeded,
                                                    emailNeeded, addressNeeded, salaryNeeded);


                    await LoadAllAdminsInDataGridView();
                    ClearTextBoxes();
                    MessageBox.Show("New Admin has been Successfully Created",
                            "CREATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Admin Username has already been taken",
                        "CREATE Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearTextBoxes();
                    TXT_UserNameAdmin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not Create" + ex.Message,
                        "CREATE Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //UPDATE
        private async void BTN_UpdateAdmin_Click(object sender, EventArgs e)
        {
            int adminIDNeeded = Convert.ToInt32(LBL_ShowIDAdmin.Text);
            string userNameNeeded = TXT_UserNameAdmin.Text;
            string passwordNeeded = TXT_PasswordAdmin.Text;
            string userTypeNeeded = "admin";
            string firstNameNeeded = TXT_FirstNameAdmin.Text;
            string lastNameNeeded = TXT_LastNameAdmin.Text;
            string phoneNumberNeeded = TXT_PhonenumberAdmin.Text;
            string emailNeeded = TXT_EmailAdmin.Text;
            string addressNeeded = TXT_AddressAdmin.Text;
            string salaryNeeded = TXT_Salary.Text;
            try
            {
                await _adminService.UpdateAdmin(adminIDNeeded, userNameNeeded, passwordNeeded,
                    firstNameNeeded, lastNameNeeded, phoneNumberNeeded, emailNeeded, addressNeeded, salaryNeeded);

                await LoadAllAdminsInDataGridView();
                ClearTextBoxes();
                MessageBox.Show("The chosen Admin has been Successfully Updated",
                    "UPDATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not Update" + ex.Message,
                    "UPDATE Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //DELETE
        private async void BTN_DeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {


                int adminIDNeeded = Convert.ToInt32(LBL_ShowIDAdmin.Text);

                await _adminService.DeleteAdmin(adminIDNeeded);
                await LoadAllAdminsInDataGridView();
                ClearTextBoxes();
                MessageBox.Show("The chosen Admin has been Successfully Deleted",
                       "DELETE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not Update" + ex.Message,
                    "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //RESET
        private async void BTN_ResetAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                await LoadAllAdminsInDataGridView();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not Reset" + ex.Message,
                    "Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //FIND
        private async void BTN_FindAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                IAdmin findTheAdmin = _adminService.GetAdminByUserName(TXT_UserNameAdmin.Text);
                if (findTheAdmin != null)
                {
                    List<IAdmin> listForTheFoundAdmin = new List<IAdmin>(); //DGV accepts only lists
                    listForTheFoundAdmin.Add(findTheAdmin);

                    DGV_Admins.DataSource = null; //Clear the previous datasource
                    DGV_Admins.DataSource = listForTheFoundAdmin; //The only customer comes here

                    await ShowAdminDetails(findTheAdmin);
                }
                else
                {
                    MessageBox.Show("Admin not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer not found. Please double-check the username." + ex.Message,
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
