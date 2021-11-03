using SFModels;

namespace SFUI
{
    public class StoreFrontSingleton
    {
        public static Customer customer = new Customer();

        public static Order order = new Order();

        public static string StoreFrontAddress {get; set; }
        public static int StoreFrontID { get; set; }

        public static int CustomerID {get; set; }
        
    }
}