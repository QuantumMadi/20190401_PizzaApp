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
        private static void CreateParametr()
        {
            
        }

        public void Add(T item)
        {
            Type type = typeof(T);
            PropertyInfo[] fieldInfo = type.GetProperties();

            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                try
                {
                    connection.Open();                 
                    StringBuilder commandString = new StringBuilder($"insert into {type.Name}s values(");

                    for(int i = 0; i < fieldInfo.Length; ++i)
                    {
                        if(i != fieldInfo.Length - 1)
                        {
                            commandString.Append($"@{fieldInfo[i]}");
                            commandString.Append(',');
                        }
                        else
                        {
                            commandString.Append($"@{fieldInfo[i]}");
                            commandString.Append(')');
                        }
                    }
                                      
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
