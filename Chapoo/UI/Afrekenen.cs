using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logica;

namespace UI
{
    public partial class Afrekenen : Form
    {
        AfrekenenLogica logicaLaag = new AfrekenenLogica();
        int tafelId;
        

        public Afrekenen()
        {
            InitializeComponent();
            pnl_betaling.Hide();
            lv_bon.Columns.Add("Aantal", 100);
            lv_bon.Columns.Add("Item", 100);
            lv_bon.Columns.Add("Prijs", 100);
            lv_bon.Columns.Add("Subtotaal", 100);
        }

        private void Afrekenen_Load(object sender, EventArgs e)
        {
            tafelId = 1;
            List<Model.MenuItem> bon = logicaLaag.GetBon(tafelId);
            VulListView(bon);
        }

        private void VulListView(List<Model.MenuItem> bon)
        {
            if (bon.Count == 0)
                return;

            

            foreach (Model.MenuItem item in bon)
            {
                ListViewItem lvItem = new ListViewItem(item.Aantal.ToString());

                
                lvItem.SubItems.Add(item.Naam);
                lvItem.SubItems.Add(item.Prijs.ToString());
                lvItem.SubItems.Add((item.Prijs * item.Aantal).ToString());

                lv_bon.Items.Add(lvItem);
                //lbl_totaal.Text = item.Prijs.ToString();
            }

        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            this.Hide();

            //code waarnaar gerefereerd welk form hij terug moet
        }

        private void btn_betalen_Click(object sender, EventArgs e)
        {
            pnl_betaling.Show();
        }
               
        private void btn_terugBetaald_Click(object sender, EventArgs e)
        {
            Afrekenen afrekenen = new Afrekenen();
            this.Hide();
            afrekenen.Show();
        }

       
    }
}
