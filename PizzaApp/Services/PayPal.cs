using Services.Abstract;
using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PayPal : IPaySystem<Models.Order>
    {             
        public bool Pay(Models.Order order)
        {           
            throw new NotImplementedException();
        }
    }
}
