using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;

namespace UI
{
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void btn_Login_Text_Click(object sender, EventArgs e)
        {
            int loginId = Int32.Parse(tbx_WerknemerID_Login.Text);
            this.Close();
        }

        private void Inlogscherm_FormClose(object sender, FormClosedEventArgs e)
        {
            (new BestellingOpneemScherm()).Show();
        }


    }
}
