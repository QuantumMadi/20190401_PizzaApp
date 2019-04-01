using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IRegistration<T>
    {
        void SendRegesterNotification(T user);
    }
}
