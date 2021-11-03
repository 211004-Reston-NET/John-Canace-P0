using System.Collections.Generic;
using SFModels;

namespace SFBL
{
    public interface IStoreFrontBL
    {
        /// <summary>
        /// This will return a list of storefronts stored in the database
        /// It will also capitalize every name of the storefront
        /// </summary>
        /// <returns>It will return a list of storefronts</returns>
        List<StoreFront> GetAllStoreFronts();

        /// <summary>
        /// Adds a storefront to the database
        /// </summary>
        /// <param name="s_ront">This is the storefront we are adding</param>
        /// <returns>It returns the added storefront</returns>
        StoreFront AddStoreFront(StoreFront s_ront);


        StoreFront GetStoreFrontByID(int s_id);

        
    }

    public interface ICustomerBL
    {        
        
        
        //Return list of customers stored in Database
        List<Customer> GetAllCustomers();

        //Adds a customer to the database
        Customer AddCustomer(Customer c_omer);

        Customer GetCustomerByID(int c_id);

        //Order AddOrder(Customer s_customer, Order o_rder);
    }

    public interface ILine_ItemBL
    {        
        
        
        //Return list of customers stored in Database
        List<Line_Item> GetAllLine_Items();

        //Adds a customer to the database
        Line_Item AddLine_Item(Line_Item l_item);
    }

    public interface IOrderBL
    {        
        
        
        //Return list of customers stored in Database
        List<Order> GetAllOrders();
    }

    public interface IProductBL
    {        
        
        
        //Return list of customers stored in Database
        List<Product> GetAllProducts();

        //Adds a customer to the database
        Product AddProduct(Product p_duct);

        List<Product> GetStoreFrontInventory(int s_id);
    }
}