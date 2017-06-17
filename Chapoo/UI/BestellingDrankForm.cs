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
    public partial class BestellingDrankForm : Form
    {
        private BestellingService bs = new BestellingService();

        public BestellingDrankForm()
        {
            InitializeComponent();
        }

        private void BestellingDrankForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            lbl_clock.Text = DateTime.Now.ToString("HH:mm");
            lbl_date.Text = DateTime.Now.ToString("ddd dd/MM/yyyy");
            bool drank = true;
            vulEersteDGV(drank);
            vulTweedeDGV(drank);

            Timer timer = new Timer();
            timer.Interval = (15 * 1000); // 15 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BestellingDrankForm_Load(sender, e);
        }

        private void btn_annuleren_Click(object sender, EventArgs e)
        {
            BestellingDrankForm_Load(sender, e);
        }

        private void btn_bevestig_Click(object sender, EventArgs e)
        {
            bool drank = true;
            int c = dgv_eerste.SelectedRows.Count; 
            if (c > 0)
            {
                int id = Convert.ToInt32(dgv_eerste.CurrentRow.Cells[0].Value);
                bs.BevestigBestelling(id, drank);
            }

            BestellingDrankForm_Load(sender, e);
        }

        private void btn_afmelden_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inlogscherm inlog = new Inlogscherm();
            inlog.Closed += (s, args) => this.Close();
            inlog.Show();
            inlog.BringToFront();
        }

        private void vulEersteDGV(bool drank)
        {
            dgv_eerste.Rows.Clear();
            dgv_eerste.Columns.Clear();
            dgv_eerste.AutoGenerateColumns = false;
            dgv_eerste.RowHeadersVisible = false;
            dgv_eerste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_eerste.MultiSelect = false;
            dgv_eerste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_eerste.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_eerste.AllowUserToAddRows = false;

            dgv_eerste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 25,


            });
            dgv_eerste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Bestelling",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 75
            });
            bool status = false;
            List<Bestelling> bestellingen = bs.VulBestellingen(drank, status);
            foreach (Bestelling b in bestellingen)
                dgv_eerste.Rows.Add(b.Id, b.ToString());
        }

        private void vulTweedeDGV(bool drank)
        {
            dgv_tweede.Rows.Clear();
            dgv_tweede.Columns.Clear();
            dgv_tweede.AutoGenerateColumns = false;
            dgv_tweede.RowHeadersVisible = false;
            dgv_tweede.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_tweede.MultiSelect = false;
            dgv_tweede.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_tweede.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_tweede.AllowUserToAddRows = false;

            dgv_tweede.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 25
            });
            dgv_tweede.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Bestelling",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 75
            });
            bool status = true;
            List<Bestelling> bestellingen = bs.VulBestellingen(drank, status);
            foreach(Bestelling b in bestellingen)
                dgv_tweede.Rows.Add(b.Id, b.ToString());
        }
    }
}
