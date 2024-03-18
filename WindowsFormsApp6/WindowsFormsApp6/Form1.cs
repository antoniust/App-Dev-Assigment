using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        DataTable dtsoccer = new DataTable();
       DataTable dtRegion = new DataTable();



        private Dictionary<string, List<string>> _countriesAndClubs = new Dictionary<string, List<string>>()
        {
            { "England", new List<string>() { "Manchester United", "Liverpool", "Chelsea", "Arsenal" } },
            { "Spain", new List<string>() { "Real Madrid", "Barcelona", "Atletico Madrid", "Sevilla" } },
            { "Germany", new List<string>() { "Bayern Munich", "Borussia Dortmund", "RB Leipzig", "Bayer Leverkusen" } },
            { "Italy", new List<string>() { "Juventus", "Inter Milan", "AC Milan", "Napoli" } }
        };



        List<string> Country = new List<string>() { "England", "Germany" , "Spain" , "Italy" };
        List<string> England = new List<string>() { "Chelsea", "Manchester United", };
        List<string> Germany = new List<string>() { "Bayern Munich", "Borussia Dortmund" };
        List<string> Spain = new List<string>() { "Barcelona" };
        List<string> Italy = new List<string>() { "Inter Milan" };

        List<string> Position = new List<string>() { "GK","DF", "FW", "MF"};

        public Form1()
        {
            InitializeComponent();

            comboBoxCountry.DataSource = Country;
            CmboBoxPlayerPosition.DataSource = Position;

            dtRegion.Columns.Add("England");
            dtRegion.Columns.Add("Germany");

            dtRegion.Rows.Add("Chelsea", "Bayern Munich");
            dtRegion.Rows.Add("Manchester United" , "");
           

            //dtChelsea.Columns.Add("Profil");
            dtsoccer.Columns.Add("Country");
            dtsoccer.Columns.Add("Tim");
            dtsoccer.Columns.Add("No");
            dtsoccer.Columns.Add("Name");
            dtsoccer.Columns.Add("Pos");
            dtsoccer.Rows.Add("England", "Chelsea" ,"01"," Robert Sánchez." ,"GK");
            dtsoccer.Rows.Add("England","Chelsea" ,"02", "Axel Disasi.", "DF");
            dtsoccer.Rows.Add("England", "Chelsea" ,"03", "Marc Cucurella.", "DF");
            dtsoccer.Rows.Add("England", "Chelsea" ,"05", "Benoît Badiashile.", "DF");
            dtsoccer.Rows.Add("England", "Chelsea" , "07", "Raheem Sterling.", "FW");
            dtsoccer.Rows.Add("England", "Chelsea" ,"13", "Marcus Bettinelli.", "GK");
            dtsoccer.Rows.Add("England", "Chelsea" ,"20", " Cole Palmer.", "MF");
            dtsoccer.Rows.Add("England", "Chelsea" ,"08", "Enzo Fernández.", "MF");
            dtsoccer.Rows.Add("England", "Chelsea" ,"18", "Christopher Nkunku.", "FW");
            dtsoccer.Rows.Add("England", "Chelsea" ,"43", "Diego Moreira.", "FW");
            dtsoccer.Rows.Add("England", "Chelsea" ,"28", "Đorđe Petrović.", "GK");

            dtsoccer.Rows.Add("England", "Manchester United", "17", "Alejandro Garnacho.", "FW");
            dtsoccer.Rows.Add("England", "Manchester United", "01", "Altay Bayındır.", "GK");
            dtsoccer.Rows.Add("England", "Manchester United", "02", "Victor Lindelöf.", "DF");
            dtsoccer.Rows.Add("England", "Manchester United", "04", "Sofyan Amrabat.", "MF");
            dtsoccer.Rows.Add("England", "Manchester United", "05", "Harry Maguire.", "DF");
            dtsoccer.Rows.Add("England", "Manchester United", "08", "Bruno Fernandes.", "MF");
            dtsoccer.Rows.Add("England", "Manchester United", "09", "Anthony Martial.", "FW");
            dtsoccer.Rows.Add("England", "Manchester United", "23", "Luke Shaw", "DK");
            dtsoccer.Rows.Add("England", "Manchester United", "24", "André Onana", "GK");
            dtsoccer.Rows.Add("England", "Manchester United", "14", "Christian Eriksen", "MF");
            dtsoccer.Rows.Add("England", "Manchester United", "47", "Shola Shoretire", "MF");


            dtsoccer.Rows.Add("Germany", "Bayern Munich", "09", "Harry Kane", "FW");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "04", "Matthijs de Ligt", "DF");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "22", "Raphaël Guerreiro", "DF");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "07", "Serge Gnabry", "FW");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "18", "Daniel Peretz", "GK");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "42", "Jamal Musiala", "MF");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "03", "Kim Min-jae", "DF");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "01", "Manuel Neuer", "GK");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "27", "Konrad Laimer", "MF");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "28", "Tarek Buchmann", "DF");
            dtsoccer.Rows.Add("Germany", "Bayern Munich", "13", "Eric M. Choupo-Moting", "FW");

            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "01", "Gregor Kobel.", "GK");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "17", "Marius Wolf.", "MF");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "08", "Felix Nmecha.", "MF");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "26", "Julian Ryerson.", "DF");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "33", "Alexander Meyer.", "GK");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "02", "Mateu Morey.", "DF");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "19", "Julian Brandt.", "MF");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "14", "Niclas Füllkrug.", "FW");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "43", "Jamie Bynoe-Gittens.", "FW");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "21", "Donyell Malen.", "FW");
            dtsoccer.Rows.Add("Germany", "Borussia Dortmund", "15", "Mats Hummels", "DF");

            dtsoccer.Rows.Add("Italy", "Inter Milan", "02", "Denzel Dumfries.", "MF");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "07", "Juan Cuadrado.", "MF");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "31", "Yann Bisseck.", "DF");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "70", "Alexis Sánchez.", "FW");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "14", "Davy Klaassen.", "MF");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "01", "Yann Sommer.", "GK");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "15", "Francesco Acerbi.", "DF");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "32", "Federico Dimarco.", "DF");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "10", "Lautaro Martínez.", "FW");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "09", "Marcus Thuram.", "FW");
            dtsoccer.Rows.Add("Italy", "Inter Milan", "77", "Emil Audero.", "GK");

            dtsoccer.Rows.Add("Spain", "Barcelona", "04", "Ronald Araújo.", "DF");
            dtsoccer.Rows.Add("Spain", "Barcelona", "08", "Pedri.", "MF");
            dtsoccer.Rows.Add("Spain", "Barcelona", "15", "Andreas Christensen.", "DF");
            dtsoccer.Rows.Add("Spain", "Barcelona", "01", "Marc André ter Stegen.", "GK");
            dtsoccer.Rows.Add("Spain", "Barcelona", "16", "Fermín López.", "MF");
            dtsoccer.Rows.Add("Spain", "Barcelona", "19", "Vitor Roque.", "FW");
            dtsoccer.Rows.Add("Spain", "Barcelona", "06", "Gavi.", "MF");
            dtsoccer.Rows.Add("Spain", "Barcelona", "02", "João Cancelo.", "DF");
            dtsoccer.Rows.Add("Spain", "Barcelona", "09", "Robert Lewandowski.", "FW");
            dtsoccer.Rows.Add("Spain", "Barcelona", "13", "Iñaki Peña.", "GK");
            dtsoccer.Rows.Add("Spain", "Barcelona", "18", "Oriol Romeu.", "MF");
            //dtsoccer.Rows.Add("Spain", "Barcelona", "", "", "");










        }

        private void labelChooseTeam_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.SelectedItem == "England")
            {


                comboBoxTeam.DataSource = England;

            }
            else if (comboBoxCountry.SelectedItem == "Germany")
            {

                comboBoxTeam.DataSource = Germany;

            }
            else if (comboBoxCountry.SelectedItem == "Spain")
            {
                comboBoxTeam.DataSource = Spain;
            }
            else if (comboBoxCountry.SelectedItem == "Italy")
            {
                comboBoxTeam.DataSource = Italy;


            }
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBoxTeamPlayer.Items.Clear();
                for (int i = 0;i < dtsoccer.Rows.Count; i++) 
                {
                    if (dtsoccer.Rows[i][1] == comboBoxTeam.SelectedItem) 
                    {
                    listBoxTeamPlayer.Items.Add("(" + dtsoccer.Rows[i][2] + ")" + " " + dtsoccer.Rows[i][3].ToString() + " " +dtsoccer.Rows[i][4].ToString());
                    }
                    
                }


            
        }

        

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            Country.Add(tboxTeamCountry.Text);

           
        }

        private void ButtRmove_Click(object sender, EventArgs e)
        {
            if (listBoxTeamPlayer.Items.Count > 11) 
            { 
                listBoxTeamPlayer.Items.Remove(listBoxTeamPlayer.SelectedItem); 
            }else { MessageBox.Show("Anda bisa mengurangi pemain apabila pemain lebih dari 11 Pemain."); }
           
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            listBoxTeamPlayer.Items.Add("(" + tboxPlayerNum.Text + ")" +" "+ tboxPlayerName.Text+"." + CmboBoxPlayerPosition.SelectedItem);
            //dtsoccer.Rows.Add("","",tboxPlayerNum.Text,tboxPlayerName.Text,CmboBoxPlayerPosition.SelectedItem);
        }

        private void CmboBoxPlayerPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
