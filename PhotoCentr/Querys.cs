using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PhotoCentr
{
    internal class Querys
    {

        public void showAllOrders(DataGridView dataGrid)
        {
            string _cmd = "select * from Customers";
            SqlDataAdapter _adapter = new SqlDataAdapter(_cmd, Connection._connection);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds, "Customers");
            dataGrid.DataSource = _ds.Tables["Customers"];
            dataGrid.DataSource = _ds.Tables[0];
        }

        public void showSomeOrders(DataGridView dataGrid, TextBox textBox )
        {
            string _cmd = "select id_order,id_customer,date_order,total_price from Orders where date_order>'2008-11-11'";
            SqlDataAdapter _adapter = new SqlDataAdapter(_cmd, Connection._connection);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds, "Customers");
            dataGrid.DataSource = _ds.Tables["Customers"];
            dataGrid.DataSource = _ds.Tables[0];

            string _ccmd = "select SUM(total_price) as 'sum_price' from Orders where date_order>'2008-11-11'";
            SqlCommand sqlCommand = new SqlCommand( _ccmd, Connection._connection );
            sqlCommand.CommandText = _ccmd;
            SqlDataReader _reader = sqlCommand.ExecuteReader();
            while (_reader.Read())
            {
                textBox.Text += _reader.GetValue(0).ToString();
            }
            _reader.Close();
            
        }

        public void showPhotographers(DataGridView dataGrid, TextBox textBox)
        {
            string _cmd = "select " +
                "Orders.id_order as 'Номер заказа'," +
                "Photographers.fio_photographer as 'ФИО фотографа'," +
                "Photographers.price_an_hour as 'Стоимость часа съёмок'," +
                "Photographers.phonenumber_photographer as 'Рабочий номер фотографа'," +
                "Photographers.date_start as 'Начало фотосессии'," +
                "Photographers.date_end as 'Окончание фотосессии' " +
                "from Photographers " +
                "inner join Services on Photographers.id_photograph = Services.id_service " +
                "inner join Orders on Services.id_service = Orders.id_order " +
                "where Orders.id_order = "+textBox.Text;
            SqlDataAdapter _adapter = new SqlDataAdapter(_cmd, Connection._connection);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds, "Customers");
            dataGrid.DataSource = _ds.Tables["Customers"];
            dataGrid.DataSource = _ds.Tables[0];
        }

        public void manualQuery(DataGridView dataGrid, TextBox textBox)
        {
            string _cmd = textBox.Text;
            SqlDataAdapter _adapter = new SqlDataAdapter(_cmd, Connection._connection);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds, "Customers");
            dataGrid.DataSource = _ds.Tables["Customers"];
            dataGrid.DataSource = _ds.Tables[0];
        }
    }
}
