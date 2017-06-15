using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class Afrekenen : Form
    {
        AfrekenenLogica logicaLaag;
        int tafelId;

        public Afrekenen()
        {
            InitializeComponent();
        }

        private void Afrekenen_Load(object sender, EventArgs e)
        {
            tafelId = 1;
            logicaLaag = new AfrekenenLogica();
            List<Model.MenuItem> bon = logicaLaag.GetBon(tafelId);
            VulListView(bon);
        }

        private void VulListView(List<Model.MenuItem> bon)
        {
            if (bon.Count == 0)
                return;

            lv_bon.Columns.Add("Aantal");
            lv_bon.Columns.Add("Item");
            lv_bon.Columns.Add("Prijs");
            lv_bon.Columns.Add("Subtotaal");

            foreach (Model.MenuItem item in bon)
            {
                ListViewItem lvItem = new ListViewItem();

                lvItem.SubItems.Add("aantal");
                lvItem.SubItems.Add(item.Naam);
                lvItem.SubItems.Add(item.Prijs.ToString());
                lvItem.SubItems.Add("prijs * aantal");

                lv_bon.Items.Add(lvItem);
                //lbl_totaal.Text = item.Prijs.ToString();
            }

        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            this.Hide();

            //code waarnaar gerefereerd welk form hij terug moet
        }
    }
}
