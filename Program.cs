using System;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using Dapper;
using Microsoft.VisualBasic;

class Program
{
    public static void Main()
    {
        List<Hotel> hotels = HotelDatabase.GetHotels();

        foreach (Hotel h in hotels)
        {
            Console.WriteLine($"Name: {h.Name}, Rating: {h.Rating}");
        }
    }
}
class Hotel
{
    public string Name {get; set;}
    public float Rating {get; set;}
     public Hotel()
    {

    }
    public Hotel(string name, float rating)
    {
        Name = name;
        Rating = rating;
    }
}

class HotelDatabase
{
    static string connectionString = "server=localhost;database=hotell;uid=root;pwd=;";
    
    static IDbConnection connection = new MySqlConnection(connectionString);
    
    
    public static List<Hotel> GetHotels()
    {
        string sql = "SELECT Name, Rating " +  
            "FROM hotels";

        var hotels = connection.Query<Hotel>(sql).AsList();
        
        return hotels;
    }
}
