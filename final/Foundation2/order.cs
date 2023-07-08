
public class Order
{
    private List<Product> _products = new List<Product>{};
    private Costumer _costumer;
    private Address _address;
    // public void SetProduct(Product prod)
    // {
    //     _products = prod;
    // }
    public Order(Costumer costumer, Product product1, Product product2, Product product3)
    {
        _costumer = costumer;
        _products.Add(product1);
        _products.Add(product2);
        _products.Add(product3);
    }
    public void PackagingLabel()
    {
       // A packing label should list the name and product id of each product in the order.
       Console.WriteLine("****************************************************************");
       foreach( Product product in _products)
       {
           Console.WriteLine(product.productDisplay);
       }
       Console.WriteLine($"\nTOTAL: {TotalCost}\n");
       Console.WriteLine("****************************************************************");
    }
    public void ShippingLabel()
    {
        //A shipping label should list the name and address of the customer
        
        Console.WriteLine("****************************************************************");
        Console.WriteLine();
        Console.WriteLine(_costumer.DisplayCostumer);
        Console.WriteLine();
        Console.WriteLine("****************************************************************");

    }
    public double TotalCost()
    {
        //Can calculate the total cost of the order, and can return a string for the packing label, 
        //and can return a string for the shipping label.
        double cost = 0;
        foreach( Product product in _products)
       {
           Console.WriteLine(product.productPrice);
           cost =+ product.productPrice();
       }
        return cost;
    }
  
    public double TotalPrice()
    //The total price is calculated as the sum of the prices of each product plus a one-time shipping cost
    //USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    {
        double shippingCost = 0;
        if (_address.International())
        {
            shippingCost = TotalCost() + 5;
        }
        else
        {
            shippingCost = TotalCost() + 35;
        }
        return shippingCost;
    }
    public void OrderDisplay()
    {
        Console.WriteLine();
        Console.WriteLine(PackagingLabel);
        Console.WriteLine(TotalCost());
        Console.WriteLine(TotalPrice());
        Console.WriteLine(ShippingLabel);
        
    }
    

}