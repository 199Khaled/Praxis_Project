using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmMitarbeiterListeAnzeigen : Form
    {
        DataTable _dtMitarbeiter;
        DataTable _dtAbteilung;

        BindingSource _bindingsource;
        public frmMitarbeiterListeAnzeigen()
        {
            InitializeComponent();
            _bindingsource = new BindingSource();
        }

        private void frmMitarbeiterListeAnzeigen_Load(object sender, EventArgs e)
        {    
            _DataGridViewEinrichten();
            cbFilterbei.SelectedIndex = 0;
        }

        private void _DataGridViewEinrichten()
        {
            datagvMitarbeiter.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 13);
            datagvMitarbeiter.EnableHeadersVisualStyles = false;
            datagvMitarbeiter.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            _dtMitarbeiter = clsMitarbeiterDaten.GetAllMitarbeiter();
            _bindingsource.DataSource = _dtMitarbeiter;
            datagvMitarbeiter.DataSource = _bindingsource;

        }

        private void cbFilterbei_SelectedValueChanged(object sender, EventArgs e)
        {
            txtFilterwert.Visible = (cbFilterbei.Text != "Keine");

            if(cbFilterbei.Text != "Keine")
            {
                txtFilterwert.Clear();
                txtFilterwert.Focus();
                return;
            }
            _bindingsource.Filter = string.Empty;
            lblRecordwert.Text = _bindingsource.Count.ToString();
        }

        private void txtFilterwert_TextChanged(object sender, EventArgs e)
        {
            _FilterAnwenden();
            lblRecordwert.Text = _bindingsource.Count.ToString();
        }

        private void _FilterAnwenden()
        {
            string filterwert = txtFilterwert.Text;
            string filterspalte = cbFilterbei.Text;

            if (filterspalte == "Keine" || string.IsNullOrEmpty(filterwert))
            {
                _bindingsource.Filter = string.Empty;
                return;
            }

            if (filterspalte == "MitarbeiterID" && int.TryParse(filterwert, out int mitarbeiterID))
            {
                _bindingsource.Filter = $"{filterspalte} = {mitarbeiterID}";
                return;
            }

            if (filterspalte == "PersonID" && int.TryParse(filterwert, out int personID))
            {
                _bindingsource.Filter = $"{filterspalte} = {personID}";
            }
        }

        private void txtFilterwert_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filterspalte = cbFilterbei.Text;

            if (filterspalte == "MitarbeiterID" || filterspalte == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mitarbeiterDetailsAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mitarbeiterID = (int)datagvMitarbeiter.CurrentRow.Cells[0].Value;


            frmMitarbeiterDetailsAnzeigen frm = new frmMitarbeiterDetailsAnzeigen(mitarbeiterID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void mitarbeiterAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mitarbeiterID = (int)datagvMitarbeiter.CurrentRow.Cells[0].Value;

            frmAktualisierenUndNeuenMitarbeiterHinzufügen frm = 
                new frmAktualisierenUndNeuenMitarbeiterHinzufügen(frmAktualisierenUndNeuenMitarbeiterHinzufügen.enMode.UpdateByMitarbeiterID, mitarbeiterID);
            frm.ShowDialog();
            frm.Dispose();

            _DataGridViewEinrichten();
        }

        private void persondetailsanzeigentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int personID = (int)datagvMitarbeiter.CurrentRow.Cells[1].Value;

            frmPersonDatenAnzeigen frm = new frmPersonDatenAnzeigen(personID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void mitarbeiterDeaktivierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mitarbeiterID = (int)datagvMitarbeiter.CurrentRow.Cells[0].Value;

            bool istDeaktiviert = clsMitarbeiterDaten.deaktiviereMitarbeiter(mitarbeiterID);
            if(!istDeaktiviert)
            {
                MessageBox.Show("Der Vorgang konnte nicht durchgeführt werden.\nDer Mitarbeiter ist entweder Inktive oder Gekündigt.",
                  "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _DataGridViewEinrichten();
        }

        private void mitarbeiterEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mitarbeiterID = (int)datagvMitarbeiter.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show(
                            "Sind Sie sicher, dass Sie diesen Vorgang durchführen möchten?",
                            "Bestätigung",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes)
            {
                if (clsMitarbeiterDaten.Delete(mitarbeiterID))
                {
                    MessageBox.Show("Der Vorgang wurde erfolgreich durchgeführt!");
                    _DataGridViewEinrichten();
                }
                else
                    MessageBox.Show("Keine Daten für diesen Mitarbeiter wruden gefunden!", "fehlermeldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mitarbeiterAktivierentoolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int mitarbeiterID = (int)datagvMitarbeiter.CurrentRow.Cells[0].Value;

            bool istDeaktiviert = clsMitarbeiterDaten.aktiviereMitarbeiter(mitarbeiterID);
            if (!istDeaktiviert)
            {
                MessageBox.Show("Der Vorgang konnte nicht durchgeführt werden.\nDer Mitarbeiter ist entweder Aktive oder Gekündigt.",
                  "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _DataGridViewEinrichten();
        }

        private bool _IstValidiert(int mitarbeiterID)
        {
            if (mitarbeiterID == -1)
            {
                MessageBox.Show("Bitte wählen Sie eine gültige MitarbeiterID aus!", "Hinweis");
                return false;
            }

            if (clsMitarbeiterDaten.HatMitarbeiterEinenArbeitsvertrag(mitarbeiterID))
            {
                MessageBox.Show("Dieser Mitarbeiter hat bereits einen Arbeitsvertrag!", "Hinweis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void arbeitersvertragErstellentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int mitarbeiterID = (int)datagvMitarbeiter.CurrentRow.Cells[0].Value;

            if (!_IstValidiert(mitarbeiterID))
                return;

            frmAktualiserenUndNeuenArbeitsvertragHinzufügen frm =
           new frmAktualiserenUndNeuenArbeitsvertragHinzufügen(frmAktualiserenUndNeuenArbeitsvertragHinzufügen.enMode.addnew, mitarbeiterID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void arbeitsvertragAktualisierentoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int mitarbeiterID = (int)datagvMitarbeiter.CurrentRow.Cells[0].Value;

            bool bestehtVertrag = clsMitarbeiterDaten.HatMitarbeiterEinenArbeitsvertrag(mitarbeiterID);
            if(!bestehtVertrag)
            {
                MessageBox.Show("Für diesen Mitarbeiter wurde noch keinen Vertrag erstellt.",
                  "Vertrag nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            frmAktualiserenUndNeuenArbeitsvertragHinzufügen frm =
          new frmAktualiserenUndNeuenArbeitsvertragHinzufügen(frmAktualiserenUndNeuenArbeitsvertragHinzufügen.enMode.update, mitarbeiterID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnNeueMitarbeiterHinzufügen_Click(object sender, EventArgs e)
        {
            frmAktualisierenUndNeuenMitarbeiterHinzufügen frm =
                new frmAktualisierenUndNeuenMitarbeiterHinzufügen();
            frm.ShowDialog();
            frm.Dispose();

            _DataGridViewEinrichten();
        }

        private void cbAbteilung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
