﻿using System;
using System.Data;
using System.Reflection;
using System.Text;

namespace PizzaAppDataAccess
{
    public partial class TableDataService<T>
    {
        private static PropertyInfo[] GetProperties(ref string command)
        {
            Type type = typeof(T);
            PropertyInfo[] propertyInfo = type.GetProperties();
            StringBuilder commandString = new StringBuilder($"insert into {type.Name}s values(");
            for (int i = 0; i < propertyInfo.Length; ++i)
            {
                if (propertyInfo[i].Name != "Id")
                {
                    if (i != propertyInfo.Length - 1)
                    {
                        commandString.Append($"@{propertyInfo[i].Name}");
                        commandString.Append(',');
                    }
                    else
                    {
                        commandString.Append($"@{propertyInfo[i].Name}");
                        commandString.Append(')');
                    }
                }
            }
            command = commandString.ToString();
            return propertyInfo;
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
                return SqlDbType.DateTime2;
            else
                return SqlDbType.Xml; //заглушка
        }
    }
}
