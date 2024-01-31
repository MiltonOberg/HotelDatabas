using System;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;
using Dapper;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        do{
            
            int choice = MenuHandler.Menu(MenuHandler.MainMenu());

            switch(choice){
                case 0:
                    UIConsole.GetBookings();
                    break;
                case 1:
                    UIConsole.GetHotels();
                    break;
                case 2:
                    UIConsole.GetGuest();
                    break;
                case 3:
                    UIConsole.BookRoom();
                    break;
            }
            Thread.Sleep(3000);
        }while(true);
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
    public static List<Booking> GetBookings()
    {
        string sql = "SELECT guests.Name, hotels.Name, reservations.ReservIn, reservations.ReservOut " +
            "FROM guests " +
                "INNER JOIN reservations ON guests.ID = reservations.GuestID " +
                    "INNER JOIN rooms ON reservations.RoomID = rooms.ID " +
                        "INNER JOIN hotels ON rooms.HotelID = hotels.ID; ";

        var bookings = connection.Query<Booking>(sql).AsList();
        
        return bookings;
    }
    public static List<Guest> GetGuests()
    {
        string sql = "SELECT * " +
            "FROM guests; ";

        var guests = connection.Query<Guest>(sql).AsList();
        return guests;
    }
    public static List<Room> GetAvalibleRooms()
    {
        string sql = "SELECT rooms.RoomNr, rooms.Price " +
            "FROM rooms " +
                "WHERE rooms.Status = 1 ";
        
        var avalibleRooms = connection.Query<Room>(sql).AsList();
        return avalibleRooms;
    }
}

