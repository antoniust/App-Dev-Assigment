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
    public partial class Form1 : Form
    {
        List<Button> buttonList = new List<Button>();
        List<Label> labelListscore = new List<Label>();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUKURAN_TextChanged(object sender, EventArgs e)
        {





        }

        private void panelMAIN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int size = 0;
        private void buttonSTART_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBoxUKURAN.Text);
            Button[,] butnLoc = new Button[size, size];
            panelMAIN.Visible = true;
            if (size % 2 == 0)
            {
                MessageBox.Show("Input Ukuran harus Ganjil ");
            }
            else
            {
                panelMAIN.Visible = false;
            }




            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button buttonBaru = new Button();
                    //buttonBaru.Text = i.ToString() + "," + j.ToString();
                    //buttonBaru.Name = i.ToString() + "," + j.ToString();
                    buttonBaru.Size = new Size(40, 40);
                    buttonBaru.Location = new Point(j * 40, i * 40);
                    buttonBaru.Tag = "White";
                    this.Controls.Add(buttonBaru);
                    butnLoc[i, j] = buttonBaru;
                    buttonBaru.Click += new EventHandler(buttonClicksEvent);
                    buttonList.Add(buttonBaru);


                }
            }










        }

        public void buttonClicksEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point btnLocation = btn.Location;
            int posX = btn.Location.X;
            int posY = btn.Location.Y;
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Location.X == posX && buttonList[i].Location.Y == posY - 40 && buttonList[i].Tag != "White")
                {
                    if (buttonList[i].Tag == "red")
                    {
                        buttonList[i].BackColor = Color.Blue;
                        buttonList[i].Tag = "blue";
                    }
                    else if (buttonList[i].Tag == "blue")
                    {
                        buttonList[i].BackColor = Color.Red;
                        buttonList[i].Tag = "red";
                    }
                }
                    if (buttonList[i].Location.X == posX && buttonList[i].Location.Y == posY + 40 && buttonList[i].Tag != "White")
                    {
                        if (buttonList[i].Tag == "red")
                        {
                            buttonList[i].BackColor = Color.Blue;
                            buttonList[i].Tag = "blue";
                        }
                        else if (buttonList[i].Tag == "blue")
                        {
                            buttonList[i].BackColor = Color.Red;
                            buttonList[i].Tag = "red";
                        }
                    }
                    if (buttonList[i].Location.X == posX - 40 && buttonList[i].Location.Y == posY && buttonList[i].Tag != "White")
                    {
                        if (buttonList[i].Tag == "red")
                        {
                            buttonList[i].BackColor = Color.Blue;
                            buttonList[i].Tag = "blue";
                        }
                        else if (buttonList[i].Tag == "blue")
                        {
                            buttonList[i].BackColor = Color.Red;
                            buttonList[i].Tag = "red";
                        }
                    }
                    if (buttonList[i].Location.X == posX + 40 && buttonList[i].Location.Y == posY && buttonList[i].Tag != "White")
                    {
                        if (buttonList[i].Tag == "red")
                        {
                            buttonList[i].BackColor = Color.Blue;
                            buttonList[i].Tag = "blue";
                        }
                        else if (buttonList[i].Tag == "blue")
                        {
                            buttonList[i].BackColor = Color.Red;
                            buttonList[i].Tag = "red";
                        }
                    }
                    



                
                if (btn.Tag == "White")
                {
                    btn.BackColor = Color.Red;
                    btn.Tag = "red";

                }

                int scoreRED = 0;
                int scoreBlue = 0;

                foreach(Button button in buttonList) 
                { 
                    if (button.Tag == "red") {  scoreRED++; }
                    if (btn.Tag == "blue") { scoreBlue++; }
                }
                if (scoreRED == (size * size)) 
                {
                    MessageBox.Show("You Win");
                }
                if (scoreBlue == (size * size))
                {
                    MessageBox.Show("You Win");
                }
                


            }
        }
    }
}
