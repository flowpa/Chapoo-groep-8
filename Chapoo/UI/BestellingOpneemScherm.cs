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
            btn_addOpmerking.Hide();
            tbx_opmerking.Hide();
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
                menuItem.Opmerking = "";
                besteldeMenuItemsList.Add(menuItem);

            }

            foreach(Model.MenuItem menuItem in besteldeMenuItemsList)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
                item.SubItems.Add(menuItem.Prijs.ToString());
                item.SubItems.Add("");
                item.SubItems.Add(menuItem.Omschrijving);
                item.Tag = menuItem;

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
            if (btn_addOpmerking.Visible == false)
            {
                btn_addOpmerking.Show();
                tbx_opmerking.Show();
            }
            else
            {
                btn_addOpmerking.Hide();
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
            lv_BesteldeItemlist.Clear();
        }
        
        private void btn_VerzendenBestelscherm_Click(object sender, EventArgs e)
        {
            BesteldeMenuItemsLogica b = new BesteldeMenuItemsLogica();

            List<Model.MenuItem> besteldeMenuItemsList = new List<Model.MenuItem>();
            List<Model.BesteldeMenuItems> besteldeItemsList = new List<Model.BesteldeMenuItems>();

            for (int i = 0; i < lv_BesteldeItemlist.Items.Count; i++)
            {
                Model.MenuItem menuItem = (Model.MenuItem)lv_BesteldeItemlist.Items[i].Tag;          
                besteldeMenuItemsList.Add(menuItem);
            }

            b.MaakBesteldeMenuItemsLijst(besteldeMenuItemsList);

            btn_addOpmerking.Hide();
            tbx_opmerking.Hide();

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

        private void btn_addOpmerking_Click(object sender, EventArgs e)
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
                menuItem.Opmerking = tbx_opmerking.Text;
                besteldeMenuItemsList.Add(menuItem);

            }

            foreach (Model.MenuItem menuItem in besteldeMenuItemsList)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
                item.SubItems.Add(menuItem.Prijs.ToString());
                item.SubItems.Add(menuItem.Opmerking);
                item.SubItems.Add(menuItem.Omschrijving);
                item.Tag = menuItem;

                lv_BesteldeItemlist.Items.Add(item);
            }
        }
    }
}
