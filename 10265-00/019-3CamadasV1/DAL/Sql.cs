using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using _019_3CamadasV1.Util;

namespace _019_3CamadasV1.DAL
{
    class Sql
    {
        private static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DADOS;Integrated Security=true;");
        }

        public static void Execute(SqlCommand k)
        {
            k.Connection = GetConnection();

            k.Connection.Open();
            k.ExecuteNonQuery();
            k.Connection.Close();
        }

        public static List<T> GetData<T>(SqlCommand k)
            where T : new()
        {
            List<T> retorno = new List<T>();

            k.Connection = GetConnection();

            k.Connection.Open();

            var dr = k.ExecuteReader();

            while (dr.Read())
            {
                T obj = new T();

                var t = typeof(T);

                foreach (var item in t.GetProperties())
                {
                    if (item.CanWrite)
                    {
                        item.SetValue(obj, Convert.ChangeType(dr[item.GetCustomAttributes(typeof(DbAttribute), false)[0].ToString()], item.PropertyType), null);
                    }
                }

                retorno.Add(obj);
            }

            k.Connection.Close();

            return retorno;
        }
    }
}
