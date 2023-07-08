using System;

class Program
{
    static void Main(string[] args)
    {
        //two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label,
        // and the total price of the order, and display the results of these methods.
        
        Address address1 = new Address("8989 Stoney Shore", "Las Vegas", "NV", "USA");
        Costumer costumer1 = new Costumer("Oliver G", address1);
        Product product1 = new Product("Milk", 098761, 5.99, 2);
        Product product2 = new Product("Eggs", 098762, 6.99, 1);
        Product product3 = new Product("Cheese", 098763, 9.99, 3);
        Order order1 = new Order(costumer1, product1, product2, product3);
        Console.WriteLine(order1.OrderDisplay);

        Address address2 = new Address("7316 Stoney", "San Cristobal", "Guatemala", "GT");
        Costumer costumer2 = new Costumer("Kathleen C", address2);
        Product product4 = new Product("Chocolate Milk", 098764, 7.99, 1);
        Product product5 = new Product("Baguels", 098765, 5.99, 2);
        Product product6 = new Product("Cream Cheese", 098766, 4.99, 1);
        Order order2 = new Order(costumer1, product1, product2, product3);
        Console.WriteLine(order2.OrderDisplay);

       

   


    }
}