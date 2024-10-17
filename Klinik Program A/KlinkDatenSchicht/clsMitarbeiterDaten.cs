using KlinikDatenZugriffsSchicht;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KlinkDatenSchicht
{
   public class clsMitarbeiterDaten 
    {
        public enum enMode { addNew = 0, Update = 1}
        public enMode Mode = enMode.addNew;

        public int MitarbeiterID { get; set; }
        public int PersonID { get; set; }
        public clsPersonDaten personInfo => clsPersonDaten.Find(this.PersonID);

        public string Vollname => clsPersonDaten.Find(this.PersonID).Vollname;
        public int VersicherungsID { get; set; }
        public string SteuerID { get; set; }
        public DateTime EingestelltAm { get; set; }
        public string GefeuertAm { get; set; }
        public int EingestelltBeiUser { get; set; }
        public string Zustand { get; set; }

        private clsMitarbeiterDaten(int mitarbeiterID, int personID, int versicherungsID, string steuerID,
            DateTime eingestelltAm,string gefeuertAm, int eingestelltBeiUser, string zustand)
        {
            this.MitarbeiterID = mitarbeiterID;
            this.PersonID = personID;
            this.VersicherungsID = versicherungsID;
            this.SteuerID = steuerID;
            this.EingestelltAm = eingestelltAm;
            this.GefeuertAm = gefeuertAm;
            this.EingestelltBeiUser = eingestelltBeiUser;
            this.Zustand = zustand;
            Mode = enMode.Update;
        }

        public clsMitarbeiterDaten()
        {
            this.MitarbeiterID = -1;
            this.VersicherungsID = -1;
            this.SteuerID = string.Empty;
            this.EingestelltAm = DateTime.Now;
            this.GefeuertAm = string.Empty;
            this.EingestelltBeiUser = -1;
            this.Zustand = string.Empty;
            Mode = enMode.addNew;
        }

        private bool _AddNew()
        {
            this.MitarbeiterID = clsMitarbeiterDatenZugriff.AddNewMitarbeiter(this.PersonID, this.VersicherungsID,
                this.SteuerID, this.EingestelltAm,
                this.GefeuertAm, this.EingestelltBeiUser, this.Zustand);

            return (this.MitarbeiterID != -1);
        }

        private bool _Update()
        {
            return clsMitarbeiterDatenZugriff.UpdateMitarbeiter(this.MitarbeiterID, this.PersonID, this.VersicherungsID,
                this.SteuerID, this.EingestelltAm,
                this.GefeuertAm, this.EingestelltBeiUser,this.Zustand);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.addNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static clsMitarbeiterDaten Find(int MitarbeiterID)
        {
            int personID = -1; int versicherungsID = -1; string steuerID = string.Empty;
            ; DateTime eingestelltAm = DateTime.Now;
            string gefeuertAm = string.Empty; int eingestelltBeiUser = -1;
           string zustand = string.Empty;

            if (clsMitarbeiterDatenZugriff.GetMitarbeiterbyID(MitarbeiterID, ref personID, ref versicherungsID,
                ref steuerID, ref eingestelltAm, ref gefeuertAm, ref eingestelltBeiUser, ref zustand))
            {
                return new clsMitarbeiterDaten(MitarbeiterID, personID, versicherungsID, steuerID,
               eingestelltAm, gefeuertAm, eingestelltBeiUser,zustand);
            }
            else
                return null;
        }

        public static clsMitarbeiterDaten FindByPersonID(int PersonID)
        {
            int MitarbeiterID = -1; int versicherungsID = -1; string steuerID = string.Empty;
           ; DateTime eingestelltAm = DateTime.Now;
            string gefeuertAm = string.Empty; int eingestelltBeiUser = -1;
            string zustand = string.Empty;

            if (clsMitarbeiterDatenZugriff.GetMitarbeiterbyPersonID(ref MitarbeiterID, PersonID, ref versicherungsID,
                ref steuerID,ref eingestelltAm, ref gefeuertAm, ref eingestelltBeiUser, ref zustand))
            {
                return new clsMitarbeiterDaten(MitarbeiterID, PersonID, versicherungsID, steuerID,
               eingestelltAm,gefeuertAm, eingestelltBeiUser, zustand);
            }
            else
                return null;
        }

        public bool Delete()
        {
            bool Done = clsMitarbeiterDatenZugriff.DeleteMitarbeiter(this.MitarbeiterID);

            if (!Done)
                return false;

            //wir löschen dann die generated Person vom System.
            return clsPersonDaten.Delete(this.PersonID);
        }

        public static bool Delete(int MitarbeiterID)
        {
            bool Done = clsMitarbeiterDatenZugriff.DeleteMitarbeiter(MitarbeiterID);

            return Done;
        }

        public static bool DoesMitarbeiterExistForThisPerson(int PersonID)
        {
            return clsMitarbeiterDatenZugriff.DoesMitarbeiterExistForThisPerson(PersonID);
        }
        public static bool IsMitarbeiterActiveForThisPerson(int PersonID)
        {
            return clsMitarbeiterDatenZugriff.isMitarbeiterActiveForThisPersonID(PersonID);
        }

        public static DataTable GetAllMitarbeiter()
        {
            return clsMitarbeiterDatenZugriff.GetAllMitarbeiter();
        }

        public static bool deaktiviereMitarbeiter(int mitarbeiterID)
        {
            return clsMitarbeiterDatenZugriff.deaktiviereMitarbeiter(mitarbeiterID);
        }

        public static bool aktiviereMitarbeiter(int mitarbeiterID)
        {
            return clsMitarbeiterDatenZugriff.aktiviereMitarbeiter(mitarbeiterID);
        }

        public static bool HatMitarbeiterEinenArbeitsvertrag(int mitarbeiterId)
        {
            return clsMitarbeiterDatenZugriff.HatMitarbeiterEinenArbeitsvertrag(mitarbeiterId);
        }
    }
}
