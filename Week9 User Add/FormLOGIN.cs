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
    public partial class FormLOGIN : Form
    {
        //Form1 formSATU = new Form1();
        Form1 form1;
        //FormLOGIN formLOGIN = new FormLOGIN();  

        public List<string> listUsername = new List<string>();
        public List<string> listPW = new List<string>();



        public FormLOGIN(Form1 _form)
        {
            form1 = _form;
            listUsername = form1.listUsername;
            listPW = form1.listPW;
            InitializeComponent();
        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            
            int x = 0;
            for (int i = 0; i < listUsername.Count; i++)
            {
                if (textBoxUSERNAMELOGIN.Text == form1.listUsername[i].ToString())
                {
                    x++;
                }

            }
            for (int i = 0; i < form1.listPW.Count; i++)
            {
                if (textBoxPWLOGIN.Text == form1.listPW[i])
                {
                    x++;
                }
            }
            if (x > 1)
            {

                this.Hide();
                form1.Show();
            }
        }
        public void close()
        {
            form1.Hide();
        }
        private void checkusername()
        {

        }

        private void textBoxPWLOGIN_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
