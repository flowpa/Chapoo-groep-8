﻿using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class Afrekenen : Form
    {
        
        AfrekenenService logicaLaag;
        Bon bon;
        int tafelId;

        public Afrekenen()
        {
            InitializeComponent();
            //lbl_huidigeTafel.Text = "Geselecteerde tafel = " + ;
            pnl_betaling.Hide();
            lv_bon.Columns.Add("Aantal", 100);
            lv_bon.Columns.Add("Item", 100);
            lv_bon.Columns.Add("Prijs", 100);
            lv_bon.Columns.Add("Subtotaal", 100);
        }

        private void Afrekenen_Load(object sender, EventArgs e)
        {
            tafelId = 1;
            logicaLaag = new AfrekenenService();
            List<BesteldeMenuItems> bonLijst = logicaLaag.GetBon(tafelId);
            bon = logicaLaag.BerekenBedragen(bonLijst);
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

        private void VulListView(List<BesteldeMenuItems> bon)
        {
            if (bon.Count == 0)
                return;


            foreach (BesteldeMenuItems item in bon)
            {
                ListViewItem lvItem = new ListViewItem(item.Aantal.ToString());
                
                lvItem.SubItems.Add(item.MenuItem.Naam);
                lvItem.SubItems.Add(item.MenuItem.Prijs.ToString());
                lvItem.SubItems.Add((item.MenuItem.Prijs * item.Aantal).ToString());

                lv_bon.Items.Add(lvItem);
                //lbl_totaal.Text = item.Prijs.ToString();
            }

        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            this.Hide();

            //code waarnaar gerefereerd welk form hij terug moet
        }
               
        private void btn_betaald_Click(object sender, EventArgs e)
        {
            // pomp de bon naar db


            // show betaald succes scherm
        }

        private void btn_terugBetaald_Click_1(object sender, EventArgs e)
        {
            pnl_betaling.Hide();
        }

        private void btn_betalen_Click(object sender, EventArgs e)
        {
            pnl_betaling.Show();
        }

        private void pnl_betaling_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
