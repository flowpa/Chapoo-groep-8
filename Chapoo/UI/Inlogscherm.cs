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
        private Inloggen i;

        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void btn_Login_Text_Click(object sender, EventArgs e)
        {
            i = new Inloggen();

            try
            {
                int loginId = Int32.Parse(tbx_WerknemerID_Login.Text);
                i.checkMedewerker(loginId);

                if (i.checkMedewerker(loginId) == true)
                {
                    this.Hide();
                    BestellingOpneemScherm b = new BestellingOpneemScherm();
                    b.ShowDialog();
                }

                else
                {
                    l_Message_Inlog.ForeColor = Color.Red;
                    l_Message_Inlog.Text = "Foute inlogcode!";
                }

            }

            catch
            {
                l_Message_Inlog.ForeColor = Color.Red;
                l_Message_Inlog.Text = "Vul je inlogcode in '01'";
            }
        }

        private void btn_Login_Symbol_Click(object sender, EventArgs e)
        {
            try
            {
                int loginId = Int32.Parse(tbx_WerknemerID_Login.Text);
                this.Hide();
                BestellingOpneemScherm b = new BestellingOpneemScherm();
                b.ShowDialog();
            }
            catch
            {
                l_Message_Inlog.Text = "Vul je inlogcode in '01'";
            }
        }

        private void tbx_WerknemerID_Login_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tbx_WerknemerID_Login.Text))
            {
                btn_Login_Text.Enabled = true;
                btn_Login_Symbol.Enabled = true;
            }

            try
            {
                int loginId = Int32.Parse(tbx_WerknemerID_Login.Text);

                if (loginId == 01)
                {
                    tbx_Password_Login.Visible = true;
                }
                else
                {
                    tbx_Password_Login.Visible = false;
                }
            }

            catch { }
        }

    }
}
