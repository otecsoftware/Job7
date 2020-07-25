using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Job.Database
{
    public class DBContext
    {
        public static string connStr = "Data Source=PHIWOKUHLEN-PC\\SQLEXPRESS;Initial Catalog=JoburgWter;Integrated Security=SSPI;";
        public static void ExecuteWithoutReturn(string procname, DynamicParameters dataParams)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                conn.Execute(procname, dataParams, commandType: CommandType.StoredProcedure);
            }

        }

        public static T ExecuteReturnScalar<T>(string procname, DynamicParameters dataParams)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                List<T> ts = conn.Query<T>(procname, dataParams, commandType: CommandType.StoredProcedure).ToList();
                //return ts.First();
               return (T)Convert.ChangeType(conn.QueryFirst<T>(procname, dataParams, commandType: CommandType.StoredProcedure), typeof(T));
            }
        }

        public static IEnumerable<T> ReturnList<T>(string procname, DynamicParameters dataParams)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                return conn.Query<T>(procname, dataParams, commandType: CommandType.StoredProcedure);
            }
        }

    }
}
