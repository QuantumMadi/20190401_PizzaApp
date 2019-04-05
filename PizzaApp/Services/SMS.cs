using Models;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SMS : INotification<string>
    {
        public void SendNotification(string number)
        {
            throw new NotImplementedException();
        }
       
    }
}
