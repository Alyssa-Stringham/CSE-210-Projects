using System;
using System.Data;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Address address = order1._customer.SetCustomerAddress("Mary Ellen", "145 North Main Street", "Salt Lake City", "Utah", "USA");
        Product o1product1 = new Product();
        o1product1.SetProduct("Milk", "001-Mk", 2.99, 2);
        Product o1product2 = new Product();
        o1product2.SetProduct("Eggs", "002-E", 1.89, 1);
        Product o1product3 = new Product();
        o1product3.SetProduct("Bread", "003-Br", 1.55, 1);
        Product o1product4 = new Product();
        o1product4.SetProduct("Paper Towels", "101-PT", 2.45, 2);
        order1._customerProducts.Add(o1product1);
        order1._customerProducts.Add(o1product2);
        order1._customerProducts.Add(o1product3);
        order1._customerProducts.Add(o1product4);

        order1.GetShippingLabel();
        order1.GetPackingLabel();
        order1.CalculateShipping(address.InUSA());
        double order1Total = order1.CalculateOrderTotal();
        Console.WriteLine($"Order Total: ${order1Total}");

        Console.WriteLine();

        Order order2 = new Order();
        address = order2._customer.SetCustomerAddress("Robert Jones", "1450 West Main", "Calgary", "Alberta", "Canada");
        Product o2product1 = new Product();
        o2product1.SetProduct("Paper Towels", "101-PT", 2.45, 1);
        Product o2product2 = new Product();
        o2product2.SetProduct("Blanket", "201-Bkt", 17.95, 1);
        Product o2product3 = new Product();
        o2product3.SetProduct("Hot Chocolate Mix", "065-HCmx", 5.49, 2);
        Product o2product4 = new Product();
        o2product4.SetProduct("Thermos", "503-Thms", 20.95, 1);
        order2._customerProducts.Add(o2product1);
        order2._customerProducts.Add(o2product2);
        order2._customerProducts.Add(o2product3);
        order2._customerProducts.Add(o2product4);

        order2.GetShippingLabel();
        order2.GetPackingLabel();
        order2.CalculateShipping(address.InUSA());
        double order2Total = order2.CalculateOrderTotal();
        Console.WriteLine($"Order Total: ${order2Total}");
    }
}