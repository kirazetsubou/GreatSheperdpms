namespace PMS
{
    partial class Notice
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rButton1 = new PMS.RoundedButtons.RButton();
            this.rButton2 = new PMS.RoundedButtons.RButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rPanel1 = new PMS.RPanel();
            this.SuspendLayout();
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.ForeColor = System.Drawing.Color.GreenYellow;
            this.rButton1.Location = new System.Drawing.Point(57, 210);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(119, 45);
            this.rButton1.TabIndex = 0;
            this.rButton1.Text = "LOGOUT";
            this.rButton1.UseVisualStyleBackColor = false;
            this.rButton1.Click += new System.EventHandler(this.rButton1_Click);
            // 
            // rButton2
            // 
            this.rButton2.BackColor = System.Drawing.Color.SkyBlue;
            this.rButton2.FlatAppearance.BorderSize = 0;
            this.rButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton2.ForeColor = System.Drawing.Color.GreenYellow;
            this.rButton2.Location = new System.Drawing.Point(271, 215);
            this.rButton2.Name = "rButton2";
            this.rButton2.Size = new System.Drawing.Size(150, 40);
            this.rButton2.TabIndex = 1;
            this.rButton2.Text = "Cancel";
            this.rButton2.UseVisualStyleBackColor = false;
            this.rButton2.Click += new System.EventHandler(this.rButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are You Sure You want To Logout?\r\n";
            // 
            // rPanel1
            // 
            this.rPanel1.BorderColor = System.Drawing.Color.White;
            this.rPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rPanel1.Edge = 20;
            this.rPanel1.Location = new System.Drawing.Point(0, 0);
            this.rPanel1.Name = "rPanel1";
            this.rPanel1.Size = new System.Drawing.Size(448, 45);
            this.rPanel1.TabIndex = 3;
            this.rPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.rPanel1_Paint);
            // 
            // Notice
            // 
            this.ClientSize = new System.Drawing.Size(448, 285);
            this.ControlBox = false;
            this.Controls.Add(this.rPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rButton2);
            this.Controls.Add(this.rButton1);
            this.Name = "Notice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButtons.RButton rButton1;
        private RoundedButtons.RButton rButton2;
        private System.Windows.Forms.Label label1;
        private RPanel rPanel1;
    }
}
