using System;

namespace SFUI
{
    public class CustomerMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Customer List!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[2] - Add Customer");
            Console.WriteLine("[1] - Find Customer");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "2":
                    return MenuType.AddCustomer;
                case "1":
                    return MenuType.ShowCustomer;
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