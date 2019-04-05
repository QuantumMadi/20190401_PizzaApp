using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAppDataAccess
{
    public partial class TableDataService<T>
    {
        private static PropertyInfo[] GetProperties(ref string command)
        {
            Type type = typeof(T);
            PropertyInfo[] propertyInfo = type.GetProperties(BindingFlags.Public);
            StringBuilder commandString = new StringBuilder($"insert into {type.Name}s values(");

            for (int i = 0; i < propertyInfo.Length; ++i)
            {
                if (propertyInfo[i].ToString() != "Id")
                {
                    if (i != propertyInfo.Length - 1)
                    {
                        commandString.Append($"@{propertyInfo[i]}");
                        commandString.Append(',');
                    }
                    else
                    {
                        commandString.Append($"@{propertyInfo[i]}");
                        commandString.Append(')');
                    }
                }
            }
            return propertyInfo;
        }

        private static string CreateSelectCommand(ref PropertyInfo[] properties)
        {
            string selectCommand = "select ";
            Type type = typeof(T);
            
            for(int i =0; i < properties.Length - 1; ++i)
            {
                selectCommand += properties[i];
                if (properties[i] != properties[properties.Length - 1])
                {
                    selectCommand += ",";
                }
                else selectCommand += " ";               
            }
            return selectCommand += $"from {type.Name}s";
        }

        private static SqlDbType SqlTypeIdentifier(Type parameterType)
        {
            if (parameterType == typeof(int))
                return SqlDbType.Int;
            else if (parameterType == typeof(string))
                return SqlDbType.NVarChar;
            else if (parameterType == typeof(bool))
                return SqlDbType.Bit;
            else if (parameterType == typeof(DateTime))
                return SqlDbType.DateTime;
            else
                return SqlDbType.Xml; //заглушка
        }

    }
}
