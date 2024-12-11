using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using LinearGradientBrush = System.Drawing.Drawing2D.LinearGradientBrush;

namespace PMS
{
    public partial class Dashboard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn=new Panel();
            leftBorderBtn.Size = new Size(7, 60);
         
        }

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();


                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private struct RGBColors 
        {
            public static Color color1 = Color.FromArgb(37, 36, 81);
            public static Color color2 = Color.FromArgb(37, 36, 81);
            public static Color color3 = Color.FromArgb(37, 36, 81);
            public static Color color4 = Color.FromArgb(37, 36, 81);
            public static Color color5 = Color.FromArgb(37, 36, 81);
            public static Color color6 = Color.FromArgb(37, 36, 81);
            public static Color color7 = Color.FromArgb(37, 36, 81);
            public static Color color8 = Color.FromArgb(37, 36, 81);
        }
        private void DisableButton() 
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.AliceBlue;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.AliceBlue;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
      
        }

        private void Services_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            panel1.Show();

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void About_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void Patients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void MedicalR_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }


        private void DPanel_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush =
            new LinearGradientBrush(DPanel.ClientRectangle, Color.Red, Color.Yellow, 45);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Cyan, Color.White, Color.Green };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush,DPanel.ClientRectangle);
        }
        private void UpperP_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush =
            new LinearGradientBrush(UpperP.ClientRectangle, Color.Red, Color.Yellow, 45);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Cyan, Color.White, Color.Green };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, UpperP.ClientRectangle);
        }
    }
}
