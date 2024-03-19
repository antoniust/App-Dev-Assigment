using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPremierLeague : Form
    {
        //Antonius Trimaryono /048
        DataTable dtLeague = new DataTable();
        List<string> listID = new List<string>();

        public FormPremierLeague()
        {
            InitializeComponent();

            dtLeague.Columns.Add("ID Tim");
            dtLeague.Columns.Add("Nama Tim");
            dtLeague.Columns.Add("Nama Stadium");
            dtLeague.Columns.Add("Kapasitas");
            dtLeague.Columns.Add("Kota");
            dtLeague.Columns.Add("Nama Manager");



            
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTimID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxTimName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTimName.Text != "")
            {
                string timID = textBoxTimName.Text.ToString();
                string FirstID = timID.Substring(0, 1).ToUpper();
                int NumID = 00;
                string FinalID = FirstID + NumID.ToString();
                int tes = 0;
                int d = 0;


                listID.Add(FirstID.ToUpper());

                for (int i = 0; i < dtLeague.Rows.Count; i++)
                {
                    if (dtLeague.Rows[i][1] == FirstID)
                    {
                        tes++;
                    }

                }
                d++;
                if (d == 1)
                {
                    if (tes + 1 < 10)
                    {
                        textBoxTimID.Text = FirstID + "0" + (tes + 1);
                    }
                    else
                    {
                        textBoxTimID.Text = FirstID + (tes + 1);
                    }
                    d = 0;

                }
                tes = 0;
               
                
            }
            
            
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in dtLeague.Rows)
            {
                if (row[1].ToString() == textBoxTimName.Text || row[2].ToString() == textBoxStadium.Text || row[5].ToString() == textBoxManager.Text)
                {
                    MessageBox.Show("EroR Masszeh");
                }
               
            }
            dtLeague.Rows.Add(textBoxTimID.Text, textBoxTimName.Text, textBoxStadium.Text, textBoxKapasitas.Text, textBoxKota.Text, textBoxManager.Text);
            dataGridViewLeage.DataSource = dtLeague;

            textBoxTimID.Clear();
            textBoxTimName.Clear();
            textBoxStadium.Clear();
            textBoxKapasitas.Clear();
            textBoxKota.Clear();
            textBoxManager.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
