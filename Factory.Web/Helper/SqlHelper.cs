using System;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using Dapper;
using System.Data.Common;

namespace Factory.Web.Helper
{
    public class SqlHelper
    {
        private static string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public static DbConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(conn);
            return con;
        }

        public static IEnumerable<T> DoSearch<T>(string sql, object param)
        {
            using (var con = GetConnection())
            {
                return SqlMapper.Query<T>(con, sql, param);
            }
        }


        public static int DoUpdate(string sql, object param)
        {
            using (var con = GetConnection())
            {
                return SqlMapper.Execute(con, sql, param);
            }
        }

        public static int DoDelete(string sql, object param)
        {
            using (var con = GetConnection())
            {
                return SqlMapper.Execute(con, sql, param);
            }
        }

        public static int DoAdd(string sql, object param)
        {
            using (var con = GetConnection())
            {
                return SqlMapper.Execute(con, sql, param);
            }
        }
    }
}