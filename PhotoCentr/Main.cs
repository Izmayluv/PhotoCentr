using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhotoCentr
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            label3.Text = "Введите запрос в поле,\n расположенное внизу окна";

            textBoxO.Hide();
            textBoxQ.Hide();
            textBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();

            FormAuth formAuth = new FormAuth();
            formAuth.Show();

            Order formOrder = new Order();
            formOrder.Show();

            MyBooks myBooks = new MyBooks();
            myBooks.Show();
            
            //comboBoxServices.Items.Add("Все заказы");
            //comboBoxServices.Items.Add("Заказы в течении опредлённого времени и сумма выручки");
            //comboBoxServices.Items.Add("Узнать информацию о фотографе по номеру заказа");
            //comboBoxServices.Items.Add("Ввести запрос вручную");
        }

        Connection connection = new Connection();
        Querys querys = new Querys();

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.StartConnectionSQL();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
            finally
            {
                if (Connection._connection.State == ConnectionState.Open)
                    MessageBox.Show("Connection is open!");
            }
            
        }

        private void buttonCloseconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.CloseConnectionSQL();
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection closing error");
            }
            finally
            {
                if (Connection._connection.State == ConnectionState.Closed)
                    MessageBox.Show("Connection closed!");

            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                connection.StartConnectionSQL();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error");
            }
            /////   /\   /////   /\   /////   /\   ///// /\ Connection open /\
         
            switch (comboBoxServices.SelectedIndex)
            {
                default:
                    break;

                case -1:
                    MessageBox.Show("Выберите запрос");
                    break;

                case 1:
                    try
                    {
                        querys.showAllOrders(dataGridViewPC);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                    break;

                case 2:
                    try
                    {
                        querys.showSomeOrders(dataGridViewPC, textBoxO);
                        textBoxO.Show();
                        label1.Show();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                    break;

                case 3:
                    try
                    {
                        querys.showPhotographers(dataGridViewPC, textBoxQ);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error", "Error");
                    }
                    break;

                case 0:
                    try
                    {
                        querys.manualQuery(dataGridViewPC, textBox1);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Encorrect query", "Error");
                    }
                    break;
            }







            //        \/ Connection close \/  
            try
            {
                connection.CloseConnectionSQL();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxServices.SelectedIndex)
            {
                default:
                    break;

                case 1:
                    textBoxO.Hide(); textBoxO.Clear();
                    label1.Hide();

                    textBoxQ.Hide(); textBoxQ.Clear();
                    label2.Hide();

                    textBox1.Hide(); textBoxQ.Clear();
                    label3.Hide();
                    panel1.Height = 289;
                    break;
                case 2: 


                    textBoxQ.Hide(); textBoxQ.Clear();
                    label2.Hide();

                    textBox1.Hide(); textBoxQ.Clear();
                    label3.Hide();
                    panel1.Height = 289;
                    break;
                case 3:
                    textBoxO.Hide(); textBoxO.Clear();
                    label1.Hide();

                    textBoxQ.Show();
                    label2.Show();

                    textBox1.Hide(); textBoxQ.Clear();
                    label3.Hide();
                    panel1.Height = 289;
                    break;
                case 0:
                    textBoxO.Hide(); textBoxO.Clear();
                    label1.Hide();

                    textBoxQ.Hide(); textBoxQ.Clear();
                    label2.Hide();

                    textBox1.Show();
                    label3.Show();
                    panel1.Height = 270;
                    break;
            }
        }

        private void textBoxQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
