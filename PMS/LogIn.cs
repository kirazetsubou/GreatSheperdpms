using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PMS
{
    public partial class LogIn : Form
    {
        private OleDbConnection connection;

        public Point mouseLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // width of ellipse
             int nHeightEllipse // height of ellipse

            );
        public LogIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PatientManagement.accdb");

        }

        private void rPanel2_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush =
            new LinearGradientBrush(rPanel2.ClientRectangle, Color.Red, Color.Yellow, 45);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[3] { Color.Cyan, Color.White, Color.YellowGreen };
            cblend.Positions = new float[3] { 0f, 0.5f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, rPanel2.ClientRectangle);
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        private void frmInstallDevice_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void frmInstallDevice_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }  
        }

        private void LogInPanel_MouseMove(object sender, MouseEventArgs e)
        {
            frmInstallDevice_MouseMove(sender,e);
        }

        private void LogInPanel_MouseDown(object sender, MouseEventArgs e)
        {
            frmInstallDevice_MouseDown(sender, e);
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {

        }
        private void Database()
        {
            
           
        }
    }
}
