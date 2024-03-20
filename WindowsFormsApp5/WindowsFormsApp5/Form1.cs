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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button buttonTest = new Button();
            buttonTest.Text = "YOWESS YOO";
            buttonTest.Location = new Point(250, 55);
            buttonTest.Size = new Size(100, 40);
            buttonTest.Name = "buttonSpecial";
            buttonTest.BackColor = Color.Beige;
            this.Controls.Add(buttonTest);
            
        }

        private void buttonTEST_Click(object sender, EventArgs e)
        {

            string cok = textBox1.Text;

            int jmlh = Convert.ToInt32(cok);
            int g = 100;
            int x = 0;
            
            for (int i = 0;i < jmlh; i++) 
            {
                
                x += 80;
                Button buttonBaru = new Button();
                buttonBaru.Text = "YOWESS YOO" + i;
                if (x == 80 * 6) 
                {
                    
                    g += 80;
                    x = 80;
                }
                if (i % 2 == 0) 
                { 
                    buttonBaru.BackColor = Color.Aqua;
                }
                else { buttonBaru.BackColor = Color.Beige; }
                buttonBaru.Location = new Point(x, g);
                buttonBaru.Size = new Size(100, 30);
                buttonBaru.Click += new EventHandler(buttonClicksEvent);
                if ((i-1) %2 == 0) 
                {
                    buttonBaru.Tag = "YOWW";
                }else 
                {
                    buttonBaru.Tag = "HAA";
                }
                this.Controls.Add(buttonBaru);
                
            }
        }

        public void buttonClicksEvent(object sender, EventArgs e) 
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text + " is " + btn.Tag);
        }
    }
}
