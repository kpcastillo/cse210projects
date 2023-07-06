public class Product
{
    string _name;
    int _id;
    double _price;
    int _quantity;
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public double productPrice()
    {
        return _price * _quantity;
    }
}