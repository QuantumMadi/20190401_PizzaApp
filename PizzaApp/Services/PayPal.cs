using Services.Abstract;
using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PayPal : IPaySystem<Order>
    {             
        public bool Pay(Order order)
        {           
            throw new NotImplementedException();
        }
    }
}
