using System;

namespace SFUI
{
    public class StoreMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to the Store Menu!");
            Console.WriteLine("What do you want to do?");
            //Console.WriteLine("[3] - Purchase a Product");
            Console.WriteLine("[2] - Add a Store");
            Console.WriteLine("[1] - Locate a Store");
            Console.WriteLine("[0] - Go to MainMenu");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                //case "3":
                //    return MenuType.ShowProduct;
                case "2":
                    return MenuType.AddStoreFront;
                case "1":
                    return MenuType.ShowStoreFront;
                case "0":
                    return MenuType.MainMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreMenu;
            }
        }
    }
}