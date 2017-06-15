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
                
        public TafeloverzichtScherm()
        {
            InitializeComponent();

            btn_Vrijgeven.Enabled = false;

            //HARDCODED VALUE
            int tafelid = 1;

            tService = new TafeloverzichtService();
            t = tService.getTafel(tafelid);

            if (t.IsBezet == false)
            {
                btn_Tafel1.BackColor = Color.Green;            
            }
            else
            {
                btn_Tafel1.BackColor = Color.Tomato;
            }
        }

        public void medewerker(Medewerker m)
        {
            l_huidigeGebruiker.Tag = m;
            l_huidigeGebruiker.Text += m.Naam; 
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            //HARDCODED VALUE
            int tafelid = 1;

            if(btn_Tafel1.BackColor == Color.Green)
            {
                l_huidigeTafel.Text += tafelid;
                btn_Tafel1.BackColor = Color.Tomato;
                btn_Vrijgeven.Enabled = true;        
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
            //HARDCODED VALUE
            int tafelId = 1;
            Tafel t = tService.getTafel(tafelId);
            tService.writeTafelStatus(t.Nummer, t.IsBezet);
        }
    }
}
