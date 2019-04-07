using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Drinking : Product
    {
        public Drinking(string name, int price, bool isExist) : base(name, price, isExist) { }
    }
}
