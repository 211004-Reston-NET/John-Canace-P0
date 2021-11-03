using System.Collections.Generic;
using SFModels;

namespace SFDL
{
    public interface IRepository
    {
        /// <summary>
        /// It will add a storefront in our database
        /// </summary>
        /// <param name="s_ront">This is the storefront we will be adding to the database</param>
        /// <returns>It will just return the storefront we are adding</returns>
        StoreFront AddStoreFront(StoreFront s_ront);

        /// <summary>
        /// This will return a list of storefronts stored in the database
        /// </summary>
        /// <returns>It will return a list of storefronts</returns>
        List<StoreFront> GetAllStoreFronts();

        StoreFront GetStoreFrontByID(int s_id);

        
    }

    public interface ICRepository
    {
        Customer AddCustomer(Customer c_omer);

        List<Customer> GetAllCustomers();

        Customer GetCustomerByID(int c_id);

        //Order AddOrder(Customer s_customer,Order o_rder);
    }

    public interface ILRepository
    {
        Line_Item AddLine_Item(Line_Item l_item);

        List<Line_Item> GetAllLine_Items();
    }

    public interface IORepository  
    {   
        List<Order> GetAllOrders();
    }

    public interface IPRepository
    {
        Product AddProduct(Product P_duct);

        List<Product> GetAllProducts();

        List<Product> GetStoreFrontInventory(int s_id);
    }
}