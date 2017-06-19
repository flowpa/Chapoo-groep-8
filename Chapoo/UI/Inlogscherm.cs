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
        private InloggenService iService;
        private TafeloverzichtScherm tafelForm;
        private BestellingOpneemScherm bestelForm;
        private BestellingDrankForm barmanForm;
        private BestellingEtenForm kokForm;
        

        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void btn_Login_Text_Click(object sender, EventArgs e)
        {
            iService = new InloggenService();

            int loginId;

            bool legit= int.TryParse(tbx_WerknemerID_Login.Text, out loginId);
            if(legit)
            { 
                if (iService.checkMedewerker(loginId) == true)
                {
                    Medewerker m = iService.getMedewerker(loginId);


                    switch (m.Functie)
                    {
                        case Functie.eigenaar:
                            string password = tbx_Password_Login.Text;

                            try
                            {
                                if (password == m.Wachtwoord)
                                {
                                    this.Hide();
                                    Tafel tafel = null;
                                    Bestelling b = null;
                                    bestelForm = new BestellingOpneemScherm(b,tafel);
                                    bestelForm.ShowDialog();
                                }
                                else
                                {
                                    l_Message_Inlog.ForeColor = Color.Red;
                                    l_Message_Inlog.Text = "Uw wachtwoord klopt niet.";
                                }

                            }
                            catch { }

                            break;

                        case Functie.bediende:
                            this.Hide();
                            tafelForm = new TafeloverzichtScherm();
                            tafelForm.medewerker(m);
                            tafelForm.ShowDialog();
                            break;

                        case Functie.kok:
                            this.Hide();
                            kokForm = new BestellingEtenForm();
                            kokForm.ShowDialog();
                            break;

                        case Functie.barman:
                            this.Hide();
                            barmanForm = new BestellingDrankForm();
                            barmanForm.ShowDialog();
                            break;

                        default:
                            break;
                    }
                }

                else
                {
                    l_Message_Inlog.ForeColor = Color.Red;
                    l_Message_Inlog.Text = "De inlogcode is niet bekend!";
                }
            }

            else
            {
                l_Message_Inlog.ForeColor = Color.Red;
                l_Message_Inlog.Text = "Vul je inlogcode in '8'";
            }
        }

        


        private void tbx_WerknemerID_Login_TextChanged(object sender, EventArgs e)
        {
            InloggenService iService = new InloggenService();

            if (!string.IsNullOrWhiteSpace(tbx_WerknemerID_Login.Text))
            {
                btn_Login_Text.Enabled = true;
                btn_Login_Symbol.Enabled = true;
            }
            else
            {
                btn_Login_Text.Enabled = false;
                btn_Login_Symbol.Enabled = false;
            }

            try
            {
                int loginId = Int32.Parse(tbx_WerknemerID_Login.Text);
                Medewerker m = iService.getMedewerker(loginId);
                
                if (m.Functie == Functie.eigenaar)
                {
                    tbx_Password_Login.Visible = true;
                    l_Message_Inlog.Text = "Voer uw wachtwoord in";
                }
                else
                {
                    tbx_Password_Login.Visible = false;
                }
            }

            catch
            {
                tbx_Password_Login.Visible = false;
                l_Message_Inlog.Text = "Voer uw inlogcode in";
            }
        }


    }
}

