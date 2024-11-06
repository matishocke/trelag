using Abstraction.IModels;
using Abstraction.IService;
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

namespace F1Login
{
    public partial class F3User : Form
    {
        private Button currentButton;
        private Panel leftBorderBTN;
        private Form currentChildForm;
        private readonly ICustomerService _customerService;
        private readonly IFavorService _favorService;
        private string _username;
        private readonly IRequestService _requestService;

        private readonly ILoginService _loginService;

        private readonly IFavorLineService _favorLineService; //ii
        private readonly IAdminService _adminService;

        public F3User(ICustomerService service, string username, IFavorService favoriteService,
                       IRequestService requestService, ILoginService loginService,
                       IFavorLineService favorLineService, IAdminService adminService)
        {
            InitializeComponent();
            leftBorderBTN = new Panel();  //make a new panel to do something 
            leftBorderBTN.Size = new Size(30, 80);  //send the button 30pixel to the right hight80pixel stay same
            panelMenu.Controls.Add(leftBorderBTN);
            timer1.Start();
            LBL_Date.Text = DateTime.Now.ToLongDateString();

            _customerService = service;
            _username = username;
            _favorService = favoriteService;
            _requestService = requestService;
            _loginService = loginService;
            _favorLineService = favorLineService; //ii
            _adminService = adminService;
        }

        private struct RGBColors //struct
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
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

        private void BTN_Customer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new CustomerForm(_customerService, _username));  //Sends username from here
        }

        private void BTN_Services_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new ServicesForm(_favorService, _requestService, _username, _customerService, _favorLineService));
        }

        private void BTN_Contact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ContactForm());
        }




        private void BTN_help_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

            try
            {
                string filePath = "C:\\Users\\dashm\\OneDrive\\Skrivebord\\2.semester projektttttttt\\HelpFunction\\2_User Guide for Clean.pdf";

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

        private void BTN_picHome_Click(object sender, EventArgs e)
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






        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }








        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_Clock.Text = DateTime.Now.ToString("hh:mm:ss");
        }




        //BACK TO LOGIN BUTTON
        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1
                (_loginService, _customerService, _favorService, _requestService, _favorLineService,_adminService);
            form1.Show();
            this.Close();

        }









        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
