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
        string[] datalogo = { "akherad", "bebekcarok", "BR", "orange", "Umimi", "AyamGeprek", "babe", "Pepsi", "dominos", "krispykreme" };
        string[] daftarmenu = { "cendol", "BabiGuling", "PuddingLele", "Pecel", "karedok", "RujakCingur", "LotnogBalap", "TahuTek", "EsJeruk", "penyetanlele" };
        int a = 0;
        int X = 0;
        int c = 0;
        string b = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string bapak = "Logo";
        int log = 0;
        int mak = 0;
        private void buttonTampil_Click(object sender, EventArgs e)
        {


            if (bapak == "Logo")
            {
                if (log < 9)
                {
                    log++;

                }
                string c = datalogo[log];
                pBoxLogo.Image = new Bitmap("Y:\\Logo\\" + c + ".jpg");
               
            }
            if (bapak == "Foto")
            {
                if (mak < 9)
                {
                    mak++;

                }
                string b = daftarmenu[mak];
                pBoxLogo.Image = new Bitmap("Y:\\Foto\\" + b + ".jpg");

            }



        }

        private void buttonPREV_Click(object sender, EventArgs e)
        {
            if (bapak == "Logo")
            {
                if (log > 0)
                {
                    log--;

                }
                string c = datalogo[log];
                pBoxLogo.Image = new Bitmap("Y:\\Logo\\" + c + ".jpg");

            }
            if (bapak == "Foto")
            {
                if (mak > 0)
                {
                    mak--;

                }
                string b = daftarmenu[mak];
                pBoxLogo.Image = new Bitmap("Y:\\Foto\\" + b + ".jpg");

            }



        }

        private void buttonchange_Click(object sender, EventArgs e)
        {
            if (bapak == "Foto")
            {
                bapak = "Logo";
                string c = datalogo[log];
                pBoxLogo.Image = new Bitmap("Y:\\Logo\\" + c + ".jpg");
            }
            else if (bapak == "Logo")
            {
                bapak = "Foto";
                string b = daftarmenu[mak];
                pBoxLogo.Image = new Bitmap("Y:\\Foto\\" + b + ".jpg");
            }
        }
    }
}
