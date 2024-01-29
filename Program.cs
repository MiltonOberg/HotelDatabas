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
        List<Room> rooms = HotelDatabase.GetRooms();

        foreach (Hotel h in hotels)
        {
            Console.WriteLine($"Name: {h.Name}, Rating: {h.Rating}");
        }
        foreach (Room r in rooms)
        {
            Console.WriteLine($"RoomNr: {r.ID}\nPrice: {r.Price}\nStatus: {r.Status}\n");
        }
    }
}


class HotelDatabase
{
    static string connectionString = "server=localhost;database=hotell;uid=root;pwd=;";
    
    static IDbConnection connection = new MySqlConnection(connectionString);
    
    
    public static List<Hotel> GetHotels()
    {
        string sql = "SELECT Name, Rating " +  
            "FROM hotels; ";

        var hotels = connection.Query<Hotel>(sql).AsList();
        
        return hotels;
    }
    public static List<Room> GetRooms()
    {
        string sql = "SELECT ID, Price, Status " +
            "FROM rooms; ";
        var rooms = connection.Query<Room>(sql).AsList();

        return rooms;
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
class Room
{
    public int ID {get; set;}
    public int Price {get; set;}
    public bool Status {get; set;}
    public Room()
    {

    }
    public Room(int id, int price, bool status)
    {
        ID = id;
        Price = price;
        Status = status;
    }
}