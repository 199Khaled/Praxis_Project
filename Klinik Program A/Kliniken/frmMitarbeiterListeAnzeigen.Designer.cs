namespace Kliniken
{
    partial class frmMitarbeiterListeAnzeigen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsMitarbeiter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arbeitersvertragErstellentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.persondetailsanzeigentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterDeaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterbei = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterwert = new System.Windows.Forms.TextBox();
            this.datagvMitarbeiter = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordwert = new System.Windows.Forms.Label();
            this.arbeitsvertragAktualisierentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNeueMitarbeiterHinzufügen = new System.Windows.Forms.Button();
            this.mitarbeiterAktivierentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvMitarbeiter)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsMitarbeiter
            // 
            this.cmsMitarbeiter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmsMitarbeiter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbeitersvertragErstellentoolStripMenuItem1,
            this.arbeitsvertragAktualisierentoolStripMenuItem1,
            this.toolStripSeparator5,
            this.persondetailsanzeigentoolStripMenuItem1,
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem,
            this.toolStripSeparator1,
            this.mitarbeiterAktualisierenToolStripMenuItem,
            this.mitarbeiterDeaktivierenToolStripMenuItem,
            this.mitarbeiterAktivierentoolStripMenuItem1,
            this.mitarbeiterEntfernenToolStripMenuItem});
            this.cmsMitarbeiter.Name = "cmsMitarbeiter";
            this.cmsMitarbeiter.Size = new System.Drawing.Size(375, 320);
            // 
            // arbeitersvertragErstellentoolStripMenuItem1
            // 
            this.arbeitersvertragErstellentoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arbeitersvertragErstellentoolStripMenuItem1.Image = global::Kliniken.Properties.Resources.ApplicationType;
            this.arbeitersvertragErstellentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.arbeitersvertragErstellentoolStripMenuItem1.Name = "arbeitersvertragErstellentoolStripMenuItem1";
            this.arbeitersvertragErstellentoolStripMenuItem1.Size = new System.Drawing.Size(374, 38);
            this.arbeitersvertragErstellentoolStripMenuItem1.Text = "Arbeitesvertrag erstellen";
            this.arbeitersvertragErstellentoolStripMenuItem1.Click += new System.EventHandler(this.arbeitersvertragErstellentoolStripMenuItem1_Click);
            // 
            // persondetailsanzeigentoolStripMenuItem1
            // 
            this.persondetailsanzeigentoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persondetailsanzeigentoolStripMenuItem1.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.persondetailsanzeigentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.persondetailsanzeigentoolStripMenuItem1.Name = "persondetailsanzeigentoolStripMenuItem1";
            this.persondetailsanzeigentoolStripMenuItem1.Size = new System.Drawing.Size(374, 38);
            this.persondetailsanzeigentoolStripMenuItem1.Text = "Person details anzeigen";
            this.persondetailsanzeigentoolStripMenuItem1.Click += new System.EventHandler(this.persondetailsanzeigentoolStripMenuItem1_Click);
            // 
            // mitarbeiterDetailsAnzeigenToolStripMenuItem
            // 
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem.Name = "mitarbeiterDetailsAnzeigenToolStripMenuItem";
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(374, 38);
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem.Text = "Mitarbeiter details anzeigen";
            this.mitarbeiterDetailsAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterDetailsAnzeigenToolStripMenuItem_Click);
            // 
            // mitarbeiterAktualisierenToolStripMenuItem
            // 
            this.mitarbeiterAktualisierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitarbeiterAktualisierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.mitarbeiter__1_;
            this.mitarbeiterAktualisierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterAktualisierenToolStripMenuItem.Name = "mitarbeiterAktualisierenToolStripMenuItem";
            this.mitarbeiterAktualisierenToolStripMenuItem.Size = new System.Drawing.Size(374, 38);
            this.mitarbeiterAktualisierenToolStripMenuItem.Text = "Mitarbeiter aktualisieren";
            this.mitarbeiterAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterAktualisierenToolStripMenuItem_Click);
            // 
            // mitarbeiterDeaktivierenToolStripMenuItem
            // 
            this.mitarbeiterDeaktivierenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitarbeiterDeaktivierenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Delete_32;
            this.mitarbeiterDeaktivierenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterDeaktivierenToolStripMenuItem.Name = "mitarbeiterDeaktivierenToolStripMenuItem";
            this.mitarbeiterDeaktivierenToolStripMenuItem.Size = new System.Drawing.Size(374, 38);
            this.mitarbeiterDeaktivierenToolStripMenuItem.Text = "Mitarbeiter deaktivieren";
            this.mitarbeiterDeaktivierenToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterDeaktivierenToolStripMenuItem_Click);
            // 
            // mitarbeiterEntfernenToolStripMenuItem
            // 
            this.mitarbeiterEntfernenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitarbeiterEntfernenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Delete_32_2;
            this.mitarbeiterEntfernenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterEntfernenToolStripMenuItem.Name = "mitarbeiterEntfernenToolStripMenuItem";
            this.mitarbeiterEntfernenToolStripMenuItem.Size = new System.Drawing.Size(374, 38);
            this.mitarbeiterEntfernenToolStripMenuItem.Text = "Mitarbeiter entfernen";
            this.mitarbeiterEntfernenToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterEntfernenToolStripMenuItem_Click);
            // 
            // cbFilterbei
            // 
            this.cbFilterbei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterbei.FormattingEnabled = true;
            this.cbFilterbei.Items.AddRange(new object[] {
            "Keine",
            "MitarbeiterID",
            "PersonID"});
            this.cbFilterbei.Location = new System.Drawing.Point(119, 102);
            this.cbFilterbei.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbFilterbei.Name = "cbFilterbei";
            this.cbFilterbei.Size = new System.Drawing.Size(180, 28);
            this.cbFilterbei.TabIndex = 2;
            this.cbFilterbei.SelectedValueChanged += new System.EventHandler(this.cbFilterbei_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter bei:";
            // 
            // txtFilterwert
            // 
            this.txtFilterwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterwert.Location = new System.Drawing.Point(306, 102);
            this.txtFilterwert.Name = "txtFilterwert";
            this.txtFilterwert.Size = new System.Drawing.Size(299, 29);
            this.txtFilterwert.TabIndex = 4;
            this.txtFilterwert.Visible = false;
            this.txtFilterwert.TextChanged += new System.EventHandler(this.txtFilterwert_TextChanged);
            this.txtFilterwert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterwert_KeyPress);
            // 
            // datagvMitarbeiter
            // 
            this.datagvMitarbeiter.AllowUserToAddRows = false;
            this.datagvMitarbeiter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this.datagvMitarbeiter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagvMitarbeiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagvMitarbeiter.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.datagvMitarbeiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvMitarbeiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagvMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvMitarbeiter.ContextMenuStrip = this.cmsMitarbeiter;
            this.datagvMitarbeiter.Cursor = System.Windows.Forms.Cursors.Default;
            this.datagvMitarbeiter.EnableHeadersVisualStyles = false;
            this.datagvMitarbeiter.Location = new System.Drawing.Point(30, 138);
            this.datagvMitarbeiter.Name = "datagvMitarbeiter";
            this.datagvMitarbeiter.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagvMitarbeiter.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datagvMitarbeiter.Size = new System.Drawing.Size(1335, 455);
            this.datagvMitarbeiter.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 609);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Record:";
            // 
            // lblRecordwert
            // 
            this.lblRecordwert.AutoSize = true;
            this.lblRecordwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordwert.Location = new System.Drawing.Point(106, 609);
            this.lblRecordwert.Name = "lblRecordwert";
            this.lblRecordwert.Size = new System.Drawing.Size(39, 20);
            this.lblRecordwert.TabIndex = 10;
            this.lblRecordwert.Text = "###";
            // 
            // arbeitsvertragAktualisierentoolStripMenuItem1
            // 
            this.arbeitsvertragAktualisierentoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arbeitsvertragAktualisierentoolStripMenuItem1.Image = global::Kliniken.Properties.Resources.ApplicationTitle;
            this.arbeitsvertragAktualisierentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.arbeitsvertragAktualisierentoolStripMenuItem1.Name = "arbeitsvertragAktualisierentoolStripMenuItem1";
            this.arbeitsvertragAktualisierentoolStripMenuItem1.Size = new System.Drawing.Size(374, 38);
            this.arbeitsvertragAktualisierentoolStripMenuItem1.Text = "Bestehender Arbeitsvertrag aktualisieren";
            this.arbeitsvertragAktualisierentoolStripMenuItem1.Click += new System.EventHandler(this.arbeitsvertragAktualisierentoolStripMenuItem1_Click);
            // 
            // btnNeueMitarbeiterHinzufügen
            // 
            this.btnNeueMitarbeiterHinzufügen.BackColor = System.Drawing.Color.LightSalmon;
            this.btnNeueMitarbeiterHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeueMitarbeiterHinzufügen.ForeColor = System.Drawing.Color.Black;
            this.btnNeueMitarbeiterHinzufügen.Location = new System.Drawing.Point(845, 96);
            this.btnNeueMitarbeiterHinzufügen.Name = "btnNeueMitarbeiterHinzufügen";
            this.btnNeueMitarbeiterHinzufügen.Size = new System.Drawing.Size(520, 34);
            this.btnNeueMitarbeiterHinzufügen.TabIndex = 11;
            this.btnNeueMitarbeiterHinzufügen.Text = "Neue Mitarbeiter hinzufügen";
            this.btnNeueMitarbeiterHinzufügen.UseVisualStyleBackColor = false;
            this.btnNeueMitarbeiterHinzufügen.Click += new System.EventHandler(this.btnNeueMitarbeiterHinzufügen_Click);
            // 
            // mitarbeiterAktivierentoolStripMenuItem1
            // 
            this.mitarbeiterAktivierentoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitarbeiterAktivierentoolStripMenuItem1.Image = global::Kliniken.Properties.Resources.Delete_32;
            this.mitarbeiterAktivierentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterAktivierentoolStripMenuItem1.Name = "mitarbeiterAktivierentoolStripMenuItem1";
            this.mitarbeiterAktivierentoolStripMenuItem1.Size = new System.Drawing.Size(374, 38);
            this.mitarbeiterAktivierentoolStripMenuItem1.Text = "Mitarbeiter aktivieren";
            this.mitarbeiterAktivierentoolStripMenuItem1.Click += new System.EventHandler(this.mitarbeiterAktivierentoolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(371, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(371, 6);
            // 
            // frmMitarbeiterListeAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 639);
            this.Controls.Add(this.btnNeueMitarbeiterHinzufügen);
            this.Controls.Add(this.lblRecordwert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagvMitarbeiter);
            this.Controls.Add(this.txtFilterwert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterbei);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMitarbeiterListeAnzeigen";
            this.Text = "MitarbeiterListe-Anzeigen";
            this.Load += new System.EventHandler(this.frmMitarbeiterListeAnzeigen_Load);
            this.cmsMitarbeiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvMitarbeiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsMitarbeiter;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterDetailsAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterAktualisierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterDeaktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterEntfernenToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFilterbei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterwert;
        private System.Windows.Forms.DataGridView datagvMitarbeiter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordwert;
        private System.Windows.Forms.ToolStripMenuItem arbeitersvertragErstellentoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem persondetailsanzeigentoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem arbeitsvertragAktualisierentoolStripMenuItem1;
        private System.Windows.Forms.Button btnNeueMitarbeiterHinzufügen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterAktivierentoolStripMenuItem1;
    }
}