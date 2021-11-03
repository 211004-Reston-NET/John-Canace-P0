using System;
using System.Collections.Generic;

#nullable disable

namespace SFDL.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            OrderLists = new HashSet<OrderList>();
        }

        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public int CusCustomerId { get; set; }

        public virtual ICollection<OrderList> OrderLists { get; set; }
    }
}
