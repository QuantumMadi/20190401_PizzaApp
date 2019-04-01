using Models;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SMS : IRegistration<User>
    {            
        public void SendRegesterNotification(User user)
        {
            throw new NotImplementedException();
        }
    }
}
