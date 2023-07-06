public class Costumer
{
    string _name;
    Address _address;
    public Costumer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public void DisplayCostumer()
    {
        Console.WriteLine($"Name: {_name}, \nAddress: {_address}.");
    }
}