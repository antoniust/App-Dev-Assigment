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
    public partial class Form2 : Form
    {

        //Form1 formSATU = new Form1 ();
        Form1 form1 ;
        //Form2 form2 = new Form2();
        public List<string> listUsername = new List<string>();
        public List<string> listPW = new List<string>();

        public Form2(Form1 _form)
        {
            form1 = _form;
            listUsername = form1.listUsername;
            listPW = form1.listPW;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonREGISTER_Click(object sender, EventArgs e)
        {
            
           

            if (textBoxPWREGIS.Text == textBoxrepeatPW.Text) 
            {

                bool coy = false;

                for (int i = 0; i < listUsername.Count; i++)
                {
                    if (textBoxUSERREGIS.Text == listUsername[i])
                    {
                        coy = true;
                        break;
                    }
                }
                if (coy == true)
                {
                    MessageBox.Show("User Already Exist");
                    textBoxUSERREGIS.Text = "";
                }
                else
                {
                    MessageBox.Show("uSER added");
                    listUsername.Add(textBoxUSERREGIS.Text);
                    listPW.Add(textBoxPWREGIS.Text);
                    coy = false;
                    this.Hide();
                }
            }
            else if (textBoxPWREGIS.Text != textBoxrepeatPW.Text)
            {
                MessageBox.Show("Password yang anda masukan tidak sama");
            }
        }
    }
}
