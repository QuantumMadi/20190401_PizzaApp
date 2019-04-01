using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public User OrderingUser { get; set; }
        public List<Product> Products { get; set; }
        public int OverallPrice { get; set; }

        public void OverallPriceCount()
        {
            foreach(var product in Products)
            {
                OverallPrice += product.Price;
            }

        }
    }
}
