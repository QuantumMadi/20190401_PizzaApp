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
        public delegate void UserAddNotificationHandler(string number);
       // public delegate void ProductAddNotificationHandler(string notificationText);
        public event UserAddNotificationHandler SendMessage;
        //public event ProductAddNotificationHandler SendNotificationToAdmin;
        public void ItemRegister(T user, TableDataService<T> usersTable)
        {
            Type type = typeof(T);
            usersTable.Add(user);
            if (type.Name.ToString().ToLower() == "user") SendMessage($"{GetRandom()}");
            //else SendNotificationToAdmin($"The {type.Name} has added");   
        }
        private static int GetRandom()
        {
            var random = new Random();
            return (random.Next() + 10000) % 1000;
        }
    }
}
