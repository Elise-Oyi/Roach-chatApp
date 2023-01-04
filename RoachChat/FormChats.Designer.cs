
namespace RoachChat
{
    partial class FormChats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChats));
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.txtLocalPort = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFriendIP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtFriendPort = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtLocalIP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.txtTextMessage = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSend = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(-2, -3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.Location = new System.Drawing.Point(116, -3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(211, 89);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox.TabIndex = 1;
            this.iconPictureBox.TabStop = false;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblConnection.Location = new System.Drawing.Point(136, 85);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(178, 22);
            this.lblConnection.TabIndex = 2;
            this.lblConnection.Text = "Establish Connection";
            this.lblConnection.Click += new System.EventHandler(this.lblConnection_Click);
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.BorderColorFocused = System.Drawing.Color.DarkOliveGreen;
            this.txtLocalPort.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalPort.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtLocalPort.BorderThickness = 1;
            this.txtLocalPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalPort.ForeColor = System.Drawing.Color.Gray;
            this.txtLocalPort.isPassword = false;
            this.txtLocalPort.Location = new System.Drawing.Point(13, 175);
            this.txtLocalPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(191, 46);
            this.txtLocalPort.TabIndex = 3;
            this.txtLocalPort.Text = "Port";
            this.txtLocalPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLocalPort.OnValueChanged += new System.EventHandler(this.txtLocalPort_OnValueChanged);
            this.txtLocalPort.Enter += new System.EventHandler(this.txtLocalPort_Enter);
            this.txtLocalPort.Leave += new System.EventHandler(this.txtLocalPort_Leave);
            // 
            // txtFriendIP
            // 
            this.txtFriendIP.BorderColorFocused = System.Drawing.Color.DarkOliveGreen;
            this.txtFriendIP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFriendIP.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtFriendIP.BorderThickness = 1;
            this.txtFriendIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFriendIP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriendIP.ForeColor = System.Drawing.Color.Gray;
            this.txtFriendIP.isPassword = false;
            this.txtFriendIP.Location = new System.Drawing.Point(239, 114);
            this.txtFriendIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtFriendIP.Name = "txtFriendIP";
            this.txtFriendIP.Size = new System.Drawing.Size(195, 44);
            this.txtFriendIP.TabIndex = 4;
            this.txtFriendIP.Text = "Friend\'s IP";
            this.txtFriendIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendIP.OnValueChanged += new System.EventHandler(this.txtFriendIP_OnValueChanged);
            this.txtFriendIP.Enter += new System.EventHandler(this.txtFriendIP_Enter);
            this.txtFriendIP.Leave += new System.EventHandler(this.txtFriendIP_Leave);
            // 
            // txtFriendPort
            // 
            this.txtFriendPort.BorderColorFocused = System.Drawing.Color.DarkOliveGreen;
            this.txtFriendPort.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFriendPort.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtFriendPort.BorderThickness = 1;
            this.txtFriendPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFriendPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriendPort.ForeColor = System.Drawing.Color.Gray;
            this.txtFriendPort.isPassword = false;
            this.txtFriendPort.Location = new System.Drawing.Point(239, 175);
            this.txtFriendPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtFriendPort.Name = "txtFriendPort";
            this.txtFriendPort.Size = new System.Drawing.Size(195, 46);
            this.txtFriendPort.TabIndex = 5;
            this.txtFriendPort.Text = "Port";
            this.txtFriendPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFriendPort.Enter += new System.EventHandler(this.txtFriendPort_Enter);
            this.txtFriendPort.Leave += new System.EventHandler(this.txtFriendPort_Leave);
            // 
            // txtLocalIP
            // 
            this.txtLocalIP.BorderColorFocused = System.Drawing.Color.DarkOliveGreen;
            this.txtLocalIP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocalIP.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.txtLocalIP.BorderThickness = 1;
            this.txtLocalIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalIP.Enabled = false;
            this.txtLocalIP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalIP.ForeColor = System.Drawing.Color.Gray;
            this.txtLocalIP.isPassword = false;
            this.txtLocalIP.Location = new System.Drawing.Point(13, 114);
            this.txtLocalIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalIP.Name = "txtLocalIP";
            this.txtLocalIP.Size = new System.Drawing.Size(191, 44);
            this.txtLocalIP.TabIndex = 6;
            this.txtLocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnConnect
            // 
            this.btnConnect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConnect.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.BorderRadius = 5;
            this.btnConnect.ButtonText = "Connect";
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.DisabledColor = System.Drawing.Color.Gray;
            this.btnConnect.ForeColor = System.Drawing.Color.Gray;
            this.btnConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConnect.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConnect.Iconimage")));
            this.btnConnect.Iconimage_right = null;
            this.btnConnect.Iconimage_right_Selected = null;
            this.btnConnect.Iconimage_Selected = null;
            this.btnConnect.IconMarginLeft = 45;
            this.btnConnect.IconMarginRight = 0;
            this.btnConnect.IconRightVisible = true;
            this.btnConnect.IconRightZoom = 0D;
            this.btnConnect.IconVisible = true;
            this.btnConnect.IconZoom = 60D;
            this.btnConnect.IsTab = false;
            this.btnConnect.Location = new System.Drawing.Point(116, 228);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Normalcolor = System.Drawing.Color.DarkOliveGreen;
            this.btnConnect.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.btnConnect.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConnect.selected = false;
            this.btnConnect.Size = new System.Drawing.Size(217, 58);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Textcolor = System.Drawing.Color.White;
            this.btnConnect.TextFont = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // listMessage
            // 
            this.listMessage.Enabled = false;
            this.listMessage.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 22;
            this.listMessage.Location = new System.Drawing.Point(14, 292);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(421, 444);
            this.listMessage.TabIndex = 7;
            // 
            // txtTextMessage
            // 
            this.txtTextMessage.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTextMessage.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTextMessage.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtTextMessage.BorderThickness = 1;
            this.txtTextMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTextMessage.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextMessage.ForeColor = System.Drawing.Color.Gray;
            this.txtTextMessage.isPassword = false;
            this.txtTextMessage.Location = new System.Drawing.Point(12, 753);
            this.txtTextMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtTextMessage.Name = "txtTextMessage";
            this.txtTextMessage.Size = new System.Drawing.Size(333, 49);
            this.txtTextMessage.TabIndex = 8;
            this.txtTextMessage.Text = "Text here..";
            this.txtTextMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTextMessage.OnValueChanged += new System.EventHandler(this.txtTextMessage_OnValueChanged);
            this.txtTextMessage.Enter += new System.EventHandler(this.txtTextMessage_Enter);
            this.txtTextMessage.Leave += new System.EventHandler(this.txtTextMessage_Leave);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(352, 765);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(38, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageActive = null;
            this.btnSend.Location = new System.Drawing.Point(386, 765);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 37);
            this.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSend.TabIndex = 10;
            this.btnSend.TabStop = false;
            this.btnSend.Zoom = 10;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Location = new System.Drawing.Point(12, 812);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 6);
            this.panel1.TabIndex = 11;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(191, 25);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(0, 22);
            this.lblChat.TabIndex = 12;
            // 
            // FormChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(447, 828);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.txtTextMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtLocalIP);
            this.Controls.Add(this.txtFriendPort);
            this.Controls.Add(this.txtFriendIP);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChats";
            this.Load += new System.EventHandler(this.FormChats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label lblConnection;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLocalPort;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFriendIP;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFriendPort;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtLocalIP;
        private Bunifu.Framework.UI.BunifuFlatButton btnConnect;
        private System.Windows.Forms.ListBox listMessage;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTextMessage;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChat;
    }
}