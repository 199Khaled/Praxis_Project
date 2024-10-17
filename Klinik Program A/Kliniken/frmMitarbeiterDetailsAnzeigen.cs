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
    public partial class frmMitarbeiterDetailsAnzeigen : Form
    {
        int mitarbeiterId;
        public frmMitarbeiterDetailsAnzeigen(int mitarbeiterId)
        {
            InitializeComponent();
            this.mitarbeiterId = mitarbeiterId; 
        }

        private void frmMitarbeiterDetailsAnzeigen_Load(object sender, EventArgs e)
        {
            ctrMiratbeiterKarte1.LoadMitarbeiterDatenByMitarbeiterID(mitarbeiterId);
        }
    }
}
