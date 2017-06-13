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
            this.tab_Tafels = new System.Windows.Forms.TabPage();
            this.tab_menus = new System.Windows.Forms.TabPage();
            this.Bestelde_itemlist = new System.Windows.Forms.ListView();
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
            this.BackgroundPannel.SuspendLayout();
            this.container_tabjes.SuspendLayout();
            this.tab_menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPannel
            // 
            this.BackgroundPannel.Controls.Add(this.container_tabjes);
            this.BackgroundPannel.Location = new System.Drawing.Point(-3, -2);
            this.BackgroundPannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackgroundPannel.Name = "BackgroundPannel";
            this.BackgroundPannel.Size = new System.Drawing.Size(308, 548);
            this.BackgroundPannel.TabIndex = 3;
            // 
            // container_tabjes
            // 
            this.container_tabjes.Controls.Add(this.tab_Tafels);
            this.container_tabjes.Controls.Add(this.tab_menus);
            this.container_tabjes.Controls.Add(this.tab_Rekeningen);
            this.container_tabjes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container_tabjes.ItemSize = new System.Drawing.Size(134, 36);
            this.container_tabjes.Location = new System.Drawing.Point(0, 2);
            this.container_tabjes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.container_tabjes.MinimumSize = new System.Drawing.Size(100, 29);
            this.container_tabjes.Name = "container_tabjes";
            this.container_tabjes.SelectedIndex = 0;
            this.container_tabjes.Size = new System.Drawing.Size(308, 544);
            this.container_tabjes.TabIndex = 2;
            // 
            // tab_Tafels
            // 
            this.tab_Tafels.Location = new System.Drawing.Point(4, 40);
            this.tab_Tafels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Tafels.Name = "tab_Tafels";
            this.tab_Tafels.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Tafels.Size = new System.Drawing.Size(300, 500);
            this.tab_Tafels.TabIndex = 3;
            this.tab_Tafels.Text = "Tafels";
            this.tab_Tafels.UseVisualStyleBackColor = true;
            // 
            // tab_menus
            // 
            this.tab_menus.Controls.Add(this.Bestelde_itemlist);
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
            this.tab_menus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_menus.Name = "tab_menus";
            this.tab_menus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_menus.Size = new System.Drawing.Size(300, 500);
            this.tab_menus.TabIndex = 1;
            this.tab_menus.Text = "Menu\'s";
            this.tab_menus.UseVisualStyleBackColor = true;
            // 
            // Bestelde_itemlist
            // 
            this.Bestelde_itemlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bestelde_itemlist.Location = new System.Drawing.Point(-1, 299);
            this.Bestelde_itemlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bestelde_itemlist.Name = "Bestelde_itemlist";
            this.Bestelde_itemlist.Size = new System.Drawing.Size(302, 161);
            this.Bestelde_itemlist.TabIndex = 22;
            this.Bestelde_itemlist.UseCompatibleStateImageBehavior = false;
            // 
            // lv_MenuKaart
            // 
            this.lv_MenuKaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_MenuKaart.Location = new System.Drawing.Point(-2, 33);
            this.lv_MenuKaart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv_MenuKaart.Name = "lv_MenuKaart";
            this.lv_MenuKaart.Size = new System.Drawing.Size(302, 218);
            this.lv_MenuKaart.TabIndex = 21;
            this.lv_MenuKaart.UseCompatibleStateImageBehavior = false;
            this.lv_MenuKaart.View = System.Windows.Forms.View.Details;
            // 
            // btn_OpmerkingBestelscherm
            // 
            this.btn_OpmerkingBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpmerkingBestelscherm.Location = new System.Drawing.Point(202, 255);
            this.btn_OpmerkingBestelscherm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_OpmerkingBestelscherm.Name = "btn_OpmerkingBestelscherm";
            this.btn_OpmerkingBestelscherm.Size = new System.Drawing.Size(100, 43);
            this.btn_OpmerkingBestelscherm.TabIndex = 20;
            this.btn_OpmerkingBestelscherm.Text = "Opmerking";
            this.btn_OpmerkingBestelscherm.UseVisualStyleBackColor = true;
            this.btn_OpmerkingBestelscherm.Click += new System.EventHandler(this.btn_OpmerkingBestelscherm_Click);
            // 
            // btn_DeleteBestelscherm
            // 
            this.btn_DeleteBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteBestelscherm.Location = new System.Drawing.Point(101, 255);
            this.btn_DeleteBestelscherm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteBestelscherm.Name = "btn_DeleteBestelscherm";
            this.btn_DeleteBestelscherm.Size = new System.Drawing.Size(100, 43);
            this.btn_DeleteBestelscherm.TabIndex = 19;
            this.btn_DeleteBestelscherm.Text = "Delete";
            this.btn_DeleteBestelscherm.UseVisualStyleBackColor = true;
            this.btn_DeleteBestelscherm.Click += new System.EventHandler(this.btn_DeleteBestelscherm_Click);
            // 
            // btn_AddBestelscherm
            // 
            this.btn_AddBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBestelscherm.Location = new System.Drawing.Point(0, 255);
            this.btn_AddBestelscherm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddBestelscherm.Name = "btn_AddBestelscherm";
            this.btn_AddBestelscherm.Size = new System.Drawing.Size(100, 43);
            this.btn_AddBestelscherm.TabIndex = 18;
            this.btn_AddBestelscherm.Text = "Add";
            this.btn_AddBestelscherm.UseVisualStyleBackColor = true;
            this.btn_AddBestelscherm.Click += new System.EventHandler(this.btn_AddBestelscherm_Click);
            // 
            // btn_Drank
            // 
            this.btn_Drank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Drank.Location = new System.Drawing.Point(250, 0);
            this.btn_Drank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Drank.Name = "btn_Drank";
            this.btn_Drank.Size = new System.Drawing.Size(51, 41);
            this.btn_Drank.TabIndex = 17;
            this.btn_Drank.Text = "Drank";
            this.btn_Drank.UseVisualStyleBackColor = true;
            this.btn_Drank.Click += new System.EventHandler(this.btn_Drank_Click);
            // 
            // btn_Nagerecht
            // 
            this.btn_Nagerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nagerecht.Location = new System.Drawing.Point(182, 0);
            this.btn_Nagerecht.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Nagerecht.Name = "btn_Nagerecht";
            this.btn_Nagerecht.Size = new System.Drawing.Size(70, 41);
            this.btn_Nagerecht.TabIndex = 16;
            this.btn_Nagerecht.Text = "Nagerecht-";
            this.btn_Nagerecht.UseVisualStyleBackColor = true;
            this.btn_Nagerecht.Click += new System.EventHandler(this.btn_Nagerecht_Click);
            // 
            // btn_Tussengerecht
            // 
            this.btn_Tussengerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tussengerecht.Location = new System.Drawing.Point(114, 0);
            this.btn_Tussengerecht.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Tussengerecht.Name = "btn_Tussengerecht";
            this.btn_Tussengerecht.Size = new System.Drawing.Size(70, 41);
            this.btn_Tussengerecht.TabIndex = 15;
            this.btn_Tussengerecht.Text = "Tussen-";
            this.btn_Tussengerecht.UseVisualStyleBackColor = true;
            this.btn_Tussengerecht.Click += new System.EventHandler(this.btn_Tussengerecht_Click);
            // 
            // btn_hoofdgerecht
            // 
            this.btn_hoofdgerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoofdgerecht.Location = new System.Drawing.Point(57, 0);
            this.btn_hoofdgerecht.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_hoofdgerecht.Name = "btn_hoofdgerecht";
            this.btn_hoofdgerecht.Size = new System.Drawing.Size(60, 41);
            this.btn_hoofdgerecht.TabIndex = 14;
            this.btn_hoofdgerecht.Text = "Hoofd-";
            this.btn_hoofdgerecht.UseVisualStyleBackColor = true;
            this.btn_hoofdgerecht.Click += new System.EventHandler(this.btn_hoofdgerecht_Click);
            // 
            // btn_voorgerecht
            // 
            this.btn_voorgerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voorgerecht.Location = new System.Drawing.Point(0, 0);
            this.btn_voorgerecht.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_voorgerecht.Name = "btn_voorgerecht";
            this.btn_voorgerecht.Size = new System.Drawing.Size(60, 41);
            this.btn_voorgerecht.TabIndex = 13;
            this.btn_voorgerecht.Text = "Voor-";
            this.btn_voorgerecht.UseVisualStyleBackColor = true;
            this.btn_voorgerecht.Click += new System.EventHandler(this.btn_voorgerecht_Click);
            // 
            // btn_VorrigeBestelscherm
            // 
            this.btn_VorrigeBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VorrigeBestelscherm.Location = new System.Drawing.Point(-3, 440);
            this.btn_VorrigeBestelscherm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_VorrigeBestelscherm.Name = "btn_VorrigeBestelscherm";
            this.btn_VorrigeBestelscherm.Size = new System.Drawing.Size(104, 56);
            this.btn_VorrigeBestelscherm.TabIndex = 8;
            this.btn_VorrigeBestelscherm.Text = "Vorrige";
            this.btn_VorrigeBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_AnnuleerBestelscherm
            // 
            this.btn_AnnuleerBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnuleerBestelscherm.Location = new System.Drawing.Point(98, 440);
            this.btn_AnnuleerBestelscherm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AnnuleerBestelscherm.Name = "btn_AnnuleerBestelscherm";
            this.btn_AnnuleerBestelscherm.Size = new System.Drawing.Size(104, 56);
            this.btn_AnnuleerBestelscherm.TabIndex = 9;
            this.btn_AnnuleerBestelscherm.Text = "Annuleren";
            this.btn_AnnuleerBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendenBestelscherm
            // 
            this.btn_VerzendenBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerzendenBestelscherm.Location = new System.Drawing.Point(197, 440);
            this.btn_VerzendenBestelscherm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_VerzendenBestelscherm.Name = "btn_VerzendenBestelscherm";
            this.btn_VerzendenBestelscherm.Size = new System.Drawing.Size(104, 56);
            this.btn_VerzendenBestelscherm.TabIndex = 10;
            this.btn_VerzendenBestelscherm.Text = "Verzenden";
            this.btn_VerzendenBestelscherm.UseVisualStyleBackColor = true;
            // 
            // tab_Rekeningen
            // 
            this.tab_Rekeningen.Location = new System.Drawing.Point(4, 40);
            this.tab_Rekeningen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Rekeningen.Name = "tab_Rekeningen";
            this.tab_Rekeningen.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Rekeningen.Size = new System.Drawing.Size(300, 500);
            this.tab_Rekeningen.TabIndex = 2;
            this.tab_Rekeningen.Text = "Rekeningen";
            this.tab_Rekeningen.UseVisualStyleBackColor = true;
            // 
            // BestellingOpneemScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 528);
            this.Controls.Add(this.BackgroundPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BestellingOpneemScherm";
            this.Text = "BestellingOpneemScherm";
            this.BackgroundPannel.ResumeLayout(false);
            this.container_tabjes.ResumeLayout(false);
            this.tab_menus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BackgroundPannel;
        private System.Windows.Forms.TabControl container_tabjes;
        private System.Windows.Forms.TabPage tab_menus;
        private System.Windows.Forms.TabPage tab_Rekeningen;
        private System.Windows.Forms.TabPage tab_Tafels;
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
        private System.Windows.Forms.ListView Bestelde_itemlist;
    }
}