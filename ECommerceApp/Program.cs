using System;
using System.Collections.Generic;

namespace ECommerceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> orders = new List<string>();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Add an Order");
                Console.WriteLine("2. View Orders");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the order name:");
                        string order = Console.ReadLine();
                        orders.Add(order);
                        Console.WriteLine("Order added successfully.");
                        break;

                    case "2":
                        Console.WriteLine("Orders:");
                        foreach (var o in orders)
                        {
                            Console.WriteLine(o);
                        }
                        break;

                    case "3":
                        keepRunning = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
