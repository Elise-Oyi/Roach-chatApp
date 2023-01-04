using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Importing library files
using System.Net;
using System.Net.Sockets;

namespace RoachChat
{
    public partial class FormChats : Form
    {
        // Variable Declaration and Initialization
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;


        public FormChats()
        {
            InitializeComponent();
        }

        private void lblConnection_Click(object sender, EventArgs e)
        {

        }

        private void txtFriendIP_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTextMessage_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void FormChats_Load(object sender, EventArgs e)
        {
            //Hidding the back button
            btnBack.Visible = false;

            // Calling user-define Function(GetLocalIP)
            txtLocalIP.Text = GetLocalIP();

            // Setting up sockets and connection
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);


        }

        private void txtLocalPort_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLocalPort_Enter(object sender, EventArgs e)
        {
            // Placeholder function
            if (txtLocalPort.Text == "Port")
            {
                txtLocalPort.Text = "";
                txtLocalPort.ForeColor = Color.Black;
            }
        }

        private void txtLocalPort_Leave(object sender, EventArgs e)
        {
            if(txtLocalPort.Text == "")
            {
                txtLocalPort.Text = "Port";
                txtLocalPort.ForeColor = Color.Gray;
            }
        }

        private void txtFriendIP_Enter(object sender, EventArgs e)
        {

            // Placeholder Function

            if(txtFriendIP.Text == "Friend's IP")
            {
                txtFriendIP.Text = "";
                txtFriendIP.ForeColor = Color.Black;
            }
        }

        private void txtFriendIP_Leave(object sender, EventArgs e)
        {
            if (txtFriendIP.Text == "")
            {
                txtFriendIP.Text = "Friend's IP";
                txtFriendIP.ForeColor = Color.Gray;
            }
        }

        private void txtFriendPort_Enter(object sender, EventArgs e)
        {
            if(txtFriendPort.Text == "Port")
            {
                txtFriendPort.Text = "";
                txtFriendPort.ForeColor = Color.Black;
            }
        }

        private void txtFriendPort_Leave(object sender, EventArgs e)
        {
            if(txtFriendPort.Text == "")
            {
                txtFriendPort.Text = "Port";
                txtFriendPort.ForeColor = Color.Gray;
            }
        }

        private void txtTextMessage_Enter(object sender, EventArgs e)
        {
            if(txtTextMessage.Text == "Text here..")
            {
                txtTextMessage.Text = "";
                txtTextMessage.ForeColor = Color.Black;
            }
        }

        private void txtTextMessage_Leave(object sender, EventArgs e)
        {
            if(txtTextMessage.Text == "")
            {
                txtTextMessage.Text = "Text here..";
                txtTextMessage.ForeColor = Color.Gray;
            }

            // Creating user-defined function to get local IP Address

           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Creating connection & Binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIP.Text), Convert.ToInt32(txtLocalPort.Text));
            sck.Bind(epLocal);

            // Connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(txtFriendIP.Text), Convert.ToInt32(txtFriendPort.Text));
            sck.Connect(epRemote);


            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epLocal, new AsyncCallback(MessageCallBack), buffer);

            // Activates if connect is succesful
            if (sck.Connected)
            {
                txtFriendIP.Visible = false;
                txtFriendPort.Visible = false;
                txtLocalIP.Visible = false;
                txtLocalPort.Visible = false;

                // Hiding connect button
                btnConnect.Visible = false;

                // Reposition ListMessage Box
                listMessage.Size = new Size(421, 686);
                listMessage.Location = new Point(14, 50);

                // Showing Back button
                btnBack.Visible = true;


                //Showing chat label and hiding chat icon
                lblChat.Visible = true;
                lblChat.Text = "Chats";
                iconPictureBox.Visible = false;

            }
        }

        // Creating the Message call back function

        private void MessageCallBack(IAsyncResult aResult)
        {
            byte[] recievedData = new byte[1500];
            recievedData = (byte[])aResult.AsyncState;

            // Converting byte to string
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            string recievedMessage = aEncoding.GetString(recievedData);

            // Adding message to the message box
            listMessage.Items.Add("FRIENDS: " + recievedMessage);

            // Converting byte to data
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Shutting down connection
            sck.Shutdown(SocketShutdown.Both);

            // Showing textboxes
            txtLocalIP.Visible = true;
            txtLocalPort.Visible = true;
            txtFriendIP.Visible = true;
            txtFriendPort.Visible = true;


            // Clearing chat messages
            listMessage.Items.Clear();

            // Showing connect button
            btnConnect.Visible = true;

            // Showing connection label
            lblConnection.Visible = true;

            // Repositioning listmessage box
            listMessage.Size = new Size(421, 444);
            listMessage.Location = new Point(14, 292);

            // Hidding back icon
            btnBack.Visible = false;

            // Hidding chat label & showing chat logo
            lblChat.Visible = false;
            iconPictureBox.Visible = true;


            // Resetting texts in textboxes
            txtLocalPort.Text = "Port";
            txtFriendIP.Text = "Friend's IP";
            txtFriendPort.Text = "Port";

            txtFriendPort.ForeColor = Color.Gray;
            txtFriendPort.ForeColor = Color.Gray;
            txtFriendIP.ForeColor = Color.Gray;


        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(txtTextMessage.Text);

            // Sending encoding messages
            sck.Send(sendingMessage);

            // Adding message to the listbox
            listMessage.Items.Add("ME : " + txtTextMessage.Text);
            txtTextMessage.Text = "";
        }



        // Creating user defined function to get local IP Address
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iP in host.AddressList)
            {
                if (iP.AddressFamily == AddressFamily.InterNetwork)
                    return iP.ToString();
            }
            return "66.228.116.179";
        }
    }
}
