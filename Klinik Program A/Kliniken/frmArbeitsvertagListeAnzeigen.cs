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
    public partial class frmArbeitsvertagListeAnzeigen : Form
    {
        public frmArbeitsvertagListeAnzeigen()
        {
            InitializeComponent();
        }

        private void _ladeAllAbteilungen()
        {
            DataTable dtAbteilung = clsAbteilungDaten.GetAllAbteilungen();
            cbAbteilung.Items.Clear();

            if (dtAbteilung != null)
            {
                foreach (DataRow zeile in dtAbteilung.Rows)
                {
                    cbAbteilung.Items.Add(zeile["Abteilungname"]);
                }
            }
            cbAbteilung.SelectedIndex = 0;
        }
        private void frmArbeitsvertagListeAnzeigen_Load(object sender, EventArgs e)
        {
            _ladeAllAbteilungen();
        }
    }
}
