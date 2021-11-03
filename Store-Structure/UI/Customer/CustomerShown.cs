using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class CustomerShown : IMenu
    {
        private ICustomerBL _omerBL;
        private static Customer _omer = new Customer();
        public CustomerShown(ICustomerBL c_omerBL)
        {
            _omerBL = c_omerBL;
        }
        public void Menu()
        {
            Customer CustomerSelected = _omerBL.GetCustomerByID(StoreFrontSingleton.CustomerID);
            
            Console.WriteLine("====================");
            Console.WriteLine(CustomerSelected);
            Console.WriteLine("====================");
            
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "0":
                    return MenuType.ShowCustomer;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowCustomer;
            }
        }
    }



}