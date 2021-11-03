using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class StoreFront
    {
        public StoreFront()
        {
            LineItems = new HashSet<LineItem>();
            OrderLists = new HashSet<OrderList>();
            Products = new HashSet<Product>();
        }

        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public int StoreStoreId { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<OrderList> OrderLists { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
