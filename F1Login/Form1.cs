using Abstraction.IModels;
using Abstraction.IService;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace F1Login
{

    public partial class Form1 : Form
    {
        private readonly ILoginService _loginService;
        private readonly ICustomerService _customerService;
        private readonly ICustomer _customer;  //exstra
        private readonly IFavorService _favorService;
        private readonly IRequestService _requestService;
        private readonly IFavorLineService _favorLineService;  //ii
        private readonly IAdminService _adminService;


        public Form1(ILoginService loginService, ICustomerService customerService, IFavorService favorService,
            IRequestService requestService, IFavorLineService favorLineService, IAdminService adminService)
        {
            InitializeComponent();
            _loginService = loginService;
            _customerService = customerService;

            _favorService = favorService;
            _requestService = requestService;
            _favorLineService = favorLineService;  //ii
            _adminService = adminService;
        }




        private void Login_BTN_Click(object sender, EventArgs e)
        {
            //F3UserChildForms.CustomerForm customerForm = new F3UserChildForms.CustomerForm(_service, _username);  //CHAIN DATA USERNAME


            string usernameInput = Username_TXT.Text;
            string passwordInput = Password_TXT.Text;



            if (comboBoxUserOrAdmin.SelectedItem != null) //is chosed one in combobox
            {
                string? comboBoxItemValue = comboBoxUserOrAdmin.SelectedItem.ToString();   //change the selectedItem to string

                if (comboBoxItemValue != null)  //if that was string and was not null
                {
                    Task<bool> succedLogin = _loginService.Login(usernameInput, passwordInput, comboBoxItemValue);

                    if (succedLogin.Result)
                    {
                        if (comboBoxUserOrAdmin.SelectedIndex == 0)  //login as admin cuz check combobox
                        {
                            MessageBox.Show("You are login as " + comboBoxItemValue);
                            F2Admin f2Admin = new F2Admin(_customerService, usernameInput,
                                _favorService, _loginService, _requestService, _favorLineService, _adminService);

                            f2Admin.Show();
                            this.Hide();
                        }
                        else //if (comboBoxUserOrAdmin.SelectedIndex == 1) could we write //login as user cuz chexk combobox
                        {
                            MessageBox.Show("You are login as " + comboBoxItemValue);
                            F3User f3Admin = new F3User(_customerService, usernameInput, _favorService,
                                _requestService, _loginService, _favorLineService, _adminService);

                            f3Admin.Show();
                            this.Hide();
                        }
                    }
                    else //if (succedLogin.Result) == false
                    {
                        MessageBox.Show("error; Your Username or Your Password is incorrect !!!");
                    }
                }
                else  //if combobox did not give an string
                {
                    MessageBox.Show("You have did not choose user or admin");
                }
            }
            else //if comboBoxItemValue == null  //did not chose any in combobox
            {
                MessageBox.Show("You have did not choose user or admin");
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password_TXT.UseSystemPasswordChar = false;
            }
            else
            {
                Password_TXT.UseSystemPasswordChar = true;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Form4CreateAccount form4CreateAccount = new Form4CreateAccount
                (_loginService, _customerService, _favorService, _requestService, _favorLineService, _adminService);
            form4CreateAccount.Show();
            this.Hide();
        }


        //Help Function
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