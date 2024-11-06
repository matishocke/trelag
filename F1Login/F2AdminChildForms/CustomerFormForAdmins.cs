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
    public partial class CustomerFormForAdmins : Form
    {
        private readonly ICustomerService _customerService;
        public CustomerFormForAdmins(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }


        //READ
        private async void CustomerFormForAdmins_Load(object sender, EventArgs e)
        {
            await LoadAllCustomersInDataGridView();
        }




        //READ
        private async Task LoadAllCustomersInDataGridView()
        {
            try
            {
                var customerList = await _customerService.GetAllCustomers();  //READ

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = customerList;

                DGV_Customers.DataSource = bindingSource;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading Customers:" +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private async Task ShowCustomerDetails(ICustomer customer)
        {
            LBL_ShowID.Text = Convert.ToString(customer.CustomerId);
            TXT_Phonenumber.Text = customer.PhoneNumber;
            TXT_UserName.Text = customer.Username;
            TXT_Password.Text = customer.Password;
            TXT_FirstName.Text = customer.Firstname;
            TXT_LastName.Text = customer.Lastname;
            TXT_Email.Text = customer.Email;
            TXT_Address.Text = customer.Address;
        }
        private async void DGV_Customers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Customers.SelectedRows.Count > 0)
                {
                    await ShowCustomerDetails((ICustomer)DGV_Customers.SelectedRows[0].DataBoundItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SelectionChanged:" +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void ClearTextboxes()
        {
            LBL_ShowID.Text = string.Empty;
            TXT_Phonenumber.Text = string.Empty;
            TXT_UserName.Text = string.Empty;
            TXT_Password.Text = string.Empty;
            TXT_FirstName.Text = string.Empty;
            TXT_LastName.Text = string.Empty;
            TXT_Email.Text = string.Empty;
            TXT_Address.Text = string.Empty;
        }






        //CREATE
        private async void BTN_CreateFavor_Click(object sender, EventArgs e)
        {
            string userNameNeed = TXT_UserName.Text;
            string passwordNeed = TXT_Password.Text;
            string userTypeNeed = "user";
            string firstNameNeed = TXT_FirstName.Text;
            string lastNameNeed = TXT_LastName.Text;
            string phoneNumberNeed = TXT_Phonenumber.Text;
            string emailNeed = TXT_Email.Text;
            string addressNeed = TXT_Address.Text;

            ICustomer canThisCustomerBeFound = _customerService.GetCustomer(userNameNeed);

            if (canThisCustomerBeFound.Username != userNameNeed)
            {
                await _customerService.CreateCustomer(userNameNeed, passwordNeed, userTypeNeed,
                firstNameNeed, lastNameNeed, phoneNumberNeed, emailNeed, addressNeed);



                await LoadAllCustomersInDataGridView();

                ClearTextboxes();
                MessageBox.Show("New Customer has been Successfully Created",
                        "CREATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This Customer Username has already been taken",
                    "CREATE Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextboxes();
                TXT_UserName.Focus();
            }
        }






        //UPDATE
        private async void BTN_UpdateFavor_Click(object sender, EventArgs e)
        {
            int customerIDNeed = Convert.ToInt32(LBL_ShowID.Text);
            string userNameNeed = TXT_UserName.Text;
            string passwordNeed = TXT_Password.Text;
            string userTypeNeed = "user";
            string firstNameNeed = TXT_FirstName.Text;
            string lastNameNeed = TXT_LastName.Text;
            string phoneNumberNeed = TXT_Phonenumber.Text;
            string emailNeed = TXT_Email.Text;
            string addressNeed = TXT_Address.Text;

            
            await _customerService.UpdateCustomer(customerIDNeed, userNameNeed, passwordNeed, firstNameNeed,
            lastNameNeed, phoneNumberNeed, emailNeed, addressNeed);

            await LoadAllCustomersInDataGridView();

            ClearTextboxes();

            MessageBox.Show("The chosen Customer has been Successfully Updated",
                "UPDATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }






        //DELETE
        private async void BTN_DeleteFavor_Click(object sender, EventArgs e)
        {
            int customerIDNeed = Convert.ToInt32(LBL_ShowID.Text);

            await _customerService.DeleteCustomer(customerIDNeed);

            await LoadAllCustomersInDataGridView();

            ClearTextboxes();
            MessageBox.Show("The chosen Customer has been Successfully Deleted",
                   "DELETE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //RESET
        private async void BTN_Reset_Click(object sender, EventArgs e)
        {

            await LoadAllCustomersInDataGridView();
            ClearTextboxes();
        }


        //FIND
        private async void BTN_Find_Click(object sender, EventArgs e)
        {
            try
            {
                ICustomer findTheCustomer = _customerService.GetCustomer(TXT_UserName.Text);
                if (findTheCustomer != null)
                {
                    List<ICustomer> listForFoundCustomer = new List<ICustomer>(); //DGV accepts only lists
                    listForFoundCustomer.Add(findTheCustomer);

                    DGV_Customers.DataSource = null; //Clear the previous datasource
                    DGV_Customers.DataSource = listForFoundCustomer; //The only customer comes here

                    await ShowCustomerDetails(findTheCustomer);
                }
                else
                {
                    MessageBox.Show("Admin not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Admin not found. Please double-check the username.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
