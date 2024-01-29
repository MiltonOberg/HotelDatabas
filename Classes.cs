
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