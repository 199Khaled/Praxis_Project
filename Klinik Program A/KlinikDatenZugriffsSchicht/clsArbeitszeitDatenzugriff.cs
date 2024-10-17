using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace KlinikDatenZugriffsSchicht
{
    public class clsArbeitszeitDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        public static DataTable GetAllArbeitszeiten()
        {
            DataTable dt = new DataTable();

            string abfrage = @"select * from dbo.GetAllArbeitszeiten()";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand commmand = new SqlCommand(abfrage, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = commmand.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return dt;
        }

        public static int GetArbeitszeitIDByName(string name)
        {
            int ID = -1;
            string abfrage = @"Select dbo.GetArbeitszeitID(@Name)";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand commmand = new SqlCommand(abfrage, connection))
                {
                    commmand.Parameters.AddWithValue("@Name", name);

                    connection.Open();
                    object result = commmand.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int outputParameter))
                        ID = outputParameter;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return ID;
        }

        public static bool FindByArbeitszeitID(int arbeitszeitID, ref string arbeitszeit, ref string beschreibung)
        {
            bool isfound = false;

            string abfrage = @"Select  * from Arbeitszeiten Where ArbeitszeitID = @arbeitszeitId";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand commmand = new SqlCommand(abfrage, connection))
                {
                    commmand.Parameters.AddWithValue("@arbeitszeitId", arbeitszeitID);

                    connection.Open();
                    using (SqlDataReader leser = commmand.ExecuteReader())
                    {
                        if (leser.Read())
                        {
                            isfound = true;

                            arbeitszeit = (string)leser["Arbeitszeit"];
                            beschreibung = (string)leser["Beschreibung"];
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
    }
}
