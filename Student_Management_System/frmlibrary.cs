using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frmlibrary : Form
    {
        public frmlibrary()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are sure to Exit?","Confirm Exit", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
            this.Close();
        }

        private void frmlibrary_Load(object sender, EventArgs e)
        {
            cbBooks.Text = "Select Book To Borrow";
            cbBooks.Items.Add("Automata Theory");
            cbBooks.Items.Add("Application Programming");
            cbBooks.Items.Add("Network Administration and Maintenance");
            cbBooks.Items.Add("Pc MAintenance and Networking Lab");
            cbBooks.Items.Add("Digital Logics");
            cbBooks.Items.Add("Wireless and Mobile Computing");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
           DialogResult res1= MessageBox.Show("Confirm borrowing", "Borrow Confirmation", MessageBoxButtons.OKCancel,  MessageBoxIcon.Question);
            if (res1 == DialogResult.OK)
            {
                MessageBox.Show("You have successfully Borrowed"+" "+ cbBooks.SelectedItem +" "+" To be returned before "+" "+dateTimePicker2.Text, "Successful Borrowing",MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
        }

        private void cbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
