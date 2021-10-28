using Microsoft.Data.SqlClient;
using System;

namespace Villain_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection("Server=.;Integrated Security=true;Database=MinionsDB"))
            {
                connection.Open();
                var com = new SqlCommand("SELECT v.Name,COUNT(*) as count  FROM MinionsVillains as mv JOIN Villains as v ON v.Id = mv.VillainId GROUP BY v.Name ORDER BY COUNT(*)", connection);
                var reader = com.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine($"{reader["Name"]} - {reader["count"]}");
                }
                connection.Close();

            }
        }
    }
}
