using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class OrderList
    {
        public OrderList()
        {
            LineItems = new HashSet<LineItem>();
        }

        public decimal OrderTotalprice { get; set; }
        public int OrderOrderListId { get; set; }
        public int OrderStoreId { get; set; }
        public int OrderCustomerId { get; set; }

        public virtual Customer OrderCustomer { get; set; }
        public virtual StoreFront OrderStore { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
