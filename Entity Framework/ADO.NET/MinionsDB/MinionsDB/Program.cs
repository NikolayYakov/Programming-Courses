using Microsoft.Data.SqlClient;
using System;
namespace MinionsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection("Server=.;Integrated Security=true;Database=MinionsDB"))
            {
                connection.Open();
                var comCountries = new SqlCommand("CREATE TABLE Countries(Id INT PRIMARY KEY NOT NULL,Name NVARCHAR(MAX) )", connection);
                var comTowns = new SqlCommand("CREATE TABLE Towns(Id INT PRIMARY KEY NOT NULL,Name NVARCHAR(MAX),CountryCode VARCHAR(10) NOT NULL)",connection);
                var comMinions = new SqlCommand("CREATE TABLE Minions(Id INT PRIMARY KEY NOT NULL,Name NVARCHAR(MAX),Age INT,TownId INT NOT NULL REFERENCES Towns(Id))   ", connection);
                var comFactory = new SqlCommand(" CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY NOT NULL,Name NVARCHAR(MAX)) ", connection);
                var comVillains = new SqlCommand("CREATE TABLE Villains(Id INT PRIMARY KEY NOT NULL,Name NVARCHAR(MAX),EvilnessFactorsId INT NOT NULL REFERENCES EvilnessFactors(Id))  ", connection);
                var comMinVill = new SqlCommand(" CREATE TABLE MinionsVillains(MinionId INT NOT NULL REFERENCES Minions(Id),VillainId INT NOT NULL REFERENCES Villains(Id),PRIMARY KEY(MinionId,VillainId))", connection);

                comCountries.ExecuteNonQuery();
                comTowns.ExecuteNonQuery();
                comMinions.ExecuteNonQuery();
                comFactory.ExecuteNonQuery();
                comVillains.ExecuteNonQuery();
                comMinVill.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
