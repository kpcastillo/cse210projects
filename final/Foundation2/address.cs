public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    //getters, setters
    public void CostumerAddress()
    {
        Console.WriteLine($"Address: {_streetAddress} {_city}, {_state} {_country}");
    }
    public bool International()
    {
        bool usaShip = false;
        if (_country == "USA")
        {
            usaShip = true;
           
        }
        return usaShip;
        
    }


}