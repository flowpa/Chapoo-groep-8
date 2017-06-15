namespace UI
{
    partial class BestellingDrankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_bevestig = new System.Windows.Forms.Button();
            this.lbl_naam = new System.Windows.Forms.Label();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.btn_annuleren = new System.Windows.Forms.Button();
            this.lbl_bestellingen = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dgv_eerste = new System.Windows.Forms.DataGridView();
            this.dgv_alle = new System.Windows.Forms.DataGridView();
            this.btn_afmelden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eerste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bevestig
            // 
            this.btn_bevestig.BackColor = System.Drawing.Color.Green;
            this.btn_bevestig.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bevestig.ForeColor = System.Drawing.Color.White;
            this.btn_bevestig.Location = new System.Drawing.Point(1320, 415);
            this.btn_bevestig.Name = "btn_bevestig";
            this.btn_bevestig.Size = new System.Drawing.Size(562, 225);
            this.btn_bevestig.TabIndex = 2;
            this.btn_bevestig.Text = "Bevestigen";
            this.btn_bevestig.UseVisualStyleBackColor = false;
            this.btn_bevestig.Click += new System.EventHandler(this.btn_bevestig_Click);
            // 
            // lbl_naam
            // 
            this.lbl_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naam.Location = new System.Drawing.Point(1320, 13);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.Size = new System.Drawing.Size(562, 137);
            this.lbl_naam.TabIndex = 4;
            this.lbl_naam.Text = "CHAPOO";
            this.lbl_naam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clock
            // 
            this.lbl_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.Location = new System.Drawing.Point(1319, 139);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(562, 137);
            this.lbl_clock.TabIndex = 5;
            this.lbl_clock.Text = "88:88";
            this.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_annuleren
            // 
            this.btn_annuleren.BackColor = System.Drawing.Color.Red;
            this.btn_annuleren.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuleren.ForeColor = System.Drawing.Color.White;
            this.btn_annuleren.Location = new System.Drawing.Point(1320, 666);
            this.btn_annuleren.Name = "btn_annuleren";
            this.btn_annuleren.Size = new System.Drawing.Size(562, 225);
            this.btn_annuleren.TabIndex = 6;
            this.btn_annuleren.Text = "Annuleren";
            this.btn_annuleren.UseVisualStyleBackColor = false;
            this.btn_annuleren.Click += new System.EventHandler(this.btn_annuleren_Click);
            // 
            // lbl_bestellingen
            // 
            this.lbl_bestellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bestellingen.Location = new System.Drawing.Point(12, 13);
            this.lbl_bestellingen.Name = "lbl_bestellingen";
            this.lbl_bestellingen.Size = new System.Drawing.Size(648, 123);
            this.lbl_bestellingen.TabIndex = 7;
            this.lbl_bestellingen.Text = "Bestellingen";
            this.lbl_bestellingen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1339, 267);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(542, 137);
            this.lbl_date.TabIndex = 16;
            this.lbl_date.Text = "DAG DD/MM/JJJJ";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_eerste
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_eerste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_eerste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eerste.Location = new System.Drawing.Point(28, 117);
            this.dgv_eerste.MultiSelect = false;
            this.dgv_eerste.Name = "dgv_eerste";
            this.dgv_eerste.ReadOnly = true;
            this.dgv_eerste.RowTemplate.Height = 33;
            this.dgv_eerste.Size = new System.Drawing.Size(632, 871);
            this.dgv_eerste.TabIndex = 17;
            // 
            // dgv_alle
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_alle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alle.Location = new System.Drawing.Point(681, 22);
            this.dgv_alle.Name = "dgv_alle";
            this.dgv_alle.RowTemplate.Height = 33;
            this.dgv_alle.Size = new System.Drawing.Size(632, 975);
            this.dgv_alle.TabIndex = 18;
            // 
            // btn_afmelden
            // 
            this.btn_afmelden.Location = new System.Drawing.Point(1320, 926);
            this.btn_afmelden.Name = "btn_afmelden";
            this.btn_afmelden.Size = new System.Drawing.Size(562, 71);
            this.btn_afmelden.TabIndex = 22;
            this.btn_afmelden.Text = "Afmelden";
            this.btn_afmelden.UseVisualStyleBackColor = true;
            this.btn_afmelden.Click += new System.EventHandler(this.btn_afmelden_Click);
            // 
            // BestellingDrankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.ControlBox = false;
            this.Controls.Add(this.btn_afmelden);
            this.Controls.Add(this.dgv_alle);
            this.Controls.Add(this.dgv_eerste);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_bestellingen);
            this.Controls.Add(this.btn_annuleren);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.lbl_naam);
            this.Controls.Add(this.btn_bevestig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BestellingDrankForm";
            this.ShowIcon = false;
            this.Text = "BestellingDrankForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BestellingDrankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eerste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_bevestig;
        private System.Windows.Forms.Label lbl_naam;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Button btn_annuleren;
        private System.Windows.Forms.Label lbl_bestellingen;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DataGridView dgv_eerste;
        private System.Windows.Forms.DataGridView dgv_alle;
        private System.Windows.Forms.Button btn_afmelden;
    }
}