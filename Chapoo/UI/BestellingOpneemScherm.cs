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

            VulMenuKaart(c, d);


        }

        private void btn_AddBestelscherm_Click(object sender, EventArgs e)
        {
            lv_BesteldeItemlist.Columns.Clear();

            List<Model.MenuItem> besteldeMenuItemsList = new List<Model.MenuItem>();
           
            lv_BesteldeItemlist.Columns.Add("naam", 100);
            lv_BesteldeItemlist.Columns.Add("prijs", 100);
            lv_BesteldeItemlist.Columns.Add("opmerking", 150);
            lv_BesteldeItemlist.Columns.Add("omschrijving", 350);


            for (int i = 0; i < lv_MenuKaart.SelectedItems.Count; i++)
            {
                Model.MenuItem menuItem = (Model.MenuItem)lv_MenuKaart.SelectedItems[i].Tag;

                besteldeMenuItemsList.Add(menuItem);

            }

            foreach(Model.MenuItem menuItem in besteldeMenuItemsList)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
                item.SubItems.Add(menuItem.Prijs.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(menuItem.Omschrijving);

                lv_BesteldeItemlist.Items.Add(item);
            }

            
            
        }

        private void btn_DeleteBestelscherm_Click(object sender, EventArgs e)
        {
            //lv_BesteldeItemlist.SelectedItems.Clear();
            foreach(ListViewItem lv in lv_BesteldeItemlist.SelectedItems)
            {
                lv.Remove();
            }
        }

        private void btn_OpmerkingBestelscherm_Click(object sender, EventArgs e)
        {

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
            lv_BesteldeItemlist.Clear();
        }
        
        private void btn_VerzendenBestelscherm_Click(object sender, EventArgs e)
        {
            BestellingLogica bsl = new BestellingLogica();

            Medewerker m = bsl.HaalMedewerkerOp();
            Tafel t = bsl.HaalTafelOp();

            bsl.WriteBestelling(m, t);

            lv_BesteldeItemlist.Clear();
        }

        private void VulMenuKaart(Catagorie c, Dagdeel d)
        {
            lv_MenuKaart.Items.Clear();
            lv_MenuKaart.Columns.Clear();

            MenuKaart m = new MenuKaart();

            List<Model.MenuItem> menuKaart = new List<Model.MenuItem>();


            menuKaart = m.VulMenuKaart(c, d);

            lv_MenuKaart.Columns.Add("naam", 100);
            lv_MenuKaart.Columns.Add("prijs", 100);
            lv_MenuKaart.Columns.Add("omschrijving", 350);


            foreach (Model.MenuItem menuItem in menuKaart)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);

                item.SubItems.Add(menuItem.Prijs.ToString());
                item.SubItems.Add(menuItem.Omschrijving);

                lv_MenuKaart.Items.Add(item);

            }
            VulTagMenuKaart(menuKaart);
        }

        private List<BesteldeMenuItems> maakBesteldeMenuItems(List<Model.MenuItem> menuItems)
        {
            BestellingLogica b = new BestellingLogica();

            List<BesteldeMenuItems> besteldeMenuItems = new List<BesteldeMenuItems>();

            Medewerker m = b.HaalMedewerkerOp();

            Tafel t = b.HaalTafelOp();

          //  BesteldeMenuItems b = new BesteldeMenuItems(,);

            return besteldeMenuItems;
        }

        
    }
}
