
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
    public partial class ChangePro : Form
    {
        public ChangePro()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=AUCARegistration;Integrated Security=True");

        private void ChangePro_Load(object sender, EventArgs e)
        {
            fetchProgrData();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
                comboBox1.Items.Add(reader["Program_name"].ToString());
            }
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();

            // Query the source table and populate the ComboBox
            string query = "SELECT Program_name FROM Program";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Program_name"].ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String StudentID = textBox3.Text;
            String Department = comboBox1.SelectedItem.ToString();
            //String query = "Update Student set deptName = '" + Department + "' where id ='" + StudentID + "'";
            SqlDataAdapter sda = new SqlDataAdapter("Update Student set Program_name = '" + Department + "' where stu_id ='" + StudentID + "'", con);
            con.Open();
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Program updated seccessfully");
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
