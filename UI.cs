using System.Net;

class UIConsole
{
    public static void GetHotels(){
        List<Hotel> hotels = HotelDatabase.GetHotels();
        for(int i = 0; i < hotels.Count; i++){
            Hotel h = hotels[i];
            Console.WriteLine($"Name: {h.Name}\n" +
                $"Rating: {h.Rating}");
        }
    }
    public static void GetRooms(){
        List<Room> rooms = HotelDatabase.GetRooms();
        foreach (Room r in rooms)
            Console.Write($"RoomNr: {r.ID}\nPrice: {r.Price}\nStatus: {r.Status}\n");   
    }
    public static void GetBookings(){
        List<Guest> guests = HotelDatabase.GetGuests();
        List<Room> rooms = HotelDatabase.GetRooms();
        List<Booking> bookings = HotelDatabase.GetBookings();
        foreach(Booking b in bookings){
            for(int i = 0; i <= bookings.Count; i++)
                Console.WriteLine($"Name: {guests[b.GuestID + i].Name}\nCheck in: {b.ReservStart}\nCheck Out {b.ReservOut}\nRoom: {rooms[b.RoomID + i].ID}");
            return;
        }
    }
    public static void GetGuest(){
        List<Guest> guests = HotelDatabase.GetGuests();
        foreach (Guest g in guests)
            Console.Write($"Name: {g.Name}\nAge: {g.Age}\nPhone: {g.PhoneNr}\nEmail: {g.Email}");
    }
    public static void GetAvalibleRooms()
    {
        List<Room> rooms = HotelDatabase.GetAvalibleRooms();
        for(int i = 0; i < rooms.Count; i++){
            Room room = rooms[i];
            Console.WriteLine($"Room Number: {room.RoomNr}");
        }
    }
    public static void BookRoom()
    {
        GetHotels();
        
    

        GetAvalibleRooms();
        
    }
}




class MenuHandler
{
    public static string[] MainMenu()
    {
        string[] mainMenu = {"Bokningar", "Hotell", "Rum", "Boka rum"};
        return mainMenu;
    }
    public static int Menu(string[] menu)
    {
        ConsoleKey key;
        int index = 0;
        do{
            Console.Clear();
            for(int i = 0; i < menu.Length; i++){
                if(i == index)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menu[i]);
            }
            key = Console.ReadKey().Key;
            switch(key){
                case ConsoleKey.UpArrow:
                    if(index > 0)
                        index--;
                    break;
                case ConsoleKey.DownArrow:
                    if(index < menu.Length - 1)
                        index++;
                    break;
            }
        }while(key != ConsoleKey.Enter);
        Console.ForegroundColor = ConsoleColor.White;
        return index;
    }
}