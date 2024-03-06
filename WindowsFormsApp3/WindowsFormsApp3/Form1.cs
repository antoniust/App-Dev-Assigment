using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        DataTable dtmakan = new DataTable();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxMAKANAN.Items.Add(textBoxMAKANAN.Text);
            textBoxMAKANAN.Clear();
            comboBox1.Items.Add(textBoxTMPTMKN.Text);
            textBoxTMPTMKN.Clear();

        }

        private void buttonCLEAR_Click(object sender, EventArgs e)
        {
            listBoxMAKANAN.Items.Clear();
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            listBoxMAKANAN.Items.Remove(listBoxMAKANAN.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtmakan.Columns.Add(" ID Makanan");
            dtmakan.Columns.Add(" Nama Makanan");
            dtmakan.Columns.Add(" Harga Makanan");

            dtmakan.Rows.Add("CRD001", "Pizza Kukus", "25000");
            dtmakan.Rows.Add("CRD002", "Ayam Goreng", "26000");
            dtmakan.Rows.Add("CRD003", "Babi Wuling", "2700000");
            dtmakan.Rows.Add("CRD004", "Tape Goreng", "28000");
            dtmakan.Rows.Add("CRD005", "Susu Goreng", "29000");

            listBoxMAKANAN.DataSource = dtmakan;
            listBoxMAKANAN.DisplayMember = " Nama Makanan";
            listBoxMAKANAN.ValueMember = " Harga Makanan";
        }

        private void buttonPILIH_Click(object sender, EventArgs e)
        {
            int indexMkananDipilih = listBoxMAKANAN.SelectedIndex;

            string harga = dtmakan.Rows[indexMkananDipilih][2].ToString();

            int heheh = Convert.ToInt32(dtmakan.Rows[indexMkananDipilih][2].ToString());
            string urutan1 = dtmakan.Rows[indexMkananDipilih][0].ToString();
            string urutan2 = dtmakan.Rows[indexMkananDipilih][1].ToString();
            string urutan3 = heheh.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"));
            string HrgaFinal = urutan1 + " - " + urutan2 + "  " + urutan3;
            MessageBox.Show(HrgaFinal);


            

            MessageBox.Show(dtmakan.Rows[indexMkananDipilih][0].ToString() + " - " + dtmakan.Rows[indexMkananDipilih][1].ToString() + " Rp. " + urutan3);

            MessageBox.Show(listBoxMAKANAN.SelectedValue.ToString());
        }
    }
}
