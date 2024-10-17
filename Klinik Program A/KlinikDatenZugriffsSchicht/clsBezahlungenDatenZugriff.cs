using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace KlinikDatenZugriffsSchicht
{
    public class clsBezahlungenDatenZugriff
    {
        public static bool GetBezahlungsDatenByID(int BezahlungsID,ref int TerminID, ref string BezahlungsMethode,
                                         ref DateTime BezahlungsDatum, ref float BetragZumBezahlen)
        {
            bool isFound = false;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Select * From Bezahlungen  where BezahlungsID =  @BezahlungsID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@BezahlungsID", BezahlungsID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            TerminID = (int)reader["TerminID"];
                            BezahlungsMethode = (string)reader["BezahlungsMethode"];
                            BezahlungsDatum = (DateTime)reader["BezahlungsDatum"];
                            BetragZumBezahlen = Convert.ToSingle(reader["Diagnose"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw new Exception("Fehler beim GetBezahlungDatenByID Methode " + ex.Message);
                }
            }
            return isFound;
        }


        public static int AddNewBezahlung(int TerminID,string BezahlungsMethode,
                                          DateTime BezahlungsDatum, float BetragZumBezahlen)
        {
            int BezahlungsID = -1;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Insert into Bezahlungen (TerminID,BezahlungsMethode,BezahlungsDatum,BetragZumBezahlen)
                                         Values  (@TerminID,@BezahlungsMethode, @BezahlungsDatum, @BetragZumBezahlen);
                              Select Scope_Identity()";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@TerminID", TerminID);
                command.Parameters.AddWithValue("@BezahlungsMethode",BezahlungsMethode) ;
                command.Parameters.AddWithValue("@BezahlungsDatum", BezahlungsDatum);
                command.Parameters.AddWithValue("@BetragZumBezahlen", BetragZumBezahlen);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        BezahlungsID = InsertedID;
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode AddNeuVersicherung " + ex.Message);
                }
            }
            return BezahlungsID;
        }

        public static bool DeleteBezahlung(int BezahlungsID)
        {
            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Delete from Bezahlungen 
                               Where BezahlungsID = @BezahlungsID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@BezahlungsID", BezahlungsID);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode DeleteBezahlung " + ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }

        public static bool UpdateBezahlung(int BezahlungsID,int TerminID, string BezahlungsMethode,
                                          DateTime BezahlungsDatum, float BetragZumBezahlen)
        {

            int BetroffeneZeile = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            string abfrage = @"Update Bezahlungen 
                                      Set 
                                          TerminID         = @TerminID,
                                          BezahlungsMethode= @BezahlungsMethode,
                                          BezahlungsDatum = @BezahlungsDatum,
                                          BetragZumBezahlen  = @BetragZumBezahlen
                                      Where  BezahlungsID = @BezahlungsID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(abfrage, connection))
            {
                command.Parameters.AddWithValue("@BezahlungsID", BezahlungsID);
                command.Parameters.AddWithValue("@TerminID", TerminID);
                command.Parameters.AddWithValue("@BezahlungsMethode", BezahlungsMethode);
                command.Parameters.AddWithValue("@BezahlungsDatum", BezahlungsDatum);
                command.Parameters.AddWithValue("@BetragZumBezahlen", BetragZumBezahlen);

                try
                {
                    connection.Open();
                    BetroffeneZeile = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fehler bei Methode UpdateBezahlung" + ex.Message);
                }
            }
            return (BetroffeneZeile > 0);
        }

        public static DataTable GetAllBezahlungmethoden()
        {
            DataTable dt = new DataTable();
            string abfrage = @"select * from GetAllBezahlungmethoden()";
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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

        public static int GetBezahlungmethodeIDByName(string name)
        {
            int ID = -1;
            string abfrage = @"Select dbo.GetBezahlungmethodeID(@Name)";
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
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

        public static bool FindByBezahlungmethodeID(int bezahlungmethodeID, ref string bezahlungmethodeName)
        {
            bool isfound = false;

            string abfrage = @"Select  * from BezahlungMethode Where BezahlungmethodeID = @bezahlungmethodeID";
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand commmand = new SqlCommand(abfrage, connection))
                {
                    commmand.Parameters.AddWithValue("@bezahlungmethodeID", bezahlungmethodeID);

                    connection.Open();
                    using (SqlDataReader leser = commmand.ExecuteReader())
                    {
                        if (leser.Read())
                        {
                            isfound = true;

                            bezahlungmethodeName = (string)leser["BezahlungmethodeName"];
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
