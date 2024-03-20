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
    //Giselle Neyva Siahaya - 006022310030
    public partial class Form_premier : Form
    {
        public Form_premier()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        DataTable dt;
        string id = "";

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("tim id");
            dt.Columns.Add("nama tim");
            dt.Columns.Add("nama stadium");
            dt.Columns.Add("kapasitas");
            dt.Columns.Add("kota");
            dt.Columns.Add("nama manager");
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_tim_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            bool benar = true;
            foreach (DataRow row in dt.Rows)
            {
                if (row[1].ToString() == tb_namat.Text || row[2].ToString() == tb_stadium.Text || row[5].ToString() == tb_manager.Text)
                {       
                    benar = false;
                }
            }
            if (benar == false)
            {
                MessageBox.Show("Error");
            }
            else
            {
                dt.Rows.Add(id, tb_namat.Text, tb_stadium.Text , tb_kapasitas.Text , tb_kota.Text , tb_manager.Text);
            }
            tb_namat.Clear();
            tb_stadium.Clear();
            tb_manager.Clear();
            tb_kapasitas.Clear();
            tb_kota.Clear();
            tb_tim.Clear();

        }

        private void tb_namat_TextChanged(object sender, EventArgs e)
        {
            if ( tb_namat.Text != "")
            {
               
                int angka = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    if (dt.Rows[i][0].ToString().Substring(0, 1) == tb_namat.Text.Substring(0, 1).ToUpper())
                    {
                        angka++;
                    }
                }
                if(angka < 10)
                {
                    id = tb_namat.Text.ToString().Substring(0, 1).ToUpper() + "0" + angka;
                    tb_tim.Text = id;
                }
                else
                {
                    id = tb_namat.Text.ToString().Substring(0, 1).ToUpper() + angka;
                    tb_tim.Text = id;
                }
             
                
            }
        }
    }
}
