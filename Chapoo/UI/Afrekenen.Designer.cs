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
            this.lbl_btwTotaalPrijs = new System.Windows.Forms.Label();
            this.lbl_btwTotaal = new System.Windows.Forms.Label();
            this.btn_betalen = new System.Windows.Forms.Button();
            this.btn_wijzig = new System.Windows.Forms.Button();
            this.btn_terug = new System.Windows.Forms.Button();
            this.lbl_btwHoogPrijs = new System.Windows.Forms.Label();
            this.lbl_btwLaagPrijs = new System.Windows.Forms.Label();
            this.lbl_totaalPrijs = new System.Windows.Forms.Label();
            this.lbl_btwHoog = new System.Windows.Forms.Label();
            this.lbl_btwLaag = new System.Windows.Forms.Label();
            this.lbl_totaal = new System.Windows.Forms.Label();
            this.lv_bon = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_btwTotaalPrijs);
            this.panel1.Controls.Add(this.lbl_btwTotaal);
            this.panel1.Controls.Add(this.btn_betalen);
            this.panel1.Controls.Add(this.btn_wijzig);
            this.panel1.Controls.Add(this.btn_terug);
            this.panel1.Controls.Add(this.lbl_btwHoogPrijs);
            this.panel1.Controls.Add(this.lbl_btwLaagPrijs);
            this.panel1.Controls.Add(this.lbl_totaalPrijs);
            this.panel1.Controls.Add(this.lbl_btwHoog);
            this.panel1.Controls.Add(this.lbl_btwLaag);
            this.panel1.Controls.Add(this.lbl_totaal);
            this.panel1.Controls.Add(this.lv_bon);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 888);
            this.panel1.TabIndex = 3;
            // 
            // lbl_btwTotaalPrijs
            // 
            this.lbl_btwTotaalPrijs.AutoSize = true;
            this.lbl_btwTotaalPrijs.Location = new System.Drawing.Point(762, 704);
            this.lbl_btwTotaalPrijs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_btwTotaalPrijs.Name = "lbl_btwTotaalPrijs";
            this.lbl_btwTotaalPrijs.Size = new System.Drawing.Size(0, 25);
            this.lbl_btwTotaalPrijs.TabIndex = 14;
            // 
            // lbl_btwTotaal
            // 
            this.lbl_btwTotaal.AutoSize = true;
            this.lbl_btwTotaal.Location = new System.Drawing.Point(482, 704);
            this.lbl_btwTotaal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_btwTotaal.Name = "lbl_btwTotaal";
            this.lbl_btwTotaal.Size = new System.Drawing.Size(147, 25);
            this.lbl_btwTotaal.TabIndex = 13;
            this.lbl_btwTotaal.Text = "BTW TOTAAL";
            // 
            // btn_betalen
            // 
            this.btn_betalen.Location = new System.Drawing.Point(672, 763);
            this.btn_betalen.Margin = new System.Windows.Forms.Padding(6);
            this.btn_betalen.Name = "btn_betalen";
            this.btn_betalen.Size = new System.Drawing.Size(268, 94);
            this.btn_betalen.TabIndex = 12;
            this.btn_betalen.Text = "Betalen";
            this.btn_betalen.UseVisualStyleBackColor = true;
            // 
            // btn_wijzig
            // 
            this.btn_wijzig.Location = new System.Drawing.Point(342, 763);
            this.btn_wijzig.Margin = new System.Windows.Forms.Padding(6);
            this.btn_wijzig.Name = "btn_wijzig";
            this.btn_wijzig.Size = new System.Drawing.Size(268, 94);
            this.btn_wijzig.TabIndex = 11;
            this.btn_wijzig.Text = "Wijzig";
            this.btn_wijzig.UseVisualStyleBackColor = true;
            // 
            // btn_terug
            // 
            this.btn_terug.Location = new System.Drawing.Point(20, 763);
            this.btn_terug.Margin = new System.Windows.Forms.Padding(6);
            this.btn_terug.Name = "btn_terug";
            this.btn_terug.Size = new System.Drawing.Size(268, 94);
            this.btn_terug.TabIndex = 10;
            this.btn_terug.Text = "Terug";
            this.btn_terug.UseVisualStyleBackColor = true;
            this.btn_terug.Click += new System.EventHandler(this.btn_terug_Click);
            // 
            // lbl_btwHoogPrijs
            // 
            this.lbl_btwHoogPrijs.AutoSize = true;
            this.lbl_btwHoogPrijs.Location = new System.Drawing.Point(762, 637);
            this.lbl_btwHoogPrijs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_btwHoogPrijs.Name = "lbl_btwHoogPrijs";
            this.lbl_btwHoogPrijs.Size = new System.Drawing.Size(0, 25);
            this.lbl_btwHoogPrijs.TabIndex = 9;
            // 
            // lbl_btwLaagPrijs
            // 
            this.lbl_btwLaagPrijs.AutoSize = true;
            this.lbl_btwLaagPrijs.Location = new System.Drawing.Point(762, 569);
            this.lbl_btwLaagPrijs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_btwLaagPrijs.Name = "lbl_btwLaagPrijs";
            this.lbl_btwLaagPrijs.Size = new System.Drawing.Size(0, 25);
            this.lbl_btwLaagPrijs.TabIndex = 8;
            // 
            // lbl_totaalPrijs
            // 
            this.lbl_totaalPrijs.AutoSize = true;
            this.lbl_totaalPrijs.Location = new System.Drawing.Point(762, 504);
            this.lbl_totaalPrijs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_totaalPrijs.Name = "lbl_totaalPrijs";
            this.lbl_totaalPrijs.Size = new System.Drawing.Size(0, 25);
            this.lbl_totaalPrijs.TabIndex = 7;
            // 
            // lbl_btwHoog
            // 
            this.lbl_btwHoog.AutoSize = true;
            this.lbl_btwHoog.Location = new System.Drawing.Point(482, 637);
            this.lbl_btwHoog.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_btwHoog.Name = "lbl_btwHoog";
            this.lbl_btwHoog.Size = new System.Drawing.Size(177, 25);
            this.lbl_btwHoog.TabIndex = 6;
            this.lbl_btwHoog.Text = "BTW HOOG 21%";
            // 
            // lbl_btwLaag
            // 
            this.lbl_btwLaag.AutoSize = true;
            this.lbl_btwLaag.Location = new System.Drawing.Point(482, 569);
            this.lbl_btwLaag.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_btwLaag.Name = "lbl_btwLaag";
            this.lbl_btwLaag.Size = new System.Drawing.Size(158, 25);
            this.lbl_btwLaag.TabIndex = 5;
            this.lbl_btwLaag.Text = "BTW LAAG 6%";
            // 
            // lbl_totaal
            // 
            this.lbl_totaal.AutoSize = true;
            this.lbl_totaal.Location = new System.Drawing.Point(482, 504);
            this.lbl_totaal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_totaal.Name = "lbl_totaal";
            this.lbl_totaal.Size = new System.Drawing.Size(72, 25);
            this.lbl_totaal.TabIndex = 4;
            this.lbl_totaal.Text = "Totaal";
            // 
            // lv_bon
            // 
            this.lv_bon.Location = new System.Drawing.Point(20, 21);
            this.lv_bon.Margin = new System.Windows.Forms.Padding(6);
            this.lv_bon.Name = "lv_bon";
            this.lv_bon.Size = new System.Drawing.Size(916, 442);
            this.lv_bon.TabIndex = 0;
            this.lv_bon.UseCompatibleStateImageBehavior = false;
            this.lv_bon.View = System.Windows.Forms.View.Details;
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 883);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Afrekenen";
            this.Text = "Afrekenen";
            this.Load += new System.EventHandler(this.Afrekenen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_btwTotaalPrijs;
        private System.Windows.Forms.Label lbl_btwTotaal;
        private System.Windows.Forms.Button btn_betalen;
        private System.Windows.Forms.Button btn_wijzig;
        private System.Windows.Forms.Button btn_terug;
        private System.Windows.Forms.Label lbl_btwHoogPrijs;
        private System.Windows.Forms.Label lbl_btwLaagPrijs;
        private System.Windows.Forms.Label lbl_totaalPrijs;
        private System.Windows.Forms.Label lbl_btwHoog;
        private System.Windows.Forms.Label lbl_btwLaag;
        private System.Windows.Forms.Label lbl_totaal;
        private System.Windows.Forms.ListView lv_bon;
    }
}