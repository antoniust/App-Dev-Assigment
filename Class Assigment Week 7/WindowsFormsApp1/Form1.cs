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
    public partial class FormNBAMatch : Form
    {
        DataTable dtNBA = new DataTable();
        List<string> Team = new List<string>();
        //List<string> Away = new List<string>();
        Form2AddTeam Form2AddTeam;


        public FormNBAMatch()
        {
            InitializeComponent();
        }

        private void buttonADDMatch_Click(object sender, EventArgs e)
        {


            dtNBA.Rows.Add(dtpNBAMatch.Value.ToString(), comboBoxHome.SelectedItem.ToString(), textBoxHome.Text, textBoxAWAY.Text, comboBoxAWAY.SelectedItem.ToString());
        }

        private void dataGridViewNBAMatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FormNBAMatch_Load(object sender, EventArgs e)
        {

            

            dtNBA.Columns.Add("Date");
            dtNBA.Columns.Add("Home Team Name");
            dtNBA.Columns.Add("Home Score");
            dtNBA.Columns.Add("Away Score");
            dtNBA.Columns.Add("Away Team Name");



            Team.Add("Boston Celtic");
            Team.Add("Persebaya");
            Team.Add("Cukurukuk");


            

            dataGridViewNBAMatch.DataSource = dtNBA;

            for (int i = 0; i < Team.Count; i++) 
            {
                comboBoxAWAY.Items.Add(Team[i].ToString());
                comboBoxHome.Items.Add(Team[i].ToString());
            }

               
            







        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            Form2AddTeam = new Form2AddTeam(this, Team);
            Form2AddTeam.Show();
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow teamrow in dataGridViewNBAMatch.SelectedRows) 
            {
                dataGridViewNBAMatch.Rows.RemoveAt(teamrow.Index);
            }
        }

        public void setAddTeamAway(string team) 
        {
            Team.Add(team);
            
        }

        private void txtNumber_KeyPressHOME(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                textBoxHome.Text = "";
                e.Handled = true;

            }
        }
        private void txtNumber_KeyPressAWAY(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                textBoxAWAY.Text = "";
                e.Handled = true;

            }
        }

        private void comboBoxHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBoxHome.Items.Count;i++) 
            { 
                if (comboBoxHome.Items[i].ToString() == comboBoxAWAY.Text) 
                { 
                    comboBoxHome.Items.RemoveAt(i);
                }
            }
        }

        private void comboBoxAWAY_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBoxAWAY.Items.Count; i++)
            {
                if (comboBoxAWAY.Items[i].ToString() == comboBoxHome.Text)
                {
                    comboBoxAWAY.Items.RemoveAt(i);
                }
            }
        }

        private void textBoxHome_TextChanged(object sender, EventArgs e)
        {
            textBoxHome.KeyPress += new KeyPressEventHandler(txtNumber_KeyPressHOME);
        }

        private void textBoxAWAY_TextChanged(object sender, EventArgs e)
        {
            textBoxAWAY.KeyPress += new KeyPressEventHandler(txtNumber_KeyPressAWAY);
        }
        public void antod(string tod) 
        { 
            Team.Add(tod);
            Form2AddTeam.Close();
            comboBoxAWAY.Items.Clear();
            comboBoxHome.Items.Clear();

            for (int i = 0; i < Team.Count; i++)
            {
                comboBoxAWAY.Items.Add(Team[i].ToString());
                comboBoxHome.Items.Add(Team[i].ToString());
            }

        }
    }
}
