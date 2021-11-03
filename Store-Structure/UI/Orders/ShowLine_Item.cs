using System;
using System.Collections.Generic;
using SFBL;
using SFModels;

namespace SFUI
{
    public class ShowLine_Item : IMenu
    {
        private ILine_ItemBL _itemBL;
        public ShowLine_Item(ILine_ItemBL l_itemBL)
        {
            _itemBL = l_itemBL;
        }
        public void Menu()
        {
            Console.WriteLine("List of Line Items");
            List<Line_Item> listOfLine_Items = _itemBL.GetAllLine_Items();

            foreach (Line_Item item in listOfLine_Items)
            {
                Console.WriteLine("====================");
                Console.WriteLine(item);
                Console.WriteLine("====================");
            }
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "0":
                    return MenuType.ShowStoreFront;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.ShowLine_Item;
            }
        }
    }
}