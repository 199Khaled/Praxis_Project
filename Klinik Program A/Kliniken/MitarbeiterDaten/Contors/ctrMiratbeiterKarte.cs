using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class ctrMiratbeiterKarte : UserControl
    {
        clsMitarbeiterDaten _mitarbeiterDaten;
        public ctrMiratbeiterKarte()
        {
            InitializeComponent();
        }
        private void ctrMiratbeiterKarte_Load(object sender, EventArgs e)
        {

        }

        public void LoadMitarbeiterDatenByMitarbeiterID(int MitarbeiterId)
        {
            _mitarbeiterDaten = clsMitarbeiterDaten.Find(MitarbeiterId);

            if (_mitarbeiterDaten != null)
            {
                txtMitarbeiterID.Text = _mitarbeiterDaten.MitarbeiterID.ToString();
                txtVollname.Text = _mitarbeiterDaten.Vollname;
                txtUserID.Text = _mitarbeiterDaten.EingestelltBeiUser.ToString();
                txtVersicherung.Text = clsVersicherungDaten.Find(_mitarbeiterDaten.VersicherungsID).VersicherungsName;
                txtSteuerID.Text = _mitarbeiterDaten.SteuerID;  
                txtEingestelltAm.Text = _mitarbeiterDaten.EingestelltAm.ToString();
                txtGefeuertAm.Text = _mitarbeiterDaten.GefeuertAm;
                txtZustand.Text = _mitarbeiterDaten.Zustand;
                txtAbteilung.Text = "Muss noch gemacht werden!";
                
            }
            else
                MessageBox.Show("Keine Mitarbeiter mit dieser ID wurde gefunden", "Fehlermeldung");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
