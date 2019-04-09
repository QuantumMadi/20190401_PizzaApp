using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Models;
using PizzaApp.Services;
using PizzaAppDataAccess;
using Services;
using Services.Abstract;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //User newUser = new User();
            //SmsSender smsSender = new SmsSender();

            //var usersTableData = new TableDataService<User>();
            //var pizzasTableData = new TableDataService<Pizza>();
            //var ordersTableData = new TableDataService<Order>();

            //Console.WriteLine("Insert your Name");
            //newUser.Name = Console.ReadLine();
            //Console.WriteLine("Insert your Address");

            //newUser.Address = Console.ReadLine();
            //Console.WriteLine("Insert your Number");

            //newUser.Number= Console.ReadLine();
            //var dBRegistration = new IntoDBRegistration<User>(newUser, usersTableData);
            //dBRegistration.SendMessage+=(message => smsSender.SendNotification(newUser.Number));

            //List<object> pizzas = pizzasTableData.GetAll();
            //foreach (var pizzaza in pizzasTableData.GetAll())
            //{
            //    Console.WriteLine($"{((Pizza)pizzaza).Id} : {((Pizza)pizzaza).Name} : {((Pizza)pizzaza).Composition}");                
            //}

            //Console.WriteLine("Insert id of pizza you want");
            // var orderingPizzaId = int.Parse(Console.ReadLine());

            //List<Pizza> pizzasForOrder = new List<Pizza>();
            //foreach (var pizza in pizzas)
            //{
            //    if (orderingPizzaId == ((Pizza)pizza).Id && ((Pizza)pizza).IsExists == true) { pizzasForOrder.Add(((Pizza)pizza)); }

            //}
            //Order order = new Order(pizzasForOrder,newUser.Id);
            //ordersTableData.Add(order);


            //User user = new User()
            //{
            //    Name = "Madi",
            //    Number = "8702514414",
            //    Address = "Sarayshyk",
            //};

            //TableDataService<User> userTableData = new TableDataService<User>();
            //userTableData.Add(user);

            Order order = new Order()
            {
                OrderingList = "qwdqwdqw",
                OrderingUserId = 1,
                OverallPrice = 3000,
            };
            TableDataService<Order> userTableData = new TableDataService<Order>();
            userTableData.Add(order);
        }
    }
}
