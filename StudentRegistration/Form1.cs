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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fetchDeptData();
            fetchProgrData();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=AUCARegistration;Integrated Security=True");

        public void fetchDeptData()
        {
            // SqlDataAdapter sda = new SqlDataAdapter("SELECT* from Department", con);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "Department");
            // comboBox1.DataSource = ds.Tables["Department"];
            //comboBox1.DisplayMember = "deptName";
            // comboBox1.ValueMember = "deptid";
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

        public void fetchProgrData()
        {
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT* FROM Program", con);
            //DataSet ds = new DataSet();
            // sda.Fill(ds, "Program");
            // comboBox2.DataSource = ds.Tables["Program"];
            //comboBox2.DisplayMember = "Program_name";
            //comboBox2.ValueMember = "Program_id";

            con.Open();

            // Query the source table and populate the ComboBox
            string query = "SELECT Program_name FROM Program";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader["Program_name"].ToString());
            }
            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            // Query the source table and populate the ComboBox
            string query = "SELECT Program_name FROM Program";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader["Program_name"].ToString());
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
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


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String Department = comboBox1.SelectedItem.ToString();
            String Program = comboBox2.SelectedItem.ToString();
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Student (stu_id, fullName, email, password, deptName, Program_name) VALUES ("+textBox1.Text+", '"+textBox2.Text+ "', '" + textBox3.Text + "', '" + textBox4.Text + "', '"+Department+ "', '"+Program+"')", con);
            con.Open();
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registration Successful");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }
    }
}
