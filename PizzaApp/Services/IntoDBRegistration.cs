using Models;
using PizzaAppDataAccess;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class IntoDBRegistration<T>
    {
        public delegate bool UserAddNotificationHandler(string number);
        public delegate void ProductAddNotificationHandler(string notificationText);
        public event UserAddNotificationHandler SendMessage;
        public event ProductAddNotificationHandler SendNotificationToAdmin;
        public IntoDBRegistration(T user, TableDataService<T> usersTable)
        {
            Type type = typeof(T);
            usersTable.Add(user);
            if (type.Name.ToString().ToLower() == "user") SendMessage(type.GetProperty("Number").GetValue(user).ToString());
            else if (type.Name.ToString().ToLower() == "product") SendNotificationToAdmin("The product has added");          

        }
    }
}
