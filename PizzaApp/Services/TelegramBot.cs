using Models;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class TelegramBot : INotification<User>
    {
        public void SendNotification(User user)
        {
            throw new NotImplementedException();
        }
    }
}
