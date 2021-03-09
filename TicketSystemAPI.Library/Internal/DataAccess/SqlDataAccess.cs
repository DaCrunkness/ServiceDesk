using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TicketSystemAPI.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {

        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

            }
        }


        //public static string GetConnectionString(string connectionName = "TicketSystemDB")
        //{
        //    return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        //}


        //public static List<T> LoadData<T>(string sql)
        //{
        //    using (IDbConnection connection = new SqlConnection(GetConnectionString()))
        //    {
        //        return connection.Query<T>(sql).ToList();
        //    }
        //}

        //public static int SaveData<T>(string sql, T data)
        //{
        //    using (IDbConnection connection = new SqlConnection(GetConnectionString()))
        //    {
        //        return connection.Execute(sql, data);
        //    }
        //}
    }
}
