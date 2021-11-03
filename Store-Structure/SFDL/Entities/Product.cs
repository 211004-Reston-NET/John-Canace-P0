using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Product
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public int StoreStoreId { get; set; }
        public int ProductProductnameId { get; set; }
        public int ProductQuantity { get; set; }

        public virtual StoreFront StoreStore { get; set; }
        public virtual LineItem LineItem { get; set; }
    }
}
