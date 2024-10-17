using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;

namespace KlinikDatenZugriffsSchicht
{
    public class clsArbeitsvertragDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool FindByVertragID(int vertragId, ref int mitarbeiterID, ref int vergütungID,ref  int arbeitszeitID,
            ref int bezahlungsmethodeID,ref  int urlaubsanspruch,ref  DateTime startdatum, ref DateTime enddatum, ref int abteilungID,
            ref bool istInProbezeit,ref  bool istAktive)
        {
            bool isfound = false;
            string abfrage = @" select * from dbo.GetVertragByID(@VertragID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(abfrage, connection))
                {
                    command.Parameters.AddWithValue("@VertragID", vertragId);

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            isfound = true;

                             mitarbeiterID = (int)reader["MitarbeiterID"];
                            vergütungID = (int)reader["VergütungID"];
                            arbeitszeitID = (int)reader["ArbeitszeitID"];
                            bezahlungsmethodeID = (int)reader["BezahlungmethodeID"];
                            urlaubsanspruch = (int)reader["Urlaubsanspruch"];
                            startdatum = (DateTime)reader["StartDatum"];
                            enddatum = (DateTime)reader["EndDatum"]; 
                            abteilungID = (int)reader["AbteilungID"];
                            istInProbezeit = (bool)reader["IstInProbezeit"];
                            istAktive = (bool)reader["istAktive"];
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return isfound;
        }
        public static bool FindByMitarbeiterID(ref int vertragID, int mitarbeiterID, ref int vergütungID, ref int arbeitszeitID,
      ref int bezahlungsmethodeID, ref int urlaubsanspruch, ref DateTime startdatum, ref DateTime enddatum, ref int abteilungID,
      ref bool istInProbezeit, ref bool istAktive)
        {
            bool isfound = false;
            string abfrage = @" select * from dbo.GetVertragByMitarbeiterID(@MitarbeiterID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(abfrage, connection))
                {
                    command.Parameters.AddWithValue("@MitarbeiterID", mitarbeiterID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isfound = true;

                            vertragID = (int)reader["VertragID"];
                            vergütungID = (int)reader["VergütungID"];
                            arbeitszeitID = (int)reader["ArbeitsZeitID"];
                            bezahlungsmethodeID = (int)reader["BezahlungmethodeID"];
                            urlaubsanspruch = (int)reader["Urlaubsanspruch"];
                            startdatum = (DateTime)reader["StartDatum"];
                            enddatum = (DateTime)reader["EndDatum"];
                            abteilungID = (int)reader["AbteilungID"];
                            istInProbezeit = (bool)reader["IstInProbezeit"];
                            istAktive = (bool)reader["istAktive"];
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return isfound;
        }
        public static int AddNewArbeitsvertrag(int mitarbeiterID, int vergütugnID, int arbeitszeitID, int bezahlungsmethodeId, 
            int urlaubsanspruch, DateTime startdatum, DateTime enddatum, int abteilungID, bool istInProbezeit, bool istAktive)
        {
            int vertragID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                using(SqlCommand command = new SqlCommand("Sp_AddNewVertrag", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MitarbeiterID",mitarbeiterID);
                    command.Parameters.AddWithValue("@VergütungID",vergütugnID);
                    command.Parameters.AddWithValue("@ArbeitszeitID",arbeitszeitID);
                    command.Parameters.AddWithValue("@BezahlungmethodeID",bezahlungsmethodeId);
                    command.Parameters.AddWithValue("@Urlaubsanspruch",urlaubsanspruch);
                    command.Parameters.AddWithValue("@StartDatum",startdatum);
                    command.Parameters.AddWithValue("@EndDatum",enddatum);
                    command.Parameters.AddWithValue("@AbteilungID",abteilungID);
                    command.Parameters.AddWithValue("@IstInProbezeit",istInProbezeit);
                    command.Parameters.AddWithValue("@IstAktive",istAktive);

                    SqlParameter outputParameter = new SqlParameter("@NewVertragID", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();
                    command.ExecuteNonQuery();
                    vertragID = (int)outputParameter.Value;
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return vertragID;
        }

        public static bool UpdateVertragByMitArbeiterID(int mitarbeiterID, int vergütugnID, int arbeitszeitID, int bezahlungsmethodeId,
         int urlaubsanspruch, DateTime startdatum, DateTime enddatum, int abteilungID, bool istInProbezeit, bool istAktive)
        {
            int rowAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("Sp_UpdateVertragByMitArbeiterID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MitarbeiterID", mitarbeiterID);

                    command.Parameters.AddWithValue("@VergütungID", vergütugnID);
                    command.Parameters.AddWithValue("@ArbeitszeitID", arbeitszeitID);
                    command.Parameters.AddWithValue("@BezahlungmethodeID", bezahlungsmethodeId);
                    command.Parameters.AddWithValue("@Urlaubsanspruch", urlaubsanspruch);
                    command.Parameters.AddWithValue("@StartDatum", startdatum);
                    command.Parameters.AddWithValue("@EndDatum", enddatum);
                    command.Parameters.AddWithValue("@AbteilungID", abteilungID);
                    command.Parameters.AddWithValue("@HatProbezeit", istInProbezeit);
                    command.Parameters.AddWithValue("@istAtkive", istAktive);

                    SqlParameter outputParameter = new SqlParameter("@RowAffected", SqlDbType.Int);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    rowAffected= (int)outputParameter.Value;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return rowAffected > 0;
        }
    }
}
