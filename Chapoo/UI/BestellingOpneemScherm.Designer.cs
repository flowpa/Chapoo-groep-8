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
            this.tab_menus = new System.Windows.Forms.TabPage();
            this.container_tabjes = new System.Windows.Forms.TabControl();
            this.tab_Rekeningen = new System.Windows.Forms.TabPage();
            this.tab_Tafels = new System.Windows.Forms.TabPage();
            this.btn_VorrigeBestelscherm = new System.Windows.Forms.Button();
            this.btn_AnnuleerBestelscherm = new System.Windows.Forms.Button();
            this.btn_VerzendenBestelscherm = new System.Windows.Forms.Button();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.BackgroundPannel.SuspendLayout();
            this.container_tabjes.SuspendLayout();
            this.tab_Tafels.SuspendLayout();
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
            // tab_menus
            // 
            this.tab_menus.Location = new System.Drawing.Point(4, 40);
            this.tab_menus.Name = "tab_menus";
            this.tab_menus.Padding = new System.Windows.Forms.Padding(3);
            this.tab_menus.Size = new System.Drawing.Size(402, 625);
            this.tab_menus.TabIndex = 1;
            this.tab_menus.Text = "Menu\'s";
            this.tab_menus.UseVisualStyleBackColor = true;
            // 
            // container_tabjes
            // 
            this.container_tabjes.Controls.Add(this.tab_menus);
            this.container_tabjes.Controls.Add(this.tab_Rekeningen);
            this.container_tabjes.Controls.Add(this.tab_Tafels);
            this.container_tabjes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.container_tabjes.ItemSize = new System.Drawing.Size(134, 36);
            this.container_tabjes.Location = new System.Drawing.Point(0, 3);
            this.container_tabjes.MinimumSize = new System.Drawing.Size(134, 36);
            this.container_tabjes.Name = "container_tabjes";
            this.container_tabjes.SelectedIndex = 0;
            this.container_tabjes.Size = new System.Drawing.Size(410, 669);
            this.container_tabjes.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.container_tabjes.TabIndex = 0;
            // 
            // tab_Rekeningen
            // 
            this.tab_Rekeningen.Location = new System.Drawing.Point(4, 40);
            this.tab_Rekeningen.Name = "tab_Rekeningen";
            this.tab_Rekeningen.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rekeningen.Size = new System.Drawing.Size(402, 625);
            this.tab_Rekeningen.TabIndex = 2;
            this.tab_Rekeningen.Text = "Rekeningen";
            this.tab_Rekeningen.UseVisualStyleBackColor = true;
            // 
            // tab_Tafels
            // 
            this.tab_Tafels.Controls.Add(this.ItemList);
            this.tab_Tafels.Controls.Add(this.btn_VorrigeBestelscherm);
            this.tab_Tafels.Controls.Add(this.btn_AnnuleerBestelscherm);
            this.tab_Tafels.Controls.Add(this.btn_VerzendenBestelscherm);
            this.tab_Tafels.Location = new System.Drawing.Point(4, 40);
            this.tab_Tafels.Name = "tab_Tafels";
            this.tab_Tafels.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tafels.Size = new System.Drawing.Size(402, 625);
            this.tab_Tafels.TabIndex = 3;
            this.tab_Tafels.Text = "Tafels";
            this.tab_Tafels.UseVisualStyleBackColor = true;
            // 
            // btn_VorrigeBestelscherm
            // 
            this.btn_VorrigeBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VorrigeBestelscherm.Location = new System.Drawing.Point(0, 541);
            this.btn_VorrigeBestelscherm.Name = "btn_VorrigeBestelscherm";
            this.btn_VorrigeBestelscherm.Size = new System.Drawing.Size(139, 69);
            this.btn_VorrigeBestelscherm.TabIndex = 3;
            this.btn_VorrigeBestelscherm.Text = "Vorrige";
            this.btn_VorrigeBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_AnnuleerBestelscherm
            // 
            this.btn_AnnuleerBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnnuleerBestelscherm.Location = new System.Drawing.Point(134, 541);
            this.btn_AnnuleerBestelscherm.Name = "btn_AnnuleerBestelscherm";
            this.btn_AnnuleerBestelscherm.Size = new System.Drawing.Size(139, 69);
            this.btn_AnnuleerBestelscherm.TabIndex = 4;
            this.btn_AnnuleerBestelscherm.Text = "Annuleren";
            this.btn_AnnuleerBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendenBestelscherm
            // 
            this.btn_VerzendenBestelscherm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerzendenBestelscherm.Location = new System.Drawing.Point(267, 541);
            this.btn_VerzendenBestelscherm.Name = "btn_VerzendenBestelscherm";
            this.btn_VerzendenBestelscherm.Size = new System.Drawing.Size(139, 69);
            this.btn_VerzendenBestelscherm.TabIndex = 5;
            this.btn_VerzendenBestelscherm.Text = "Verzenden";
            this.btn_VerzendenBestelscherm.UseVisualStyleBackColor = true;
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 31;
            this.ItemList.Location = new System.Drawing.Point(0, 50);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(402, 283);
            this.ItemList.TabIndex = 6;
            // 
            // BestellingOpneemScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 650);
            this.Controls.Add(this.BackgroundPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BestellingOpneemScherm";
            this.Text = "BestellingOpneemScherm";
            this.BackgroundPannel.ResumeLayout(false);
            this.container_tabjes.ResumeLayout(false);
            this.tab_Tafels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BackgroundPannel;
        private System.Windows.Forms.TabControl container_tabjes;
        private System.Windows.Forms.TabPage tab_menus;
        private System.Windows.Forms.TabPage tab_Rekeningen;
        private System.Windows.Forms.TabPage tab_Tafels;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Button btn_VorrigeBestelscherm;
        private System.Windows.Forms.Button btn_AnnuleerBestelscherm;
        private System.Windows.Forms.Button btn_VerzendenBestelscherm;
    }
}