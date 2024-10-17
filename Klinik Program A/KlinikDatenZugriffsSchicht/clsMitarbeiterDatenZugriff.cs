using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KlinikDatenZugriffsSchicht
{
    public class clsMitarbeiterDatenZugriff
    {
        private static string ConnectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public static bool GetMitarbeiterbyID(int mitarbeiterID, ref int personID, ref int versicherungsID,
            ref string steuerID, ref  DateTime eingestelltAm, ref string GefeuertAm,
            ref int EingestelltBeiUser, ref string zustand)
        {

            bool isfound = false;
            string abfrage = @"SELECT PersonID, VersicherungsID, SteuerID, EingestelltAm, GefeuertAm, EingestelltBeiUser, Zustand 
                       FROM GetMitarbeiterByID(@MitarbeiterID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {

                        command.Parameters.AddWithValue("@MitarbeiterID", mitarbeiterID);

                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                isfound = true;

                                personID = (int)reader["PersonID"];
                                versicherungsID = (int)reader["VersicherungsID"];
                                steuerID = (string)reader["SteuerID"];
             
                                eingestelltAm = (DateTime)reader["EingestelltAm"];
                                GefeuertAm = (string)reader["GefeuertAm"];
                                EingestelltBeiUser = (int)reader["EingestelltBeiUser"];
                               zustand = (string)reader["Zustand"];

                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                isfound = false;
                throw;
            }

            return isfound;
        }

        public static bool GetMitarbeiterbyPersonID(ref int mitarbeiterID, int personID, ref int versicherungsID,
     ref string steuerID, ref DateTime eingestelltAm, ref string GefeuertAm,
      ref int EingestelltBeiUser, ref string zustand)
        {

            bool isfound = false;

            string abfrage = @"SELECT PersonID, VersicherungsID, SteuerID, EingestelltAm, GefeuertAm, EingestelltBeiUser, Zustand 
                       FROM GetMitarbeiterByPersonID(@PersonID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;

                                mitarbeiterID = (int)reader["MitarbeiterID"];
                                versicherungsID = (int)reader["VersicherungsID"];
                                steuerID = (string)reader["SteuerID"];
                                eingestelltAm = (DateTime)reader["EingestelltAm"];
                                GefeuertAm = (string)reader["GefeuertAm"].ToString();
                                EingestelltBeiUser = (int)reader["EingestelltBeiUser"];
                                zustand = (string)reader["Zustand"];

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                isfound = false;
                throw;
            }

            return isfound;
        }



        public static DataTable GetAllMitarbeiter()
        {
            DataTable dt = new DataTable();

            string abfrage = @"Select * From  dbo.GetAllMitarbeiter()
                                                  Order by MitarbeiterID Desc";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                       
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return dt;
        }

        public static bool DoesMitarbeiterExistForThisPerson(int PersonID)
        {
            bool isFound = false;
           string abfrage = "Select 1 From Mitarbeiter Where PersonID = @PersonID";
            try
            {
                using(SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        isFound = (result != null && (int)result == 1);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return isFound;
        }

        public static bool isMitarbeiterActiveForThisPersonID(int PersonID)
        {
            bool isActive = false;
            string abfrage = "Select 1 From Mitarbeiter Where PersonID = @PersonID And Zustand = 'Aktive' ";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        isActive = (result != null && (int)result == 1);
                     
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return isActive;
        }
        public static int AddNewMitarbeiter(int personID, int versicherungsID,
           string steuerID, DateTime eingestelltAm, string GefeuertAm, 
           int EingestelltBeiUser, string zustand)
        {
            int MitarbeiterID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Sp_AddNewMitarbeiter", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Über Parameter hinzufügen
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@VersicherungsID", versicherungsID);
                        command.Parameters.AddWithValue("@SteuerID", steuerID);
                        command.Parameters.AddWithValue("@EingestelltAm", eingestelltAm); 
                        command.Parameters.AddWithValue("@GefeuertAm", GefeuertAm);
                        command.Parameters.AddWithValue("@EingestelltBeiUser", EingestelltBeiUser);
                        command.Parameters.AddWithValue("@Zustand", zustand);

                        // Output-Parameter für die neue MitarbeiterID hinzufügen
                        SqlParameter outputparam = new SqlParameter("@NewMitarbeiterID", SqlDbType.Int);

                        // Diraction wird auf Output gesetzt.
                        outputparam.Direction = ParameterDirection.Output;                     
                        command.Parameters.Add(outputparam);

                        //Open the connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();


                        // Die neue MitarbeiterID aus dem Output-Parameter erhalten
                        MitarbeiterID = (int)outputparam.Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return MitarbeiterID;
        }

        public static bool UpdateMitarbeiter(int MitarbeiterID,int personID, int versicherungsID,
           string steuerID, DateTime eingestelltAm, string GefeuertAm,
           int EingestelltBeiUser, string zustand)
        {
            int RowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Sp_UpdateMitarbeiter", connection))
                    {
                        // Über Stored Procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Parameter hinzufügen
                        command.Parameters.AddWithValue("@MitarbeiterID", MitarbeiterID);
                        command.Parameters.AddWithValue("@PersonID", personID);
                        command.Parameters.AddWithValue("@VersicherungsID", versicherungsID);
                        command.Parameters.AddWithValue("@SteuerID", steuerID);
                        command.Parameters.AddWithValue("@EingestelltAm", eingestelltAm);
                        command.Parameters.AddWithValue("@GefeuertAm", GefeuertAm);
                        command.Parameters.AddWithValue("@EingestelltBeiUser", EingestelltBeiUser) ;
                        command.Parameters.AddWithValue("@Zustand", zustand);

                        SqlParameter output = new SqlParameter("@RowAffected", SqlDbType.Int);
                        output.Direction = ParameterDirection.Output;
                        command.Parameters.Add(output);

                        connection.Open();
                        command.ExecuteNonQuery();

                        RowAffected = (int)output.Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }

        public static bool DeleteMitarbeiter(int MitarbeiterID)
        {
            int RowAffected = 0;

            try
            {
                using(SqlConnection  connection =new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand("Sp_DeleteMitarbeiter", connection))
                    {
                        // Stored Procedure
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MitarbeiterID", MitarbeiterID);

                        //den output parameter für die betroffenezeile hinzufügen 
                        SqlParameter outputParameter = new SqlParameter("@RowAffected", SqlDbType.Int);
                        outputParameter.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputParameter);

                        //Öffene die verbindung und ausführe den Befehl
                        connection.Open();
                        command.ExecuteNonQuery();

                        RowAffected = (int)outputParameter.Value;
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return RowAffected > 0;
        }

        public static bool deaktiviereMitarbeiter(int mitarbeiterID)
        {
            int rowAffected = 0;
            string abfrage = @"Update Mitarbeiter
                                  set Zustand = 'Inaktive'
                                      where  Zustand = 'Aktive' And MitarbeiterID = @mitarbeiterID"  ;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using(SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@mitarbeiterID", mitarbeiterID);

                        connection.Open();
                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return rowAffected > 0;
        }

        public static bool aktiviereMitarbeiter(int mitarbeiterID)
        {
            int rowAffected = 0;
            string abfrage = @"Update Mitarbeiter
                                  set Zustand = 'Aktive'
                                      where  Zustand = 'Inaktive'  And  MitarbeiterID = @mitarbeiterID";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@mitarbeiterID", mitarbeiterID);

                        connection.Open();
                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return rowAffected > 0;
        }

        public static bool HatMitarbeiterEinenArbeitsvertrag(int mitarbeiterID)
        {
            bool hatVertrag = false;
            string abfrage = @"Select dbo.HatMitarbeiterEinenArbeitsVertrag(@MitarbeiterID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(abfrage, connection))
                    {
                        command.Parameters.AddWithValue("@MitarbeiterID", mitarbeiterID);

                        connection.Open();
                      object result = command.ExecuteScalar();
                        if (result != null)
                            hatVertrag = Convert.ToBoolean(result);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return hatVertrag;
        }

    }
}
