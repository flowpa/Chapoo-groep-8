namespace UI
{
    partial class Afrekenen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_huidigeTafel = new System.Windows.Forms.Label();
            this.pnl_betaling = new System.Windows.Forms.Panel();
            this.btn_terugBetaald = new System.Windows.Forms.Button();
            this.lbl_totaalBetaaldPrijs = new System.Windows.Forms.Label();
            this.lbl_totaalBetaald = new System.Windows.Forms.Label();
            this.lbl_betaaldBedrag = new System.Windows.Forms.Label();
            this.txt_betaaldBedrag = new System.Windows.Forms.TextBox();
            this.rbtn_creditcard = new System.Windows.Forms.RadioButton();
            this.rbtn_pinnen = new System.Windows.Forms.RadioButton();
            this.rbtn_contant = new System.Windows.Forms.RadioButton();
            this.btn_betaald = new System.Windows.Forms.Button();
            this.lbl_btwTotaalPrijs = new System.Windows.Forms.Label();
            this.lbl_btwTotaal = new System.Windows.Forms.Label();
            this.btn_betalen = new System.Windows.Forms.Button();
            this.btn_terug = new System.Windows.Forms.Button();
            this.lbl_btwHoogPrijs = new System.Windows.Forms.Label();
            this.lbl_btwLaagPrijs = new System.Windows.Forms.Label();
            this.lbl_totaalPrijs = new System.Windows.Forms.Label();
            this.lbl_btwHoog = new System.Windows.Forms.Label();
            this.lbl_btwLaag = new System.Windows.Forms.Label();
            this.lbl_totaal = new System.Windows.Forms.Label();
            this.lv_bon = new System.Windows.Forms.ListView();
            this.lbl_fooi = new System.Windows.Forms.Label();
            this.lbl_fooiPrijs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_betaling.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_huidigeTafel);
            this.panel1.Controls.Add(this.pnl_betaling);
            this.panel1.Controls.Add(this.lbl_btwTotaalPrijs);
            this.panel1.Controls.Add(this.lbl_btwTotaal);
            this.panel1.Controls.Add(this.btn_betalen);
            this.panel1.Controls.Add(this.btn_terug);
            this.panel1.Controls.Add(this.lbl_btwHoogPrijs);
            this.panel1.Controls.Add(this.lbl_btwLaagPrijs);
            this.panel1.Controls.Add(this.lbl_totaalPrijs);
            this.panel1.Controls.Add(this.lbl_btwHoog);
            this.panel1.Controls.Add(this.lbl_btwLaag);
            this.panel1.Controls.Add(this.lbl_totaal);
            this.panel1.Controls.Add(this.lv_bon);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 462);
            this.panel1.TabIndex = 3;
            // 
            // lbl_huidigeTafel
            // 
            this.lbl_huidigeTafel.AutoSize = true;
            this.lbl_huidigeTafel.Location = new System.Drawing.Point(10, 262);
            this.lbl_huidigeTafel.Name = "lbl_huidigeTafel";
            this.lbl_huidigeTafel.Size = new System.Drawing.Size(0, 13);
            this.lbl_huidigeTafel.TabIndex = 17;
            // 
            // pnl_betaling
            // 
            this.pnl_betaling.Controls.Add(this.lbl_fooiPrijs);
            this.pnl_betaling.Controls.Add(this.lbl_fooi);
            this.pnl_betaling.Controls.Add(this.btn_terugBetaald);
            this.pnl_betaling.Controls.Add(this.lbl_totaalBetaaldPrijs);
            this.pnl_betaling.Controls.Add(this.lbl_totaalBetaald);
            this.pnl_betaling.Controls.Add(this.lbl_betaaldBedrag);
            this.pnl_betaling.Controls.Add(this.txt_betaaldBedrag);
            this.pnl_betaling.Controls.Add(this.rbtn_creditcard);
            this.pnl_betaling.Controls.Add(this.rbtn_pinnen);
            this.pnl_betaling.Controls.Add(this.rbtn_contant);
            this.pnl_betaling.Controls.Add(this.btn_betaald);
            this.pnl_betaling.Location = new System.Drawing.Point(0, 0);
            this.pnl_betaling.Name = "pnl_betaling";
            this.pnl_betaling.Size = new System.Drawing.Size(481, 459);
            this.pnl_betaling.TabIndex = 16;
            this.pnl_betaling.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_betaling_Paint);
            // 
            // btn_terugBetaald
            // 
            this.btn_terugBetaald.Location = new System.Drawing.Point(10, 397);
            this.btn_terugBetaald.Name = "btn_terugBetaald";
            this.btn_terugBetaald.Size = new System.Drawing.Size(134, 49);
            this.btn_terugBetaald.TabIndex = 8;
            this.btn_terugBetaald.Text = "Terug";
            this.btn_terugBetaald.UseVisualStyleBackColor = true;
            this.btn_terugBetaald.Click += new System.EventHandler(this.btn_terugBetaald_Click_1);
            // 
            // lbl_totaalBetaaldPrijs
            // 
            this.lbl_totaalBetaaldPrijs.AutoSize = true;
            this.lbl_totaalBetaaldPrijs.Location = new System.Drawing.Point(115, 31);
            this.lbl_totaalBetaaldPrijs.Name = "lbl_totaalBetaaldPrijs";
            this.lbl_totaalBetaaldPrijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_totaalBetaaldPrijs.TabIndex = 7;
            // 
            // lbl_totaalBetaald
            // 
            this.lbl_totaalBetaald.AutoSize = true;
            this.lbl_totaalBetaald.Location = new System.Drawing.Point(47, 31);
            this.lbl_totaalBetaald.Name = "lbl_totaalBetaald";
            this.lbl_totaalBetaald.Size = new System.Drawing.Size(40, 13);
            this.lbl_totaalBetaald.TabIndex = 6;
            this.lbl_totaalBetaald.Text = "Totaal:";
            // 
            // lbl_betaaldBedrag
            // 
            this.lbl_betaaldBedrag.AutoSize = true;
            this.lbl_betaaldBedrag.Location = new System.Drawing.Point(47, 166);
            this.lbl_betaaldBedrag.Name = "lbl_betaaldBedrag";
            this.lbl_betaaldBedrag.Size = new System.Drawing.Size(80, 13);
            this.lbl_betaaldBedrag.TabIndex = 5;
            this.lbl_betaaldBedrag.Text = "Betaald Bedrag";
            // 
            // txt_betaaldBedrag
            // 
            this.txt_betaaldBedrag.Location = new System.Drawing.Point(50, 182);
            this.txt_betaaldBedrag.Name = "txt_betaaldBedrag";
            this.txt_betaaldBedrag.Size = new System.Drawing.Size(100, 20);
            this.txt_betaaldBedrag.TabIndex = 4;
            this.txt_betaaldBedrag.TextChanged += new System.EventHandler(this.txt_betaaldBedrag_TextChanged);
            // 
            // rbtn_creditcard
            // 
            this.rbtn_creditcard.AutoSize = true;
            this.rbtn_creditcard.Location = new System.Drawing.Point(50, 115);
            this.rbtn_creditcard.Name = "rbtn_creditcard";
            this.rbtn_creditcard.Size = new System.Drawing.Size(73, 17);
            this.rbtn_creditcard.TabIndex = 3;
            this.rbtn_creditcard.TabStop = true;
            this.rbtn_creditcard.Text = "Creditcard";
            this.rbtn_creditcard.UseVisualStyleBackColor = true;
            // 
            // rbtn_pinnen
            // 
            this.rbtn_pinnen.AutoSize = true;
            this.rbtn_pinnen.Location = new System.Drawing.Point(50, 92);
            this.rbtn_pinnen.Name = "rbtn_pinnen";
            this.rbtn_pinnen.Size = new System.Drawing.Size(58, 17);
            this.rbtn_pinnen.TabIndex = 2;
            this.rbtn_pinnen.TabStop = true;
            this.rbtn_pinnen.Text = "Pinnen";
            this.rbtn_pinnen.UseVisualStyleBackColor = true;
            // 
            // rbtn_contant
            // 
            this.rbtn_contant.AutoSize = true;
            this.rbtn_contant.Checked = true;
            this.rbtn_contant.Location = new System.Drawing.Point(50, 69);
            this.rbtn_contant.Name = "rbtn_contant";
            this.rbtn_contant.Size = new System.Drawing.Size(62, 17);
            this.rbtn_contant.TabIndex = 1;
            this.rbtn_contant.TabStop = true;
            this.rbtn_contant.Text = "Contant";
            this.rbtn_contant.UseVisualStyleBackColor = true;
            // 
            // btn_betaald
            // 
            this.btn_betaald.Location = new System.Drawing.Point(336, 397);
            this.btn_betaald.Name = "btn_betaald";
            this.btn_betaald.Size = new System.Drawing.Size(134, 49);
            this.btn_betaald.TabIndex = 0;
            this.btn_betaald.Text = "Betaald";
            this.btn_betaald.UseVisualStyleBackColor = true;
            this.btn_betaald.Click += new System.EventHandler(this.btn_betaald_Click);
            // 
            // lbl_btwTotaalPrijs
            // 
            this.lbl_btwTotaalPrijs.AutoSize = true;
            this.lbl_btwTotaalPrijs.Location = new System.Drawing.Point(333, 332);
            this.lbl_btwTotaalPrijs.Name = "lbl_btwTotaalPrijs";
            this.lbl_btwTotaalPrijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_btwTotaalPrijs.TabIndex = 14;
            // 
            // lbl_btwTotaal
            // 
            this.lbl_btwTotaal.AutoSize = true;
            this.lbl_btwTotaal.Location = new System.Drawing.Point(241, 332);
            this.lbl_btwTotaal.Name = "lbl_btwTotaal";
            this.lbl_btwTotaal.Size = new System.Drawing.Size(77, 13);
            this.lbl_btwTotaal.TabIndex = 13;
            this.lbl_btwTotaal.Text = "BTW TOTAAL";
            // 
            // btn_betalen
            // 
            this.btn_betalen.Location = new System.Drawing.Point(336, 397);
            this.btn_betalen.Name = "btn_betalen";
            this.btn_betalen.Size = new System.Drawing.Size(134, 49);
            this.btn_betalen.TabIndex = 12;
            this.btn_betalen.Text = "Betalen";
            this.btn_betalen.UseVisualStyleBackColor = true;
            this.btn_betalen.Click += new System.EventHandler(this.btn_betalen_Click);
            // 
            // btn_terug
            // 
            this.btn_terug.Location = new System.Drawing.Point(10, 397);
            this.btn_terug.Name = "btn_terug";
            this.btn_terug.Size = new System.Drawing.Size(134, 49);
            this.btn_terug.TabIndex = 10;
            this.btn_terug.Text = "Terug";
            this.btn_terug.UseVisualStyleBackColor = true;
            this.btn_terug.Click += new System.EventHandler(this.btn_terug_Click);
            // 
            // lbl_btwHoogPrijs
            // 
            this.lbl_btwHoogPrijs.AutoSize = true;
            this.lbl_btwHoogPrijs.Location = new System.Drawing.Point(333, 297);
            this.lbl_btwHoogPrijs.Name = "lbl_btwHoogPrijs";
            this.lbl_btwHoogPrijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_btwHoogPrijs.TabIndex = 9;
            // 
            // lbl_btwLaagPrijs
            // 
            this.lbl_btwLaagPrijs.AutoSize = true;
            this.lbl_btwLaagPrijs.Location = new System.Drawing.Point(333, 262);
            this.lbl_btwLaagPrijs.Name = "lbl_btwLaagPrijs";
            this.lbl_btwLaagPrijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_btwLaagPrijs.TabIndex = 8;
            // 
            // lbl_totaalPrijs
            // 
            this.lbl_totaalPrijs.AutoSize = true;
            this.lbl_totaalPrijs.Location = new System.Drawing.Point(333, 363);
            this.lbl_totaalPrijs.Name = "lbl_totaalPrijs";
            this.lbl_totaalPrijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_totaalPrijs.TabIndex = 7;
            // 
            // lbl_btwHoog
            // 
            this.lbl_btwHoog.AutoSize = true;
            this.lbl_btwHoog.Location = new System.Drawing.Point(241, 297);
            this.lbl_btwHoog.Name = "lbl_btwHoog";
            this.lbl_btwHoog.Size = new System.Drawing.Size(90, 13);
            this.lbl_btwHoog.TabIndex = 6;
            this.lbl_btwHoog.Text = "BTW HOOG 21%";
            // 
            // lbl_btwLaag
            // 
            this.lbl_btwLaag.AutoSize = true;
            this.lbl_btwLaag.Location = new System.Drawing.Point(241, 262);
            this.lbl_btwLaag.Name = "lbl_btwLaag";
            this.lbl_btwLaag.Size = new System.Drawing.Size(80, 13);
            this.lbl_btwLaag.TabIndex = 5;
            this.lbl_btwLaag.Text = "BTW LAAG 6%";
            // 
            // lbl_totaal
            // 
            this.lbl_totaal.AutoSize = true;
            this.lbl_totaal.Location = new System.Drawing.Point(241, 363);
            this.lbl_totaal.Name = "lbl_totaal";
            this.lbl_totaal.Size = new System.Drawing.Size(49, 13);
            this.lbl_totaal.TabIndex = 4;
            this.lbl_totaal.Text = "TOTAAL";
            // 
            // lv_bon
            // 
            this.lv_bon.Location = new System.Drawing.Point(10, 11);
            this.lv_bon.Name = "lv_bon";
            this.lv_bon.Size = new System.Drawing.Size(460, 232);
            this.lv_bon.TabIndex = 0;
            this.lv_bon.UseCompatibleStateImageBehavior = false;
            this.lv_bon.View = System.Windows.Forms.View.Details;
            // 
            // lbl_fooi
            // 
            this.lbl_fooi.AutoSize = true;
            this.lbl_fooi.Location = new System.Drawing.Point(50, 229);
            this.lbl_fooi.Name = "lbl_fooi";
            this.lbl_fooi.Size = new System.Drawing.Size(30, 13);
            this.lbl_fooi.TabIndex = 9;
            this.lbl_fooi.Text = "Fooi:";
            // 
            // lbl_fooiPrijs
            // 
            this.lbl_fooiPrijs.AutoSize = true;
            this.lbl_fooiPrijs.Location = new System.Drawing.Point(92, 229);
            this.lbl_fooiPrijs.Name = "lbl_fooiPrijs";
            this.lbl_fooiPrijs.Size = new System.Drawing.Size(0, 13);
            this.lbl_fooiPrijs.TabIndex = 10;
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 459);
            this.Controls.Add(this.panel1);
            this.Name = "Afrekenen";
            this.Text = "Afrekenen";
            this.Load += new System.EventHandler(this.Afrekenen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_betaling.ResumeLayout(false);
            this.pnl_betaling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_btwTotaalPrijs;
        private System.Windows.Forms.Label lbl_btwTotaal;
        private System.Windows.Forms.Button btn_betalen;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Label lbl_btwHoogPrijs;
        private System.Windows.Forms.Label lbl_btwLaagPrijs;
        private System.Windows.Forms.Label lbl_totaalPrijs;
        private System.Windows.Forms.Label lbl_btwHoog;
        private System.Windows.Forms.Label lbl_btwLaag;
        private System.Windows.Forms.Label lbl_totaal;
        private System.Windows.Forms.ListView lv_bon;
        private System.Windows.Forms.Panel pnl_betaling;
        private System.Windows.Forms.Button btn_terugBetaald;
        private System.Windows.Forms.Label lbl_totaalBetaaldPrijs;
        private System.Windows.Forms.Label lbl_totaalBetaald;
        private System.Windows.Forms.Label lbl_betaaldBedrag;
        private System.Windows.Forms.TextBox txt_betaaldBedrag;
        private System.Windows.Forms.RadioButton rbtn_creditcard;
        private System.Windows.Forms.RadioButton rbtn_pinnen;
        private System.Windows.Forms.RadioButton rbtn_contant;
        private System.Windows.Forms.Button btn_betaald;
        private System.Windows.Forms.Label lbl_huidigeTafel;
        private System.Windows.Forms.Label lbl_fooiPrijs;
        private System.Windows.Forms.Label lbl_fooi;
    }
}