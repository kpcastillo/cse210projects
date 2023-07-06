
public class Order
{
    List<Product> _products = new List<Product>{};
    Costumer _costumer;
    public void PackagingLabel()
    {
       // A packing label should list the name and product id of each product in the order.
    }
    public void ShippingLabel()
    {
        //A shipping label should list the name and address of the customer
    }
  
    public double TotalPrice()
    //The total price is calculated as the sum of the prices of each product plus a one-time shipping cost
    //USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    {
        return 1.2;
    }
    public double TotalCost()
    {
        //Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
        return 1.2;
    }

}