namespace Kliniken
{
    partial class frmMainSystemScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalVerwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonenListeAnzeigentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientVerwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientenListeAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuenPatientenHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ärtzeVerwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fachrichtungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ärzteListeAnziegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuenArztHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerVerwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerListeAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuenBenutzerHinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterVerwaltungtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueMitarbeiterHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountEinstellungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktuellenBenutzerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwortÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalVerwaltungToolStripMenuItem,
            this.patientVerwaltungToolStripMenuItem,
            this.ärtzeVerwaltungToolStripMenuItem,
            this.benutzerVerwaltungToolStripMenuItem,
            this.mitarbeiterVerwaltungtoolStripMenuItem1,
            this.accountEinstellungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1377, 100);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalVerwaltungToolStripMenuItem
            // 
            this.personalVerwaltungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.personalVerwaltungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonenListeAnzeigentoolStripMenuItem1});
            this.personalVerwaltungToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personalVerwaltungToolStripMenuItem.Name = "personalVerwaltungToolStripMenuItem";
            this.personalVerwaltungToolStripMenuItem.Size = new System.Drawing.Size(233, 92);
            this.personalVerwaltungToolStripMenuItem.Text = "Personalverwaltung";
            // 
            // PersonenListeAnzeigentoolStripMenuItem1
            // 
            this.PersonenListeAnzeigentoolStripMenuItem1.Image = global::Kliniken.Properties.Resources.People_64;
            this.PersonenListeAnzeigentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PersonenListeAnzeigentoolStripMenuItem1.Name = "PersonenListeAnzeigentoolStripMenuItem1";
            this.PersonenListeAnzeigentoolStripMenuItem1.Size = new System.Drawing.Size(393, 70);
            this.PersonenListeAnzeigentoolStripMenuItem1.Text = "Personen Liste anzeigen";
            this.PersonenListeAnzeigentoolStripMenuItem1.Click += new System.EventHandler(this.PersonenListeAnzeigentoolStripMenuItem1_Click);
            // 
            // patientVerwaltungToolStripMenuItem
            // 
            this.patientVerwaltungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.patientVerwaltungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientenListeAnzeigenToolStripMenuItem,
            this.neuenPatientenHinzufügenToolStripMenuItem});
            this.patientVerwaltungToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.patientVerwaltungToolStripMenuItem.Name = "patientVerwaltungToolStripMenuItem";
            this.patientVerwaltungToolStripMenuItem.Size = new System.Drawing.Size(217, 92);
            this.patientVerwaltungToolStripMenuItem.Text = "Patientverwaltung";
            // 
            // patientenListeAnzeigenToolStripMenuItem
            // 
            this.patientenListeAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.medical_team__4_;
            this.patientenListeAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.patientenListeAnzeigenToolStripMenuItem.Name = "patientenListeAnzeigenToolStripMenuItem";
            this.patientenListeAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(452, 78);
            this.patientenListeAnzeigenToolStripMenuItem.Text = "Patienten Liste anzeigen";
            this.patientenListeAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.patientenListeAnzeigenToolStripMenuItem_Click);
            // 
            // neuenPatientenHinzufügenToolStripMenuItem
            // 
            this.neuenPatientenHinzufügenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Add_Person_72;
            this.neuenPatientenHinzufügenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.neuenPatientenHinzufügenToolStripMenuItem.Name = "neuenPatientenHinzufügenToolStripMenuItem";
            this.neuenPatientenHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(452, 78);
            this.neuenPatientenHinzufügenToolStripMenuItem.Text = "Neuen Patienten hinzufügen";
            this.neuenPatientenHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.neuenPatientenHinzufügenToolStripMenuItem_Click);
            // 
            // ärtzeVerwaltungToolStripMenuItem
            // 
            this.ärtzeVerwaltungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ärtzeVerwaltungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fachrichtungenToolStripMenuItem,
            this.ärzteListeAnziegenToolStripMenuItem,
            this.neuenArztHinzufügenToolStripMenuItem});
            this.ärtzeVerwaltungToolStripMenuItem.Name = "ärtzeVerwaltungToolStripMenuItem";
            this.ärtzeVerwaltungToolStripMenuItem.Size = new System.Drawing.Size(199, 92);
            this.ärtzeVerwaltungToolStripMenuItem.Text = "Ärtzeverwaltung";
            // 
            // fachrichtungenToolStripMenuItem
            // 
            this.fachrichtungenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.doctor__1_;
            this.fachrichtungenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fachrichtungenToolStripMenuItem.Name = "fachrichtungenToolStripMenuItem";
            this.fachrichtungenToolStripMenuItem.Size = new System.Drawing.Size(410, 70);
            this.fachrichtungenToolStripMenuItem.Text = "Fachrichtungen verwalten";
            this.fachrichtungenToolStripMenuItem.Click += new System.EventHandler(this.fachrichtungenToolStripMenuItem_Click);
            // 
            // ärzteListeAnziegenToolStripMenuItem
            // 
            this.ärzteListeAnziegenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.doctor;
            this.ärzteListeAnziegenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ärzteListeAnziegenToolStripMenuItem.Name = "ärzteListeAnziegenToolStripMenuItem";
            this.ärzteListeAnziegenToolStripMenuItem.Size = new System.Drawing.Size(410, 70);
            this.ärzteListeAnziegenToolStripMenuItem.Text = "Ärzte Liste anziegen";
            this.ärzteListeAnziegenToolStripMenuItem.Click += new System.EventHandler(this.ärzteListeAnziegenToolStripMenuItem_Click);
            // 
            // neuenArztHinzufügenToolStripMenuItem
            // 
            this.neuenArztHinzufügenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.doctor;
            this.neuenArztHinzufügenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.neuenArztHinzufügenToolStripMenuItem.Name = "neuenArztHinzufügenToolStripMenuItem";
            this.neuenArztHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(410, 70);
            this.neuenArztHinzufügenToolStripMenuItem.Text = "Neuen Arzt hinzufügen";
            this.neuenArztHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.neuenArztHinzufügenToolStripMenuItem_Click);
            // 
            // benutzerVerwaltungToolStripMenuItem
            // 
            this.benutzerVerwaltungToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.benutzerVerwaltungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerListeAnzeigenToolStripMenuItem,
            this.neuenBenutzerHinzufügenToolStripMenuItem1});
            this.benutzerVerwaltungToolStripMenuItem.Name = "benutzerVerwaltungToolStripMenuItem";
            this.benutzerVerwaltungToolStripMenuItem.Size = new System.Drawing.Size(239, 92);
            this.benutzerVerwaltungToolStripMenuItem.Text = "Benutzerverwaltung";
            // 
            // benutzerListeAnzeigenToolStripMenuItem
            // 
            this.benutzerListeAnzeigenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Add_New_User_72;
            this.benutzerListeAnzeigenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.benutzerListeAnzeigenToolStripMenuItem.Name = "benutzerListeAnzeigenToolStripMenuItem";
            this.benutzerListeAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(439, 70);
            this.benutzerListeAnzeigenToolStripMenuItem.Text = "Benutzer Liste anzeigen";
            this.benutzerListeAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.benutzerListeAnzeigenToolStripMenuItem_Click);
            // 
            // neuenBenutzerHinzufügenToolStripMenuItem1
            // 
            this.neuenBenutzerHinzufügenToolStripMenuItem1.Image = global::Kliniken.Properties.Resources.Add_New_User_72;
            this.neuenBenutzerHinzufügenToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.neuenBenutzerHinzufügenToolStripMenuItem1.Name = "neuenBenutzerHinzufügenToolStripMenuItem1";
            this.neuenBenutzerHinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(439, 70);
            this.neuenBenutzerHinzufügenToolStripMenuItem1.Text = "Neuen Benutzer hinzufügen";
            this.neuenBenutzerHinzufügenToolStripMenuItem1.Click += new System.EventHandler(this.neuenBenutzerHinzufügenToolStripMenuItem1_Click);
            // 
            // mitarbeiterVerwaltungtoolStripMenuItem1
            // 
            this.mitarbeiterVerwaltungtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitarToolStripMenuItem,
            this.neueMitarbeiterHinzufügenToolStripMenuItem});
            this.mitarbeiterVerwaltungtoolStripMenuItem1.Name = "mitarbeiterVerwaltungtoolStripMenuItem1";
            this.mitarbeiterVerwaltungtoolStripMenuItem1.Size = new System.Drawing.Size(262, 92);
            this.mitarbeiterVerwaltungtoolStripMenuItem1.Text = "Mitarbeiterverwaltung";
            // 
            // mitarToolStripMenuItem
            // 
            this.mitarToolStripMenuItem.Image = global::Kliniken.Properties.Resources.users_64;
            this.mitarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarToolStripMenuItem.Name = "mitarToolStripMenuItem";
            this.mitarToolStripMenuItem.Size = new System.Drawing.Size(448, 70);
            this.mitarToolStripMenuItem.Text = "Mitarbeiter Liste anzeigen";
            this.mitarToolStripMenuItem.Click += new System.EventHandler(this.mitarToolStripMenuItem_Click);
            // 
            // neueMitarbeiterHinzufügenToolStripMenuItem
            // 
            this.neueMitarbeiterHinzufügenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.users_64;
            this.neueMitarbeiterHinzufügenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.neueMitarbeiterHinzufügenToolStripMenuItem.Name = "neueMitarbeiterHinzufügenToolStripMenuItem";
            this.neueMitarbeiterHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(448, 70);
            this.neueMitarbeiterHinzufügenToolStripMenuItem.Text = "Neue Mitarbeiter hinzufügen";
            this.neueMitarbeiterHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.neueMitarbeiterHinzufügenToolStripMenuItem_Click);
            // 
            // accountEinstellungToolStripMenuItem
            // 
            this.accountEinstellungToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accountEinstellungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktuellenBenutzerInfoToolStripMenuItem,
            this.passwortÄndernToolStripMenuItem,
            this.abmeldenToolStripMenuItem});
            this.accountEinstellungToolStripMenuItem.Name = "accountEinstellungToolStripMenuItem";
            this.accountEinstellungToolStripMenuItem.Size = new System.Drawing.Size(231, 92);
            this.accountEinstellungToolStripMenuItem.Text = "Accounteinstellung";
            // 
            // aktuellenBenutzerInfoToolStripMenuItem
            // 
            this.aktuellenBenutzerInfoToolStripMenuItem.Image = global::Kliniken.Properties.Resources.PersonDetails_32;
            this.aktuellenBenutzerInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktuellenBenutzerInfoToolStripMenuItem.Name = "aktuellenBenutzerInfoToolStripMenuItem";
            this.aktuellenBenutzerInfoToolStripMenuItem.Size = new System.Drawing.Size(356, 38);
            this.aktuellenBenutzerInfoToolStripMenuItem.Text = "Aktuellen Benutzer Info";
            this.aktuellenBenutzerInfoToolStripMenuItem.Click += new System.EventHandler(this.aktuellenBenutzerInfoToolStripMenuItem_Click);
            // 
            // passwortÄndernToolStripMenuItem
            // 
            this.passwortÄndernToolStripMenuItem.Image = global::Kliniken.Properties.Resources.Password_32;
            this.passwortÄndernToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.passwortÄndernToolStripMenuItem.Name = "passwortÄndernToolStripMenuItem";
            this.passwortÄndernToolStripMenuItem.Size = new System.Drawing.Size(356, 38);
            this.passwortÄndernToolStripMenuItem.Text = "Passwort ändern";
            this.passwortÄndernToolStripMenuItem.Click += new System.EventHandler(this.passwortÄndernToolStripMenuItem_Click);
            // 
            // abmeldenToolStripMenuItem
            // 
            this.abmeldenToolStripMenuItem.Image = global::Kliniken.Properties.Resources.sign_out_32__2;
            this.abmeldenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.abmeldenToolStripMenuItem.Name = "abmeldenToolStripMenuItem";
            this.abmeldenToolStripMenuItem.Size = new System.Drawing.Size(356, 38);
            this.abmeldenToolStripMenuItem.Text = "Abmelden";
            this.abmeldenToolStripMenuItem.Click += new System.EventHandler(this.abmeldenToolStripMenuItem_Click);
            // 
            // frmMainSystemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 639);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainSystemScreen";
            this.Text = "frmMainSystemScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainSystemScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmMainSystemScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalVerwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientVerwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ärtzeVerwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fachrichtungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ärzteListeAnziegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerVerwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerListeAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountEinstellungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuenArztHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuenBenutzerHinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientenListeAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuenPatientenHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktuellenBenutzerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwortÄndernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmeldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonenListeAnzeigentoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterVerwaltungtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueMitarbeiterHinzufügenToolStripMenuItem;
    }
}