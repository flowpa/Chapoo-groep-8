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
        private Tafel t;
        private int tafelId;
        private bool isBezet;

        public TafeloverzichtScherm()
        {
            InitializeComponent();

            btn_Vrijgeven.Enabled = false;
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
        }

        private void checkBezettenTafels(Button b, int tafelId)
        {
            
                tService = new TafeloverzichtService();
                t = tService.getTafel(tafelId);
                b.Tag = t; 

                if (t.IsBezet == true)
                {
                    b.BackColor = Color.Tomato;
                }
                else
                {
                    b.BackColor = Color.Green;
                }
            
        }

        //methode: tafelid meegeven tafel ophalen 
        public void medewerker(Medewerker m)
        {
            l_huidigeGebruiker.Tag = m;
            l_huidigeGebruiker.Text += m.Naam;
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel1.Tag; 
            tafelButton(tafel.Nummer, btn_Tafel1, tafel);
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel2.Tag;
            tafelButton(tafel.Nummer, btn_Tafel2, tafel);
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel3.Tag;
            tafelButton(tafel.Nummer, btn_Tafel3, tafel);
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel4.Tag;
            tafelButton(tafel.Nummer, btn_Tafel4, tafel);
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel5.Tag;
            tafelButton(tafel.Nummer, btn_Tafel5, tafel);
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel6.Tag;
            tafelButton(tafel.Nummer, btn_Tafel6, tafel);
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel7.Tag;
            tafelButton(tafel.Nummer, btn_Tafel7, tafel);
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel8.Tag;
            tafelButton(tafel.Nummer, btn_Tafel8, tafel);
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel9.Tag;
            tafelButton(tafel.Nummer, btn_Tafel9, tafel);
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            Tafel tafel = (Tafel)btn_Tafel10.Tag;
            tafelButton(tafel.Nummer, btn_Tafel10, tafel);
        }

        private void tafelButton(int tafelid, Button b, Tafel tafel)
        {
            //GREEN = 0 = FALSE
            //TOMATO = 1 = TRUE
            l_huidigeTafel.Text = "Geselecteerde tafel = " + tafel.Nummer;

            if (t.IsBezet == true) //TOMATO
            {
                tService.writeTafelStatus(tafelid, isBezet);
            }

            else //GREEN
            {
                tafel.IsBezet = false;
                b.BackColor = Color.Tomato;
                btn_Vrijgeven.Enabled = true;
                tService.writeTafelStatus(tafelid, isBezet);
            }
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            inlogForm = new Inlogscherm();
            this.Hide();
            inlogForm.ShowDialog();
        }

        private void btn_Vrijgeven_Click(object sender, EventArgs e)
        {
            //GREEN = 0 = FALSE
            //TOMATO = 1 = TRUE

            for (int tafelId = 1; tafelId < 10; tafelId++)
            {
                t.IsBezet = false;
                tService.writeTafelStatus(t.Nummer, t.IsBezet);
                btn_Tafel1.BackColor = Color.Green;
                btn_Tafel2.BackColor = Color.Green;
                btn_Tafel3.BackColor = Color.Green;
                btn_Tafel4.BackColor = Color.Green;
                btn_Tafel5.BackColor = Color.Green;
                btn_Tafel6.BackColor = Color.Green;
                btn_Tafel7.BackColor = Color.Green;
                btn_Tafel8.BackColor = Color.Green;
                btn_Tafel9.BackColor = Color.Green;
                btn_Tafel10.BackColor = Color.Green;

                btn_Vrijgeven.Enabled = false;
            }
        }

        
    }
}
