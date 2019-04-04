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
        private List<Product> Products;
        public string OrderingList { get; set; }
        public int OverallPrice { get; set; }
        public Order(List<Product> products, int userId)
        {
            Products = new List<Product>();
            OrderingUserId = userId;
            OrderDateTime = DateTime.Now;
            Products = products;
            foreach (var product in Products)
            {
                OverallPrice += product.Price;
                OrderingList += product.Name;
            }          
        }      
    }
}
