using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAppDataAccess
{
    public class UsersTableDataService<T>
    {
        private readonly string _connectionString;
        public UsersTableDataService()
        {
            _connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\АбдигалиевМ.CORP.000\source\repos\20190401_PizzaApp\PizzaApp\PizzaAppDataAccess\PizzaApp.mdf;Integrated Security=True";
        }
        public void Add(T item)
        {
            Type type = typeof(T);
            type.GetFields();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();
                    command.CommandText = $"insert into Users values('{user.Login}', '{user.Password}')";
                    var affectedRows = command.ExecuteNonQuery();
                    if (affectedRows < 1) throw new Exception("No rows affected");
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
    }
}
