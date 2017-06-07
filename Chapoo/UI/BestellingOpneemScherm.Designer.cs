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
            this.btn_VorrigeBestelscherm = new System.Windows.Forms.Button();
            this.btn_AnnuleerBestelscherm = new System.Windows.Forms.Button();
            this.btn_VerzendenBestelscherm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_VorrigeBestelscherm
            // 
            this.btn_VorrigeBestelscherm.Location = new System.Drawing.Point(-4, 591);
            this.btn_VorrigeBestelscherm.Name = "btn_VorrigeBestelscherm";
            this.btn_VorrigeBestelscherm.Size = new System.Drawing.Size(139, 69);
            this.btn_VorrigeBestelscherm.TabIndex = 0;
            this.btn_VorrigeBestelscherm.Text = "Vorrige";
            this.btn_VorrigeBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_AnnuleerBestelscherm
            // 
            this.btn_AnnuleerBestelscherm.Location = new System.Drawing.Point(132, 591);
            this.btn_AnnuleerBestelscherm.Name = "btn_AnnuleerBestelscherm";
            this.btn_AnnuleerBestelscherm.Size = new System.Drawing.Size(139, 69);
            this.btn_AnnuleerBestelscherm.TabIndex = 1;
            this.btn_AnnuleerBestelscherm.Text = "Annuleren";
            this.btn_AnnuleerBestelscherm.UseVisualStyleBackColor = true;
            // 
            // btn_VerzendenBestelscherm
            // 
            this.btn_VerzendenBestelscherm.Location = new System.Drawing.Point(267, 591);
            this.btn_VerzendenBestelscherm.Name = "btn_VerzendenBestelscherm";
            this.btn_VerzendenBestelscherm.Size = new System.Drawing.Size(139, 69);
            this.btn_VerzendenBestelscherm.TabIndex = 2;
            this.btn_VerzendenBestelscherm.Text = "Verzenden";
            this.btn_VerzendenBestelscherm.UseVisualStyleBackColor = true;
            // 
            // BestellingOpneemScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 650);
            this.Controls.Add(this.btn_VerzendenBestelscherm);
            this.Controls.Add(this.btn_AnnuleerBestelscherm);
            this.Controls.Add(this.btn_VorrigeBestelscherm);
            this.Name = "BestellingOpneemScherm";
            this.Text = "BestellingOpneemScherm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_VorrigeBestelscherm;
        private System.Windows.Forms.Button btn_AnnuleerBestelscherm;
        private System.Windows.Forms.Button btn_VerzendenBestelscherm;
    }
}