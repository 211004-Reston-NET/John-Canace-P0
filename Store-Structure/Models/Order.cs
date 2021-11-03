using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SFModels
{
    public class Order
    {
        private List<Line_Item> _lineItems = new List<Line_Item>();
        public int OrderList {get; set; }
        public decimal TotalPrice {get; set; }

        public List<Line_Item> ItemList{get{return _lineItems;} set{_lineItems = value;} }
        //public string ItemList{get; set; }

        public int CustomerID {get; set; }

        public int StoreID {get; set; }

         public override string ToString()
        {
            return $"ListName: {OrderList}\nTotalPrice: {TotalPrice}\nItemList: {ItemList}";
            //return $"Price: {TotalPrice}";
        }

    }
}

