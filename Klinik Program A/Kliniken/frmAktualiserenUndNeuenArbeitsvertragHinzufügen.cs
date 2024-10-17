using KlinkDatenSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kliniken
{
    public partial class frmAktualiserenUndNeuenArbeitsvertragHinzufügen : Form
    {
        public enum enMode { addnew = 0, update = 1 }
        enMode mode = enMode.addnew;

        clsArbeitsVertragDaten vertragDaten;
        int MitarbeiterID = -1;
        public frmAktualiserenUndNeuenArbeitsvertragHinzufügen(enMode mode, int mitarbeiterID)
        {
            InitializeComponent();

            this.MitarbeiterID = mitarbeiterID;
            this.mode = mode;
        }

        private void _ladeAbteilungen()
        {
            DataTable dtAbteilung = clsAbteilungDaten.GetAllAbteilungen();
            cbAbteilung.Items.Clear();

            if(dtAbteilung != null)
            {
                foreach(DataRow zeile in dtAbteilung.Rows )
                {
                    cbAbteilung.Items.Add(zeile["Abteilungname"]);
                }
            }
            cbAbteilung.SelectedIndex = 0;
        }
        private void _ladeAllArbeitszeiten()
        {
            DataTable dtArbeitszeit = clsArbeitszeitDaten.GetAllArbeitszeiten();
            cbArbeitszeit.Items.Clear();

            if (dtArbeitszeit != null)
            {
                foreach (DataRow row in dtArbeitszeit.Rows)
                {
                    cbArbeitszeit.Items.Add(row["Arbeitszeit"]);
                }
            }
            cbArbeitszeit.SelectedIndex = 0;
        }

        private void _ladeAllVergütungen()
        {
            DataTable dtVergütung = clsVergütungDaten.GetAllVergütungen();
            cbVergütung.Items.Clear();

            if (dtVergütung != null)
            {
                foreach (DataRow row in dtVergütung.Rows)
                {
                    cbVergütung.Items.Add(row["Entgeltgruppen"]);
                }
            }
            cbVergütung.SelectedIndex = 0;
        }

        private void _ladeAllBezahlungmethoden()
        {
            DataTable dtmethoden = clsBezalungmethodenDaten.GetAllBezahlungmethoden();
            cbBezahlungsmethode.Items.Clear();

            if (dtmethoden != null)
            {
                foreach (DataRow zeile in dtmethoden.Rows)
                {
                    cbBezahlungsmethode.Items.Add(zeile["BezahlungmethodeName"]);
                }
            }
            cbBezahlungsmethode.SelectedIndex = 3;
        }

       

        private void _datumEinrichten()
        {
            dtpStartdatum.Format = DateTimePickerFormat.Custom;
            dtpEnddatum.Format = DateTimePickerFormat.Custom;
            dtpStartdatum.CustomFormat = "dd.MM.yyyy";
            dtpEnddatum.CustomFormat = "dd.MM.yyyy";

            //wenn da eine probe zeit markiert ist.
            dtpEnddatum.Value = DateTime.Now.Date.AddMonths(3);

        }

        private void _FillAlleDatenAus()
        {
            _ladeAllArbeitszeiten();
            _ladeAllVergütungen();
            _ladeAllBezahlungmethoden();
            _ladeAbteilungen();

            _datumEinrichten();

            //ich habe Zahlen für einen Urlaub bereitgestellt.
            urlaubsansruchdomainUpDown1.SelectedIndex = 2;

            txtMitarbeiterID.Text = MitarbeiterID.ToString();
        }
        private void frmAktualiserenUndNeuenArbeitsvertragHinzufügen_Load(object sender, EventArgs e)
        {
     
               _FillAlleDatenAus();
              if(mode == enMode.update)
                _HoleVertragsDatenVonDatenbank();
        }

        private void _HoleVertragsDatenVonDatenbank()
        {
            vertragDaten = clsArbeitsVertragDaten.FindByMitarbeiterID(MitarbeiterID);

            if (vertragDaten != null)
            {
                txtVertragID.Text = vertragDaten.vertragID.ToString();
                txtMitarbeiterID.Text = vertragDaten.mitarbeiterID.ToString();
                cbVergütung.SelectedIndex = cbVergütung.FindString(vertragDaten.vergütungInfos.entgeltgruppe);
                cbArbeitszeit.SelectedIndex = cbArbeitszeit.FindString(vertragDaten.arbeitszeitInfos.arbeitzeit);
                cbBezahlungsmethode.SelectedIndex = cbBezahlungsmethode.FindString(vertragDaten.bezahlungmethodeInfos.bezahlungmethodename);
                urlaubsansruchdomainUpDown1.Text = vertragDaten.urlaubsanspruch.ToString();
                dtpStartdatum.Value = vertragDaten.startdatum;
                dtpEnddatum.Value = vertragDaten.enddatum;
                cbAbteilung.SelectedIndex = cbAbteilung.FindString(vertragDaten.abteilungInfos.abteilungName);
                chbHatProbezeit.Checked = vertragDaten.HatProbezeit;
                chbIstAtkive.Checked = vertragDaten.istAtkive;
            }
            else
                MessageBox.Show("Arbeitsvertrag wurde nicht gefunden.", 
                    "Vertrag nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void _ÜbertrageVertragsDatenZuDatenbank()
        {
            if (mode == enMode.addnew)
            {
                vertragDaten = new clsArbeitsVertragDaten();
            }

            vertragDaten.mitarbeiterID = Convert.ToInt32(txtMitarbeiterID.Text);
            vertragDaten.vergütungID = clsVergütungDaten.GetVergütungID(cbVergütung.Text);
            vertragDaten.arbeitszeitID = clsArbeitszeitDaten.GetArbeitszeitID(cbArbeitszeit.Text);
            vertragDaten.bezahlungmethodeID = clsBezalungmethodenDaten.GetBezahlungmethodeID(cbBezahlungsmethode.Text);
            vertragDaten.urlaubsanspruch = Convert.ToInt16(urlaubsansruchdomainUpDown1.Text);
            vertragDaten.startdatum = dtpStartdatum.Value;
            vertragDaten.enddatum = dtpEnddatum.Value;
            vertragDaten.abteilugsID = clsAbteilungDaten.GetAbteilungID(cbAbteilung.Text);
            vertragDaten.HatProbezeit = (chbHatProbezeit.Checked) ? true : false;
            vertragDaten.istAtkive = (chbIstAtkive.Checked) ? true : false;
        }


        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _ÜbertrageVertragsDatenZuDatenbank();

            string status = string.Empty;
            if (mode == enMode.update)
                status = "aktualisiert";
            else
                status = "hinzugefügt";

            if (vertragDaten.Save())
            {
                MessageBox.Show("Vertragsdaten wurden erfolgreich " + status + ".", "Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVertragID.Text = vertragDaten.vertragID.ToString();
                btnSpeichern.Enabled = false;
            }
            else
            {
                MessageBox.Show("Fehler beim " + status + " der Vertragsdaten. Bitte erneut versuchen.", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVergütungDetails_Click(object sender, EventArgs e)
        {
            frmVergütungDetails frm = new frmVergütungDetails(vertragDaten.vergütungID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnArbeitszeitDetails_Click(object sender, EventArgs e)
        {
            frmArbeitszeitDetails frm = new frmArbeitszeitDetails(vertragDaten.arbeitszeitID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnAbteilungDetails_Click(object sender, EventArgs e)
        {
            frmAbteilungDetails frm = new frmAbteilungDetails(vertragDaten.abteilugsID);
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
