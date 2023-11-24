using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fetchDeptData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=AUCARegistration;Integrated Security=True");
        public void fetchDeptData()
        {
            con.Open();

            // Query the source table and populate the ComboBox
            string query = "SELECT deptName FROM Department";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["deptName"].ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String StudentID = textBox3.Text;
            String Department = comboBox1.SelectedItem.ToString();
            //String query = "Update Student set deptName = '" + Department + "' where id ='" + StudentID + "'";
            SqlDataAdapter sda = new SqlDataAdapter("Update Student set deptName = '" + Department + "' where stu_id ='" + StudentID + "'", con);
            con.Open();
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data updated seccessfully");
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            // Query the source table and populate the ComboBox
            string query = "SELECT deptName FROM Department";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["deptName"].ToString());
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
