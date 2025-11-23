using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Pickle Street", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Alex Rore", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("USB Flash Drive", "P001", 10.0, 2));
        order1.AddProduct(new Product("Wireless Keyboard", "P002" ,25.0 , 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
    }


}