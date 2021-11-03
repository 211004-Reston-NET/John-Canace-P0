namespace SFUI
{

    //enum hold diff types of Menu user can go through
    public enum MenuType
    {
        MainMenu,
        OrderMenu,
        StoreMenu,
        AddStoreFront,
        ShowStoreFront,
        StoreFrontShown,
        StoreInventory,
        ShowLine_Item,
        CustomerMenu,
        AddCustomer,
        ShowCustomer,
        CustomerShown,
        ShowProduct,
        Exit,
    }

    public interface IMenu
    {
        /// <summary>
        /// Display menu of current menu class and the choice 
        /// you/the user can make
        /// </summary>

        void Menu();

        /// <summary>
        /// Record user's choice and change meny 
        /// based on user's choice
        /// </summary>
        /// <returns> returns a menu type
        MenuType YourChoice();
    }




}