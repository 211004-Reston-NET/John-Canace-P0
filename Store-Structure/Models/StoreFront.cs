using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SFModels
{
    public class StoreFront
    {
        //This is a field
        private string _storeFrontName;

        //This is a property that uses the field called _storeFront
        public string StoreFrontName
        {
            get { return _storeFrontName; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the storeFront field with a number
                    throw new Exception("StoreFront can only hold letters!");
                }
                _storeFrontName = value;
            }
        }

        public string StoreFrontAddress { get; set; }
        
        //this is how I wanted it to work but without erros
        //List<string> newList = new List<string>();
        //newList.Add(Console.ReadLine());

        public string ProductsList { get; set; }
        //public string Orders{get; set; }

        public int StoreFrontID{get; set; }

        private List<Line_Item> lineItems;
        private List<Order> _orders;

        public List<Line_Item> Line_Items {get{return lineItems;}set{lineItems = value;}}

        public List<Order> Orders {get{return _orders;}set{_orders = value;}}

        public override string ToString()
        {
            return $"StoreFrontName: {StoreFrontName}\nStoreFrontAddress: {StoreFrontAddress}\nStoreFrontID: {StoreFrontID}";
        }

    }
}

