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
            lv_MenuKaart.Items.Clear();

            MenuKaart m = new MenuKaart();

            List<Model.MenuItem> voorgerechtKaart = new List<Model.MenuItem>();
            Dagdeel d = new Dagdeel();
            
            voorgerechtKaart = m.VulMenuKaart(Catagorie.voorgerecht, d);

            lv_MenuKaart.Columns.Add("naam", 100);
            lv_MenuKaart.Columns.Add("prijs", 100);
            lv_MenuKaart.Columns.Add("omschrijving", 300);


            foreach (Model.MenuItem menuItem in voorgerechtKaart)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
               
                item.SubItems.Add(menuItem.Prijs.ToString());
                item.SubItems.Add(menuItem.Omschrijving);

                lv_MenuKaart.Items.Add(item);
            }
        }

        private void btn_hoofdgerecht_Click(object sender, EventArgs e)
        {
            lv_MenuKaart.Items.Clear();

            MenuKaart m = new MenuKaart();
            List<Model.MenuItem> hoofdgerechtKaart = new List<Model.MenuItem>();
            Model.MenuItem mItem = new Model.MenuItem(1, "test", Catagorie.hoofdgerecht, Dagdeel.diner, false, 10.10f, 20, "heerlijk");
            hoofdgerechtKaart.Add(mItem);
            hoofdgerechtKaart.Add(mItem);
            hoofdgerechtKaart.Add(mItem);
            hoofdgerechtKaart.Add(mItem);
     

            foreach (Model.MenuItem menuItem in hoofdgerechtKaart)
            {
                lv_MenuKaart.Items.Add(menuItem.ToString());
            }


        }

        private void btn_Tussengerecht_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Nagerecht_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Drank_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_AddBestelscherm_Click(object sender, EventArgs e)
        {
        }

        private void btn_DeleteBestelscherm_Click(object sender, EventArgs e)
        {

        }

        private void btn_OpmerkingBestelscherm_Click(object sender, EventArgs e)
        {

        }
    }
}
