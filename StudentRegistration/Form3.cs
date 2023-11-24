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

namespace StudentRegistration
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=AUCARegistration;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {

            displayData();
        }

        public void displayData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Department", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Department");
            dataGridView1.DataSource = ds.Tables["Department"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                // Create tunnel
            SqlCommand cmd = new SqlCommand("Insert into Department (deptid, deptName, facultyid) values(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox4.Text + "')", con);
            //Opem con and execute the cmd, finally close con and display
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved with sucess");
            
            displayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String search = textBox3.Text;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Department where deptId=" + search + "", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Department");
            dataGridView1.DataSource = ds.Tables["Department"];
            displayData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)

            }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Department", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Department");
            dataGridView1.DataSource = ds.Tables["Department"];
        }
    }
   }
    

