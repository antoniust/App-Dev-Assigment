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
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToDouble(textBox_angka1.Text);

            double angka2 = Convert.ToDouble(textBox_angka2.Text);

            if (angka1 > angka2) 
            {
                MessageBox.Show("Input 1 harus lebih kecil dari input 2");
            } 
            else if (radbut1.Checked == false && radbut2.Checked == false && radbut3.Checked == false && radbut4.Checked == false ) 
            {
                MessageBox.Show("Sampeyan Dereng Milih Mode");
            }
            else 
            {
                if (radbut1.Checked == true)
                {
                    double jumlah = angka1 + angka2;
                    labelangka.Text = Convert.ToString(jumlah);
                }
                else if (radbut2.Checked == true)
                {
                    double kurang = angka1 - angka2;
                    labelangka.Text = Convert.ToString(kurang);
                }
                else if (radbut3.Checked == true)
                {
                    double kali = angka1 * angka2;
                    labelangka.Text = Convert.ToString(kali);
                }
                else if (radbut4.Checked == true)

                {
                    double bagi = angka1 / angka2;
                    labelangka.Text = Convert.ToString(bagi);
                }
            }
                      
        }

        private void labelangka1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_angka1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelHasil_Click(object sender, EventArgs e)
        {

        }

        private void labelangka_Click(object sender, EventArgs e)
        {

        }
    }
}
