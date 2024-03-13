using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
                dt = new DataTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int input = Convert.ToInt32(textBox1.Text);
            int cek = 0;
            for (int i = 1; i<input; i++) 
            {
                for (int j = 1; j <= i; j++) 
                { 
                    if (i % j == 0) 
                    {
                        cek++;
                    }
                }
            }
            if (cek == 2)
            {
                DialogResult dr = MessageBox.Show("Apakah bilangan Prima ? ", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Sampeyan KURANG BELAJAR MSZZ");
                }
                else if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Sampeyan TOP GLOBAL MASZZ");
                }
                
            }
            else 
            {
                DialogResult dr = MessageBox.Show("Apakah bilangan Prima ? ", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Sampeyan TOP GLOBAL MASZZ");
                }
                else if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Sampeyan KURANG BELAJAR MSZZ");
                }
            }


            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("NIM");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Jurusan");
            dt.Rows.Add("070602231", "John Cena", "Jawa Tengah");
            dt.Rows.Add("070602232", "John Legend", "Jawa Utara");
            dt.Rows.Add("070602233", "Johnson", "Jawa Tenggara");
            dataGridView1.DataSource = dt;
            buttonUPDATE.Enabled = false;

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            
            dt.Rows.Add(textBoxNIM.Text,textBoxNama.Text,textBoxjurusan.Text);
            textBoxNIM.Clear();
            textBoxNama.Clear();
            textBoxjurusan.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            MessageBox.Show("Nama : " + dgrv.Cells[1].Value.ToString() + "NIM :" + dgrv.Cells[0].Value.ToString() + "Jurusan : " + dgrv.Cells[2].Value.ToString());
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(dgrv);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgrv = dataGridView1.CurrentRow;
            buttonUPDATE.Enabled = true;
            textBoxNIM.Text = dgrv.Cells[0].Value.ToString();
            textBoxNIM.Enabled = false;
            textBoxNama.Text = dgrv.Cells[1].Value.ToString();
            textBoxjurusan.Text = dgrv.Cells[2].Value.ToString();
            buttonsubmit.Enabled = false;






        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            string NIM = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int index = 0;
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                if (dt.Rows[i][0].ToString() == NIM) 
                { 
                    index = i; 
                }
            }
            dt.Rows[index][1] = textBoxNama.Text;
            dt.Rows[index][2] = textBoxjurusan.Text;
            textBoxNIM.Enabled = true;
            textBoxNama.Clear();
            textBoxjurusan.Clear();
            textBoxNIM.Clear();

            buttonsubmit.Enabled = true;
            buttonUPDATE.Enabled = false;
        }
    }
}
