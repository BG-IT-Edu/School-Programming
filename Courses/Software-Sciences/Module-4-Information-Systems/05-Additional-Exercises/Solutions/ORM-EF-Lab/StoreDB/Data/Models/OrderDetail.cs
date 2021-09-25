
namespace StoreDB.Data.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int Product { get; set; }
        public int Quantity { get; set; }

    }
}
