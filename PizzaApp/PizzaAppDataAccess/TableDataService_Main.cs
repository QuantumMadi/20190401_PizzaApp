using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace PizzaAppDataAccess
{   //Считывает только публичные поля, лучше использовать какой-нибудь атрибут
    public partial class TableDataService<T>
    {
        private readonly string _connectionString;
        public TableDataService()
        {
            // _connectionString = connectionString;
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PizzaDB;Integrated Security=True";
              // _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\WWW\DOCUMENTS\GITHUB\20190401_PIZZAAPP\PIZZAAPP\PIZZAAPPDATAACCESS\PIZZAAPPNOTEBOOKDBCONTEXT.MDF;Integrated Security=True";
           // _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\АбдигалиевМ.CORP.000\source\repos\20190401_PizzaApp\PizzaApp\PizzaAppDataAccess\PizzaApp.mdf;Integrated Security=True";
        }                   
        public List<T> GetAll()
        {
            Type itemType = typeof(T);
            PropertyInfo[] properties = itemType.GetProperties(BindingFlags.Public);
            object itemObject = Activator.CreateInstance(itemType);

            var data = new List<T>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                try {
                        SqlTransaction transaction = null;
                        transaction = connection.BeginTransaction();
                        command.Transaction = transaction;
                        command.CommandText = CreateSelectCommand(ref properties);
                        var dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                             foreach(var property in properties)
                            {
                              Type propertyType = property.PropertyType;                             
                              object propertyObj = Activator.CreateInstance(propertyType);  
                              propertyObj = dataReader[$"{property.Name}"];
                               
                              
                            }
                        }
                    }
                catch (SqlException exeption)
                {
                    //TODO обработка
                    throw;
                }
                catch (Exception exeption)
                {
                    //TODO обработка
                    throw;
                }
            }
            return data;
        }
    }
}


//public List<User> GetAll()
//{
//    var data = new List<User>();
//    using (var connection = new SqlConnection(_connectionString))
//    using (var command = connection.CreateCommand())
//    {
//        try
//        {
//            connection.Open();
//            command.CommandText = "select * from Users";
//            var dataReader = command.ExecuteReader();
//            while (dataReader.Read())
//            {
//                data
//                int id = (int)dataReader["Id"];
//                string login = dataReader["Login"].ToString();
//                string password = dataReader["Password"].ToString();
//                data.Add(new User
//                {
//                    Id = id,
//                    Login = login,
//                    Password = password,
//                });
//            }
//            dataReader.Close();
//        }
//        catch (SqlException exeption)
//        {
//            //TODO обработка
//            throw;
//        }
//        catch (Exception exeption)
//        {
//            //TODO обработка
//            throw;
//        }
//    }
//    return data;
//}