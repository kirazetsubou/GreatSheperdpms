using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PMS
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Dashboard tmp = (Dashboard)this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}
