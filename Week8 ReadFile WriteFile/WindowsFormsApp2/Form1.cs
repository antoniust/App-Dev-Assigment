using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        int next = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAMBIL_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();

            //ofd.Filter = "aku tinta kamu dancok (*.txt)|*.txt|all files (*.*)|*.*|Image (*.jpeg)|*.jpeg";
            //ofd.InitialDirectory = "Y:\\";
            //ofd.ShowDialog();
            //MessageBox.Show(ofd.FileName);



            //StreamReader sr = new StreamReader("Y:\\CELEBEW.txt");
            //String BARIS = sr.ReadLine();
            //while (BARIS != null) 
            //{
            //    MessageBox.Show(BARIS);
            //    BARIS = sr.ReadLine();
            //}
            //sr.Close();
        }

        private void buttonTULIS_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter("Y:\\CELEBEW.txt");
            //sw.WriteLine("1hobby;2hobby;3hobby\r\n1Bhobby;2Bhobby;3Bhobby\r\n1Chobby;2Chobby;3Chobby\r\n anjayyyyy");
            //sw.Close();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "aku tinta kamu dancok (*.txt)|*.txt|all files (*.*)|*.*|Image (*.jpeg)|*.jpeg";
            ofd.InitialDirectory = "Y:\\";
            ofd.ShowDialog();
        }

        private void buttonLIHAT_Click(object sender, EventArgs e)
        {
            buttonSimpan.Visible = false;
            buttonLIHAT.Visible = false;
            buttonnext.Visible = true;
            buttonprev.Visible = true;
            buttonkEMBALI.Visible = true;

            textboxNAMA.Enabled = false;
            textBoxALAMAT.Enabled = false;
            textBoxNOTELP.Enabled = false;


            StreamReader sr = new StreamReader("Y:\\ANJAYGEMINK.txt");
            String BARIS = sr.ReadLine();
            while (BARIS != null)
            {
                
                list.Add(BARIS);
                BARIS = sr.ReadLine();
            }
            sr.Close();

            
            string[] stri = list[next].Split(';');
            

            for (int i = 0;i < stri.Length; i++) 
            { 

                if (i == 0) 
                { 
                    textboxNAMA.Text = stri[0];
                }
                else if (i == 1) 
                { 
                    textBoxALAMAT.Text = stri[1];
                }
                else if (i == 2) 
                { 
                    textBoxNOTELP.Text = stri[2];
                }
                
            }   


        }

        private void buttonkEMBALI_Click(object sender, EventArgs e)
        {
            buttonnext.Visible = false;
            buttonprev.Visible = false;
            buttonkEMBALI.Visible = false;
            buttonSimpan.Visible = true;
            buttonLIHAT.Visible = true;

            textboxNAMA.Enabled = true;
            textBoxALAMAT.Enabled = true;
            textBoxNOTELP.Enabled = true;

            textboxNAMA.Clear();
            textBoxALAMAT.Clear();
            textBoxNOTELP.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonnext.Visible=false;
            buttonprev.Visible=false;
            buttonkEMBALI.Visible=false;
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            if (next != list.Count - 1) 
            {
                next++;
                string[] stri = list[next].Split(';');



                for (int i = 0; i < stri.Length; i++)
                {

                    if (i == 0)
                    {
                        textboxNAMA.Text = stri[0];
                    }
                    else if (i == 1)
                    {
                        textBoxALAMAT.Text = stri[1];
                    }
                    else if (i == 2)
                    {
                        textBoxNOTELP.Text = stri[2];
                    }

                }
            }
            

        }

        private void buttonprev_Click(object sender, EventArgs e)
        {
            if (next != 0)
            {
                next--;
                string[] stri = list[next].Split(';');



                for (int i = 0; i < stri.Length; i++)
                {

                    if (i == 0)
                    {
                        textboxNAMA.Text = stri[0];
                    }
                    else if (i == 1)
                    {
                        textBoxALAMAT.Text = stri[1];
                    }
                    else if (i == 2)
                    {
                        textBoxNOTELP.Text = stri[2];
                    }

                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Y:\\ANJAYGEMINK.txt");

            for (int i = 0;i < list.Count;i++) 
            {
                sw.WriteLine(list[i]);
            }

            
            sw.WriteLine(textboxNAMA.Text+";"+textBoxALAMAT.Text+";"+textBoxNOTELP.Text);
            sw.Close();

            textboxNAMA.Clear();
            textBoxALAMAT.Clear();
            textBoxNOTELP.Clear();
        }
    }
}
