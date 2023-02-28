using System;
using System.Collections.Generic;

namespace PastorFinals1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>
            {
                "MOSSO",
                "MOB",
                "GIANT",
                "CANNONDALE",
                "SPECIALIZED",
                "SCOTT",
                "SUNPEED",
                "ATOMIC",
                "TWITTER",
                "MOUNTAINPEAK",
                "SIMPLON",
                "SANTA CRUZ",
                "MERIDA",
                "COLE",
                "FOXTER",
                "DARE",
                "TRINX",

            };

            List<int> prices = new List<int>
            {
                45000,
                30000,
                55000,
                50000,
                60000,
                63000,
                50000,
                70000,
                55000,
                75000,
                30000,
                35000,
                50000,
                70000,
                80000,
                65000,
                70000,

            };

            List<string> orderList = new List<string>();
            int totalCost = 0;

            while (true)
            {
                ShowMainMenu();
                string userInput = GetUserInput();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("==========BIKE STATION==========");
                        Console.WriteLine("---------------------------------------");
                        for (int i = 0; i < menu.Count; i++)
                        {
                            Console.WriteLine($"{menu[i]} = {prices[i]}");
                        }
                        Console.WriteLine("");
                        break;

                    case "2":
                        Console.WriteLine("Enter your choice of bike:");
                        string order = Console.ReadLine();
                        if (menu.Contains(order))
                        {
                            Console.WriteLine("Successfully added your order!");
                            orderList.Add(order);
                            totalCost += prices[menu.IndexOf(order)];
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the variant you entered is not available.");
                        }
                        Console.WriteLine("");
                        break;

                    case "3":
                        Console.WriteLine("Enter the bike you want to remove:");
                        string removeOrder = Console.ReadLine();
                        if (orderList.Contains(removeOrder))
                        {
                            Console.WriteLine("Successfully removed the order from the list!");
                            orderList.Remove(removeOrder);
                            totalCost -= prices[menu.IndexOf(removeOrder)];
                        }
                        else
                        {
                            Console.WriteLine("Sorry, the order you entered is not in the list.");
                        }
                        Console.WriteLine("");
                        break;

                    case "4":
                        Console.WriteLine("Here is/are Your Bike");
                        foreach (string orderItem in orderList)
                        {
                            Console.WriteLine($"{orderItem} = {prices[menu.IndexOf(orderItem)]}");
                        }
                        Console.WriteLine($"Total cost: {totalCost}");
                        Console.WriteLine("");
                        break;

                    case "5":
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for choosing DREW'S BIKE SHOP");
                        Console.WriteLine($"Your total cost is: {totalCost}");
                        Console.WriteLine("Please proceed to the counter for your payment.");

                        return;
                }
            }
        }

        static void ShowMainMenu()
        {

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("===== PLEASE INPUT A NUMBER =====");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1 to open Main Menu");
            Console.WriteLine("2 to place an order");
            Console.WriteLine("3 to remove an order");
            Console.WriteLine("4 to view your order and total cost");
            Console.WriteLine("5 to leave");
            Console.WriteLine("");
        }

        static string GetUserInput()
        {
            Console.WriteLine("Customer Input:");
            string input = Console.ReadLine();
            return input;
        }
    }
}
