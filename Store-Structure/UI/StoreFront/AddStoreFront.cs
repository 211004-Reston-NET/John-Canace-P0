using System;
using SFBL;
using SFModels;

namespace SFUI
{
    public class AddStoreFront : IMenu
    {
        private static StoreFront _ront = new StoreFront();
        private IStoreFrontBL _rontBL;
         
        public AddStoreFront(IStoreFrontBL p_rontBL)
        {
            _rontBL = p_rontBL;
        }

        public void Menu()
        {
            Console.WriteLine("Adding a new StoreFront");
            Console.WriteLine("StoreFrontName - " + _ront.StoreFrontName);
            Console.WriteLine("StoreFrontAddress - "+ _ront.StoreFrontAddress);
            Console.WriteLine("StoreID - "+ _ront.StoreFrontID);
            Console.WriteLine("[4] - Add StoreFront");
            Console.WriteLine("[3] - Input value for Name");
            Console.WriteLine("[2] - Input value for Address");
            Console.WriteLine("[1] - Input value for Store ID");
            Console.WriteLine("[0] - Go Back");
        }

        public MenuType YourChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "4":
                try
                {
                    //Add implementation to talk to the repository method to add a storefront
                    _rontBL.AddStoreFront(_ront);
                    return MenuType.StoreMenu;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Fill out all fields!");
                    return MenuType.AddStoreFront;
                }
                case "3":
                try
                {
                    Console.WriteLine("Type in the value for the Name");
                    _ront.StoreFrontName = Console.ReadLine();
                    return MenuType.AddStoreFront;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("That is not a StoreFront name!");
                    return MenuType.AddStoreFront;
                }
                case "2":
                try
                {
                    Console.WriteLine("Type in the value for the Address");
                    _ront.StoreFrontAddress = Console.ReadLine();
                    return MenuType.AddStoreFront;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("That is not an Address!");
                    return MenuType.AddStoreFront;
                }
                case "1":
                try
                {
                    Console.WriteLine("Type in the value for the Store ID");
                    _ront.StoreFrontID = Convert.ToInt32(Console.ReadLine());
                    return MenuType.AddStoreFront;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Store ID only takes numbers!");
                    return MenuType.AddStoreFront;
                }
                case "0":
                    return MenuType.StoreMenu;
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    return MenuType.AddStoreFront;
            }
        }
    }
}