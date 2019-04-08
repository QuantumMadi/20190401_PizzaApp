using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsExists { get; set; }
        public Product(string name, int price, bool isExist) { Name = name; Price = price; IsExists = isExist; }
        public Product() { }
    }
}
