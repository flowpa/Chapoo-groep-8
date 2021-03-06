﻿namespace UI
{
    partial class BestellingEtenForm
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
            this.lbl_bestellingen = new System.Windows.Forms.Label();
            this.btn_annuleren = new System.Windows.Forms.Button();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.lbl_naam = new System.Windows.Forms.Label();
            this.btn_bevestig = new System.Windows.Forms.Button();
            this.lv_alle = new System.Windows.Forms.ListView();
            this.lv_eerste = new System.Windows.Forms.ListView();
            this.lbl_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bestellingen
            // 
            this.lbl_bestellingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bestellingen.Location = new System.Drawing.Point(12, 12);
            this.lbl_bestellingen.Name = "lbl_bestellingen";
            this.lbl_bestellingen.Size = new System.Drawing.Size(648, 123);
            this.lbl_bestellingen.TabIndex = 14;
            this.lbl_bestellingen.Text = "Bestellingen";
            this.lbl_bestellingen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_annuleren
            // 
            this.btn_annuleren.BackColor = System.Drawing.Color.Red;
            this.btn_annuleren.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuleren.ForeColor = System.Drawing.Color.White;
            this.btn_annuleren.Location = new System.Drawing.Point(1320, 726);
            this.btn_annuleren.Name = "btn_annuleren";
            this.btn_annuleren.Size = new System.Drawing.Size(562, 270);
            this.btn_annuleren.TabIndex = 13;
            this.btn_annuleren.Text = "Annuleren";
            this.btn_annuleren.UseVisualStyleBackColor = false;
            this.btn_annuleren.Click += new System.EventHandler(this.btn_annuleren_Click);
            // 
            // lbl_clock
            // 
            this.lbl_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.Location = new System.Drawing.Point(1320, 138);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(562, 137);
            this.lbl_clock.TabIndex = 12;
            this.lbl_clock.Text = "88:88";
            this.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_naam
            // 
            this.lbl_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naam.Location = new System.Drawing.Point(1320, 12);
            this.lbl_naam.Name = "lbl_naam";
            this.lbl_naam.Size = new System.Drawing.Size(562, 137);
            this.lbl_naam.TabIndex = 11;
            this.lbl_naam.Text = "CHAPOO";
            this.lbl_naam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_bevestig
            // 
            this.btn_bevestig.BackColor = System.Drawing.Color.Green;
            this.btn_bevestig.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bevestig.ForeColor = System.Drawing.Color.White;
            this.btn_bevestig.Location = new System.Drawing.Point(1320, 415);
            this.btn_bevestig.Name = "btn_bevestig";
            this.btn_bevestig.Size = new System.Drawing.Size(562, 270);
            this.btn_bevestig.TabIndex = 10;
            this.btn_bevestig.Text = "Bevestigen";
            this.btn_bevestig.UseVisualStyleBackColor = false;
            this.btn_bevestig.Click += new System.EventHandler(this.btn_bevestig_Click);
            // 
            // lv_alle
            // 
            this.lv_alle.FullRowSelect = true;
            this.lv_alle.Location = new System.Drawing.Point(666, 12);
            this.lv_alle.Name = "lv_alle";
            this.lv_alle.Size = new System.Drawing.Size(647, 984);
            this.lv_alle.TabIndex = 9;
            this.lv_alle.UseCompatibleStateImageBehavior = false;
            this.lv_alle.View = System.Windows.Forms.View.Details;
            // 
            // lv_eerste
            // 
            this.lv_eerste.FullRowSelect = true;
            this.lv_eerste.Location = new System.Drawing.Point(13, 138);
            this.lv_eerste.Name = "lv_eerste";
            this.lv_eerste.Size = new System.Drawing.Size(647, 858);
            this.lv_eerste.TabIndex = 8;
            this.lv_eerste.UseCompatibleStateImageBehavior = false;
            this.lv_eerste.View = System.Windows.Forms.View.Details;
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1340, 275);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(542, 137);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "DAG DD/MM/JJJJ";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BestellingEtenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_bestellingen);
            this.Controls.Add(this.btn_annuleren);
            this.Controls.Add(this.lbl_clock);
            this.Controls.Add(this.lbl_naam);
            this.Controls.Add(this.btn_bevestig);
            this.Controls.Add(this.lv_alle);
            this.Controls.Add(this.lv_eerste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BestellingEtenForm";
            this.ShowIcon = false;
            this.Text = "BestellingDrankForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BestellingEtenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_bestellingen;
        private System.Windows.Forms.Button btn_annuleren;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Label lbl_naam;
        private System.Windows.Forms.Button btn_bevestig;
        private System.Windows.Forms.ListView lv_alle;
        private System.Windows.Forms.ListView lv_eerste;
        private System.Windows.Forms.Label lbl_date;
    }
}