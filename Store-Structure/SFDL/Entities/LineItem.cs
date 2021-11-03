using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class LineItem
    {
        public int LineOrderListId { get; set; }
        public int LineStoreId { get; set; }
        public int LineItemnameId { get; set; }
        public int LineItemquantity { get; set; }

        public virtual Product LineItemname { get; set; }
        public virtual OrderList LineOrderList { get; set; }
        public virtual StoreFront LineStore { get; set; }
    }
}
