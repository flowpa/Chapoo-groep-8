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
            WindowState = FormWindowState.Maximized;
            lbl_clock.Text = DateTime.Now.ToString("HH:mm");
            lbl_date.Text = DateTime.Now.ToString("ddd dd/MM/yyyy");
            bool drank = true;
            vulEersteDGV(drank);
            vulAlleDGV(drank);

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
            int id = Convert.ToInt32(dgv_eerste.CurrentRow.Cells[0].Value);
            bs.BevestigBestelling(id, drank);
            BestellingDrankForm_Load(sender, e);
        }

        private void vulEersteDGV(bool drank)
        {
            dgv_eerste.Rows.Clear();
            dgv_eerste.Columns.Clear();
            dgv_eerste.AutoGenerateColumns = false;
            dgv_eerste.RowHeadersVisible = false;
            dgv_eerste.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgv_eerste.MultiSelect = false;
            dgv_eerste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_eerste.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_eerste.AllowUserToAddRows = false;

            dgv_eerste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 25
            });
            dgv_eerste.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Bestelling",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 75
            });

            List<Bestelling> bestellingen = bs.VulBestellingen(drank);
            for (int i = 0; i < 3 && i < bestellingen.Count; i++)
            {
                dgv_eerste.Rows.Add(bestellingen[i].Id, bestellingen[i].ToString());
            }
        }

        private void vulAlleDGV(bool drank)
        {
            dgv_alle.Rows.Clear();
            dgv_alle.Columns.Clear();
            dgv_alle.AutoGenerateColumns = false;
            dgv_alle.RowHeadersVisible = false;
            dgv_eerste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_alle.MultiSelect = false;
            dgv_alle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_alle.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_alle.AllowUserToAddRows = false;

            dgv_alle.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "ID",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                FillWeight = 25
            });
            dgv_alle.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Bestelling",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 75
            });

            List<Bestelling> bestellingen = bs.VulBestellingen(drank);
            for (int i = 3; i < bestellingen.Count; i++)
            {
                dgv_alle.Rows.Add(bestellingen[i].Id, bestellingen[i].ToString());
            }
        }
    }
}
