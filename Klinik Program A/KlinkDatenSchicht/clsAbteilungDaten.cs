using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsAbteilungDaten
    {
        public int abteilungID { get; set; }
        public string abteilungName { get; set; }
        public string berufsbeschreibung { get; set; }
        public string qualifikation { get; set; }

        private clsAbteilungDaten(int abteilungID, string abteilungname, string berufsbeschreibung, string qualifikation)
        {
            this.abteilungID = abteilungID;
            this.abteilungName = abteilungname;
            this.berufsbeschreibung = berufsbeschreibung; 
            this.qualifikation = qualifikation;
        }
        public static DataTable GetAllAbteilungen()
        {
            return clsAbteilungDatenzugriff.GetAllArbeitszeiten();
        }

        public static int GetAbteilungID(string name)
        {
            return clsAbteilungDatenzugriff.GetAbteilungIDByName(name);
        }

        public static clsAbteilungDaten FindByAbteilungID(int abteilungID)
        {
            string abteilungname = string.Empty; string berufsbeschreibung = string.Empty; 
            string qualifikation = string.Empty;

            if (clsAbteilungDatenzugriff.FindByAbteilungID(abteilungID, ref abteilungname, ref berufsbeschreibung, ref qualifikation))
            {
                return new clsAbteilungDaten(abteilungID, abteilungname, berufsbeschreibung, qualifikation);
            }
            else
                return null;
        }
    }
}
