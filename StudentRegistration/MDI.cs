using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{ 
    public partial class MDI : Form
{ 
        public MDI()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        Form1 StudentForm = new Form1();
        StudentForm.ShowDialog();
        }

        private void departmebtToolStripMenuItem_Click(object sender, EventArgs e)
         {
        Form3 dpr = new Form3();
        dpr.ShowDialog();
    }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

