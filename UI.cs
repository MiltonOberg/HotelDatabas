using System.Net;

class UIConsole
{
    public static void GetHotels(){
        List<Hotel> hotels = HotelDatabase.GetHotels();
        foreach (Hotel h in hotels)
            Console.WriteLine($"Name: {h.Name}, Rating: {h.Rating}");
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
}