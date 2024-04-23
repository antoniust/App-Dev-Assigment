using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        FormLOGIN form;
        
        public List<string> listUsername = new List<string>();
        public List<string> listPW = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form1.Visible = false;
            
            listUsername.Add("admin");
            listPW.Add("admin");
            listUsername.Add("anton");
            listPW.Add("anton");
            FormLOGIN FormLOGIN = new FormLOGIN(this);
            FormLOGIN.ShowDialog();




        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 Form2 = new Form2(this);
            Form2.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLOGIN FormLOGIN = new FormLOGIN(this);
            FormLOGIN.Show();
            

        }
    }
}
