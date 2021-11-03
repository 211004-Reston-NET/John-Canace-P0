using System;
using SFBL;
using SFModels;

namespace SFUI
{
    public class AddCustomer : IMenu
    {
        private static Customer _omer = new Customer();
        private ICustomerBL _omerBL;
         
        public AddCustomer(ICustomerBL c_omerBL)
        {
            _omerBL = c_omerBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding a new Customer");
            Console.WriteLine("CustomerName - " + _omer.CustomerName);
            Console.WriteLine("CustomerAddress - "+ _omer.CustomerAddress);
            Console.WriteLine("CustomerEmail - "+ _omer.CustomerEmail);
            Console.WriteLine("CustomerPhoneNumber - "+ _omer.CustomerPhoneNumber);
            Console.WriteLine("[5] - Add Customer");
            Console.WriteLine("[4] - Input value for Name");
            Console.WriteLine("[3] - Input value for Address");
            Console.WriteLine("[2] - Input value for Email");
            Console.WriteLine("[1] - Input value for Phone Number");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "5":
                try
                {
                    _omerBL.AddCustomer(_omer);
                    Console.WriteLine("You have been added.");
                    return MenuType.AddCustomer;
                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine("You must input value to all fields above");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
                }
                case "4":
                try
                {
                    Console.WriteLine("Type in the value for the Name");
                    _omer.CustomerName = Console.ReadLine();
                    return MenuType.AddCustomer;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("You can only type letters!");
                    return MenuType.AddCustomer;
                }
                case "3":
                    Console.WriteLine("Type in the value for the Address");
                    _omer.CustomerAddress = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "2":
                    Console.WriteLine("Type in the value for the Email");
                    _omer.CustomerEmail = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "1":
                    Console.WriteLine("Type in the value for the Phone Number");
                    _omer.CustomerPhoneNumber = Console.ReadLine();
                    return MenuType.AddCustomer;
                case "0":
                    return MenuType.CustomerMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddCustomer;
            }
        }
    }
}