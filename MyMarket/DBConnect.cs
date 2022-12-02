using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyMarket
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=ABDURRAHMAN081A\ACT7;Initial Catalog=marketdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlConnection GetCon()
        {
            return connection;
        }
        public void OpenCon()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }
        }
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
