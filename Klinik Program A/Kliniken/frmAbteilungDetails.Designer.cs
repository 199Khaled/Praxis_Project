namespace Kliniken
{
    partial class frmAbteilungDetails
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
            this.btnSchließen = new System.Windows.Forms.Button();
            this.txtBerufsbeschreibung = new System.Windows.Forms.TextBox();
            this.txtAbteilung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQualifikation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSchließen
            // 
            this.btnSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchließen.Location = new System.Drawing.Point(171, 196);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(160, 29);
            this.btnSchließen.TabIndex = 14;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // txtBerufsbeschreibung
            // 
            this.txtBerufsbeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBerufsbeschreibung.Location = new System.Drawing.Point(171, 53);
            this.txtBerufsbeschreibung.MaxLength = 500;
            this.txtBerufsbeschreibung.Multiline = true;
            this.txtBerufsbeschreibung.Name = "txtBerufsbeschreibung";
            this.txtBerufsbeschreibung.ReadOnly = true;
            this.txtBerufsbeschreibung.Size = new System.Drawing.Size(467, 49);
            this.txtBerufsbeschreibung.TabIndex = 13;
            // 
            // txtAbteilung
            // 
            this.txtAbteilung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbteilung.Location = new System.Drawing.Point(171, 12);
            this.txtAbteilung.MaxLength = 50;
            this.txtAbteilung.Name = "txtAbteilung";
            this.txtAbteilung.ReadOnly = true;
            this.txtAbteilung.Size = new System.Drawing.Size(467, 24);
            this.txtAbteilung.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Berufsbeschreibung:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Abteilung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Qualifikation:";
            // 
            // txtQualifikation
            // 
            this.txtQualifikation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualifikation.Location = new System.Drawing.Point(171, 123);
            this.txtQualifikation.MaxLength = 500;
            this.txtQualifikation.Multiline = true;
            this.txtQualifikation.Name = "txtQualifikation";
            this.txtQualifikation.ReadOnly = true;
            this.txtQualifikation.Size = new System.Drawing.Size(467, 49);
            this.txtQualifikation.TabIndex = 16;
            // 
            // frmAbteilungDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 232);
            this.ControlBox = false;
            this.Controls.Add(this.txtQualifikation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.txtBerufsbeschreibung);
            this.Controls.Add(this.txtAbteilung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAbteilungDetails";
            this.Text = "frmAbteilungDetails";
            this.Load += new System.EventHandler(this.frmAbteilungDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.TextBox txtBerufsbeschreibung;
        private System.Windows.Forms.TextBox txtAbteilung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQualifikation;
    }
}