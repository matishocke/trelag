using Abstraction.IModels;
using Abstraction.IRepository;
using Abstraction.IService;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Login
{
    public partial class Form4CreateAccount : Form
    {
        private readonly ILoginService _loginService;
        private readonly ICustomerService _customerService;
        private readonly IFavorService _favorService;
        private readonly IRequestService _requestService;
        private readonly IFavorLineService _favorLineService;  //ii
        private readonly IAdminService _adminService;
        public Form4CreateAccount(ILoginService loginService, ICustomerService service, IFavorService favorService,
            IRequestService requestService, IFavorLineService favorLineService, IAdminService adminService)
        {
            InitializeComponent();
            _loginService = loginService;
            _customerService = service;
            _favorService = favorService;
            _requestService = requestService;
            _favorLineService = favorLineService;  //ii
            _adminService = adminService;
        }

        private void Register_BTN_Click(object sender, EventArgs e)
        {
            if (Username_TXT.Text == string.Empty && Password_TXT.Text == string.Empty &&
                ConfPassword_TXT.Text == string.Empty && Firstname_TXT.Text == string.Empty &&
                Lastname_TXT.Text == string.Empty && Phonenumber_TXT.Text == string.Empty &&
                Email_TXT.Text == string.Empty && Address_TXT.Text == string.Empty)
            {
                MessageBox.Show("One or Many of the Fields are Empty",
                    "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password_TXT.Text != ConfPassword_TXT.Text)
            {

                MessageBox.Show("Passwords does NOT match, Please Re-enter",
                    "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_TXT.Text = string.Empty;
                ConfPassword_TXT.Text = string.Empty;
                Password_TXT.Focus();

            }
            else if (Username_TXT.Text == FoundCustomer())
            {
                MessageBox.Show("This Username is already belongs to someone else please choose another one",
                    "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username_TXT.Text = string.Empty;
                Username_TXT.Focus();
            }
            else
            {
                _customerService.CreateCustomer(Username_TXT.Text, Password_TXT.Text, "user", Firstname_TXT.Text,
                    Lastname_TXT.Text, Phonenumber_TXT.Text, Email_TXT.Text, Address_TXT.Text);

                ClearTheTextBoxes();

                MessageBox.Show("Your Account has been Successfully Created",
                    "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private string FoundCustomer() //GetCustomer to string
        {
            ICustomer foundCustomer = _customerService.GetCustomer(Username_TXT.Text);
            return foundCustomer.Username;
        }





        private void ClearTheTextBoxes()
        {
            Username_TXT.Text = string.Empty;
            Password_TXT.Text = string.Empty;
            ConfPassword_TXT.Text = string.Empty;
            Firstname_TXT.Text = string.Empty;
            Lastname_TXT.Text = string.Empty;
            Phonenumber_TXT.Text = string.Empty;
            Email_TXT.Text = string.Empty;
            Address_TXT.Text = string.Empty;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password_TXT.UseSystemPasswordChar = false;
                ConfPassword_TXT.UseSystemPasswordChar = false;
            }
            else
            {
                Password_TXT.UseSystemPasswordChar = true;
                ConfPassword_TXT.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTheTextBoxes();
            Username_TXT.Focus();
        }

        private void backLogin_LBL_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1
                (_loginService, _customerService, _favorService, _requestService, _favorLineService, _adminService);
            form1.Show();
            this.Hide();
        }

        private void BTN_HelpFunction_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "C:\\Users\\dashm\\OneDrive\\Skrivebord\\2.semester projektttttttt\\HelpFunction\\1_LoginHelpFunction.pdf";

                if (System.IO.File.Exists(filePath))
                {
                    System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo(filePath);
                    processStartInfo.UseShellExecute = true;

                    System.Diagnostics.Process.Start(processStartInfo);
                }
                else
                {
                    MessageBox.Show("The file doesn't exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
