namespace Kliniken
{
    partial class frmVergütungDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntgeltgruppe = new System.Windows.Forms.TextBox();
            this.txtVergütung = new System.Windows.Forms.TextBox();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entgeltgruppe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vergütung:";
            // 
            // txtEntgeltgruppe
            // 
            this.txtEntgeltgruppe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntgeltgruppe.Location = new System.Drawing.Point(133, 24);
            this.txtEntgeltgruppe.MaxLength = 50;
            this.txtEntgeltgruppe.Name = "txtEntgeltgruppe";
            this.txtEntgeltgruppe.ReadOnly = true;
            this.txtEntgeltgruppe.Size = new System.Drawing.Size(467, 24);
            this.txtEntgeltgruppe.TabIndex = 2;
            // 
            // txtVergütung
            // 
            this.txtVergütung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVergütung.Location = new System.Drawing.Point(133, 67);
            this.txtVergütung.MaxLength = 200;
            this.txtVergütung.Multiline = true;
            this.txtVergütung.Name = "txtVergütung";
            this.txtVergütung.ReadOnly = true;
            this.txtVergütung.Size = new System.Drawing.Size(467, 29);
            this.txtVergütung.TabIndex = 3;
            // 
            // btnSchließen
            // 
            this.btnSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchließen.Location = new System.Drawing.Point(133, 117);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(160, 29);
            this.btnSchließen.TabIndex = 4;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // frmVergütungDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 158);
            this.ControlBox = false;
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.txtVergütung);
            this.Controls.Add(this.txtEntgeltgruppe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVergütungDetails";
            this.Text = "Vergütung-Details";
            this.Load += new System.EventHandler(this.frmVergütungDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntgeltgruppe;
        private System.Windows.Forms.TextBox txtVergütung;
        private System.Windows.Forms.Button btnSchließen;
    }
}