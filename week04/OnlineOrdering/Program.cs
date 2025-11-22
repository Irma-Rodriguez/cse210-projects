using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("10200 S Temple Dr", "South Jordan", "UT", "USA");
        Customer customer1 = new Customer("Joseph Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("The Book of Mormon", "TBOM1234", 2.5, 5));
        order1.AddProduct(new Product("Hymns", "HYM234", 5.0, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");


        Address address2 = new Address("Cr 123: 1-5", "Bucaramanga", "Santander", "Colombia");
        Customer customer2 = new Customer("Emilio Ramirez", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Backpack", "BP432", 30.50, 1));
        order2.AddProduct(new Product("Saints Book", "SIB987", 8.50, 2));
        order2.AddProduct(new Product("Bottle of water", "BOW456", 4.0, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}\n");
    }
}