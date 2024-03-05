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
    public partial class FormKata : Form
    {
        private string[] huruf = new string[5];
        private string clickedAlphabet = "";

        private int WinParameter = 0;
        public FormKata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            qo formBaru = new qo();
            int check = 0;
            string[] input = new string[5];

            string word1 = tbox1.Text;
            input[0] = word1;
            string word2 = tbox2.Text;
            input[1] = word2;
            string word3 = tbox3.Text;
            input[2] = word3;
            string word4 = tbox14.Text;
            input[3] = word4;
            string word5 = tbox5.Text;
            input[4] = word5;
            if (tbox1.Text.Length > 5 || tbox1.Text.Length < 5)
            {
                check++;
            }
            else if (tbox2.Text.Length > 5 || tbox2.Text.Length < 5)
            {
                check++;
            }
            else if (tbox3.Text.Length > 5 || tbox3.Text.Length < 5)
            {
                check++;
            }
            else if (tbox14.Text.Length > 5 || tbox14.Text.Length < 5)
            {
                check++;
            }
            else if (tbox5.Text.Length > 5 || tbox5.Text.Length < 5)
            {
                check++;
            }

            if (check > 0)
            {
                MessageBox.Show("Iseh enek sing error maszeh");
            }
            else

            {


                MessageBox.Show("Ayo Dulinan");

                panelMAIN.Visible = true;
                Random random = new Random();
                int rnd = random.Next(1, 5);
                labelHasilKata.Text = input[rnd].ToUpper();


                string word = labelHasilKata.Text;





                int i = 0;
                foreach (char hrf in labelHasilKata.Text)
                {
                    string hrf_hrf = hrf.ToString();
                    huruf[i] = hrf_hrf;
                    i++;
                }


            }
        }
        private void labeljwbn1_Click(object sender, EventArgs e)
        {

        }

        private void labeljwbn2_Click(object sender, EventArgs e)
        {

        }

        private void labeljwbn3_Click(object sender, EventArgs e)
        {

        }

        private void labelHasilKata_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "A";
            updatelabel();

        }

        private void panelMAIN_Paint(object sender, PaintEventArgs e)
        {



        }

        private void updatelabel()
        {
            if (clickedAlphabet == huruf[0])
            {
                labeljwbn1.Text = clickedAlphabet;
                WinParameter++;
            }
            if (clickedAlphabet == huruf[1])
            {
                labeljwbn2.Text = clickedAlphabet;
                WinParameter++;
            }
            if (clickedAlphabet == huruf[2])
            {
                labeljwbn3.Text = clickedAlphabet;
                WinParameter++;
            }
            if (clickedAlphabet == huruf[3])
            {
               labeljwbn4.Text =clickedAlphabet;
               WinParameter++;
            }
            if (clickedAlphabet == huruf[4])
            {
                labeljwbn5.Text = clickedAlphabet;
                WinParameter++;
            }
            if (WinParameter == 5)
            {
                MessageBox.Show("SAMPEYAN TOP GLOBAL MASS");
            }

           
        }
        private void buttonQ_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "Q";
            updatelabel();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "W";
            updatelabel();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "E";
            updatelabel();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "R";
            updatelabel();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "T";
            updatelabel();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "Y";
            updatelabel();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "U";
            updatelabel();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "I";
            updatelabel();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "O";
            updatelabel();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "P";
            updatelabel();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "S";
            updatelabel();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "D";
            updatelabel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "F";
            updatelabel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "G";
            updatelabel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "H";
            updatelabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "J";
            updatelabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "K";
            updatelabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "L";
            updatelabel();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clickedAlphabet = "Z";
            updatelabel();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "X";
            updatelabel();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "C";
            updatelabel();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "V";
            updatelabel();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "B";
            updatelabel();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "N";
            updatelabel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickedAlphabet = "M";
            updatelabel();
        }

        private void FormKata_Load(object sender, EventArgs e)
        {

        }
    }
}

