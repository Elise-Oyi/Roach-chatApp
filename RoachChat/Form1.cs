using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoachChat
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLoadingText_Click(object sender, EventArgs e)
        {

        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            Progressbar.Value = Progressbar.Value + 1;
            if (Progressbar.Value >= 100)
            {
                // Class & Object - Page navigation
                FormChats ChatPage = new FormChats();
                this.Hide();
                ChatPage.Show();

                //Enabling & Disabling Progress & Timer

                ProgressTimer.Enabled = true;
                Progressbar.Visible = true;
                ProgressTimer.Enabled = false;
            }

            // Changing Loading Label text & Position
            if(Progressbar.Value == 50)
            {
                lblLoadingText.Text = "Enabling Encryption";
                lblLoadingText.Location = new Point(138, 335);
            }
            if(Progressbar.Value == 80)
            {
                lblLoadingText.Text = "Finalizing";
                lblLoadingText.Location = new Point(170, 335);

            }

            if(Progressbar.Value == 90)
            {
                lblcompany1.Visible = false;
                lblcompany2.Visible = false;
            }
        }
    }
}
