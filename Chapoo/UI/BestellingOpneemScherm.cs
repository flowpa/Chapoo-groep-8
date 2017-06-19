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
    public partial class BestellingOpneemScherm : Form
    {
        public BestellingOpneemScherm()
        {
            InitializeComponent();
            tbx_opmerking.Hide();

            Timer timer = new Timer();
            timer.Interval = (15 * 1000); // 1 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            lv_MenuKaart.Columns.Add("naam", 130);
            lv_MenuKaart.Columns.Add("prijs", 100);
            lv_MenuKaart.Columns.Add("omschrijving", 350);

            lv_BesteldeItemlist.Columns.Add("Aantal", 50);
            lv_BesteldeItemlist.Columns.Add("naam", 130);
            lv_BesteldeItemlist.Columns.Add("prijs", 100);
            lv_BesteldeItemlist.Columns.Add("opmerking", 150);
            lv_BesteldeItemlist.Columns.Add("omschrijving", 350);

            lv_geheleBestelling.Columns.Add("Aantal", 50);
            lv_geheleBestelling.Columns.Add("naam", 130);
            lv_geheleBestelling.Columns.Add("prijs", 100);
            lv_geheleBestelling.Columns.Add("opmerking", 150);
        }


        private void btn_voorgerecht_Click(object sender, EventArgs e)
        {
            Catagorie c = new Catagorie();
            c = Catagorie.voorgerecht;
            Dagdeel d = new Dagdeel();

            VulMenuKaart(c, d);
        }

        private void btn_hoofdgerecht_Click(object sender, EventArgs e)
        {
            Catagorie c = new Catagorie();
            c = Catagorie.hoofdgerecht;
            Dagdeel d = new Dagdeel();

            VulMenuKaart(c, d);

        }

        private void btn_Tussengerecht_Click(object sender, EventArgs e)
        {
            Catagorie c = new Catagorie();
            c = Catagorie.tussengerecht;
            Dagdeel d = new Dagdeel();

            VulMenuKaart(c, d);

        }

        private void btn_Nagerecht_Click(object sender, EventArgs e)
        {
            Catagorie c = new Catagorie();
            c = Catagorie.nagerecht;
            Dagdeel d = new Dagdeel();

            VulMenuKaart(c, d);

        }

        private void btn_Drank_Click(object sender, EventArgs e)
        {
            Catagorie c = new Catagorie();
            c = Catagorie.dranken;
            Dagdeel d = new Dagdeel();
            d = Dagdeel.altijd;

            VulMenuKaart(c, d);


        }

        private void btn_AddBestelscherm_Click(object sender, EventArgs e)
        {
            MenuKaart m = new MenuKaart();

            for (int i = 0; i < lv_MenuKaart.SelectedItems.Count; i++)
            {
                Model.MenuItem menuItem = (Model.MenuItem)lv_MenuKaart.SelectedItems[i].Tag;
                menuItem.Opmerking = "";


                if (m.aantal(menuItem.Id) > 1)
                {
                    toevoegen(menuItem);
                }
                else
                {
                    MessageBox.Show("Het item wat je wil hebben is helaas niet meer op voorraad", "Geen Voorraad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void btn_DeleteBestelscherm_Click(object sender, EventArgs e)
        {
            
            foreach(ListViewItem lv in lv_BesteldeItemlist.SelectedItems)
            {
                deleten((BesteldeMenuItems)lv.Tag);
            }
        }

        private void btn_OpmerkingBestelscherm_Click(object sender, EventArgs e)
        {
            if (tbx_opmerking.Visible == false)
            {
                tbx_opmerking.Show();
            }
            else
            {
                tbx_opmerking.Hide();
            }
        }

        private void VulTagMenuKaart(List<Model.MenuItem> items)
        {
            for (int i = 0; i < items.Count(); i++)
            {
                lv_MenuKaart.Items[i].Tag = items[i];
            }
        }


        private void btn_AnnuleerBestelscherm_Click(object sender, EventArgs e)
        {
            lv_BesteldeItemlist.Items.Clear();
        }
        
        private void btn_VerzendenBestelscherm_Click(object sender, EventArgs e)
        {
            BesteldeMenuItemsLogica b = new BesteldeMenuItemsLogica();
           
            List<Model.BesteldeMenuItems> besteldeItemsList = new List<Model.BesteldeMenuItems>();

            for (int i = 0; i < lv_BesteldeItemlist.Items.Count; i++)
            {
                Model.BesteldeMenuItems item = (Model.BesteldeMenuItems)lv_BesteldeItemlist.Items[i].Tag;          
                besteldeItemsList.Add(item);
            }

            bool positief = true;

            b.verzendBesteldeItems(besteldeItemsList, positief);

            
            tbx_opmerking.Hide();

            lv_BesteldeItemlist.Clear();
        }

        private void VulMenuKaart(Catagorie c, Dagdeel d)
        {
            lv_MenuKaart.Items.Clear();
            //lv_MenuKaart.Columns.Clear();

            MenuKaart m = new MenuKaart();

            List<Model.MenuItem> menuKaart = new List<Model.MenuItem>();


            menuKaart = m.VulMenuKaart(c, d);


            foreach (Model.MenuItem menuItem in menuKaart)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);

                item.SubItems.Add(menuItem.Prijs.ToString("0.00"));
                item.SubItems.Add(menuItem.Omschrijving);

                lv_MenuKaart.Items.Add(item);

            }
            VulTagMenuKaart(menuKaart);
        }


        private void btn_VorrigeBestellingTab_Click(object sender, EventArgs e)
        {

        }

        private void toevoegen(Model.MenuItem item)
        {
            // voegt menuItem toe aan bestelde menuItem lijst een chekt op dubbelen


            bool toegevoegd = false;


            foreach (ListViewItem i in lv_BesteldeItemlist.Items)
            {
                Model.BesteldeMenuItems besteldeMenuItem = (Model.BesteldeMenuItems)i.Tag;
                besteldeMenuItem.Opmerking = tbx_opmerking.Text;

                if (besteldeMenuItem.MenuItem.Naam == item.Naam && item.Opmerking == besteldeMenuItem.Opmerking)
                {
                    besteldeMenuItem.Aantal++;
                    
                    lv_BesteldeItemlist.Items.Remove(i);

                    ListViewItem li = new ListViewItem(besteldeMenuItem.Aantal.ToString());
                    li.SubItems.Add(besteldeMenuItem.MenuItem.Naam);
                    li.SubItems.Add(besteldeMenuItem.MenuItem.Prijs.ToString("0.00"));
                    li.SubItems.Add(besteldeMenuItem.Opmerking);
                    li.SubItems.Add(besteldeMenuItem.MenuItem.Omschrijving);
                    li.Tag = besteldeMenuItem;

                    lv_BesteldeItemlist.Items.Add(li);

                    toegevoegd = true;
                }

            }

            if (!toegevoegd)
            {
                BesteldeMenuItems bestelItem = new BesteldeMenuItems(1, 1, tbx_opmerking.Text, item, false);

                ListViewItem li = new ListViewItem(bestelItem.Aantal.ToString());
                li.SubItems.Add(bestelItem.MenuItem.Naam);
                li.SubItems.Add(bestelItem.MenuItem.Prijs.ToString("0.00"));
                li.SubItems.Add(bestelItem.Opmerking);
                li.SubItems.Add(bestelItem.MenuItem.Omschrijving);



                li.Tag = bestelItem;

                lv_BesteldeItemlist.Items.Add(li);
            }
            tbx_opmerking.Text = "";
            tbx_opmerking.Hide();
        }

        private void deleten(Model.BesteldeMenuItems item)
        {
            // voegt menuItem toe aan bestelde menuItem lijst een chekt op dubbelen


            for (int count = 0; count < lv_BesteldeItemlist.Items.Count; count++)
            {
                BesteldeMenuItems b = (BesteldeMenuItems)lv_BesteldeItemlist.Items[count].Tag;


                if (b.MenuItem.Naam == item.MenuItem.Naam)
                {
                    if (b.Aantal > 1)
                    {
                        b.Aantal--;

                        lv_BesteldeItemlist.Items[count].Remove();


                        ListViewItem li = new ListViewItem(b.Aantal.ToString());
                        li.SubItems.Add(b.MenuItem.Naam);
                        li.SubItems.Add(b.MenuItem.Prijs.ToString("0.00"));
                        li.SubItems.Add(b.Opmerking);
                        li.SubItems.Add(b.MenuItem.Omschrijving);

                        li.Tag = b;
                        lv_BesteldeItemlist.Items.Add(li);
                    }
                    else
                    {
                        lv_BesteldeItemlist.Items[count].Remove();
                    }
                }

            }

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            lv_geheleBestelling.Items.Clear();
            MenuKaart m = new MenuKaart();
            // ophalen bestelling_id
            List<BesteldeMenuItems> besteldeItems = m.getBesteldeMenuItemsByBestellingId(1);


            foreach (Model.BesteldeMenuItems menuItem in besteldeItems)
            {
                ListViewItem item = new ListViewItem(menuItem.Aantal.ToString());
                item.SubItems.Add(menuItem.MenuItem.Naam);
                item.SubItems.Add(menuItem.MenuItem.Prijs.ToString("0.00"));
                item.SubItems.Add(menuItem.Opmerking);
                item.Tag = menuItem;

                lv_geheleBestelling.Items.Add(item);

            }

            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 15 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        

        private void btn_deleten_Click(object sender, EventArgs e)
        {
            BesteldeMenuItemsLogica b = new BesteldeMenuItemsLogica();
            bool positief = false;

            foreach (ListViewItem lv in lv_geheleBestelling.SelectedItems)
            {
                deleten((BesteldeMenuItems)lv.Tag);


                b.VeranderVooraad((BesteldeMenuItems)lv.Tag, positief);
            }
        }

        private void btn_betalen_Click(object sender, EventArgs e)
        {

        }
    }

}

