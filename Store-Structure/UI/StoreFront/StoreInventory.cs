using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class StoreInventory : IMenu
    {
        private IProductBL _ductBL;

        public StoreInventory(IProductBL p_ductBL)
        {
            _ductBL = p_ductBL;
        }

        public void Menu()
        {
            Console.WriteLine("Inventory List");
            List<Product>listofProd = _ductBL.GetStoreFrontInventory(StoreFrontSingleton.StoreFrontID);

            foreach(Product prod in listofProd)
            {
                Console.WriteLine("====================");
                Console.WriteLine(prod);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "0":
                    return MenuType.StoreFrontShown;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.StoreInventory;
            }
        } 
    }
}