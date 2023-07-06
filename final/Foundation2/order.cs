
public class Order
{
    List<Product> _products = new List<Product>{};
    Costumer _costumer;
    Address _address;
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
        if (Address _address.International)
        {
            shippingCost = TotalCost() + 5;
        }
        else
        {
            shippingCost = TotalCost() + 35;
        }
        return shippingCost;
    }
    

}