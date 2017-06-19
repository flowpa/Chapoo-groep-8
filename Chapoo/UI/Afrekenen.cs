using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class Afrekenen : Form
    {
        BestellingOpneemScherm bestellingScherm;
        AfrekenenService AfrS;
        Bon bon;
        Tafel tafel;

        public Afrekenen(BestellingOpneemScherm bestellingScherm, Tafel tafel)
        {
            InitializeComponent();
            this.tafel = tafel;
            this.bestellingScherm = bestellingScherm;
            lbl_huidigeTafel.Text = "Geselecteerde tafel = " + tafel.Nummer;
            pnl_betaling.Hide();
            pnl_betalingSucces.Hide();
            lv_bon.Columns.Add("Aantal", 100);
            lv_bon.Columns.Add("Item", 100);
            lv_bon.Columns.Add("Prijs", 100);
            lv_bon.Columns.Add("Subtotaal", 100);
            AfrS = new AfrekenenService();
            List<BesteldeMenuItems> bonLijst = AfrS.GetBon(tafel.Nummer);
            bon = AfrS.BerekenBedragen(bonLijst);
            VulListView(bonLijst);
            VulLabels();

        }
        
        private void VulLabels()
        {
            lbl_totaalPrijs.Text = "€ " + bon.TotaalPrijsInclusief.ToString();
            lbl_btwHoogPrijs.Text = "€ " + bon.TotaalBtwHoog.ToString();
            lbl_btwLaagPrijs.Text = "€ " + bon.TotaalBtwLaag.ToString();
            lbl_btwTotaalPrijs.Text = "€ " + bon.TotaalBtw.ToString();
            lbl_totaalBetaaldPrijs.Text = "€ " + bon.TotaalPrijsInclusief.ToString();
        }

        private void VulListView(List<BesteldeMenuItems> bonLijst)
        {
            if (bonLijst.Count == 0)
                return;


            foreach (BesteldeMenuItems item in bonLijst)
            {
                ListViewItem lvItem = new ListViewItem(item.Aantal.ToString());
                
                lvItem.SubItems.Add(item.MenuItem.Naam);
                lvItem.SubItems.Add(item.MenuItem.Prijs.ToString());
                lvItem.SubItems.Add((item.MenuItem.Prijs * item.Aantal).ToString());

                lv_bon.Items.Add(lvItem);
            }

        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            bestellingScherm.Show();
            this.Close();
        }
               
        private void btn_betaald_Click(object sender, EventArgs e)
        {
            AfrS.SafeBonNaarDb();
            pnl_betalingSucces.Show();
            pnl_betaling.Hide();
        }

        private void btn_terugBetaald_Click_1(object sender, EventArgs e)
        {
            pnl_betaling.Hide();
        }

        private void btn_betalen_Click(object sender, EventArgs e)
        {
            pnl_betaling.Show();
        }

        private void txt_betaaldBedrag_TextChanged(object sender, EventArgs e)
        {
            int fooiText;
            if (!Int32.TryParse(txt_betaaldBedrag.Text, out fooiText))
            {
                return;
            }

            bon.Fooi = Math.Round(Convert.ToDouble(txt_betaaldBedrag.Text) - bon.TotaalPrijsInclusief, 2);
            lbl_fooiPrijs.Text = "€ " + bon.Fooi.ToString();
        }

        private void btn_betaaldOk_Click(object sender, EventArgs e)
        {
            pnl_betalingSucces.Hide();
            btn_terug_Click(sender, e);
        }
    }
}
