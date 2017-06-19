namespace UI
{
    partial class BestellingOpneemScherm
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
            this.BackgroundPannel = new System.Windows.Forms.Panel();
            this.container_tabjes = new System.Windows.Forms.TabControl();
            this.tab_menus = new System.Windows.Forms.TabPage();
            this.tbx_opmerking = new System.Windows.Forms.TextBox();
            this.lv_BesteldeItemlist = new System.Windows.Forms.ListView();
            this.lv_MenuKaart = new System.Windows.Forms.ListView();
            this.btn_OpmerkingBestelscherm = new System.Windows.Forms.Button();
            this.btn_DeleteBestelscherm = new System.Windows.Forms.Button();
            this.btn_AddBestelscherm = new System.Windows.Forms.Button();
            this.btn_Drank = new System.Windows.Forms.Button();
            this.btn_Nagerecht = new System.Windows.Forms.Button();
            this.btn_Tussengerecht = new System.Windows.Forms.Button();
            this.btn_hoofdgerecht = new System.Windows.Forms.Button();
            this.btn_voorgerecht = new System.Windows.Forms.Button();
            this.btn_VorrigeBestelscherm = new System.Windows.Forms.Button();
            this.btn_AnnuleerBestelscherm = new System.Windows.Forms.Button();
            this.btn_VerzendenBestelscherm = new System.Windows.Forms.Button();
            this.tab_Rekeningen = new System.Windows.Forms.TabPage();
            this.lv_geheleBestelling = new System.Windows.Forms.ListView();
            this.btn_betalen = new System.Windows.Forms.Button();
            this.btn_terug = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.BackgroundPannel.SuspendLayout();
            this.container_tabjes.SuspendLayout();
            this.tab_menus.SuspendLayout();
            this.tab_Rekeningen.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPannel
            // 
            this.BackgroundPannel.Controls.Add(this.container_tabjes);
            this.BackgroundPannel.Location = new System.Drawing.Point(-4, -3);
            this.BackgroundPannel.Name = "BackgroundPannel";
            this.BackgroundPannel.Size = new System.Drawing.Size(410, 675);
            this.BackgroundPannel.TabIndex = 3;
            // 
            // container_tabjes
            // 
            this.container_tabjes.Controls.Add(this.tab_menus);
            this.container_tabjes.Controls.Add(this.tab_Rekeningen);
            this.container_tabjes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container_tabjes.ItemSize = new System.Drawing.Size(134, 36);
            this.container_tabjes.Location = new System.Drawing.Point(0, 3);
            this.container_tabjes.MinimumSize = new System.Drawing.Size(134, 36);
            this.container_tabjes.Name = "container_tabjes";
            this.container_tabjes.SelectedIndex = 0;
            this.container_tabjes.Size = new System.Drawing.Size(410, 669);
            this.container_tabjes.TabIndex = 2;
            // 
            // tab_menus
            // 
            this.tab_menus.Controls.Add(this.tbx_opmerking);
            this.tab_menus.Controls.Add(this.lv_BesteldeItemlist);
            this.tab_menus.Controls.Add(this.lv_MenuKaart);
            this.tab_menus.Controls.Add(this.btn_OpmerkingBestelscherm);
            this.tab_menus.Controls.Add(this.btn_DeleteBestelscherm);
            this.tab_menus.Controls.Add(this.btn_AddBestelscherm);
            this.tab_menus.Controls.Add(this.btn_Drank);
            this.tab_menus.Controls.Add(this.btn_Nagerecht);
            this.tab_menus.Controls.Add(this.btn_Tussengerecht);
            this.tab_menus.Controls.Add(this.btn_hoofdgerecht);
            this.tab_menus.Controls.Add(this.btn_voorgerecht);
            this.tab_menus.Controls.Add(this.btn_VorrigeBestelscherm);
            this.tab_menus.Controls.Add(this.btn_AnnuleerBestelscherm);
            this.tab_menus.Controls.Add(this.btn_VerzendenBestelscherm);
            this.tab_menus.Location = new System.Drawing.Point(4, 40);
            this.tab_menus.Name = "tab_menus";
            this.tab_menus.Padding = new System.Windows.Forms.Padding(3);
            this.tab_menus.Size = new System.Drawing.Size(402, 625);
            this.tab_menus.TabIndex = 1;
            this.tab_menus.Text = "Menu\'s";
            this.tab_menus.UseVisualStyleBackColor = true;
            // 
            // tbx_opmerking
            // 
            this.tbx_opmerking.Location = new System.Drawing.Point(56, 225);
            this.tbx_opmerking.Name = "tbx_opmerking";
            this.tbx_opmerking.Size = new System.Drawing.Size(279, 38);
            this.tbx_opmerking.TabIndex = 23;
            // 
            // lv_BesteldeItemlist
            // 
            this.lv_BesteldeItemlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_BesteldeItemlist.FullRowSelect = true;
            this.lv_BesteldeItemlist.Location = new System.Drawing.Point(-1, 368);
            this.lv_BesteldeItemlist.Name = "lv_BesteldeItemlist";
            this.lv_BesteldeItemlist.Size = new System.Drawing.Size(402, 170);
            this.lv_BesteldeItemlist.TabIndex = 22;
            this.lv_BesteldeItemlist.UseCompatibleStateImageBehavior = false;
            this.lv_BesteldeItemlist.View = System.Windows.Forms.View.Details;
            // 
            // lv_MenuKaart
            // 
            this.lv_MenuKaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_MenuKaart.FullRowSelect = true;
            this.lv_MenuKaart.Location = new System.Drawing.Point(0, 51);
            this.lv_MenuKaart.Name = "lv_MenuKaart";
            this.lv_MenuKaart.Size = new System.Drawing.Size(402, 265);
            this.lv_MenuKaart.TabIndex = 21;
            this.lv_MenuKaart.UseCompatibleStateImageBehavior = false;
            this.lv_MenuKaart.View = System.Windows.Forms.View.Details;
            // 
            // btn_OpmerkingBestelscherm
            // 
            this.btn_OpmerkingBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpmerkingBestelscherm.Location = new System.Drawing.Point(269, 314);
            this.btn_OpmerkingBestelscherm.Name = "btn_OpmerkingBestelscherm";
            this.btn_OpmerkingBestelscherm.Size = new System.Drawing.Size(133, 53);
            this.btn_OpmerkingBestelscherm.TabIndex = 20;
            this.btn_OpmerkingBestelscherm.Text = "Opmerking";
            this.btn_OpmerkingBestelscherm.UseVisualStyleBackColor = true;
            this.btn_OpmerkingBestelscherm.Click += new System.EventHandler(this.btn_OpmerkingBestelscherm_Click);
            // 
            // btn_DeleteBestelscherm
            // 
            this.btn_DeleteBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteBestelscherm.Location = new System.Drawing.Point(135, 314);
            this.btn_DeleteBestelscherm.Name = "btn_DeleteBestelscherm";
            this.btn_DeleteBestelscherm.Size = new System.Drawing.Size(133, 53);
            this.btn_DeleteBestelscherm.TabIndex = 19;
            this.btn_DeleteBestelscherm.Text = "Delete";
            this.btn_DeleteBestelscherm.UseVisualStyleBackColor = true;
            this.btn_DeleteBestelscherm.Click += new System.EventHandler(this.btn_DeleteBestelscherm_Click);
            // 
            // btn_AddBestelscherm
            // 
            this.btn_AddBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBestelscherm.Location = new System.Drawing.Point(0, 314);
            this.btn_AddBestelscherm.Name = "btn_AddBestelscherm";
            this.btn_AddBestelscherm.Size = new System.Drawing.Size(133, 53);
            this.btn_AddBestelscherm.TabIndex = 18;
            this.btn_AddBestelscherm.Text = "Add";
            this.btn_AddBestelscherm.UseVisualStyleBackColor = true;
            this.btn_AddBestelscherm.Click += new System.EventHandler(this.btn_AddBestelscherm_Click);
            // 
            // btn_Drank
            // 
            this.btn_Drank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Drank.Location = new System.Drawing.Point(333, 0);
            this.btn_Drank.Name = "btn_Drank";
            this.btn_Drank.Size = new System.Drawing.Size(68, 51);
            this.btn_Drank.TabIndex = 17;
            this.btn_Drank.Text = "Drank";
            this.btn_Drank.UseVisualStyleBackColor = true;
            this.btn_Drank.Click += new System.EventHandler(this.btn_Drank_Click);
            // 
            // btn_Nagerecht
            // 
            this.btn_Nagerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nagerecht.Location = new System.Drawing.Point(242, 0);
            this.btn_Nagerecht.Name = "btn_Nagerecht";
            this.btn_Nagerecht.Size = new System.Drawing.Size(93, 51);
            this.btn_Nagerecht.TabIndex = 16;
            this.btn_Nagerecht.Text = "Nagerecht-";
            this.btn_Nagerecht.UseVisualStyleBackColor = true;
            this.btn_Nagerecht.Click += new System.EventHandler(this.btn_Nagerecht_Click);
            // 
            // btn_Tussengerecht
            // 
            this.btn_Tussengerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tussengerecht.Location = new System.Drawing.Point(152, 0);
            this.btn_Tussengerecht.Name = "btn_Tussengerecht";
            this.btn_Tussengerecht.Size = new System.Drawing.Size(93, 51);
            this.btn_Tussengerecht.TabIndex = 15;
            this.btn_Tussengerecht.Text = "Tussen-";
            this.btn_Tussengerecht.UseVisualStyleBackColor = true;
            this.btn_Tussengerecht.Click += new System.EventHandler(this.btn_Tussengerecht_Click);
            // 
            // btn_hoofdgerecht
            // 
            this.btn_hoofdgerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoofdgerecht.Location = new System.Drawing.Point(76, 0);
            this.btn_hoofdgerecht.Name = "btn_hoofdgerecht";
            this.btn_hoofdgerecht.Size = new System.Drawing.Size(80, 51);
            this.btn_hoofdgerecht.TabIndex = 14;
            this.btn_hoofdgerecht.Text = "Hoofd-";
            this.btn_hoofdgerecht.UseVisualStyleBackColor = true;
            this.btn_hoofdgerecht.Click += new System.EventHandler(this.btn_hoofdgerecht_Click);
            // 
            // btn_voorgerecht
            // 
            this.btn_voorgerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voorgerecht.Location = new System.Drawing.Point(0, 0);
            this.btn_voorgerecht.Name = "btn_voorgerecht";
            this.btn_voorgerecht.Size = new System.Drawing.Size(80, 51);
            this.btn_voorgerecht.TabIndex = 13;
            this.btn_voorgerecht.Text = "Voor-";
            this.btn_voorgerecht.UseVisualStyleBackColor = true;
            this.btn_voorgerecht.Click += new System.EventHandler(this.btn_voorgerecht_Click);
            // 
            // btn_VorrigeBestelscherm
            // 
            this.btn_VorrigeBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VorrigeBestelscherm.Location = new System.Drawing.Point(3, 545);
            this.btn_VorrigeBestelscherm.Name = "btn_VorrigeBestelscherm";
            this.btn_VorrigeBestelscherm.Size = new System.Drawing.Size(126, 54);
            this.btn_VorrigeBestelscherm.TabIndex = 8;
            this.btn_VorrigeBestelscherm.Text = "Vorige";
            this.btn_VorrigeBestelscherm.UseVisualStyleBackColor = true;
            this.btn_VorrigeBestelscherm.Click += new System.EventHandler(this.btn_VorrigeBestelscherm_Click);
            // 
            // btn_AnnuleerBestelscherm
            // 
            this.btn_AnnuleerBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnuleerBestelscherm.Location = new System.Drawing.Point(139, 545);
            this.btn_AnnuleerBestelscherm.Name = "btn_AnnuleerBestelscherm";
            this.btn_AnnuleerBestelscherm.Size = new System.Drawing.Size(126, 54);
            this.btn_AnnuleerBestelscherm.TabIndex = 9;
            this.btn_AnnuleerBestelscherm.Text = "Annuleren";
            this.btn_AnnuleerBestelscherm.UseVisualStyleBackColor = true;
            this.btn_AnnuleerBestelscherm.Click += new System.EventHandler(this.btn_AnnuleerBestelscherm_Click);
            // 
            // btn_VerzendenBestelscherm
            // 
            this.btn_VerzendenBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerzendenBestelscherm.Location = new System.Drawing.Point(273, 545);
            this.btn_VerzendenBestelscherm.Name = "btn_VerzendenBestelscherm";
            this.btn_VerzendenBestelscherm.Size = new System.Drawing.Size(126, 54);
            this.btn_VerzendenBestelscherm.TabIndex = 10;
            this.btn_VerzendenBestelscherm.Text = "Verzenden";
            this.btn_VerzendenBestelscherm.UseVisualStyleBackColor = true;
            this.btn_VerzendenBestelscherm.Click += new System.EventHandler(this.btn_VerzendenBestelscherm_Click);
            // 
            // tab_Rekeningen
            // 
            this.tab_Rekeningen.Controls.Add(this.lv_geheleBestelling);
            this.tab_Rekeningen.Controls.Add(this.btn_betalen);
            this.tab_Rekeningen.Controls.Add(this.btn_terug);
            this.tab_Rekeningen.Controls.Add(this.btn_refresh);
            this.tab_Rekeningen.Location = new System.Drawing.Point(4, 40);
            this.tab_Rekeningen.Name = "tab_Rekeningen";
            this.tab_Rekeningen.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rekeningen.Size = new System.Drawing.Size(402, 625);
            this.tab_Rekeningen.TabIndex = 2;
            this.tab_Rekeningen.Text = "Bestelling";
            this.tab_Rekeningen.UseVisualStyleBackColor = true;
            // 
            // lv_geheleBestelling
            // 
            this.lv_geheleBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_geheleBestelling.FullRowSelect = true;
            this.lv_geheleBestelling.Location = new System.Drawing.Point(0, 0);
            this.lv_geheleBestelling.Name = "lv_geheleBestelling";
            this.lv_geheleBestelling.Size = new System.Drawing.Size(399, 539);
            this.lv_geheleBestelling.TabIndex = 12;
            this.lv_geheleBestelling.UseCompatibleStateImageBehavior = false;
            this.lv_geheleBestelling.View = System.Windows.Forms.View.Details;
            // 
            // btn_betalen
            // 
            this.btn_betalen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_betalen.Location = new System.Drawing.Point(273, 545);
            this.btn_betalen.Name = "btn_betalen";
            this.btn_betalen.Size = new System.Drawing.Size(126, 54);
            this.btn_betalen.TabIndex = 11;
            this.btn_betalen.Text = "Betalen";
            this.btn_betalen.UseVisualStyleBackColor = true;
            this.btn_betalen.Click += new System.EventHandler(this.btn_betalen_Click);
            // 
            // btn_terug
            // 
            this.btn_terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terug.Location = new System.Drawing.Point(3, 545);
            this.btn_terug.Name = "btn_terug";
            this.btn_terug.Size = new System.Drawing.Size(126, 54);
            this.btn_terug.TabIndex = 10;
            this.btn_terug.Text = "Terug";
            this.btn_terug.UseVisualStyleBackColor = true;
            this.btn_terug.Click += new System.EventHandler(this.btn_terug_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(138, 545);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(126, 54);
            this.btn_refresh.TabIndex = 9;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // BestellingOpneemScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 650);
            this.Controls.Add(this.BackgroundPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BestellingOpneemScherm";
            this.Text = "BestellingOpneemScherm";
            this.BackgroundPannel.ResumeLayout(false);
            this.container_tabjes.ResumeLayout(false);
            this.tab_menus.ResumeLayout(false);
            this.tab_menus.PerformLayout();
            this.tab_Rekeningen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BackgroundPannel;
        private System.Windows.Forms.TabControl container_tabjes;
        private System.Windows.Forms.TabPage tab_menus;
        private System.Windows.Forms.TabPage tab_Rekeningen;
        private System.Windows.Forms.Button btn_Drank;
        private System.Windows.Forms.Button btn_Nagerecht;
        private System.Windows.Forms.Button btn_Tussengerecht;
        private System.Windows.Forms.Button btn_hoofdgerecht;
        private System.Windows.Forms.Button btn_voorgerecht;
        private System.Windows.Forms.Button btn_VorrigeBestelscherm;
        private System.Windows.Forms.Button btn_AnnuleerBestelscherm;
        private System.Windows.Forms.Button btn_VerzendenBestelscherm;
        private System.Windows.Forms.Button btn_AddBestelscherm;
        private System.Windows.Forms.Button btn_OpmerkingBestelscherm;
        private System.Windows.Forms.Button btn_DeleteBestelscherm;
        private System.Windows.Forms.ListView lv_MenuKaart;
        private System.Windows.Forms.ListView lv_BesteldeItemlist;
        private System.Windows.Forms.TextBox tbx_opmerking;
        private System.Windows.Forms.Button btn_DeleteBestellingTab;
        private System.Windows.Forms.Button btn_VorrigeBestellingTab;
        private System.Windows.Forms.ListView lv_HuidigeBestelling;
        private System.Windows.Forms.TabPage tab_Bestelling;
        private System.Windows.Forms.Button btn_betalen;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ListView lv_geheleBestelling;
    }
}