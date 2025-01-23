namespace FastFood.Core.ViewModels.Orders
{
    using System.Collections.Generic;

    public class CreateOrderViewModel
    {
        public List<int> Items { get; set; }

        public List<int> Employees { get; set; }
    }
}
