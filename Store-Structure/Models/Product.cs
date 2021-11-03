using System;
using System.Text.RegularExpressions;

namespace SFModels
{
    public class Product
    {
        //This is a field
        private string _productName;
        

        //This is a property that uses the field called _productFront
        public string ProductName
        {
            get { return _productName; }
            set 
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    //Will give the user an exception whenever you try to set the storeFront field with a number
                    throw new Exception("StoreFront can only hold letters!");
                }
                _productName = value;
            }
        }

        public int ProductID {get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory {get; set; }

        public int StoreStoreID {get; set; }

        public int ProductQuantity {get; set; }

        public override string ToString()
        {
            return $"Name: {ProductName}\nPrice: {ProductPrice}\nDescription: {ProductDescription}\nCategory: {ProductCategory}\nQuantity: {ProductQuantity}";
            //return $"Price: {ProductPrice}";
        }

    }
}

