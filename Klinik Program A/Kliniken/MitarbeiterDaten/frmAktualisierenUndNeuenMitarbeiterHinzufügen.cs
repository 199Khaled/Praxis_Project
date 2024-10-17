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
    public partial class frmAktualisierenUndNeuenMitarbeiterHinzufügen : Form
    {
        private int _PersonID = -1;
        private int _MitarbeiterID = -1;
        public enum enMode { AddNew = 1, UpdateByPersonID = 2, UpdateByMitarbeiterID = 3}
        private enMode _Mode = enMode.AddNew;

        public frmAktualisierenUndNeuenMitarbeiterHinzufügen()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAktualisierenUndNeuenMitarbeiterHinzufügen(enMode Mode, int ID)
        {
            InitializeComponent();

            _Mode = Mode;
            if (_Mode == enMode.UpdateByPersonID)
                _PersonID = ID;
            else
                _MitarbeiterID = ID;
         
        }
        private void frmAktualisierenUndNeuenMitarbeiterHinzufügen_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
                ctrPersonFilter1.txtFilterWertSetzen(_PersonID);

            if (_MitarbeiterID != -1)
            {
                ctrPersonFilter1.Enabled = false;
                btnDatenSpeichern.Enabled = true;
                _PassendeDatenSetzen();
            }
                
        }     
        private void btnDatenSpeichern_Click(object sender, EventArgs e)
        {
            _DatenFürSpeichernRichten();
        }

        private void _DatenFürSpeichernRichten()
        {

            if (_Mode == enMode.UpdateByMitarbeiterID || _Mode == enMode.UpdateByPersonID)
            {
                if (ctrMitarbeiterEinfügen1.MitarbeiterDatenSpeichern())
                {
                    MessageBox.Show("Mitarbeiterdaten wurden erfolgreich aktualisiert",
                               "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Fehler beim Aktualisieren der Mitarbeiterdaten ist aufgetreten",
                               "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_Mode == enMode.AddNew)
            {
                if (ctrMitarbeiterEinfügen1.MitarbeiterDatenSpeichern())
                {
                    MessageBox.Show("Mitarbeiterdaten wurden erfolgreich hinzugefügt!",
                              "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fehler beim DatenSpeichern des Mitarbeiters ist aufgetreten",
                                    "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
 
        private bool _IsValidiert()
        {
            
            if (clsPatientDaten.IsPatientExistForPersonID(_PersonID))
            {
                MessageBox.Show("Diese Person ist bereits als Patient im System defeniert!!",
                   "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clsArztDaten.IsDoctorExistForPersonID(_PersonID))
            {
                MessageBox.Show("Diese Person ist bereits als Arzt im System definiert!!",
                    "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (clsMitarbeiterDaten.DoesMitarbeiterExistForThisPerson(_PersonID))
            {
                if (clsMitarbeiterDaten.IsMitarbeiterActiveForThisPerson(_PersonID))
                {
                    MessageBox.Show("Diese Person ist bereits als Mitarbeiter und Aktive im System defeniert!!",
                        "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Diese Person ist bereits als Mitarbeiter aber nicht mehr Aktive im System defeniert!!",
                        "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return false;
            }
            return true;
        }

        private void ctrPersonFilter1_OnSelectedPersonID(int obj)
        {
            _PersonID = obj;
            if (_Mode == enMode.AddNew)
            {
                if (!_IsValidiert())
                {
                    return;
                }
            }
          
            btnDatenSpeichern.Enabled = true;           
            _PassendeDatenSetzen();
        }

        private void _PassendeDatenSetzen()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    ctrMitarbeiterEinfügen1.AddNew(true, _PersonID);
                    break;

                case enMode.UpdateByPersonID:
                    ctrMitarbeiterEinfügen1.LoadMitarbeiterDataByPersonID(_PersonID);
                    break;

                case enMode.UpdateByMitarbeiterID:
                    ctrMitarbeiterEinfügen1.LoadMitarbeiterDataByMitarbeiterID(_MitarbeiterID);
                    break;

                default:
                    ctrMitarbeiterEinfügen1.AddNew(true, _PersonID);
                    break;
            }

        }
        private void ctrMitarbeiterEinfügen1_OnMitarbeiterSelectedID(int obj)
        {
            _MitarbeiterID = obj;

        }

        private void ctrMitarbeiterEinfügen3_Load(object sender, EventArgs e)
        {

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
