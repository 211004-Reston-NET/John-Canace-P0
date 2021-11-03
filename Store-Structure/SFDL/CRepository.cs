using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using SFModels;

namespace SFDL
{
    //The repository class has a bunch of methods that we will use to get or store information from the database
    //Does not actually hold the data itself
    public class CRepository : ICRepository
    {
        //Filepath need to reference from the startup project (RRUI) and hence why we need to go back a folder and cd into RRDL
        private const string _filepath = "./../SFDL/Database/Customer.json";
        private string _jsonString;

        public Customer AddCustomer(Customer c_omer)
        {
            //The reason why we need to grab all the information back is because File.WriteAllText method will overwrite anything inside the JSON file
            List<Customer> listOfCustomer = GetAllCustomers();

            //We added the new restaurant from the parameter 
            listOfCustomer.Add(c_omer);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented=true});

            //This is what adds the storefront.json
            File.WriteAllText(_filepath,_jsonString);

            //Will return a storefront object from the parameter
            return c_omer;
        }


        public List<Customer> GetAllCustomers()
        {
            //File class will just read everything in the StoreFront.json and put it in a string
            _jsonString = File.ReadAllText(_filepath);

            //Since we are converting from a string to an object that C# understands we need to deserialize the string to object.
            //Json Serializer has a static method called Deserialize and thats why you don't need to instantiate it
            //The parameter of the Deserialize method needs a string variable that holds the json file
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }

        public Customer GetCustomerByID(int c_id)
        {
            throw new NotImplementedException();
        }

        //Order AddOrder(Customer s_customer,Order o_rder)
        //{
        //    List<Customer> listOfCustomers = GetAllCustomers();
        //    foreach (Customer customer in listOfCustomers)
        //    {
        //        if (customer.CustomerName == s_customer.CustomerName && 
        //            customer.CustomerAddress == s_customer.CustomerAddress && 
        //            customer.CustomerEmail == s_customer.CustomerEmail && 
        //            customer.CustomerPhoneNumber == s_customer.CustomerPhoneNumber)
        //        {
        //            customer.Order.Add(o_rder);
        //            _jsonString = JsonSerializer.Serialize(listOfCustomers, new JsonSerializerOptions { WriteIndented = true });
        //            File.WriteAllText(_filepath + "Customer.json", _jsonString);
        //        }
        //    }
        //    return o_rder;
            
        //}
    }
}