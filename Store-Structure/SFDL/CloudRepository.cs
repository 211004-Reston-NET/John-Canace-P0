using System.Collections.Generic;
using System.Linq;
using Entity = SFDL.Entities;
using Model = SFModels;
using System;
using System.Collections;
using System.Text.Json;

namespace SFDL{

     public class CloudRespository : IRepository, ICRepository, ILRepository, IORepository, IPRepository
    {
        private Entity._211004restonnetdemoContext _context;
        //private string _jsonString;
        public CloudRespository(Entity._211004restonnetdemoContext p_context) 
        {
            _context = p_context;
        }

        public Model.StoreFront AddStoreFront(Model.StoreFront s_ront)
        {
            _context.StoreFronts.Add
            (
                new Entity.StoreFront()
                {
                    StoreName = s_ront.StoreFrontName,
                    StoreAddress = s_ront.StoreFrontAddress,
                    StoreStoreId = s_ront.StoreFrontID
                }
            );

            //This method will save the changes made to the database
            _context.SaveChanges();

            return s_ront;
        }

        public List<Model.StoreFront> GetAllStoreFronts()
        {
            //Method Syntax
            return _context.StoreFronts.Select(ront => 
                new Model.StoreFront()
                {
                    StoreFrontName = ront.StoreName,
                    StoreFrontID = ront.StoreStoreId,
                    StoreFrontAddress = ront.StoreAddress,
                }
            ).ToList();
        }

        public Model.StoreFront GetStoreFrontByID(int s_id)
        {
                
                Entity.StoreFront storToFind = _context.StoreFronts.FirstOrDefault(Store => Store.StoreStoreId == s_id);

                return new Model.StoreFront(){
                    StoreFrontName = storToFind.StoreName,
                    StoreFrontID = storToFind.StoreStoreId,
                    StoreFrontAddress = storToFind.StoreAddress,
                        
                };            
        }

        public List<Model.Product> GetStoreFrontInventory(int s_id)
        {
               var result = (from pro in _context.Products 
                                where pro.StoreStoreId == s_id 
                                select pro);
                
                List<Model.Product> listofproducts = new List<Model.Product>();

                foreach (Entity.Product pro in result)
                {
                    listofproducts.Add(new Model.Product(){
                        ProductID = pro.ProductProductnameId,
                        ProductName = pro.ProductName,
                        ProductPrice = pro.ProductPrice,
                        ProductCategory = pro.ProductCategory,
                        ProductDescription = pro.ProductDescription,
                        ProductQuantity = pro.ProductQuantity
                    });
                }
                return listofproducts;
        }    

       public Model.Customer AddCustomer(Model.Customer c_omer)
       {
           _context.Customers.Add
           (
               new Entity.Customer()
               {
                   CustomerName = c_omer.CustomerName,
                   CustomerAddress = c_omer.CustomerAddress,
                   CustomerEmail = c_omer.CustomerEmail,
                   CustomerPhone = c_omer.CustomerPhoneNumber,
               }
           );
           _context.SaveChanges();

           return c_omer;
       }

       public List<Model.Customer> GetAllCustomers()
       {
           return _context.Customers.Select(omer =>
                new Model.Customer()
                {
                    CustomerName = omer.CustomerName,
                    CustomerAddress = omer.CustomerAddress,
                    CustomerEmail = omer.CustomerEmail,
                    CustomerPhoneNumber = omer.CustomerPhone,
                    CustomerID = omer.CusCustomerId 
                }
            ).ToList();
       }

       public Model.Customer GetCustomerByID(int c_id)
        {
                Entity.Customer custToFind = _context.Customers.FirstOrDefault(Customer => Customer.CusCustomerId == c_id);

                return new Model.Customer(){
                    CustomerName = custToFind.CustomerName,
                    CustomerAddress = custToFind.CustomerAddress,
                    CustomerEmail = custToFind.CustomerEmail,
                    CustomerPhoneNumber = custToFind.CustomerPhone,
                    CustomerID = custToFind.CusCustomerId
                        
                };            
        }
       public Model.Line_Item AddLine_Item(Model.Line_Item l_item)
       {
           _context.LineItems.Add
           (
               new Entity.LineItem()
               {
                   LineItemnameId = l_item.lineItemProductNameID,
                   LineOrderListId = l_item.LineOrderListID,
                   LineStoreId = l_item.LineStoreID,
                   LineItemquantity = l_item.Quantity
               }
           );
           _context.SaveChanges();

           return l_item;
       }

       public List<Model.Line_Item> GetAllLine_Items()
       {
           return _context.LineItems.Select(item =>
                new Model.Line_Item()
                {
                    lineItemProductNameID = item.LineItemnameId,
                    LineOrderListID = item.LineOrderListId,
                    LineStoreID = item.LineStoreId,
                    Quantity = item.LineItemquantity
                }
           ).ToList();
       }

       public List<Model.Order> GetAllOrders()
       {
           return _context.OrderLists.Select(rder =>
           new Model.Order(){
               StoreID = rder.OrderStoreId,
               CustomerID = rder.OrderCustomerId,
               OrderList = rder.OrderOrderListId,
               TotalPrice = rder.OrderTotalprice
            }
           ).ToList();
       }

       public Model.Product AddProduct(Model.Product p_duct)
       {
           _context.Products.Add
           (
               new Entity.Product()
               {
                   ProductProductnameId = p_duct.ProductID,
                   ProductName = p_duct.ProductName,
                   ProductPrice = p_duct.ProductPrice,
                   ProductDescription = p_duct.ProductDescription,
                   StoreStoreId = p_duct.StoreStoreID,
                   ProductCategory = p_duct.ProductCategory
               }
           );
           _context.SaveChanges();
           
           return p_duct;
       }

       public List<Model.Product> GetAllProducts()
       {
           return _context.Products.Select(duct =>
            new Model.Product()
            {
                ProductID = duct.ProductProductnameId,
                ProductName = duct.ProductName,
                ProductPrice = duct.ProductPrice,
                ProductDescription = duct.ProductDescription,
                ProductCategory = duct.ProductCategory
            }
            ).ToList();
       }

       public Model.Product GetProductByID(int p_prodID)
       {
           var result = _context.Products.FirstOrDefault<Entity.Product>(prod => prod.ProductProductnameId == p_prodID);
           return new Model.Product()
           {
               ProductName = result.ProductName,
               ProductPrice = result.ProductPrice,
               ProductDescription = result.ProductDescription,
               ProductCategory = result.ProductCategory,
               ProductID = result.ProductProductnameId
           };
       }

       public void UpdateProductQuantity(int p_orderID, Model.Order p_order)
       {
           foreach (Model.Line_Item item in p_order.ItemList)
           {
               _context.LineItems.Add(new Entity.LineItem(){
                   LineItemnameId = item.lineItemProductNameID,
                   LineOrderListId = item.LineOrderListID
               });

               var quantityUpdate = _context.LineItems.FirstOrDefault<Entity.LineItem>(dpitem => dpitem.LineItemnameId == item.lineItemProductNameID);
               quantityUpdate.LineItemquantity = quantityUpdate.LineItemquantity - item.Quantity;
           }

           _context.SaveChanges();
       }
    }
    
}