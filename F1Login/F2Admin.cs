using Abstraction.IModels;
using Abstraction.IService;
using BusinessLogic.Services;
using F1Login.F2AdminChildForms;
using F1Login.F3UserChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace F1Login
{
    public partial class F2Admin : Form
    {
        private Button currentButton;
        private Panel leftBorderBTN;
        private Form currentChildForm;
        private readonly ICustomerService _customerService;
        private string _username;
        private readonly IFavorService _favorService;
        private readonly ILoginService _loginService;
        private readonly IRequestService _requestService;
        private readonly IFavorLineService _favorLineService;
        private readonly IAdminService _adminService;

        public F2Admin(ICustomerService customerService, string username, IFavorService favorService,
                       ILoginService loginService, IRequestService requestService, 
                       IFavorLineService favorLineService, IAdminService adminService)
        {
            InitializeComponent();
            leftBorderBTN = new Panel();  //make a new panel to do something 
            leftBorderBTN.Size = new Size(30, 80);  //send the button 30pixel to the right hight80pixel stay same
            panelMenu.Controls.Add(leftBorderBTN);
            timer1.Start();
            LBL_DateAdmin.Text = DateTime.Now.ToLongDateString();

            _customerService = customerService;
            _username = username;
            _favorService = favorService;
            _loginService = loginService;
            _requestService = requestService;
            _favorLineService = favorLineService;
            _adminService = adminService;
        }




        //HAVE DIFFERENT COLORS in sidelines
        private struct RGBColors //struct
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(25, 160, 250);
            public static Color color6 = Color.FromArgb(190, 190, 0);
        }




        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null) //if button is not null 
            {
                DisableButton();
                //Button
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.FromArgb(30, 20, 50); //click button, button change it to darkblue
                currentButton.ForeColor = color;                      //click button text gets the color that I give later
                currentButton.TextAlign = ContentAlignment.MiddleCenter; //take the text to center
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText; //image still stay behind text
                currentButton.ImageAlign = ContentAlignment.MiddleRight;  //
                //Left border button
                leftBorderBTN.BackColor = color;                       //border get the color i give later
                leftBorderBTN.Location = new Point(0, currentButton.Location.Y); //send this border to new location
                leftBorderBTN.Visible = true;                     //turn on the color comes beside button
                leftBorderBTN.BringToFront();                      //by choosing bring it to front
            }
        }
        private void DisableButton() //bring back the button(color and any in it)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(25, 25, 50);  //back to menu color
                currentButton.ForeColor = Color.White;                 //back to white
                currentButton.TextAlign = ContentAlignment.MiddleLeft; //back to its place middleLeft
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText; //still behind text
                currentButton.ImageAlign = ContentAlignment.MiddleLeft; //
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LBL_Home.Text = childForm.Text;
        }





        //BUTTONS
        private void BTN_Customer_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CustomerFormForAdmins(_customerService)); //_custimerService, _username
        }

        private void BTN_ServicesEditionAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new ServicesEditionByAdminForm(_favorService));
        }

        private void BTN_Order_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new RequestFormForAdmins(_requestService, _customerService, _username, _favorLineService, _favorService));
        }

        private void BTN_help_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            try
            {
                string filePath = "C:\\Users\\dashm\\OneDrive\\Skrivebord\\2.semester projektttttttt\\HelpFunction\\3_Admin Guide for Clean.pdf";

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



        private void BTN_Inspector_Click(object sender, EventArgs e)
        {
            //opens an InputBox before openning the InspectorFormForAdmin
            string enteredCode = Microsoft.VisualBasic.Interaction.InputBox("Enter the code:", "Inspector Password Required", "");

            if (enteredCode == "inspector" || enteredCode == "boss")
            {
                ActivateButton(sender, RGBColors.color5);
                OpenChildForm(new InspectorFormForAdmin(_requestService, _favorLineService, _favorService));
            }
            else
            {
                MessageBox.Show("Invalid code. Access denied. If you are not an Inspector Do Not try this button");
            }
        }




        private void BTN_Director_Click(object sender, EventArgs e)
        {
            //opens an InputBox before openning the InspectorFormForAdmin
            string enteredCode = Microsoft.VisualBasic.Interaction.InputBox("Enter the code:", "Director Password Required", "");

            if (enteredCode == "boss")
            {
                ActivateButton(sender, RGBColors.color6);
                OpenChildForm(new AdminForm(_adminService));
            }
            else
            {
                MessageBox.Show("Invalid code. Access denied. If you are not a Director Do Not try this button");
            }
        }




        private void BTN_picHomeAdmin_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();               //diable all buttons 
            leftBorderBTN.Visible = false;  //disable the part with color
            LBL_Home.Text = "Home";
        }





        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LBL_Clock.Text = DateTime.Now.ToString("hh:mm:ss");
        }





        //BACK TO LOGIN BUTTON
        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_loginService, _customerService, _favorService, _requestService, _favorLineService, _adminService);
            form1.Show();
            this.Close();
        }












        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
    }
}
