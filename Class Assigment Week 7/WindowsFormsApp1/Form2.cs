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
    public partial class Form2AddTeam : Form
    {
        FormNBAMatch formNBAMatch;
        List<string> Team = new List<string>();
        public Form2AddTeam(FormNBAMatch _FormNBAMatch, List<string> Team)
         
        {
            InitializeComponent();
            formNBAMatch = (FormNBAMatch) _FormNBAMatch;
            this.Team = Team;
        }

        private void Form2AddTeam_Load(object sender, EventArgs e)
        {

        }

        public void AddTeam() 
        {
            
        }

        private void buttonNambahTeamm_Click(object sender, EventArgs e)
        {
            formNBAMatch.antod(textBoxNamaTeam.Text);
           
        }
    }
}
