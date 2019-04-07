using Models;
using Services.Abstract;
using System;
using TLSharp.Core;
using TLSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TelegramBot : INotification<string>
    {  
        public void SendNotification(string number)
        {
            var store = new FileSessionStore();
            //var client = new TelegramClient();
           
        }
    }
}
