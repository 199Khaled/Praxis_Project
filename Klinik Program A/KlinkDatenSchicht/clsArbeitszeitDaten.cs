using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
     public class clsArbeitszeitDaten
    {
        public int arbeitszeitID { get; set; }
        public string arbeitzeit { get; set; }
        public string beschreibung { get; set; }

        private clsArbeitszeitDaten(int arbeitszeitID, string arbeitzeit, string beschreibung)
        {
            this.arbeitszeitID = arbeitszeitID;
            this.arbeitzeit = arbeitzeit;
            this.beschreibung = beschreibung;
        }
    
        public static DataTable GetAllArbeitszeiten()
        {
            return clsArbeitszeitDatenzugriff.GetAllArbeitszeiten();
        }
        public static int GetArbeitszeitID(string name)
        {
            return clsArbeitszeitDatenzugriff.GetArbeitszeitIDByName(name);
        }
        public static clsArbeitszeitDaten FindByArbeitszeitID(int ID)
        {
            string arbeitszeit = string.Empty; string beschreibung = string.Empty;

            if (clsArbeitszeitDatenzugriff.FindByArbeitszeitID(ID, ref arbeitszeit, ref beschreibung))
            {
                return new clsArbeitszeitDaten(ID, arbeitszeit, beschreibung);
            }
            else
                return null;
        }
    }
}
