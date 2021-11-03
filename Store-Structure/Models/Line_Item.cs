using System;
using System.Text.RegularExpressions;

namespace SFModels
{
    public class Line_Item
    {
        //This is a field
        
        private Product _prods;
        private int _quant;
        public string lineItemList;

        //private string _lineItemProductName;
        
        public int LineStoreID {get; set;}
        
        public int LineOrderListID {get; set;} 

        public int lineItemProductNameID;

        public Product Product {get{return _prods;}set{_prods = value;}}

        public int Quantity { get{return _quant;} set{_quant = value;} }

        public override string ToString()
        {
            return $"ProductID: {lineItemProductNameID}\nQuantity: {Quantity}";
            //return $"Quantity: {Quantity}";
        }

    }
}

