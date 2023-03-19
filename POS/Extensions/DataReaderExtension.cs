using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace POS.Extensions
{
    public static class DataReaderExtension
    {
        public static List<T> ConvertToList<T>(this IDataReader reader) where T : class
        {
            var list = new List<T>();
            T obj = default(T);

            while (reader.Read())
            {
                obj = Activator.CreateInstance<T>();

                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!Equals(reader[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, reader[prop.Name], null);
                    }
                }

                list.Add(obj);
            }

            return list;
        }

        public static T ConvertToObject<T>(this IDataReader reader) where T : class, new()
        {
            T obj = new T();

            while (reader.Read())
            {
                obj = Activator.CreateInstance<T>();

                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!Equals(reader[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, reader[prop.Name], null);
                    }
                }
            }

            return obj;
        }
    }
}
