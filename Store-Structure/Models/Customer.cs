using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SFModels
{
    public class Customer
    {
        public Customer()
        {
            this._customerName = "Name";
            
        }
        
        
        
        //This is a field
        private string _customerName;
        private string _customerphone;
        private List<Order> _orders = new List<Order>();
        //private string _address;
        //private string _email;
        //private int _phoneNumber;
        //private string _orderList;

        //This is a property that uses the field called _customer
        public string CustomerName
        {
            get { return _customerName; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the storeFront field with a number
                    throw new Exception("Customer's name can only hold letters!");
                }
                _customerName = value;
            }
        }

        //public string Customer { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail {get; set; }
        public string CustomerPhoneNumber {get {return _customerphone;} set {if (!Regex.IsMatch(value, @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$"))
                {
                    throw new Exception("Not a valid phone number");
                }
                _customerphone = value;} }
        public int CustomerID{get; set; }
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public override string ToString()
        {
            return $"Name: {CustomerName}\n Address: {CustomerAddress}\nEmail: {CustomerEmail}\nPhoneNumber: {CustomerPhoneNumber}\nCustomerID: {CustomerID}";
            //return $"PhoneNumber: {CustomerPhoneNumber}";
        }

    }
}

