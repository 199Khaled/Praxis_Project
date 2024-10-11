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
                lblMitarbeiterID.Text = _mitarbeiterDaten.MitarbeiterID.ToString();
                lblEingestelltBeiUser.Text = _mitarbeiterDaten.EingestelltBeiUser.ToString();
                lblIstAktive.Text = _mitarbeiterDaten.IstAtktive.ToString();
                txtSteuerID.Text = _mitarbeiterDaten.SteuerID;
         
                txtEingestelltAm.Text = _mitarbeiterDaten.EingestelltAm.ToString();
                txtGefeuertAm.Text = _mitarbeiterDaten.GefeuertAm;
                txtQualifikationen.Text = _mitarbeiterDaten.Qualifikationen;
                txtBerufsbezeichnung.Text = _mitarbeiterDaten.BerufsBezeichnung;
            }
            else
                MessageBox.Show("Keine Mitarbeiter mit dieser ID wurde gefunden", "Fehlermeldung");
        }
  

    }
}
