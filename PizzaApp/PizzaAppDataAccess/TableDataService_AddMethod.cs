using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAppDataAccess
{
    public partial class TableDataService<T>
    {
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

                    foreach (var property in GetProperties(ref dbCommand))
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
    }
}
