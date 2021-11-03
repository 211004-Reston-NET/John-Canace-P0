using System;
using System.Collections.Generic;
using SFDL;
using System.Linq;
using Entity = SFDL.Entities;
using SFModels;

namespace SFBL
{


    public class ProductBL :IProductBL
    {
        private Entity._211004restonnetdemoContext _context;
        public ProductBL(Entity._211004restonnetdemoContext p_context) 
        {
            _context = p_context;
        }
        private IPRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our SFDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public ProductBL(IPRepository p_repo)
        {
            _repo = p_repo;
        }

        public Product AddProduct(Product p_duct)
        {
            return _repo.AddProduct(p_duct);
        }

        public List<Product> GetAllProducts()
        {
            //Maybe my business operation needs to capitalize every name of a storefront
            List<Product> listOfProduct = _repo.GetAllProducts();
            for (int i = 0; i < listOfProduct.Count; i++)
            {
                listOfProduct[i].ProductName = listOfProduct[i].ProductName.ToLower(); 
            }

            return listOfProduct;
        }

        //public List<StoreFront> GetStoreFrontProdListID(string prodID)
        //{
        //    prodID = Entity.StoreFront.StoreProdListId;
        //}

        public List<Product> GetStoreFrontInventory(int s_id)
        {
            return _repo.GetStoreFrontInventory(s_id);
        }
    }
}