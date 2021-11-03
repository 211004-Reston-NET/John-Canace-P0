using System;
using System.Collections.Generic;
using SFDL;
using SFModels;

namespace SFBL
{


    public class OrderBL :IOrderBL
    {
        private IORepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our SFDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public OrderBL(IORepository p_repo)
        {
            _repo = p_repo;
        }

        public List<Order> GetAllOrders()
        {
            //Maybe my business operation needs to capitalize every name of a storefront
            List<Order> listOfOrder = _repo.GetAllOrders();
            for (int i = 0; i < listOfOrder.Count; i++)
            {
                listOfOrder[i].OrderList = listOfOrder[i].OrderList; 
            }

            return listOfOrder;
        }
    }
}