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
    public partial class frmMitarbeiterListeAnzeigen : Form
    {
        DataTable dtMitarbeiter;
        public frmMitarbeiterListeAnzeigen()
        {
            InitializeComponent();
        }

        private void frmMitarbeiterListeAnzeigen_Load(object sender, EventArgs e)
        {
            dtMitarbeiter = clsMitarbeiterDaten.GetAllMitarbeiter();
            dgvMitarbeiter.DataSource = dtMitarbeiter;

        }

  
    }
}
