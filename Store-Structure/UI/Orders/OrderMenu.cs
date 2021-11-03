using System;

namespace SFUI
{
    public class OrderMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Order Menu!");
            Console.WriteLine("[2] - Place an Order");
            Console.WriteLine("[1] - Show Customer/StoreFront Order History");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                //case "2":
                //    return MenuType.StoreMenu;
                //case "1":
                //    return MenuType.AddCustomer;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            }
        }
    }
}