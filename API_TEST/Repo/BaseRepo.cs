using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_TEST.Repo
{
    public class BaseRepo
    {
        public SqlConnection conn = new SqlConnection("");

        public void open()
        {
            conn.Open();
        }

        public void close()
        {
            conn.Dispose();
            conn.Close();
        }
    }
}