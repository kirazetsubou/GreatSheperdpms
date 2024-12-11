namespace PMS
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LogInPanel = new PMS.RPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PassPanel = new System.Windows.Forms.Panel();
            this.round2 = new PMS.Round();
            this.UsePanel = new System.Windows.Forms.Panel();
            this.username = new PMS.Round();
            this.rPanel2 = new PMS.RPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.registered = new System.Windows.Forms.LinkLabel();
            this.LoginB = new PMS.RoundedButtons.RButton();
            this.label4 = new System.Windows.Forms.Label();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.LogInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PassPanel.SuspendLayout();
            this.UsePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIcon
            // 
            this.UserIcon.Location = new System.Drawing.Point(0, 0);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(100, 50);
            this.UserIcon.TabIndex = 0;
            this.UserIcon.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.iconButton1.IconColor = System.Drawing.Color.Gray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(1299, 2);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(80, 31);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Exit";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LogInPanel
            // 
            this.LogInPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LogInPanel.BorderColor = System.Drawing.Color.IndianRed;
            this.LogInPanel.Controls.Add(this.pictureBox1);
            this.LogInPanel.Controls.Add(this.label5);
            this.LogInPanel.Controls.Add(this.PassPanel);
            this.LogInPanel.Controls.Add(this.UsePanel);
            this.LogInPanel.Controls.Add(this.rPanel2);
            this.LogInPanel.Controls.Add(this.label6);
            this.LogInPanel.Controls.Add(this.registered);
            this.LogInPanel.Controls.Add(this.LoginB);
            this.LogInPanel.Controls.Add(this.label4);
            this.LogInPanel.Controls.Add(this.forgot);
            this.LogInPanel.Controls.Add(this.label3);
            this.LogInPanel.Controls.Add(this.label2);
            this.LogInPanel.Controls.Add(this.label1);
            this.LogInPanel.Edge = 20;
            this.LogInPanel.Location = new System.Drawing.Point(61, 25);
            this.LogInPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(477, 759);
            this.LogInPanel.TabIndex = 8;
            this.LogInPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogInPanel_MouseDown);
            this.LogInPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogInPanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Not Registered?";
            // 
            // PassPanel
            // 
            this.PassPanel.Controls.Add(this.round2);
            this.PassPanel.Location = new System.Drawing.Point(113, 439);
            this.PassPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassPanel.Name = "PassPanel";
            this.PassPanel.Size = new System.Drawing.Size(259, 34);
            this.PassPanel.TabIndex = 13;
            // 
            // round2
            // 
            this.round2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.round2.Location = new System.Drawing.Point(0, 0);
            this.round2.Multiline = true;
            this.round2.Name = "round2";
            this.round2.PasswordChar = '*';
            this.round2.Size = new System.Drawing.Size(259, 34);
            this.round2.TabIndex = 2;
            // 
            // UsePanel
            // 
            this.UsePanel.Controls.Add(this.username);
            this.UsePanel.Location = new System.Drawing.Point(113, 361);
            this.UsePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsePanel.Name = "UsePanel";
            this.UsePanel.Size = new System.Drawing.Size(259, 34);
            this.UsePanel.TabIndex = 12;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(0, 0);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(259, 34);
            this.username.TabIndex = 1;
            // 
            // rPanel2
            // 
            this.rPanel2.BorderColor = System.Drawing.Color.White;
            this.rPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rPanel2.Edge = 20;
            this.rPanel2.Location = new System.Drawing.Point(0, 659);
            this.rPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rPanel2.Name = "rPanel2";
            this.rPanel2.Size = new System.Drawing.Size(477, 100);
            this.rPanel2.TabIndex = 11;
            this.rPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.rPanel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 96);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ultrasound and\r\nHealth Services";
            // 
            // registered
            // 
            this.registered.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.registered.AutoSize = true;
            this.registered.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registered.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registered.Location = new System.Drawing.Point(271, 605);
            this.registered.Name = "registered";
            this.registered.Size = new System.Drawing.Size(85, 16);
            this.registered.TabIndex = 6;
            this.registered.TabStop = true;
            this.registered.Text = "Registered >";
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginB.FlatAppearance.BorderSize = 0;
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginB.ForeColor = System.Drawing.Color.Black;
            this.LoginB.Location = new System.Drawing.Point(147, 544);
            this.LoginB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(195, 47);
            this.LoginB.TabIndex = 3;
            this.LoginB.Text = "LOGIN";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "- A Great Clinic ";
            // 
            // forgot
            // 
            this.forgot.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.forgot.AutoSize = true;
            this.forgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.forgot.Location = new System.Drawing.Point(256, 500);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(116, 16);
            this.forgot.TabIndex = 5;
            this.forgot.TabStop = true;
            this.forgot.Text = "Forgot Password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Great Sheperd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username\r\n";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1391, 807);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.LogInPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmInstallDevice_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmInstallDevice_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PassPanel.ResumeLayout(false);
            this.PassPanel.PerformLayout();
            this.UsePanel.ResumeLayout(false);
            this.UsePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RoundedButtons.RButton LoginB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel forgot;
        private RPanel LogInPanel;
        private System.Windows.Forms.LinkLabel registered;
        private System.Windows.Forms.Label label6;
        private RPanel rPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel PassPanel;
        private System.Windows.Forms.Panel UsePanel;
        private System.Windows.Forms.PictureBox UserIcon;
        private Round username;
        private Round round2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

