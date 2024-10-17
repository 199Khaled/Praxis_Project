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
    public partial class frmVergütungDetails : Form
    {
        int vergütungID = -1;
        public frmVergütungDetails(int vergütungID)
        {
            InitializeComponent();
            this.vergütungID = vergütungID;
        }

        private void _loadVergütungDatenVonDatenbank()
        {
            clsVergütungDaten vergütungDaten = clsVergütungDaten.FindByVergütungID(vergütungID);
            if (vergütungDaten != null)
            {
                txtEntgeltgruppe.Text = vergütungDaten.entgeltgruppe;
                txtVergütung.Text = vergütungDaten.vergütung;
            }
            else
                MessageBox.Show("Error, Some Message");
        }
        private void frmVergütungDetails_Load(object sender, EventArgs e)
        {
            _loadVergütungDatenVonDatenbank();
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
