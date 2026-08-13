using System;
using System.Data;
using System.Data.SqlClient;
using DVLDDataAccessLayer;

namespace DVLDDataAccess
{
    public class clsChatBotDataAccesscs
    {
        public static bool GetAnswerByQuestion(string question,ref string Answer,ref string Explanation)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select top 1 Id , keyword , Category , Answer, Explanation , LEN(Keyword) as MatchScore
                        from ChatBotKnowledge
                        where @question like '%' + '%' + Keyword
                        order by MatchScore DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@question", question);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Answer = (string)reader["Answer"];
                    Explanation = (string)reader["Explanation"];
                }
                else
                {
                    isFound = false;
                }
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
