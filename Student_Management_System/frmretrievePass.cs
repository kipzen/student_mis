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

namespace Student_Management_System
{
    public partial class frmretrievePass : Form
    {
        public frmretrievePass()
        {
            InitializeComponent();
        }
        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SchoolDB;Integrated Security=True";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select Password from login where Username= '" + textBox1.Text + "' AND DateReg='" + textBox2.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
               while (dataReader.Read())
               {
                  MessageBox.Show("Your Password is"+""+dataReader.GetValue(0).ToString()+"Next time Be serious in Remembering simple passwords!!");
               
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                frmLogin frml = new frmLogin();
                frml.Show();
                this.Hide();
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
