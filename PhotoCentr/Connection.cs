using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhotoCentr
{
    internal class Connection
    {
        static private string _connectionString = @"Server = DESKTOP-CPO7E1M, 1433; Database= PhotoCenter;User Id = oleg; Password=123";
        static public SqlConnection _connection;

        public void StartConnectionSQL()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void CloseConnectionSQL()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
