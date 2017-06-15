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
            vulEerste();
            vulAlle();
            vulEersteDGV();

            Timer timer = new Timer();
            timer.Interval = (15 * 1000); // 15 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            BestellingDrankForm_Load(sender, e);
        }

        private void vulEerste()
        {
            lv_eerste.Clear();
            lv_eerste.Columns.Add("ID", 30);
            lv_eerste.Columns.Add("Bestellingen", 292);


            List<Bestelling> bestellingen = bs.VulDrankBestellingen();
            for (int i = 0; i < 3 && i < bestellingen.Count; i++)
            {
                string s = bestellingen[i].ToString();

                ListViewItem item = new ListViewItem(bestellingen[i].Id.ToString());
                item.SubItems.Add(s);
                lv_eerste.Items.Add(item);
            }
        }

        private void vulAlle()
        {
            lv_alle.Clear();
            lv_alle.Columns.Add("ID", 30);
            lv_alle.Columns.Add("Bestellingen", 292);
            

            List<Bestelling> bestellingen = bs.VulDrankBestellingen();
            for (int i = 3; i < bestellingen.Count; i++)
            {
                string s = bestellingen[i].ToString();

                ListViewItem item = new ListViewItem(Environment.NewLine, bestellingen[i].Id.ToString());
                item.SubItems.Add(bestellingen[i].ToStringList().ToString());
                lv_alle.Items.Add(item);
            }
        }

        private void btn_annuleren_Click(object sender, EventArgs e)
        {
            BestellingDrankForm_Load(sender, e);
        }

        private void btn_bevestig_Click(object sender, EventArgs e)
        {
            int id = (dynamic)lv_eerste.SelectedItems[0];
            bs.BevestigDrankBestelling(id);
        }

        private void vulEersteDGV()
        {
            dgv_eerste.Rows.Clear();
            dgv_eerste.Columns.Clear();
            dgv_eerste.AutoGenerateColumns = false;
            dgv_eerste.RowHeadersVisible = false;
            dgv_eerste.MultiSelect = false;
            dgv_eerste.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_eerste.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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

            List<Bestelling> bestellingen = bs.VulDrankBestellingen();
            for (int i = 0; i < 3 && i < bestellingen.Count; i++)
            {
                dgv_eerste.Rows.Add(bestellingen[i].ToString());
            }
        }
    }
}
