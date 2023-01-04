
namespace RoachChat
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.lblRoach1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.lblcompany2 = new System.Windows.Forms.Label();
            this.lblcompany1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRoach1
            // 
            this.lblRoach1.AutoSize = true;
            this.lblRoach1.Font = new System.Drawing.Font("Microsoft Tai Le", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoach1.ForeColor = System.Drawing.Color.Gold;
            this.lblRoach1.Location = new System.Drawing.Point(122, 50);
            this.lblRoach1.Name = "lblRoach1";
            this.lblRoach1.Size = new System.Drawing.Size(219, 85);
            this.lblRoach1.TabIndex = 0;
            this.lblRoach1.Text = "Roach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(225, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version 1.0";
            // 
            // Progressbar
            // 
            this.Progressbar.animated = true;
            this.Progressbar.animationIterval = 5;
            this.Progressbar.animationSpeed = 1;
            this.Progressbar.BackColor = System.Drawing.Color.Transparent;
            this.Progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Progressbar.BackgroundImage")));
            this.Progressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Progressbar.ForeColor = System.Drawing.Color.Gold;
            this.Progressbar.LabelVisible = false;
            this.Progressbar.LineProgressThickness = 4;
            this.Progressbar.LineThickness = 2;
            this.Progressbar.Location = new System.Drawing.Point(187, 215);
            this.Progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Progressbar.MaxValue = 100;
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.ProgressBackColor = System.Drawing.Color.Transparent;
            this.Progressbar.ProgressColor = System.Drawing.Color.White;
            this.Progressbar.Size = new System.Drawing.Size(99, 99);
            this.Progressbar.TabIndex = 2;
            this.Progressbar.Value = 0;
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.AutoSize = true;
            this.lblLoadingText.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingText.ForeColor = System.Drawing.Color.Gold;
            this.lblLoadingText.Location = new System.Drawing.Point(133, 335);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(180, 19);
            this.lblLoadingText.TabIndex = 3;
            this.lblLoadingText.Text = "Initialization...Please wait";
            this.lblLoadingText.Click += new System.EventHandler(this.lblLoadingText_Click);
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Enabled = true;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // lblcompany2
            // 
            this.lblcompany2.AutoSize = true;
            this.lblcompany2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompany2.ForeColor = System.Drawing.Color.White;
            this.lblcompany2.Location = new System.Drawing.Point(224, 573);
            this.lblcompany2.Name = "lblcompany2";
            this.lblcompany2.Size = new System.Drawing.Size(154, 20);
            this.lblcompany2.TabIndex = 5;
            this.lblcompany2.Text = "Roach Technologies";
            // 
            // lblcompany1
            // 
            this.lblcompany1.AutoSize = true;
            this.lblcompany1.ForeColor = System.Drawing.Color.White;
            this.lblcompany1.Location = new System.Drawing.Point(295, 546);
            this.lblcompany1.Name = "lblcompany1";
            this.lblcompany1.Size = new System.Drawing.Size(66, 13);
            this.lblcompany1.TabIndex = 6;
            this.lblcompany1.Text = "Powered by:";
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(463, 636);
            this.Controls.Add(this.lblcompany1);
            this.Controls.Add(this.lblcompany2);
            this.Controls.Add(this.lblLoadingText);
            this.Controls.Add(this.Progressbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRoach1);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoach1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar Progressbar;
        private System.Windows.Forms.Label lblLoadingText;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.Label lblcompany2;
        private System.Windows.Forms.Label lblcompany1;
    }
}

