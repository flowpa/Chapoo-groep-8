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
        private Tafel tafel;
        private Tafel huidigeTafel;
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

            checkBestellingStatus(lbl_Bestelling_1, 1, btn_Tafel1);
            checkBestellingStatus(lbl_Bestelling_2, 2, btn_Tafel2);
            checkBestellingStatus(lbl_Bestelling_3, 3, btn_Tafel3);
            checkBestellingStatus(lbl_Bestelling_4, 4, btn_Tafel4);
            checkBestellingStatus(lbl_Bestelling_5, 5, btn_Tafel5);
            checkBestellingStatus(lbl_Bestelling_6, 6, btn_Tafel6);
            checkBestellingStatus(lbl_Bestelling_7, 7, btn_Tafel7);
            checkBestellingStatus(lbl_Bestelling_8, 8, btn_Tafel8);
            checkBestellingStatus(lbl_Bestelling_9, 9, btn_Tafel9);
            checkBestellingStatus(lbl_Bestelling_10, 10, btn_Tafel10);


        }

        private void checkBezettenTafels(Button btn, int tafelId)
        {
            tService = new TafeloverzichtService();
            tafel = tService.getTafel(tafelId);
            btn.Tag = tafel;

            if (tafel.IsBezet == true)
            {
                btn.BackColor = Color.Tomato;
            }
            else
            {
                btn.BackColor = Color.Green;
            }
        }

        private void checkBestellingStatus(Label lbl, int tafelId, Button b)
        {
            bService = new BestellingService();
            aService = new AfrekenenService();
            bmService = new BesteldeMenuItemsLogica();
            List<Bestelling> bestellingenPerTafelId = bService.getAllBestellingenByTafelId(tafelId);
            Bon bon = null;
            try
            {
                int laatstBestellingIdPerTafelId = bestellingenPerTafelId[bestellingenPerTafelId.Count - 1].Id;

                try
                {
                    bon = aService.getBonByBestellingId(laatstBestellingIdPerTafelId);
                    if (bon.IsBetaald == false)
                    {
                        lbl.Text = bon.Betstelling_id.ToString();
                        btn_Vrijgeven.Enabled = false;
                    }
                }
                catch { }

            }
            catch { }


            ////1. Lees een list uit met alle besteldeMenuitems per bestellingID
            //int bestellingid;
            //bool legit = int.TryParse(lbl.Text, out bestellingid);

            //List<BesteldeMenuItems> besteldeMenuItems = null;

            //if (legit)
            //{
            //    besteldeMenuItems = bmService.GetBesteldeMenuItems(bon.Betstelling_id);
            //}

            ////2. Beslis of alle besteldeMenuItems de status TRUE hebben
            //bool status = true;

            //foreach (BesteldeMenuItems item in besteldeMenuItems)
            //{
            //    if (item.Geserveerd == false)
            //        status = false;
            //}
            ////3. Als dat zo is, maak de button rood
            //if (status == true)
            //{
            //    b.BackColor = Color.Red;
            //}
            ////3.1 Als dat niet zo is, niks.
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel1.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel1, tafel);
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel2.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel2, tafel);
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel3.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel3, tafel);
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel4.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel4, tafel);
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel5.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel5, tafel);
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel6.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel6, tafel);
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel7.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel7, tafel);
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel8.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel8, tafel);
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel9.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel9, tafel);
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel10.Tag;
            huidigeTafel = tafel;
            tafelButton(tafel.Nummer, btn_Tafel10, tafel);
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
            bService = new BestellingService();

            List<Bestelling> bestellingen = bService.getAllBestellingen();
            
            int laasteBestellingId = bestellingen[bestellingen.Count - 2].Id;
            laasteBestellingId++;

            bService.WriteBestellingIncrement(laasteBestellingId, huidigeMedewerkerId, huidigeTafel);

            Bestelling bestelling = bService.getBestellingById(laasteBestellingId);

            aService.newBonByBestellingId(bestelling.Id);

            this.Hide();

            bestellingForm = new BestellingOpneemScherm(bestelling, huidigeTafel);
            bestellingForm.ShowDialog();
        }

    }
}
