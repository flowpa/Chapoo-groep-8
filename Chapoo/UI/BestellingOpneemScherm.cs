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
            MenuKaart m = new MenuKaart();
            List<Model.MenuItem> voorgerechtKaart = new List<Model.MenuItem>();
            Dagdeel d = new Dagdeel();
            
            voorgerechtKaart = m.VulMenuKaart(Catagorie.voorgerecht, d);

            foreach (Model.MenuItem menuItem in voorgerechtKaart)
            {
                MenuKaart.Items.Add(menuItem.ToString());
            }
        }

        private void btn_hoofdgerecht_Click(object sender, EventArgs e)
        {
            MenuKaart m = new MenuKaart();
            List<Model.MenuItem> hoofdgerechtKaart = new List<Model.MenuItem>();
            Model.MenuItem mItem = new Model.MenuItem(1, "test", Catagorie.hoofdgerecht, Dagdeel.diner, false, 10.10f, 20, "heerlijk");
            hoofdgerechtKaart.Add(mItem);
            hoofdgerechtKaart.Add(mItem);
            hoofdgerechtKaart.Add(mItem);
            hoofdgerechtKaart.Add(mItem);
     

            foreach (Model.MenuItem menuItem in hoofdgerechtKaart)
            {
                MenuKaart.Items.Add(menuItem.ToString());
            }


        }

        private void btn_Tussengerecht_Click(object sender, EventArgs e)
        {
            MenuKaart m = new MenuKaart();
            List<Model.MenuItem> tussengerechtMenu = new List<Model.MenuItem>();
            Dagdeel d = new Dagdeel();

            tussengerechtMenu = m.VulMenuKaart(Catagorie.tussengerecht, d);

            foreach (Model.MenuItem menuItem in tussengerechtMenu)
            {
                MenuKaart.Items.Add(menuItem.ToString());
            }
        }

        private void btn_Nagerecht_Click(object sender, EventArgs e)
        {
            MenuKaart m = new MenuKaart();
            List<Model.MenuItem> nagerechtKaart = new List<Model.MenuItem>();
            Dagdeel d = new Dagdeel();

            nagerechtKaart = m.VulMenuKaart(Catagorie.nagerecht, d);

            foreach (Model.MenuItem menuItem in nagerechtKaart)
            {
                MenuKaart.Items.Add(menuItem.ToString());
            }
        }

        private void btn_Drank_Click(object sender, EventArgs e)
        {
            MenuKaart m = new MenuKaart();
            List<Model.MenuItem> drankenKaart = new List<Model.MenuItem>();
            Dagdeel d = new Dagdeel();
            
            drankenKaart = m.VulDrankenKaart(Catagorie.dranken, d);

            foreach (Model.MenuItem menuItem in drankenKaart)
            {
                MenuKaart.Items.Add(menuItem.ToString());
            }
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
