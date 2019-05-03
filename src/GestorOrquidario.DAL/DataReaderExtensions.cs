using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace GestorOrquidario.DAL
{
    static public class DataReaderExtensions
    {
        static public System.Collections.Generic.List<T> ToList<T>(this IDataReader reader) where T : new()
        {
            return reader.ToList<T>(true);
        }

        static public System.Collections.Generic.List<T> ToList<T>(this IDataReader reader, bool ignoreConvertExceptions) where T : new()
        {
            var results = new List<T>();
            while (reader.Read())
            {
                T result = new T();
                results.Add(result);
                Type t = result.GetType();

                PropertyInfo[] properties = t.GetProperties(System.Reflection.BindingFlags.IgnoreCase
                        | System.Reflection.BindingFlags.Public
                        | System.Reflection.BindingFlags.Instance);

                foreach (var property in properties)
                {
                    object[] attributes = property.GetCustomAttributes(typeof(ColumnMappingAttribute), true);
                    if (attributes != null && attributes.Length > 0)
                    {
                        ColumnMappingAttribute cma = attributes[0] as ColumnMappingAttribute;

                        object dataValue = reader[cma.Source];
                        if (DBNull.Value == dataValue) dataValue = null;

                        if (dataValue != null && property.PropertyType != dataValue.GetType())
                        {
                            try
                            {
                                if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                                {
                                    Type[] genericArgs = property.PropertyType.GetGenericArguments();
                                    if (genericArgs.Length > 0)
                                    {
                                        dataValue = Convert.ChangeType(dataValue, genericArgs[0]);
                                    }
                                }
                                else
                                {
                                    dataValue = Convert.ChangeType(dataValue, property.PropertyType);
                                }
                            }
                            catch
                            {
                                throw;
                            }
                        }

                        try
                        {
                            property.SetValue(result, dataValue, null);
                        }
                        catch (ArgumentException)
                        {
                            if (!ignoreConvertExceptions)
                            {
                                throw;
                            }
                        }

                    }
                }
            }
            return results;
        }
    }
}
