using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        DataTable dtlogin = new DataTable();
        int BALANCE = 0;
        DataTable passw = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private bool cekValue(DataTable dtlogin, string columnName, object value)
        {
            var result = dtlogin.AsEnumerable().Any(row => row.Field<object>(columnName).Equals(value));
            return result;
        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            if (textBoxPW.Text == "")
            {
                MessageBox.Show("Password harus di isi");
            }
            else if (cekValue(dtlogin, "Username", textBoxUsername.Text))
            {

                panelAccountUTAMA.Visible = true;
               
            }
            else
            {
                MessageBox.Show("Username belum terdaftar");
            }

            
        }

        private void buttonREGISTER_Click(object sender, EventArgs e)
        {
            panelREGISTER.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            panelAccountUTAMA.Visible = false;
            panelREGISTER.Visible = false;

            dtlogin.Columns.Add("Username");
            passw.Columns.Add("password");
        }

        private void buttPanelRegis_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameRegis.Text == "") 
            {
                MessageBox.Show("Anda belum memasukan Username");
            }
            else if (cekValue(dtlogin, "Username", textBoxUsernameRegis.Text))
            {
                MessageBox.Show("Username telah digunakan");
            }
            else if (textBoxPWRegis.Text == "") 
            {
                MessageBox.Show("Anda belum memasukan Password");
            }
            else 
            {
                passw.Rows.Add(textBoxPWRegis.Text);
                dtlogin.Rows.Add(textBoxUsernameRegis.Text);
                MessageBox.Show("Registrasi Rampung ");
                panelREGISTER.Visible = false;
            }
            
        }

        private void buttonDEPOSITAccount_Click(object sender, EventArgs e)
        {
            panelDEPOSIT.Visible = true;

        }

        private void buttonWITHDRAWAccount_Click(object sender, EventArgs e)
        {
            panelWITHDRAW.Visible = true;
        }

        private void buttLOGOUTAccount_Click(object sender, EventArgs e)
        {
            panelAccountUTAMA.Visible =false;
        }

        private void buttonApplyDEPOSIT_Click(object sender, EventArgs e)
        {
            int JMLHDEPOSIT = Convert.ToInt32(textBoxInputDEPOSIT.Text);
            if (JMLHDEPOSIT <= 0)
            {
                MessageBox.Show("Ammount of deposit can't be less than 1");
            }
            else if (JMLHDEPOSIT > 0)
            {
                MessageBox.Show("Deposit Berhasil ditambahkan");
                BALANCE += JMLHDEPOSIT;
                panelDEPOSITView.Visible = false;
            }
        }

        private void panelAccountUTAMA_Paint(object sender, PaintEventArgs e)
        {
            panelDEPOSIT.Visible = false;
            panelWITHDRAW.Visible = false;
        }

        private void buttApplyDEPOSIT_Click(object sender, EventArgs e)
        {

            int JMLHDEPOSIT = int.Parse(textBoxInputDEPOSIT.Text);
            if (JMLHDEPOSIT <= 0)
            {
                MessageBox.Show("Ammount of deposit can't be less than 1");
            }
            else if (JMLHDEPOSIT > 0)
            {
                MessageBox.Show("Deposit Berhasil ditambahkan");
                BALANCE += JMLHDEPOSIT;
                panelDEPOSIT.Visible = false;
            }
        }

        private void textBoxDEPOSIT_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void buttonLogOutWITHDRAW_Click(object sender, EventArgs e)
        {
            panelWITHDRAW.Visible = false;
            panelAccountUTAMA.Visible = false;
        }

        private void buttonLogOutDEPOSIT_Click(object sender, EventArgs e)
        {
            panelDEPOSIT.Visible = false;
            panelAccountUTAMA.Visible = false;
        }

        private void buttApplyWITHDRAW_Click(object sender, EventArgs e)
        {

        }

        private void labelAmmountWITHDRAW_Click(object sender, EventArgs e)
        {
            labelAmmountWITHDRAW.Text = BALANCE.ToString();
        }

        private void labelBalanceNUM_Click(object sender, EventArgs e)
        {
            labelBalanceNUM.Text = BALANCE.ToString();
        }
    }
}
