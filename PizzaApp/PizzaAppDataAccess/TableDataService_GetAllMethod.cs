using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace PizzaAppDataAccess
{  
    public partial class TableDataService<T>
    {
        private readonly string _connectionString;
        public TableDataService()
        {
            // _connectionString = connectionString;
            _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\АБДИГАЛИЕВМ.CORP.000\SOURCE\REPOS\20190402_CONNECTIONTODB\CONNECTEDLVLTEST\CONNECTEDLVLTEST.DATAACCESS\DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
              // _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\WWW\DOCUMENTS\GITHUB\20190401_PIZZAAPP\PIZZAAPP\PIZZAAPPDATAACCESS\PIZZAAPPNOTEBOOKDBCONTEXT.MDF;Integrated Security=True";
           // _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\АбдигалиевМ.CORP.000\source\repos\20190401_PizzaApp\PizzaApp\PizzaAppDataAccess\PizzaApp.mdf;Integrated Security=True";
        }                   
        public List<object> GetAll()
        {
            Type itemType = typeof(T);
            PropertyInfo[] properties = itemType.GetProperties();
            object itemObject = Activator.CreateInstance(itemType);

            ConstructorInfo constructor = itemType.GetConstructor(new Type[] { });
            object itemExemplarObject;

            var data = new List<object>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                try {
                        connection.Open();
                        command.CommandText = $"select * from {itemType.Name}s";
                        var dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                        itemExemplarObject = constructor.Invoke(new object[] { });
                        foreach (var property in properties)
                        {
                            
                            Type propertyType = property.PropertyType;
                              object obj = dataReader[$"{property.Name}"];
                              property.SetValue(itemExemplarObject, obj);                                                                                     
                        }
                        data.Add(itemExemplarObject);
                        itemExemplarObject = null;
                        }
                    }
                #region catch
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
                 #endregion 
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