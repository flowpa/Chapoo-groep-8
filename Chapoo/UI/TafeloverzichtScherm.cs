using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Logica;
using System.Windows.Forms;

namespace UI
{
    public partial class TafeloverzichtScherm : Form
    {
        private TafeloverzichtService tService;
        private Inlogscherm inlogForm;
        private BestellingService bService;
        private BestellingOpneemScherm bestellingForm;
        private AfrekenenService aService;
        private BesteldeMenuItemsLogica bmService;
        private Tafel huidigeTafel;
        private Label huidigeLabel;
        private bool isBezet;
        private int huidigeMedewerkerId;

        public void medewerker(Medewerker m)
        {
            l_huidigeGebruiker.Tag = m;
            l_huidigeGebruiker.Text += m.Naam;
            huidigeMedewerkerId = m.Id;
        }

        public TafeloverzichtScherm()
        {
            InitializeComponent();

            btn_Vrijgeven.Enabled = false;
            btn_Opnemen.Enabled = false;
            checkBezettenTafels(btn_Tafel1, 1);
            checkBezettenTafels(btn_Tafel2, 2);
            checkBezettenTafels(btn_Tafel3, 3);
            checkBezettenTafels(btn_Tafel4, 4);
            checkBezettenTafels(btn_Tafel5, 5);
            checkBezettenTafels(btn_Tafel6, 6);
            checkBezettenTafels(btn_Tafel7, 7);
            checkBezettenTafels(btn_Tafel8, 8);
            checkBezettenTafels(btn_Tafel9, 9);
            checkBezettenTafels(btn_Tafel10, 10);

            checkBestellinOpTafel(lbl_Bestelling_1, 1, btn_Tafel1);
            checkBestellinOpTafel(lbl_Bestelling_2, 2, btn_Tafel2);
            checkBestellinOpTafel(lbl_Bestelling_3, 3, btn_Tafel3);
            checkBestellinOpTafel(lbl_Bestelling_4, 4, btn_Tafel4);
            checkBestellinOpTafel(lbl_Bestelling_5, 5, btn_Tafel5);
            checkBestellinOpTafel(lbl_Bestelling_6, 6, btn_Tafel6);
            checkBestellinOpTafel(lbl_Bestelling_7, 7, btn_Tafel7);
            checkBestellinOpTafel(lbl_Bestelling_8, 8, btn_Tafel8);
            checkBestellinOpTafel(lbl_Bestelling_9, 9, btn_Tafel9);
            checkBestellinOpTafel(lbl_Bestelling_10, 10, btn_Tafel10);

            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_1, btn_Tafel1);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_2, btn_Tafel2);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_3, btn_Tafel3);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_4, btn_Tafel4);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_5, btn_Tafel5);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_6, btn_Tafel6);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_7, btn_Tafel7);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_8, btn_Tafel8);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_9, btn_Tafel9);
            checkStatusBesteldeMenuItemsPerBestelling(lbl_Bestelling_10, btn_Tafel10);

        }

        private void checkBezettenTafels(Button btn, int tafelId)
        {
            tService = new TafeloverzichtService();
            huidigeTafel = tService.getTafel(tafelId);
            btn.Tag = huidigeTafel;

            if (huidigeTafel.IsBezet == true)
            {
                btn.BackColor = Color.Tomato;
            }
            else
            {
                btn.BackColor = Color.Green;
            }
        }

        private void checkBestellinOpTafel(Label lbl, int tafelId, Button b)
        {
            bService = new BestellingService();
            aService = new AfrekenenService();
            bmService = new BesteldeMenuItemsLogica();
            List<Bestelling> bestellingenPerTafelId = bService.getAllBestellingenByTafelId(tafelId);
            Bon bon = null;



            if (bestellingenPerTafelId.Count != 0 )
            {
                if (bestellingenPerTafelId.Last().Id > 0)
                {
                    bon = aService.getBonByBestellingId(bestellingenPerTafelId.Last().Id);
                    if (bon.IsBetaald == false)
                    {
                        lbl.Text = bon.Betstelling_id.ToString();
                        btn_Vrijgeven.Enabled = false;
                    }
                    else
                    {
                        btn_Vrijgeven.Enabled = true;
                        b.BackColor = Color.Green;
                    }


                }
            }
        }

        private void checkStatusBesteldeMenuItemsPerBestelling(Label huidigeLabel, Button huidigeButton)
        {
            if (huidigeButton.BackColor == Color.Tomato)
            {
                //1. Lees een list uit met alle besteldeMenuitems per bestellingID
                int bestellingId;
                bool legit = int.TryParse(huidigeLabel.Text, out bestellingId);

                List<BesteldeMenuItems> besteldeMenuItems = new List<BesteldeMenuItems>();

                if (legit)
                {
                    besteldeMenuItems = bmService.GetBesteldeMenuItems(bestellingId);
                }

                bool status = true;

                foreach (BesteldeMenuItems item in besteldeMenuItems)
                {
                    if (item.Bereid == false)
                    {
                        status = false;
                        break;
                    }
                }
                if (status)
                {
                    huidigeButton.BackColor = Color.Red;
                }
                
            }
        }




        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel1, 1);
            huidigeTafel = (Tafel)btn_Tafel1.Tag;
            huidigeLabel = lbl_Bestelling_1;
            tafelButton(huidigeTafel.Nummer, btn_Tafel1, huidigeTafel);
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel2, 2);
            huidigeTafel = (Tafel)btn_Tafel2.Tag;
            huidigeLabel = lbl_Bestelling_2;

            tafelButton(huidigeTafel.Nummer, btn_Tafel2, huidigeTafel);
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel3, 3);

            huidigeTafel = (Tafel)btn_Tafel3.Tag;
            huidigeLabel = lbl_Bestelling_3;

            tafelButton(huidigeTafel.Nummer, btn_Tafel3, huidigeTafel);
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel4, 4);

            huidigeTafel = (Tafel)btn_Tafel4.Tag;
            huidigeLabel = lbl_Bestelling_4;

            tafelButton(huidigeTafel.Nummer, btn_Tafel4, huidigeTafel);
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel5, 5);

            huidigeTafel = (Tafel)btn_Tafel5.Tag;
            huidigeLabel = lbl_Bestelling_5;

            tafelButton(huidigeTafel.Nummer, btn_Tafel5, huidigeTafel);
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel6, 6);

            huidigeTafel = (Tafel)btn_Tafel6.Tag;
            huidigeLabel = lbl_Bestelling_6;

            tafelButton(huidigeTafel.Nummer, btn_Tafel6, huidigeTafel);
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel7, 7);

            huidigeTafel = (Tafel)btn_Tafel7.Tag;
            huidigeLabel = lbl_Bestelling_7;

            tafelButton(huidigeTafel.Nummer, btn_Tafel7, huidigeTafel);
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel8, 8);

            huidigeTafel = (Tafel)btn_Tafel8.Tag;
            huidigeLabel = lbl_Bestelling_8;

            tafelButton(huidigeTafel.Nummer, btn_Tafel8, huidigeTafel);
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel9, 9);

            huidigeTafel = (Tafel)btn_Tafel9.Tag;
            huidigeLabel = lbl_Bestelling_9;

            tafelButton(huidigeTafel.Nummer, btn_Tafel9, huidigeTafel);
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            checkBezettenTafels(btn_Tafel10, 10);

            huidigeTafel = (Tafel)btn_Tafel10.Tag;
            huidigeLabel = lbl_Bestelling_10;

            tafelButton(huidigeTafel.Nummer, btn_Tafel10, huidigeTafel);
        }

        private void tafelButton(int tafelid, Button b, Tafel tafel)
        {
            //GREEN = 0 = FALSE
            //TOMATO = 1 = TRUE
            l_huidigeTafel.Text = "Geselecteerde tafel = " + tafel.Nummer;

            if (tafel.IsBezet == true ) //TOMATO
            {
                btn_Opnemen.Enabled = true;
                tService.writeTafelStatus(tafelid, tafel.IsBezet);
            }

            else //GREEN
            {
                tafel.IsBezet = true;
                b.BackColor = Color.Tomato;
                btn_Vrijgeven.Enabled = true;
                btn_Opnemen.Enabled = true;
                tService.writeTafelStatus(tafelid, tafel.IsBezet);
            }
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            inlogForm = new Inlogscherm();
            this.Hide();
            inlogForm.ShowDialog();
        }

        private void btn_Vrijgeven_Click(object sender, EventArgs e)
        {
            switch (huidigeTafel.Nummer)
            {
                case 1:
                    vrijgevenButton(1, btn_Tafel1);
                    break;
                case 2:
                    vrijgevenButton(2, btn_Tafel2);
                    break;
                case 3:
                    vrijgevenButton(3, btn_Tafel3);
                    break;
                case 4:
                    vrijgevenButton(4, btn_Tafel4);
                    break;
                case 5:
                    vrijgevenButton(5, btn_Tafel5);
                    break;
                case 6:
                    vrijgevenButton(6, btn_Tafel6);
                    break;
                case 7:
                    vrijgevenButton(7, btn_Tafel7);
                    break;
                case 8:
                    vrijgevenButton(8, btn_Tafel8);
                    break;
                case 9:
                    vrijgevenButton(9, btn_Tafel9);
                    break;
                case 10:
                    vrijgevenButton(10, btn_Tafel10);
                    break;
                default:
                    break;
            }
        }

        private void vrijgevenButton(int tafelid, Button b)
        {
            //tafel = tService.getTafel(tafelId);
            b.Tag = huidigeTafel;
            isBezet = false;
            tService.writeTafelStatus(tafelid, isBezet);
            b.BackColor = Color.Green;
            l_huidigeTafel.Text = "Geselecteerde tafel = ";
            btn_Vrijgeven.Enabled = false;
        }

        private void btn_Opnemen_Click(object sender, EventArgs e)
        {
            // check is er al een bestelling //label

            // zo niet nieuwe bestelling aangemaakt + new bon + bestellingId ophalen

            // tafel bezet zetten
            bService = new BestellingService();
            aService = new AfrekenenService();
            Bestelling bestelling = null;


            if (huidigeLabel.Text != "")
            {
                bestelling = bService.getBestellingById(int.Parse(huidigeLabel.Text));

                bestellingForm = new BestellingOpneemScherm(bestelling, huidigeTafel);
                this.Hide();
                bestellingForm.ShowDialog();
                
            }
            else
            {
                bestelling = bService.WriteBestelling(huidigeMedewerkerId, huidigeTafel);
                aService.newBonByBestellingId(bestelling.Id);
                huidigeLabel.Text = bestelling.Id.ToString();

                bestellingForm = new BestellingOpneemScherm(bestelling, huidigeTafel);
                this.Hide();
                bestellingForm.ShowDialog();
                
            }
 
        }

    }
}
