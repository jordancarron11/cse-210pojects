using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address address1 = new Address ("58 Pembroke", "Jefferson", "MO", "USA");
        Customer customer1 = new Customer("Harold Lyou", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Grapefruit", "4256", 0.25, 4);
        Product order1Product2 = new Product("Tums", "4225", 3.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        //display order 1
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("---------------------------------------------");


        //order 2
        Address address2 = new Address ("578 Walker St", "Houston", "TX", "USA");
        Customer customer2 = new Customer("Joe Prows", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Salt", "4260", 2.00, 1);
        Product order2Product2 = new Product("Red Vines", "4959", 2.00, 4);
        Product order2Product3 = new Product("Apples", "4029", 0.50, 6);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        //display 
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");

    }   
}