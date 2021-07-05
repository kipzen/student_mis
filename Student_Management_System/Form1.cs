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
   
    public partial class frmStudent : Form
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
        public frmStudent()
        {
            InitializeComponent();
        }
        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SchoolDB;Integrated Security=True";
        private void btnlibrary_Click(object sender, EventArgs e)
        {
     
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql= null;
            sql= "select distinct gender, County,School,Department,Course,Year from student";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command= new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
               cbxGender.DataSource = ds.Tables[0];
                cbxGender.DisplayMember = "Gender";
           cbxCounty.DataSource = ds.Tables[0];
              cbxCounty.DisplayMember = "County";
              cbxSchool.DataSource = ds.Tables[0];
                cbxSchool.DisplayMember = "School";
                cbxDepartment.DataSource = ds.Tables[0];
                cbxDepartment.DisplayMember = "Department";
             cbxCourse.DataSource = ds.Tables[0];
               cbxCourse.DisplayMember = "Course";
               cbxYear.DataSource = ds.Tables[0];
                cbxYear.DisplayMember = "Year";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from student  WHERE RegNo='" + txtReg.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    txtFN.Text = dataReader.GetValue(1).ToString();
                    txtLN.Text= dataReader.GetValue(2).ToString();
                    cbxGender.Text = dataReader.GetValue(3).ToString();
                    cbxCounty.Text = dataReader.GetValue(4).ToString();
                    dtpDOR.Text = dataReader.GetValue(5).ToString();
                    cbxSchool.Text = dataReader.GetValue(6).ToString();
                    cbxDepartment.Text = dataReader.GetValue(7).ToString();
                    cbxCourse.Text = dataReader.GetValue(8).ToString();
                    cbxYear.Text = dataReader.GetValue(9).ToString();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Establish Connection! ");
            }


        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Are sure to Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }

        private void goToLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdgv f2 = new frmdgv();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "insert into student(RegNo, FirstName, LastName, Gender, County, DateReg, School, Department, Course, Year) values('" + txtReg.Text + "','" + txtFN.Text + "','" + txtLN.Text + "','" + cbxGender.Text + "','" + cbxCounty.Text +"','"+ dtpDOR.Text +"','" + cbxSchool.Text +"','"+ cbxDepartment.Text +"','"+ cbxCourse.Text +"',"+ cbxYear.Text +")";
            connection = new SqlConnection(connectionString);
            try

            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Records Saved Succcessfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblyearlevel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "UPDATE student SET FirstName= '" + txtFN.Text + "', LastName='" + txtLN.Text + "',Gender='" + cbxGender.Text + "',County='" + cbxCounty.Text + "',DateReg='" + dtpDOR.Text + "',School='" + cbxSchool.Text + "',Department='" + cbxDepartment.Text + "',Course='" + cbxCourse.Text + "',Year=" + cbxYear.Text + " WHERE RegNo='" + txtReg.Text + "'";
            connection = new SqlConnection(connectionString);
            try

            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Records Updated Succcessfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "DELETE FROM  student WHERE RegNo='" + txtReg.Text + "'";
            connection = new SqlConnection(connectionString);
            try

            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Records Deleted Succcessfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }