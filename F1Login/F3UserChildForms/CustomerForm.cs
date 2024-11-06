using Abstraction.IModels;
using Abstraction.IService;
using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Login.F3UserChildForms
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerService _customerService;


        private string _username;
        public CustomerForm(ICustomerService service, string username)
        {
            InitializeComponent();
            _customerService = service;


            _username = username;
            Console.WriteLine("");
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ShowCustomerDetails();
        }




        private void BTN_SaveChanges_Click(object sender, EventArgs e)
        {
            int customerIDNeed = Convert.ToInt32(LBL_ShowCustomerID.Text);
            string userNameNeed = Username_TXT.Text;
            string passwordNeed = Password_TXT.Text;
            string userTypeNeed = "user";
            string firstNameNeed = firstname_TXT.Text;
            string lastNameNeed = lastname_TXT.Text;
            string phoneNumberNeed = Phonenumber_TXT.Text;
            string emailNeed = Email_TXT.Text;
            string addressNeed = Address_TXT.Text;

            var foundCustomer = _customerService.GetCustomer(userNameNeed);


            _customerService.UpdateCustomer(customerIDNeed, userNameNeed, passwordNeed, firstNameNeed,
                lastNameNeed, phoneNumberNeed, emailNeed, addressNeed);

            MessageBox.Show("Your change has been Submitted",
                    "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void ShowCustomerDetails()
        {

            ICustomer thisCustomer = _customerService.GetCustomer(_username); //CHAIN DATA USERNAME NOT ANYMore
            LBL_ShowCustomerID.Text = Convert.ToString(thisCustomer.CustomerId);
            Username_TXT.Text = thisCustomer.Username;
            Password_TXT.Text = thisCustomer.Password;
            firstname_TXT.Text = thisCustomer.Firstname;
            lastname_TXT.Text = thisCustomer.Lastname;
            Phonenumber_TXT.Text = thisCustomer.PhoneNumber;
            Email_TXT.Text = thisCustomer.Email;
            Address_TXT.Text = thisCustomer.Address;
        }




    }
}
