using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel.Design;

namespace KlinikDatenZugriffsSchicht
{
    public class clsVergütungDatenzugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static DataTable GetAllArbeitszeiten()
        {
            DataTable dt = new DataTable();
            string abfrage = @"select * from GetAllVergütungen()";
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                using(SqlCommand commmand = new SqlCommand(abfrage, connection))
                {
                    connection.Open();
                    using(SqlDataReader reader = commmand.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return dt;
        }

        public static int GetVergütungIDByName(string name)
        {
            int ID = -1;
            string abfrage = @"Select dbo.GetVergütungIDByName(@Name)";
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

        public static bool FindByVergütungID(int vergütungID, ref string entgeltgruppe, ref string vergütung)
        {
            bool isfound = false;

            string abfrage = @"Select  * from Vergütungen Where VergütungID = @vergütungId";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand commmand = new SqlCommand(abfrage, connection))
                {
                    commmand.Parameters.AddWithValue("@vergütungId", vergütungID);

                    connection.Open();
                    using (SqlDataReader leser = commmand.ExecuteReader())
                    {
                        if (leser.Read())
                        {
                            isfound = true;

                            entgeltgruppe = (string)leser["Entgeltgruppen"];
                            vergütung = (string)leser["Vergütung"];
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
