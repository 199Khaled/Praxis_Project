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
    public partial class frmAbteilungDetails : Form
    {
        int abteilungID;
        public frmAbteilungDetails(int abteilungID)
        {
            InitializeComponent();
            this.abteilungID = abteilungID;
        }

        private void _ladeAbteilungDatenVonDatenbank()
        {
            clsAbteilungDaten abteilungDaten = clsAbteilungDaten.FindByAbteilungID(abteilungID);
            if(abteilungDaten != null)
            {
                txtAbteilung.Text = abteilungDaten.abteilungName;
                txtBerufsbeschreibung.Text = abteilungDaten.berufsbeschreibung;
                txtQualifikation.Text = abteilungDaten.qualifikation;
            }
        }
        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAbteilungDetails_Load(object sender, EventArgs e)
        {
            _ladeAbteilungDatenVonDatenbank();
        }
    }
}
