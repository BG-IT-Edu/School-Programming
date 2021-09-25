using System;
using System.Collections.Generic;

namespace StoreDB.Data.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int Customer { get; set; }
        public int Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
