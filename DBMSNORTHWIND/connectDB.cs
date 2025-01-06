using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMSNORTHWIND
{
    internal class connectDB
    {
        public static SqlConnection ConnectNortwind()
        {
            string server = @".\sqlexpress";
            string db = "northwind";
            string strCon = string.Format(@"Data Source={0};initial catalog={1};" + "Integrated security = true; Encrypt = false", server, db);
            SqlConnection connection = new SqlConnection(strCon);
            connection.Open();
            return connection;
        }
    }
}
