using System;

namespace SFUI
{
    //":" used to indicate you will inherit another class, 
    //interface or abstraction 
    public class MainMenu : IMenu
    {

        public void Menu()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[3] - Stores");
            Console.WriteLine("[2] - Customers");
            Console.WriteLine("[1] - Orders");
            Console.WriteLine("[0] - Exit");
            //throw new System.NotImplementedException();
        }

        public MenuType YourChoice()
        {
            string userChoice  = Console.ReadLine();
            switch (userChoice)
            {
                case "3":
                    return MenuType.StoreMenu;
                case "2":
                    return MenuType.CustomerMenu;
                case "1":
                    return MenuType.OrderMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;
            
            }
            //throw new System.NotImplementedException();
        }

    }
}