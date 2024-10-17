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
    public class clsVergütungDaten
    {
        public int vergütungID { get; set; }
        public string entgeltgruppe { get; set; }
        public string vergütung {  get; set; }

        private clsVergütungDaten(int vergütungID, string entgeltgruppe, string vergütung)
        {
            this.vergütungID = vergütungID;
            this.entgeltgruppe = entgeltgruppe;
            this.vergütung = vergütung;
        }

        public static DataTable GetAllVergütungen()
        {
            return clsVergütungDatenzugriff.GetAllArbeitszeiten();
        }

        public static int GetVergütungID(string name)
        {
            return clsVergütungDatenzugriff.GetVergütungIDByName(name);
        }
        public static clsVergütungDaten FindByVergütungID(int ID)
        {
            string entgeltgruppe = string.Empty; string vergütung = string.Empty;
            if (clsVergütungDatenzugriff.FindByVergütungID(ID, ref entgeltgruppe, ref vergütung))
            {
                return new clsVergütungDaten(ID, entgeltgruppe, vergütung);
            }
            else
                return null;
        }
    }
}
