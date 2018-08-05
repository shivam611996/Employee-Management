using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class DbClass
    {
        private static SqlConnection _connection = null;
        private static string cs;

        private static SqlConnection Connection
        { 
            get
            {
                if (_connection == null)
                {
                    cs = ConfigurationManager.ConnectionStrings["DemoApplication"].ToString();
                    
                    _connection = new SqlConnection(cs);
                }

                if(_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                return _connection;
            }
        }

        public static SqlCommand GetCommand(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
           
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = commandType;

            foreach(SqlParameter p in parameters)
            {
                cmd.Parameters.Add(p);
            }

            return cmd;
        }

        public static int ExecuteNonQuery(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            return GetCommand(sql, commandType, parameters).ExecuteNonQuery();
        }

        public static SqlDataReader ExecuteReader(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            return GetCommand(sql, commandType, parameters).ExecuteReader();
        }

    }
}