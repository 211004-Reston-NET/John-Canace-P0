using System;
using System.Collections.Generic;
using SFBL;
using SFModels;
using SFUI;

namespace SFUI
{
    public class ShowCustomer : IMenu
    {
        //public static Customer _findomer = new Customer();
        private static Customer _omer = new Customer();
        private ICustomerBL _omerBL;
        public ShowCustomer(ICustomerBL c_omerBL)
        {
            _omerBL = c_omerBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Customers");
            List<Customer> listOfCustomer = _omerBL.GetAllCustomers();

            foreach (Customer omer in listOfCustomer)
            {
                Console.WriteLine("====================");
                Console.WriteLine(omer);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[1] - Search for Customer");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                try
                {
                    Console.WriteLine("Input Customer ID");
                    StoreFrontSingleton.CustomerID = int.Parse(Console.ReadLine());
                    return MenuType.CustomerShown;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("You can only type Numbers!");
                    return MenuType.ShowCustomer;
                }
                case "0":
                    return MenuType.CustomerMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomer;
            }
        }
    }
}