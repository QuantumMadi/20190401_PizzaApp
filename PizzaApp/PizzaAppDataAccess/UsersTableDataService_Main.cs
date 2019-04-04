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
    public partial class UsersTableDataService<T>
    {
        private readonly string _connectionString;
        public UsersTableDataService(string connectionString)
        {
              // _connectionString = connectionString;
               _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\WWW\DOCUMENTS\GITHUB\20190401_PIZZAAPP\PIZZAAPP\PIZZAAPPDATAACCESS\PIZZAAPPNOTEBOOKDBCONTEXT.MDF;Integrated Security=True";
           // _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\АбдигалиевМ.CORP.000\source\repos\20190401_PizzaApp\PizzaApp\PizzaAppDataAccess\PizzaApp.mdf;Integrated Security=True";
        }      
       
        public void Add(T item)
        {
            string dbCommand = string.Empty;
            SqlTransaction transaction = null;
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {              
                try
                {
                    connection.Open();

                    transaction = connection.BeginTransaction();
                    command.Transaction = transaction;       
                    
                    foreach(var property in GetProperties(ref dbCommand))
                    {
                        var propertyParametr = new SqlParameter();

                        propertyParametr.ParameterName = $"@{property}";

                        if (SqlTypeIdentifier(property.PropertyType) != SqlDbType.Xml)  //заглушка на случай если придет неизвестный тип
                            propertyParametr.SqlDbType = SqlTypeIdentifier(property.PropertyType);

                        propertyParametr.SqlValue = property.GetValue(item);
                    }

                    var affectedRows = command.ExecuteNonQuery();
                    if (affectedRows < 1) throw new Exception("No rows affected");

                    transaction.Commit();
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
        }

        public List<T> GetAll()
        {
            var data = new List<T>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                SqlTransaction transaction = null;
                transaction = connection.BeginTransaction();
                command.Transaction = transaction;
                command.CommandText = CreateSelectCommand();
                var dataReader = command.ExecuteReader();
            }
        }
        public List<User> GetAll()
        {
            var data = new List<User>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = "select * from Users";
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        data
                        int id = (int)dataReader["Id"];
                        string login = dataReader["Login"].ToString();
                        string password = dataReader["Password"].ToString();
                        data.Add(new User
                        {
                            Id = id,
                            Login = login,
                            Password = password,
                        });
                    }
                    dataReader.Close();
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
