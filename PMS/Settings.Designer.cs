


namespace PMS
{
    partial class Settings
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
            this.Logout = new FontAwesome.Sharp.IconButton();
         
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.Logout.IconColor = System.Drawing.Color.Black;
            this.Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Logout.Location = new System.Drawing.Point(1413, 20);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(113, 50);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Logout);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1540, 1075);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Logout;
   
    }
}
