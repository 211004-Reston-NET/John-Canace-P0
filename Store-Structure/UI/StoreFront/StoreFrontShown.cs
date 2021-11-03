using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class StoreFrontShown : IMenu
    {
        public static Product _findproduct = new Product();
        private IStoreFrontBL _rontBL;
        //private static StoreFront _ront = new StoreFront();
        public StoreFrontShown(IStoreFrontBL p_rontBL)
        {
            _rontBL = p_rontBL;
        }
        public void Menu()
        {
            
            StoreFront StoreFrontSelected = _rontBL.GetStoreFrontByID(StoreFrontSingleton.StoreFrontID);
            
            Console.WriteLine("====================");
            Console.WriteLine(StoreFrontSelected);
            Console.WriteLine("====================");
            
            Console.WriteLine("[1} - View Inventory");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    return MenuType.StoreInventory;
                case "0":
                    return MenuType.ShowStoreFront;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowStoreFront;
            }
        }
    }



}