using System;
using System.Collections.Generic;
using System.Linq;
using SFDL;
using SFModels;

namespace SFBL
{


    public class CustomerBL :ICustomerBL
    {
        private ICRepository _repo;
        /// <summary>
        /// We are defining the dependencies this class needs to operate
        /// We do it this way because we can easily switch out which implementation details we will be using
        /// But later on the lecture, we can then switch our SFDL project to point to an actual database in the cloud and we don't have to touch anything else to
        /// have the implementation
        /// </summary>
        /// <param name="p_repo">It will pass in a Respository object</param>
        public CustomerBL(ICRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customer AddCustomer(Customer c_omer)
        {
            return _repo.AddCustomer(c_omer);
        }

        public List<Customer> GetAllCustomers()
        {
            //Maybe my business operation needs to capitalize every name of a storefront
            List<Customer> listOfCustomer = _repo.GetAllCustomers();
            for (int i = 0; i < listOfCustomer.Count; i++)
            {
                listOfCustomer[i].CustomerName = listOfCustomer[i].CustomerName.ToLower(); 
            }

            return listOfCustomer;
        }

        public Customer GetCustomerByID(int c_id)
        {
            Customer custFound = _repo.GetCustomerByID(c_id);

            //return custFound.Where(custFound => custFound.CustomerName.Contains(c_name)).ToList();

            if(custFound == null)
            {
                throw new Exception("Customer was not found!");
            }
            return custFound;
        }

        //Order AddOrder(Customer s_customer,Order o_rder)
        //{
        //    return _repo.AddOrder(s_customer, o_rder);
        //}
    }
}