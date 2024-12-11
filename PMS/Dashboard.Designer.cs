using System;
using System.Windows.Forms.VisualStyles;

namespace PMS
{
    partial class Dashboard
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
            this.Home = new FontAwesome.Sharp.IconButton();
            this.About = new FontAwesome.Sharp.IconButton();
            this.Services = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.MedicalR = new FontAwesome.Sharp.IconButton();
            this.Reports = new FontAwesome.Sharp.IconButton();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.Patients = new FontAwesome.Sharp.IconButton();
            this.DPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DashboardP = new System.Windows.Forms.Panel();
            this.UPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Time1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.UpperP = new System.Windows.Forms.Panel();
            this.patientL1 = new PMS.PatientL();
            this.DPanel.SuspendLayout();
            this.DashboardP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UpperP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.Home.IconColor = System.Drawing.Color.Black;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 129);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(338, 57);
            this.Home.TabIndex = 0;
            this.Home.Text = "HOME\r\n";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // About
            // 
            this.About.IconChar = FontAwesome.Sharp.IconChar.None;
            this.About.IconColor = System.Drawing.Color.Black;
            this.About.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.About.Location = new System.Drawing.Point(0, 203);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(338, 51);
            this.About.TabIndex = 1;
            this.About.Text = "ABOUT";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Services
            // 
            this.Services.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Services.IconColor = System.Drawing.Color.Black;
            this.Services.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Services.Location = new System.Drawing.Point(3, 546);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(341, 57);
            this.Services.TabIndex = 2;
            this.Services.Text = "SERVICES";
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(0, 388);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(338, 51);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "APPOINTMENT";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // MedicalR
            // 
            this.MedicalR.IconChar = FontAwesome.Sharp.IconChar.Gauge;
            this.MedicalR.IconColor = System.Drawing.Color.Black;
            this.MedicalR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MedicalR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MedicalR.Location = new System.Drawing.Point(0, 694);
            this.MedicalR.Name = "MedicalR";
            this.MedicalR.Size = new System.Drawing.Size(338, 51);
            this.MedicalR.TabIndex = 4;
            this.MedicalR.Text = "MEDICAL RECORDS\r\n";
            this.MedicalR.UseVisualStyleBackColor = true;
            this.MedicalR.Click += new System.EventHandler(this.MedicalR_Click);
            // 
            // Reports
            // 
            this.Reports.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Reports.IconColor = System.Drawing.Color.Black;
            this.Reports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Reports.Location = new System.Drawing.Point(-6, 839);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(344, 51);
            this.Reports.TabIndex = 5;
            this.Reports.Text = "REPORTS";
            this.Reports.UseVisualStyleBackColor = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Settings
            // 
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.Settings.IconColor = System.Drawing.Color.Black;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(3, 985);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(344, 51);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "SETTINGS";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Patients
            // 
            this.Patients.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Patients.IconColor = System.Drawing.Color.Black;
            this.Patients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Patients.Location = new System.Drawing.Point(-6, 764);
            this.Patients.Name = "Patients";
            this.Patients.Size = new System.Drawing.Size(344, 51);
            this.Patients.TabIndex = 7;
            this.Patients.Text = "PATIENTS";
            this.Patients.UseVisualStyleBackColor = true;
            this.Patients.Click += new System.EventHandler(this.Patients_Click);
            // 
            // DPanel
            // 
            this.DPanel.Controls.Add(this.panel2);
            this.DPanel.Controls.Add(this.About);
            this.DPanel.Controls.Add(this.Reports);
            this.DPanel.Controls.Add(this.Patients);
            this.DPanel.Controls.Add(this.Settings);
            this.DPanel.Controls.Add(this.Home);
            this.DPanel.Controls.Add(this.MedicalR);
            this.DPanel.Controls.Add(this.Services);
            this.DPanel.Controls.Add(this.iconButton4);
            this.DPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DPanel.Location = new System.Drawing.Point(0, 0);
            this.DPanel.Name = "DPanel";
            this.DPanel.Size = new System.Drawing.Size(331, 1101);
            this.DPanel.TabIndex = 8;
            this.DPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 123);
            this.panel2.TabIndex = 8;
            // 
            // DashboardP
            // 
            this.DashboardP.Controls.Add(this.panel1);
            this.DashboardP.Controls.Add(this.UpperP);
            this.DashboardP.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardP.Location = new System.Drawing.Point(331, 0);
            this.DashboardP.Name = "DashboardP";
            this.DashboardP.Size = new System.Drawing.Size(1611, 1101);
            this.DashboardP.TabIndex = 10;
            // 
            // UPanel
            // 
            this.UPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UPanel.Location = new System.Drawing.Point(0, 0);
            this.UPanel.Name = "UPanel";
            this.UPanel.Size = new System.Drawing.Size(1611, 79);
            this.UPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.patientL1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1611, 1030);
            this.panel1.TabIndex = 1;
            // 
            // Time1
            // 
            this.Time1.AutoSize = true;
            this.Time1.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time1.Location = new System.Drawing.Point(665, 32);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(130, 24);
            this.Time1.TabIndex = 0;
            this.Time1.Text = "23:55:57";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(1384, 40);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(73, 16);
            this.User.TabIndex = 1;
            this.User.Text = "UserName";
            // 
            // UpperP
            // 
            this.UpperP.Controls.Add(this.User);
            this.UpperP.Controls.Add(this.Time1);
            this.UpperP.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperP.Location = new System.Drawing.Point(0, 0);
            this.UpperP.Name = "UpperP";
            this.UpperP.Size = new System.Drawing.Size(1611, 71);
            this.UpperP.TabIndex = 0;
            this.UpperP.Paint += new System.Windows.Forms.PaintEventHandler(this.UpperP_Paint);
            // 
            // patientL1
            // 
            this.patientL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientL1.Location = new System.Drawing.Point(0, 0);
            this.patientL1.Name = "patientL1";
            this.patientL1.Size = new System.Drawing.Size(1611, 1030);
            this.patientL1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1101);
            this.Controls.Add(this.DashboardP);
            this.Controls.Add(this.DPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.ShowInTaskbar = false;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DPanel.ResumeLayout(false);
            this.DashboardP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.UpperP.ResumeLayout(false);
            this.UpperP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Home;
        private FontAwesome.Sharp.IconButton About;
        private FontAwesome.Sharp.IconButton Services;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton MedicalR;
        private FontAwesome.Sharp.IconButton Reports;
        private FontAwesome.Sharp.IconButton Settings;
        private FontAwesome.Sharp.IconButton Patients;
        private System.Windows.Forms.Panel DPanel;
        private System.Windows.Forms.Panel DashboardP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel UPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel UpperP;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Time1;
        private PatientL patientL1;
    }
}