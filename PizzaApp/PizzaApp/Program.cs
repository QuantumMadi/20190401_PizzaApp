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
            User newUser = new User()
            {
                Name = "Oleg",
                Address = "Blah blah",
                Number = "8282828282"
            };

            List<Product> pro = new List<Product>()
            {
                new Pizza("qwasde",1000,true,"qwe",true),
                new Pizza("qdfsdfwe",1000,true,"qasfsd",true),
                new Pizza("qweaqw",1500,true,"qwe",true),
            };

            Order order = new Order(pro, 1);

            //Pizza pizza = new Pizza("Margaritta",1000,true,"asdawdawdaw",true);
            TableDataService<Order> tableData = new TableDataService<Order>();

            tableData.Add(order);

        }
    }
}
