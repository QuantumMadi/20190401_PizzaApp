using Services.Abstract;
using System;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderingUserId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string OrderingList { get; set; }
        public int OverallPrice { get; set; }
        public Order() { }
        public Order(List<Product> products, int userId)
        {
            OrderingUserId = userId;
            OrderDateTime = DateTime.Now;
            foreach (var product in products)
            {
                OrderingList += $"{product.Name},";
                OverallPrice += product.Price;
            }
        }
    }
}
