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
            this.tbx_opmerking = new System.Windows.Forms.TextBox();
            this.btn_addOpmerking = new System.Windows.Forms.Button();
            this.BackgroundPannel.SuspendLayout();
            this.container_tabjes.SuspendLayout();
            this.tab_menus.SuspendLayout();
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
            this.container_tabjes.Controls.Add(this.tab_Tafels);
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
            // tab_Tafels
            // 
            this.tab_Tafels.Location = new System.Drawing.Point(4, 40);
            this.tab_Tafels.Name = "tab_Tafels";
            this.tab_Tafels.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tafels.Size = new System.Drawing.Size(402, 625);
            this.tab_Tafels.TabIndex = 3;
            this.tab_Tafels.Text = "Tafels";
            this.tab_Tafels.UseVisualStyleBackColor = true;
            // 
            // tab_menus
            // 
            this.tab_menus.Controls.Add(this.btn_addOpmerking);
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
            // lv_BesteldeItemlist
            // 
            this.lv_BesteldeItemlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_BesteldeItemlist.FullRowSelect = true;
            this.lv_BesteldeItemlist.Location = new System.Drawing.Point(-1, 368);
            this.lv_BesteldeItemlist.Name = "lv_BesteldeItemlist";
            this.lv_BesteldeItemlist.Size = new System.Drawing.Size(402, 189);
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
            this.btn_VorrigeBestelscherm.Location = new System.Drawing.Point(0, 556);
            this.btn_VorrigeBestelscherm.Name = "btn_VorrigeBestelscherm";
            this.btn_VorrigeBestelscherm.Size = new System.Drawing.Size(133, 54);
            this.btn_VorrigeBestelscherm.TabIndex = 8;
            this.btn_VorrigeBestelscherm.Text = "Vorrige";
            this.btn_VorrigeBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_AnnuleerBestelscherm
            // 
            this.btn_AnnuleerBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnuleerBestelscherm.Location = new System.Drawing.Point(135, 556);
            this.btn_AnnuleerBestelscherm.Name = "btn_AnnuleerBestelscherm";
            this.btn_AnnuleerBestelscherm.Size = new System.Drawing.Size(133, 54);
            this.btn_AnnuleerBestelscherm.TabIndex = 9;
            this.btn_AnnuleerBestelscherm.Text = "Annuleren";
            this.btn_AnnuleerBestelscherm.UseVisualStyleBackColor = true;
            this.btn_AnnuleerBestelscherm.Click += new System.EventHandler(this.btn_AnnuleerBestelscherm_Click);
            // 
            // btn_VerzendenBestelscherm
            // 
            this.btn_VerzendenBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerzendenBestelscherm.Location = new System.Drawing.Point(269, 556);
            this.btn_VerzendenBestelscherm.Name = "btn_VerzendenBestelscherm";
            this.btn_VerzendenBestelscherm.Size = new System.Drawing.Size(133, 53);
            this.btn_VerzendenBestelscherm.TabIndex = 10;
            this.btn_VerzendenBestelscherm.Text = "Verzenden";
            this.btn_VerzendenBestelscherm.UseVisualStyleBackColor = true;
            this.btn_VerzendenBestelscherm.Click += new System.EventHandler(this.btn_VerzendenBestelscherm_Click);
            // 
            // tab_Rekeningen
            // 
            this.tab_Rekeningen.Location = new System.Drawing.Point(4, 40);
            this.tab_Rekeningen.Name = "tab_Rekeningen";
            this.tab_Rekeningen.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rekeningen.Size = new System.Drawing.Size(402, 625);
            this.tab_Rekeningen.TabIndex = 2;
            this.tab_Rekeningen.Text = "Bestellingen";
            this.tab_Rekeningen.UseVisualStyleBackColor = true;
            // 
            // tbx_opmerking
            // 
            this.tbx_opmerking.Location = new System.Drawing.Point(24, 226);
            this.tbx_opmerking.Name = "tbx_opmerking";
            this.tbx_opmerking.Size = new System.Drawing.Size(279, 38);
            this.tbx_opmerking.TabIndex = 23;
            // 
            // btn_addOpmerking
            // 
            this.btn_addOpmerking.Location = new System.Drawing.Point(310, 226);
            this.btn_addOpmerking.Name = "btn_addOpmerking";
            this.btn_addOpmerking.Size = new System.Drawing.Size(75, 38);
            this.btn_addOpmerking.TabIndex = 24;
            this.btn_addOpmerking.Text = "add";
            this.btn_addOpmerking.UseVisualStyleBackColor = true;
            this.btn_addOpmerking.Click += new System.EventHandler(this.btn_addOpmerking_Click);
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
        private System.Windows.Forms.ListView lv_BesteldeItemlist;
        private System.Windows.Forms.TextBox tbx_opmerking;
        private System.Windows.Forms.Button btn_addOpmerking;
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
            this.tab_Bestelling = new System.Windows.Forms.TabPage();
            this.btn_DeleteBestellingTab = new System.Windows.Forms.Button();
            this.btn_VorrigeBestellingTab = new System.Windows.Forms.Button();
            this.lv_HuidigeBestelling = new System.Windows.Forms.ListView();
            this.BackgroundPannel.SuspendLayout();
            this.container_tabjes.SuspendLayout();
            this.tab_menus.SuspendLayout();
            this.tab_Bestelling.SuspendLayout();
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
            this.container_tabjes.Controls.Add(this.tab_Tafels);
            this.container_tabjes.Controls.Add(this.tab_menus);
            this.container_tabjes.Controls.Add(this.tab_Bestelling);
            this.container_tabjes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container_tabjes.ItemSize = new System.Drawing.Size(134, 36);
            this.container_tabjes.Location = new System.Drawing.Point(0, 3);
            this.container_tabjes.MinimumSize = new System.Drawing.Size(134, 36);
            this.container_tabjes.Name = "container_tabjes";
            this.container_tabjes.SelectedIndex = 0;
            this.container_tabjes.Size = new System.Drawing.Size(410, 669);
            this.container_tabjes.TabIndex = 2;
            // 
            // tab_Tafels
            // 
            this.tab_Tafels.Location = new System.Drawing.Point(4, 40);
            this.tab_Tafels.Name = "tab_Tafels";
            this.tab_Tafels.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tafels.Size = new System.Drawing.Size(402, 625);
            this.tab_Tafels.TabIndex = 3;
            this.tab_Tafels.Text = "Tafels";
            this.tab_Tafels.UseVisualStyleBackColor = true;
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
            this.tbx_opmerking.Location = new System.Drawing.Point(56, 247);
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
            this.lv_BesteldeItemlist.Size = new System.Drawing.Size(402, 189);
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
            this.btn_VorrigeBestelscherm.Location = new System.Drawing.Point(0, 556);
            this.btn_VorrigeBestelscherm.Name = "btn_VorrigeBestelscherm";
            this.btn_VorrigeBestelscherm.Size = new System.Drawing.Size(133, 54);
            this.btn_VorrigeBestelscherm.TabIndex = 8;
            this.btn_VorrigeBestelscherm.Text = "Vorrige";
            this.btn_VorrigeBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_AnnuleerBestelscherm
            // 
            this.btn_AnnuleerBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnuleerBestelscherm.Location = new System.Drawing.Point(135, 556);
            this.btn_AnnuleerBestelscherm.Name = "btn_AnnuleerBestelscherm";
            this.btn_AnnuleerBestelscherm.Size = new System.Drawing.Size(133, 54);
            this.btn_AnnuleerBestelscherm.TabIndex = 9;
            this.btn_AnnuleerBestelscherm.Text = "Annuleren";
            this.btn_AnnuleerBestelscherm.UseVisualStyleBackColor = true;
            this.btn_AnnuleerBestelscherm.Click += new System.EventHandler(this.btn_AnnuleerBestelscherm_Click);
            // 
            // btn_VerzendenBestelscherm
            // 
            this.btn_VerzendenBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerzendenBestelscherm.Location = new System.Drawing.Point(269, 556);
            this.btn_VerzendenBestelscherm.Name = "btn_VerzendenBestelscherm";
            this.btn_VerzendenBestelscherm.Size = new System.Drawing.Size(133, 53);
            this.btn_VerzendenBestelscherm.TabIndex = 10;
            this.btn_VerzendenBestelscherm.Text = "Verzenden";
            this.btn_VerzendenBestelscherm.UseVisualStyleBackColor = true;
            this.btn_VerzendenBestelscherm.Click += new System.EventHandler(this.btn_VerzendenBestelscherm_Click);
            // 
            // tab_Bestelling
            // 
            this.tab_Bestelling.Controls.Add(this.btn_DeleteBestellingTab);
            this.tab_Bestelling.Controls.Add(this.btn_VorrigeBestellingTab);
            this.tab_Bestelling.Controls.Add(this.lv_HuidigeBestelling);
            this.tab_Bestelling.Location = new System.Drawing.Point(4, 40);
            this.tab_Bestelling.Name = "tab_Bestelling";
            this.tab_Bestelling.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Bestelling.Size = new System.Drawing.Size(402, 625);
            this.tab_Bestelling.TabIndex = 2;
            this.tab_Bestelling.Text = "Bestellingen";
            this.tab_Bestelling.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteBestellingTab
            // 
            this.btn_DeleteBestellingTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteBestellingTab.Location = new System.Drawing.Point(200, 554);
            this.btn_DeleteBestellingTab.Name = "btn_DeleteBestellingTab";
            this.btn_DeleteBestellingTab.Size = new System.Drawing.Size(199, 53);
            this.btn_DeleteBestellingTab.TabIndex = 24;
            this.btn_DeleteBestellingTab.Text = "Delete";
            this.btn_DeleteBestellingTab.UseVisualStyleBackColor = true;
            // 
            // btn_VorrigeBestellingTab
            // 
            this.btn_VorrigeBestellingTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VorrigeBestellingTab.Location = new System.Drawing.Point(0, 554);
            this.btn_VorrigeBestellingTab.Name = "btn_VorrigeBestellingTab";
            this.btn_VorrigeBestellingTab.Size = new System.Drawing.Size(199, 53);
            this.btn_VorrigeBestellingTab.TabIndex = 23;
            this.btn_VorrigeBestellingTab.Text = "Vorrige";
            this.btn_VorrigeBestellingTab.UseVisualStyleBackColor = true;
            this.btn_VorrigeBestellingTab.Click += new System.EventHandler(this.btn_VorrigeBestellingTab_Click);
            // 
            // lv_HuidigeBestelling
            // 
            this.lv_HuidigeBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_HuidigeBestelling.FullRowSelect = true;
            this.lv_HuidigeBestelling.Location = new System.Drawing.Point(0, 6);
            this.lv_HuidigeBestelling.Name = "lv_HuidigeBestelling";
            this.lv_HuidigeBestelling.Size = new System.Drawing.Size(402, 542);
            this.lv_HuidigeBestelling.TabIndex = 22;
            this.lv_HuidigeBestelling.UseCompatibleStateImageBehavior = false;
            this.lv_HuidigeBestelling.View = System.Windows.Forms.View.Details;
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
            this.tab_Bestelling.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BackgroundPannel;
        private System.Windows.Forms.TabControl container_tabjes;
        private System.Windows.Forms.TabPage tab_menus;
        private System.Windows.Forms.TabPage tab_Bestelling;
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
        private System.Windows.Forms.ListView lv_BesteldeItemlist;
        private System.Windows.Forms.TextBox tbx_opmerking;
        private System.Windows.Forms.Button btn_DeleteBestellingTab;
        private System.Windows.Forms.Button btn_VorrigeBestellingTab;
        private System.Windows.Forms.ListView lv_HuidigeBestelling;
    }
}