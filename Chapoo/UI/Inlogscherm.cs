using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private void btn_Login_Text_Click(object sender, EventArgs e)
        {
            string loginId = tbx_WerknemerID_Login.Text;
            string password = tbx_Password_Login.Text;
          

        }

    }
}
