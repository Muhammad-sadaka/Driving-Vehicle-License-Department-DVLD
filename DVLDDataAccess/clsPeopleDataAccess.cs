using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsPeopleDataAccess
    {
     
        public static bool GetPersonInfoByPersonID(int PersonID, ref string NationalNo, ref string FirstName,
                ref string SecondName, ref string ThirdName, ref string LastName,
                ref short Gendor , ref int NationalityCountryID,
                       ref string Email, ref string Phone, ref string Address,
                       ref DateTime DateOfBirth, ref string ImagePath)
            {
                bool isFound = false;

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT * FROM People WHERE PersonID = @PersonID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        LastName = (string)reader["LastName"];
                        Phone = (string)reader["Phone"];
                        Address = (string)reader["Address"];
                        Gendor = (byte)reader["Gendor"];
                        NationalNo = (string)reader["NationalNo"];
                        DateOfBirth = (DateTime)reader["DateOfBirth"];
                        NationalityCountryID = (int)reader["NationalityCountryID"];

                        //ImagePath: allows null in database so we should handle null
                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = (string)reader["ImagePath"];
                        }
                        else
                        {
                            ImagePath = "";
                        }
                        if (reader["Email"] != DBNull.Value)
                        {
                             Email = (string)reader["Email"];
                        }
                        else
                        {
                             Email = "";
                        }
                        if (reader["ThirdName"] != DBNull.Value)
                        {
                             ThirdName = (string)reader["ThirdName"];
                        }
                        else
                        {
                             ThirdName = "";
                        }

                }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }

                    reader.Close();


                }
                catch (Exception ex)
                {
                     Console.WriteLine(ex);
                     isFound = false;
                }
                finally
                {
                    connection.Close();
                }

                return isFound;
            }

            public static bool GetPersonInfoByNationalNo(ref int PersonID, string NationalNo, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName, ref short Gendor, ref int NationalityCountryID,
            ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth, ref string ImagePath)
            {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    Gendor = (byte)reader["Gendor"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

            public static int AddNewPerson( string NationalNo, string FirstName,
                string SecondName, string ThirdName, string LastName,
                short Gendor, int NationalityCountryID,
                       string Email, string Phone, string Address,
                        DateTime DateOfBirth, string ImagePath)
            {
                //this function will return the new Person id if succeeded and -1 if not.
                int PersonID = -1;

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, 
                                    Gendor, NationalityCountryID, Email, Phone, Address, DateOfBirth, ImagePath)
                               VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, 
                                    @Gendor, @NationalityCountryID, @Email, @Phone, @Address, @DateOfBirth, @ImagePath)
                               SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                if (Email != "" && Email != null)
                    command.Parameters.AddWithValue("@Email", Email);
                else
                    command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                if (ThirdName != "" && ThirdName != null)
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                else
                    command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            
                if (ImagePath != "" && ImagePath != null)
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                else
                    command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        PersonID = insertedID;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                finally
                {
                    connection.Close();
                }


                return PersonID;
            }
            
            public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName,
                string SecondName, string ThirdName, string LastName,
                short Gendor, int NationalityCountryID,
                       string Email, string Phone, string Address,
                        DateTime DateOfBirth, string ImagePath)
            {

                int rowsAffected = 0;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"UPDATE People
                                          SET NationalNo = @NationalNo
                                             ,FirstName = @FirstName
                                             ,SecondName = @SecondName
                                             ,ThirdName = @ThirdName
                                             ,LastName = @LastName
                                             ,DateOfBirth = @DateOfBirth
                                             ,Gendor = @Gendor
                                             ,Address = @Address
                                             ,Phone = @Phone
                                             ,Email = @Email
                                             ,NationalityCountryID = @NationalityCountryID
                                             ,ImagePath = @ImagePath
                                        WHERE  PersonID = @PersonID 
                                       ";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Gendor", Gendor);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                if (ImagePath != "" && ImagePath != null)
                    command.Parameters.AddWithValue("@ImagePath", ImagePath);
                else
                    command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                if (Email != "" && Email != null)
                 command.Parameters.AddWithValue("@Email", Email);
                else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

                if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
                else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }

                finally
                {
                    connection.Close();
                }

                return (rowsAffected > 0);
            }           

            public static DataTable GetAllPeople()
            {
                 DataTable dt = new DataTable();
                 try
                 {
                     using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                     {
                         connection.Open();
            
                         string query = @"SELECT PersonID, NationalNo,FirstName , SecondName , ThirdName , LastName,
                                 case when Gendor = 0 then 'Male' else 'Female' end as 'Gender',
                                     Address,DateOfBirth,NationalityCountryID, CountryName as Nationality,Phone, Email,
                                    ImagePath
                                      FROM     People INNER JOIN
                                                        Countries ON NationalityCountryID = CountryID
                                               ORDER BY FirstName;";
            
                         using(SqlCommand command = new SqlCommand(query,connection))
                         {
                             using (SqlDataReader reader = command.ExecuteReader())
                             {
                                 if (reader.HasRows)
                                 {
                                     dt.Load(reader);
                                 }
                             }
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                 }

                 return dt;
            }

            public static bool DeletePerson(int PersonID2)
            {

                int rowsAffected = 0;

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = @"EXEC SP_DeletePerson @PersonID = @PersonID2";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID2", PersonID2);

                try
                {
                    connection.Open();

                    rowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {

                    connection.Close();

                }

                return (rowsAffected > 0);
            }
            
            public static bool IsPersonExist(int PersonID)
            {
                bool isFound = false;

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    isFound = reader.HasRows;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    isFound = false;
                }
                finally
                {
                    connection.Close();
                }

                return isFound;
            }

            public static bool IsPersonExist(string NatioanlNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NatioanlNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
