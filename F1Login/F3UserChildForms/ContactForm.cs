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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }



        private void pictureBox_twitter_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://twitter.com/RealMrClean";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void pictureBox_Instagram_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.instagram.com/cleaning/";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void pictureBox_Facebook_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.facebook.com/?locale=da_DK";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true,
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
