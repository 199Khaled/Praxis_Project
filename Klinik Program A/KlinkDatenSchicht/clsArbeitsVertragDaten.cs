using HilfsMethoden;
using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
    public class clsArbeitsVertragDaten
    {
        public enum enMode { addnew = 0, update = 1 }
        enMode mode = enMode.addnew;
        public int vertragID { get; set; }
        public int mitarbeiterID { get; set; }
        public int vergütungID { get; set; }
        public clsVergütungDaten vergütungInfos => clsVergütungDaten.FindByVergütungID(vergütungID);
        public int arbeitszeitID { get; set; }
        public clsArbeitszeitDaten arbeitszeitInfos => clsArbeitszeitDaten.FindByArbeitszeitID(arbeitszeitID);
        public int bezahlungmethodeID { get; set; }
        public clsBezalungmethodenDaten bezahlungmethodeInfos => clsBezalungmethodenDaten.FindByBezahlungmethodeID(bezahlungmethodeID);
        public int urlaubsanspruch { get; set; }
        public DateTime startdatum { get; set; }
        public DateTime enddatum { get; set; }
        public int abteilugsID { get; set; }
        public clsAbteilungDaten abteilungInfos => clsAbteilungDaten.FindByAbteilungID(abteilugsID);
        public bool HatProbezeit { get; set; }
        public bool istAtkive { get; set; }

    
       private clsArbeitsVertragDaten(int vertargID, int mitarbeiterID, int vergütungID, int arbeitszeitID, int bezahlungmethodeID, 
             int urlaubsanspruch, DateTime startdatum, DateTime enddatum, int abteilugsID, bool istInprobezeit, bool istAktive)
        {
            this.vertragID = vertargID;
            this.mitarbeiterID = mitarbeiterID;
            this.vergütungID = vergütungID;
            this.arbeitszeitID = arbeitszeitID;
            this.bezahlungmethodeID = bezahlungmethodeID;
            this.urlaubsanspruch = urlaubsanspruch;
            this.startdatum = startdatum;
            this.enddatum = enddatum;
            this.abteilugsID = abteilugsID;
            this.HatProbezeit = istInprobezeit;
            this.istAtkive = istAktive;

            mode = enMode.update;
        }
        public clsArbeitsVertragDaten()
        {
            this.vertragID = -1;
            this.mitarbeiterID = -1;
            this.vergütungID = -1;
            this.arbeitszeitID = -1;
            this.bezahlungmethodeID = -1;
            this.urlaubsanspruch = 25;
            this.startdatum = DateTime.Now.Date;
            this.enddatum = DateTime.Now.AddMonths(3);
            this.abteilugsID = -1;
            this.HatProbezeit = true;
            this.istAtkive = true;

            mode = enMode.addnew;
        }

        public static clsArbeitsVertragDaten FindByID(int vertragID)
        {
            int mitarbeiterID = -1; int vergütungID = -1; int arbeitszeitID = -1;   int bezahlungmethodeID = -1;
            int urlaubsanspruch = 25; DateTime startdatum = DateTime.MinValue; DateTime enddatum = DateTime.MinValue;
            int abteilungID = -1; bool hatProbezeit = false; bool istAktive = false;

            if (clsArbeitsvertragDatenzugriff.FindByVertragID(vertragID, ref mitarbeiterID, ref vergütungID, ref arbeitszeitID,
                ref bezahlungmethodeID, ref urlaubsanspruch, ref startdatum,
                ref enddatum, ref abteilungID, ref hatProbezeit, ref istAktive))
            {
                return new clsArbeitsVertragDaten(vertragID, mitarbeiterID, vergütungID, arbeitszeitID, bezahlungmethodeID,
                    urlaubsanspruch, startdatum, enddatum, abteilungID, hatProbezeit, istAktive);
            }
            else
                return null;        
        }

        public static clsArbeitsVertragDaten FindByMitarbeiterID(int mitarbeiterID)
        {
            int vertragId = -1; int vergütungID = -1; int arbeitszeitID = -1; int bezahlungmethodeID = -1;
            int urlaubsanspruch = 25; DateTime startdatum = DateTime.MinValue; DateTime enddatum = DateTime.MinValue;
            int abteilungID = -1; bool hatProbezeit = false; bool istAktive = false;

            if (clsArbeitsvertragDatenzugriff.FindByMitarbeiterID(ref vertragId, mitarbeiterID, ref vergütungID, ref arbeitszeitID,
                ref bezahlungmethodeID, ref urlaubsanspruch, ref startdatum,
                ref enddatum, ref abteilungID, ref hatProbezeit, ref istAktive))
            {
                return new clsArbeitsVertragDaten(vertragId, mitarbeiterID, vergütungID, arbeitszeitID, bezahlungmethodeID,
                    urlaubsanspruch, startdatum, enddatum, abteilungID, hatProbezeit, istAktive);
            }
            else
                return null;
        }
        private bool _Addnew()
        {
            this.vertragID = clsArbeitsvertragDatenzugriff.AddNewArbeitsvertrag(this.mitarbeiterID, this.vergütungID, this.arbeitszeitID, this.bezahlungmethodeID,
                this.urlaubsanspruch, this.startdatum, this.enddatum, this.abteilugsID, this.HatProbezeit, this.istAtkive);


            return (this.vertragID != -1);
        }

        private bool _Update()
        {
            return clsArbeitsvertragDatenzugriff.UpdateVertragByMitArbeiterID(this.mitarbeiterID, this.vergütungID,
                this.arbeitszeitID, this.bezahlungmethodeID, this.urlaubsanspruch, this.startdatum, this.enddatum,
                this.abteilugsID, this.HatProbezeit, this.istAtkive);
        }
        public bool Save()
        {
            switch(mode)
            {
                case enMode.addnew:
                    if (_Addnew())
                    {
                        mode = enMode.update;
                        return true;
                    }
                    else
                        return false;
                case enMode.update:
                    return _Update();
            }
            return false;
        }
    }
}
