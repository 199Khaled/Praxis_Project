using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmArbeitszeitDetails : Form
    {
        int arbeitszeitID;
        public frmArbeitszeitDetails(int arbeitszeitID)
        {
            InitializeComponent();
            this.arbeitszeitID = arbeitszeitID;
        }

        private void _ladeArbeitszeitDatenVonDatenbank()
        {
            clsArbeitszeitDaten arbeitszeitDaten = clsArbeitszeitDaten.FindByArbeitszeitID(arbeitszeitID);
            if (arbeitszeitDaten != null)
            {
                txtArbeitszeit.Text = arbeitszeitDaten.arbeitzeit;
                txtBeschreibung.Text = arbeitszeitDaten.beschreibung;
            }
            else
                MessageBox.Show("Error");
            
        }
        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmArbeitszeitDetails_Load(object sender, EventArgs e)
        {
            _ladeArbeitszeitDatenVonDatenbank();
        }

        private void txtBeschreibung_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArbeitszeit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
