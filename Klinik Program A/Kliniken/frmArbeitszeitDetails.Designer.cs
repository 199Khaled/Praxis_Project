namespace Kliniken
{
    partial class frmArbeitszeitDetails
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
            this.txtBeschreibung = new System.Windows.Forms.TextBox();
            this.txtArbeitszeit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSchließen
            // 
            this.btnSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchließen.Location = new System.Drawing.Point(133, 151);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(160, 29);
            this.btnSchließen.TabIndex = 9;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // txtBeschreibung
            // 
            this.txtBeschreibung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeschreibung.Location = new System.Drawing.Point(133, 79);
            this.txtBeschreibung.MaxLength = 100;
            this.txtBeschreibung.Multiline = true;
            this.txtBeschreibung.Name = "txtBeschreibung";
            this.txtBeschreibung.ReadOnly = true;
            this.txtBeschreibung.Size = new System.Drawing.Size(467, 49);
            this.txtBeschreibung.TabIndex = 8;
            this.txtBeschreibung.TextChanged += new System.EventHandler(this.txtBeschreibung_TextChanged);
            // 
            // txtArbeitszeit
            // 
            this.txtArbeitszeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbeitszeit.Location = new System.Drawing.Point(133, 34);
            this.txtArbeitszeit.MaxLength = 50;
            this.txtArbeitszeit.Name = "txtArbeitszeit";
            this.txtArbeitszeit.ReadOnly = true;
            this.txtArbeitszeit.Size = new System.Drawing.Size(467, 24);
            this.txtArbeitszeit.TabIndex = 7;
            this.txtArbeitszeit.TextChanged += new System.EventHandler(this.txtArbeitszeit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Beschreibung:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arbeitszeit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmArbeitszeitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.txtBeschreibung);
            this.Controls.Add(this.txtArbeitszeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmArbeitszeitDetails";
            this.Text = "Arbeitzeit-Details";
            this.Load += new System.EventHandler(this.frmArbeitszeitDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.TextBox txtBeschreibung;
        private System.Windows.Forms.TextBox txtArbeitszeit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}