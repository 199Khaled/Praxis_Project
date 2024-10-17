namespace Kliniken
{
    partial class frmMitarbeiterDetailsAnzeigen
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
            this.ctrMiratbeiterKarte1 = new Kliniken.ctrMiratbeiterKarte();
            this.SuspendLayout();
            // 
            // ctrMiratbeiterKarte1
            // 
            this.ctrMiratbeiterKarte1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ctrMiratbeiterKarte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMiratbeiterKarte1.Location = new System.Drawing.Point(5, 12);
            this.ctrMiratbeiterKarte1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrMiratbeiterKarte1.Name = "ctrMiratbeiterKarte1";
            this.ctrMiratbeiterKarte1.Size = new System.Drawing.Size(589, 510);
            this.ctrMiratbeiterKarte1.TabIndex = 0;
            // 
            // frmMitarbeiterDetailsAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 534);
            this.Controls.Add(this.ctrMiratbeiterKarte1);
            this.Name = "frmMitarbeiterDetailsAnzeigen";
            this.Text = "Mitarbeiter-Details";
            this.Load += new System.EventHandler(this.frmMitarbeiterDetailsAnzeigen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrMiratbeiterKarte ctrMiratbeiterKarte1;
    }
}