using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        DataTable dtBarangSimpan = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtBarangTampil = new DataTable();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Bisque;


            dtBarangSimpan.Columns.Add("ID Produk");
            dtBarangSimpan.Columns.Add("Nama Produk");
            dtBarangSimpan.Columns.Add("Harga");
            dtBarangSimpan.Columns.Add("Stock");
            dtBarangSimpan.Columns.Add("ID Category");

            dtBarangTampil.Columns.Add("ID Produk");
            dtBarangTampil.Columns.Add("Nama Produk");
            dtBarangTampil.Columns.Add("Harga");
            dtBarangTampil.Columns.Add("Stock");
            dtBarangTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            dtBarangSimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtBarangSimpan.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtBarangSimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtBarangSimpan.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            dtBarangSimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtBarangSimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtBarangSimpan.Rows.Add("C001", "Cawat Blink-Blink", "1000000", "1", "C5");
            dtBarangSimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");

            dtBarangTampil.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtBarangTampil.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtBarangTampil.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtBarangTampil.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            dtBarangTampil.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtBarangTampil.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtBarangTampil.Rows.Add("C001", "Cawat Blink-Blink", "1000000", "1", "C5");
            dtBarangTampil.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            dataGridViewPRODUK.DataSource = dtBarangSimpan;
            dataGridViewPRODUK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCATEGORY.DataSource = dtCategory;
            dataGridViewCATEGORY.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFILTER_Click(object sender, EventArgs e)
        {
            comBoxFilterCat.Enabled = true;
        }

        private void btnRemoveCATEGORY_Click(object sender, EventArgs e)
        {
            string a = dataGridViewCATEGORY.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (a == dtCategory.Rows[i][0].ToString())
                {
                    dtCategory.Rows.RemoveAt(i); break;
                }
            }
            for (int i = dtBarangSimpan.Rows.Count - 1; i >= 0; i--)
            {
                if (dtBarangSimpan.Rows[i][4] == a)
                {
                    dtBarangSimpan.Rows.RemoveAt(i);
                }
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCATEGORY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void textBoxNamaCATEGORY_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCATEGORY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNamaCATEGORY.Text = dataGridViewCATEGORY.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnAddCATEGORY_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dtCategory.Rows.Count; i++) 
            {
                if (textBoxNamaCATEGORY.Text == dtCategory.Rows[i][1])
                {
                    MessageBox.Show("Error Nama Category sudah ada");
                }
               

            }
            


            for (int i = dtCategory.Rows.Count; i < dtCategory.Rows.Count + 1; i++)
            {
                string ID = "C" + (i + 1).ToString();
                dtCategory.Rows.Add(ID, textBoxNamaCATEGORY.Text);

            }


        }

        private void comBoxFilterCat_SelectedIndexChanged(object sender, EventArgs e)
        {
           for (int i = 0; i< comBoxFilterCat.Items.Count; i++) 
           { 
                
                if (comBoxFilterCat.SelectedItem != dtCategory.Rows[i][1]) 
                { 
                   dtBarangSimpan.Rows.RemoveAt(i);
                }

           }



        }

        private void comBoxFilterCat_Click(object sender, EventArgs e)
        {

            comBoxFilterCat.DataSource = dtCategory;
            comBoxFilterCat.DisplayMember = "Nama Category";
            comBoxFilterCat.ValueMember = "ID Category";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewPRODUK.DataSource = dtBarangSimpan;
        }

        private void dataGridViewPRODUK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNamaPRODUK.Text = dataGridViewPRODUK.CurrentRow.Cells[1].Value.ToString();
            textBoxStockPRODUK.Text = dataGridViewPRODUK.CurrentRow.Cells[3].Value.ToString();
            textBoxHargaProduk.Text = dataGridViewPRODUK.CurrentRow.Cells[2].Value.ToString();
            comboBoxCategoryPRODUK.Text = dataGridViewPRODUK.CurrentRow.Cells[4].Value.ToString() ;
           
        }

        private void dataGridViewPRODUK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddPRODUK_Click(object sender, EventArgs e)
        {
            if (textBoxNamaPRODUK.Text != "" || textBoxStockPRODUK.Text != "" || textBoxHargaProduk.Text != "")
            {
                string ProdukID = textBoxNamaPRODUK.Text.ToString();
                string FirstID = ProdukID.Substring(0, 1).ToUpper();
                int NumID = 00;
                string FinalID = FirstID + NumID.ToString();
                int tes = 0;
                int d = 0;

                for (int i = 0; i < dtBarangSimpan.Rows.Count; i++)
                {
                    if (dtBarangSimpan.Rows[i][1] == FirstID)
                    {
                        tes++;
                    }
                    d++;
                    if (d == 1)
                    {
                        if (tes + 1 < 10)
                        {
                            string IDProduk = FirstID + "0" + (tes + 1);
                            dtBarangSimpan.Rows.Add(IDProduk, textBoxNamaPRODUK.Text ,comboBoxCategoryPRODUK.SelectedValue,textBoxHargaProduk.Text, textBoxStockPRODUK.Text);
                            if (textBoxNamaPRODUK.Text.Contains(dtBarangSimpan.Rows[1].ToString())) 
                            {
                                MessageBox.Show("Wakwak");
                            }
                        }
                        else
                        {
                            string IDProduk = FirstID + (tes + 1);
                            dtBarangSimpan.Rows.Add(IDProduk, textBoxNamaPRODUK.Text, comboBoxCategoryPRODUK.SelectedValue, textBoxHargaProduk.Text, textBoxStockPRODUK.Text);
                            
                        }
                        d = 0;
                    }
                    tes = 0;

                    //dtBarangSimpan.Rows.Add();
                }
            }
            else { MessageBox.Show("Error, Seluruh Kolom Harus Terisi"); }
        }

        private void comboBoxCategoryPRODUK_Click(object sender, EventArgs e)
        {
            comboBoxCategoryPRODUK.DataSource = dtCategory;
            comboBoxCategoryPRODUK.DisplayMember = "Nama Category";
            comboBoxCategoryPRODUK.ValueMember = "ID Category";
        }

        private void textBoxHargaProduk_TextChanged(object sender, EventArgs e)
        {
            textBoxHargaProduk.KeyPress += new KeyPressEventHandler(txtNumber_KeyPress);
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                textBoxHargaProduk.Text = "";
                e.Handled = true;
               
            }
        }

        private void textBoxStockPRODUK_TextChanged(object sender, EventArgs e)
        {
            textBoxStockPRODUK.KeyPress += new KeyPressEventHandler(txtNumber_KeyPress);
        }

        private void comboBoxCategoryPRODUK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditPRODUK_Click(object sender, EventArgs e)
        {
            dataGridViewPRODUK.CurrentRow.Cells[1].Value = textBoxNamaPRODUK.Text;
            dataGridViewPRODUK.CurrentRow.Cells[2].Value = textBoxHargaProduk.Text;
            dataGridViewPRODUK.CurrentRow.Cells[3].Value = textBoxStockPRODUK.Text;
            dataGridViewPRODUK.CurrentRow.Cells[4].Value = comboBoxCategoryPRODUK.SelectedValue.ToString();
        }

        private void comBoxFilterCat_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}


