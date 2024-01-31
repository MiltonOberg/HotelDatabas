
using System.Dynamic;

class Hotel
{
    public int ID {get; set;}
    public string Name {get; set;}
    public float Rating {get; set;}
     public Hotel()
    {
        Name = "";
        Rating = 0;
    }
    public Hotel(int id, string name, float rating)
    {
        ID = id;
        Name = name;
        Rating = rating;
    }
    public override string ToString()
    {
        return $"Hotel: {Name}\n" +
            $"Rating: {Rating}";
    }
}
class Room
{
    public int ID {get; set;}
    public int RoomNr {get; set;}
    public int Price {get; set;}
    public bool Status {get; set;}
    public int HotelID {get; set;}
    public Room()
    {
        ID = 0;
        Price = 0;
        Status = true;
        HotelID = 0;
    }
    public Room(int id, int price, bool status, int hotelID)
    {
        Price = price;
        Status = status;
        ID = id;
        HotelID = hotelID;
        RoomNr = id;
    }
    public override string ToString()
    {
        return $"Hotel: {RoomNr}";
    }
}
class Guest
{
    public int ID {get; set;}
    public string Name {get; set;}
    public DateTime Age {get; set;}
    public int PhoneNr {get; set;}
    public string Email {get; set;}
    public Guest()
    {
        Name = "";
        Age = new DateTime();
        PhoneNr = 0;
        Email = "";
    }
    public Guest(int id, string name, DateTime age, int phoneNr, string email)
    {
        ID = id;
        Name = name;
        Age = age;
        PhoneNr = phoneNr;
        Email = email;
    }
    public override string ToString()
    {
        return $"ID: {ID}\n" +
            $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                    $"Phone: {PhoneNr}\n" +
                        $"Email: {Email}";
    }
}
class Booking
{
    public int ID {get; set;}
    public DateTime ReservStart {get; set;}
    public DateTime ReservOut {get; set;}
    public int RoomID {get; set;}
    public int GuestID {get; set;}
    public Booking()
    {
        ReservStart = DateTime.Now.Date;
        ReservOut = DateTime.Now.Date;
    }
    public Booking(int id, DateTime reservStart, DateTime reservOut, int guestID, int roomID)
    {
        ID = id;
        ReservStart = reservStart;
        ReservOut = reservOut;
        GuestID = guestID;
        RoomID = roomID;
    }
}