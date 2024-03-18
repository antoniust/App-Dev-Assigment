namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxTeamPlayer = new System.Windows.Forms.ListBox();
            this.ButtRmove = new System.Windows.Forms.Button();
            this.labelSoccerTeamList = new System.Windows.Forms.Label();
            this.labelChooseCountry = new System.Windows.Forms.Label();
            this.labelChooseTeam = new System.Windows.Forms.Label();
            this.tboxTeamCity = new System.Windows.Forms.TextBox();
            this.tboxTeamCountry = new System.Windows.Forms.TextBox();
            this.tboxTeamName = new System.Windows.Forms.TextBox();
            this.labelAddingTeam = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTeamCountry = new System.Windows.Forms.Label();
            this.labelTeamCity = new System.Windows.Forms.Label();
            this.labelAddingPlayer = new System.Windows.Forms.Label();
            this.tboxPlayerNum = new System.Windows.Forms.TextBox();
            this.tboxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerNum = new System.Windows.Forms.Label();
            this.labelPlayerPosition = new System.Windows.Forms.Label();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.CmboBoxPlayerPosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxTeamPlayer
            // 
            this.listBoxTeamPlayer.FormattingEnabled = true;
            this.listBoxTeamPlayer.Location = new System.Drawing.Point(577, 45);
            this.listBoxTeamPlayer.MultiColumn = true;
            this.listBoxTeamPlayer.Name = "listBoxTeamPlayer";
            this.listBoxTeamPlayer.Size = new System.Drawing.Size(211, 251);
            this.listBoxTeamPlayer.TabIndex = 1;
            // 
            // ButtRmove
            // 
            this.ButtRmove.Location = new System.Drawing.Point(652, 330);
            this.ButtRmove.Name = "ButtRmove";
            this.ButtRmove.Size = new System.Drawing.Size(75, 23);
            this.ButtRmove.TabIndex = 3;
            this.ButtRmove.Text = "Remove";
            this.ButtRmove.UseVisualStyleBackColor = true;
            this.ButtRmove.Click += new System.EventHandler(this.ButtRmove_Click);
            // 
            // labelSoccerTeamList
            // 
            this.labelSoccerTeamList.AutoSize = true;
            this.labelSoccerTeamList.Location = new System.Drawing.Point(162, 9);
            this.labelSoccerTeamList.Name = "labelSoccerTeamList";
            this.labelSoccerTeamList.Size = new System.Drawing.Size(90, 13);
            this.labelSoccerTeamList.TabIndex = 4;
            this.labelSoccerTeamList.Text = "Soccer Team List";
            // 
            // labelChooseCountry
            // 
            this.labelChooseCountry.AutoSize = true;
            this.labelChooseCountry.Location = new System.Drawing.Point(101, 44);
            this.labelChooseCountry.Name = "labelChooseCountry";
            this.labelChooseCountry.Size = new System.Drawing.Size(88, 13);
            this.labelChooseCountry.TabIndex = 5;
            this.labelChooseCountry.Text = "Choose Country :";
            // 
            // labelChooseTeam
            // 
            this.labelChooseTeam.AutoSize = true;
            this.labelChooseTeam.Location = new System.Drawing.Point(105, 76);
            this.labelChooseTeam.Name = "labelChooseTeam";
            this.labelChooseTeam.Size = new System.Drawing.Size(79, 13);
            this.labelChooseTeam.TabIndex = 6;
            this.labelChooseTeam.Text = "Choose Team :";
            this.labelChooseTeam.Click += new System.EventHandler(this.labelChooseTeam_Click);
            // 
            // tboxTeamCity
            // 
            this.tboxTeamCity.Location = new System.Drawing.Point(108, 228);
            this.tboxTeamCity.Name = "tboxTeamCity";
            this.tboxTeamCity.Size = new System.Drawing.Size(100, 20);
            this.tboxTeamCity.TabIndex = 8;
            // 
            // tboxTeamCountry
            // 
            this.tboxTeamCountry.Location = new System.Drawing.Point(108, 197);
            this.tboxTeamCountry.Name = "tboxTeamCountry";
            this.tboxTeamCountry.Size = new System.Drawing.Size(100, 20);
            this.tboxTeamCountry.TabIndex = 9;
            // 
            // tboxTeamName
            // 
            this.tboxTeamName.Location = new System.Drawing.Point(108, 162);
            this.tboxTeamName.Name = "tboxTeamName";
            this.tboxTeamName.Size = new System.Drawing.Size(100, 20);
            this.tboxTeamName.TabIndex = 10;
            // 
            // labelAddingTeam
            // 
            this.labelAddingTeam.AutoSize = true;
            this.labelAddingTeam.Location = new System.Drawing.Point(41, 128);
            this.labelAddingTeam.Name = "labelAddingTeam";
            this.labelAddingTeam.Size = new System.Drawing.Size(73, 13);
            this.labelAddingTeam.TabIndex = 11;
            this.labelAddingTeam.Text = "Adding Team ";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(12, 165);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(71, 13);
            this.labelTeamName.TabIndex = 12;
            this.labelTeamName.Text = "Team Name :";
            // 
            // labelTeamCountry
            // 
            this.labelTeamCountry.AutoSize = true;
            this.labelTeamCountry.Location = new System.Drawing.Point(12, 200);
            this.labelTeamCountry.Name = "labelTeamCountry";
            this.labelTeamCountry.Size = new System.Drawing.Size(79, 13);
            this.labelTeamCountry.TabIndex = 13;
            this.labelTeamCountry.Text = "Team Country :";
            // 
            // labelTeamCity
            // 
            this.labelTeamCity.AutoSize = true;
            this.labelTeamCity.Location = new System.Drawing.Point(12, 231);
            this.labelTeamCity.Name = "labelTeamCity";
            this.labelTeamCity.Size = new System.Drawing.Size(60, 13);
            this.labelTeamCity.TabIndex = 14;
            this.labelTeamCity.Text = "Team City :";
            // 
            // labelAddingPlayer
            // 
            this.labelAddingPlayer.AutoSize = true;
            this.labelAddingPlayer.Location = new System.Drawing.Point(262, 128);
            this.labelAddingPlayer.Name = "labelAddingPlayer";
            this.labelAddingPlayer.Size = new System.Drawing.Size(78, 13);
            this.labelAddingPlayer.TabIndex = 15;
            this.labelAddingPlayer.Text = "Adding Player :";
            // 
            // tboxPlayerNum
            // 
            this.tboxPlayerNum.Location = new System.Drawing.Point(372, 197);
            this.tboxPlayerNum.Name = "tboxPlayerNum";
            this.tboxPlayerNum.Size = new System.Drawing.Size(121, 20);
            this.tboxPlayerNum.TabIndex = 17;
            // 
            // tboxPlayerName
            // 
            this.tboxPlayerName.Location = new System.Drawing.Point(372, 162);
            this.tboxPlayerName.Name = "tboxPlayerName";
            this.tboxPlayerName.Size = new System.Drawing.Size(121, 20);
            this.tboxPlayerName.TabIndex = 18;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(267, 165);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(73, 13);
            this.labelPlayerName.TabIndex = 19;
            this.labelPlayerName.Text = "Player Name :";
            // 
            // labelPlayerNum
            // 
            this.labelPlayerNum.AutoSize = true;
            this.labelPlayerNum.Location = new System.Drawing.Point(267, 200);
            this.labelPlayerNum.Name = "labelPlayerNum";
            this.labelPlayerNum.Size = new System.Drawing.Size(82, 13);
            this.labelPlayerNum.TabIndex = 20;
            this.labelPlayerNum.Text = "Player Number :";
            // 
            // labelPlayerPosition
            // 
            this.labelPlayerPosition.AutoSize = true;
            this.labelPlayerPosition.Location = new System.Drawing.Point(267, 235);
            this.labelPlayerPosition.Name = "labelPlayerPosition";
            this.labelPlayerPosition.Size = new System.Drawing.Size(82, 13);
            this.labelPlayerPosition.TabIndex = 21;
            this.labelPlayerPosition.Text = "Player Position :";
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(79, 273);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeam.TabIndex = 22;
            this.buttonAddTeam.Text = "Add";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(329, 273);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlayer.TabIndex = 23;
            this.buttonAddPlayer.Text = "Add";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(204, 41);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 24;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(204, 73);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeam.TabIndex = 25;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // CmboBoxPlayerPosition
            // 
            this.CmboBoxPlayerPosition.FormattingEnabled = true;
            this.CmboBoxPlayerPosition.Location = new System.Drawing.Point(372, 228);
            this.CmboBoxPlayerPosition.Name = "CmboBoxPlayerPosition";
            this.CmboBoxPlayerPosition.Size = new System.Drawing.Size(121, 21);
            this.CmboBoxPlayerPosition.TabIndex = 26;
            this.CmboBoxPlayerPosition.SelectedIndexChanged += new System.EventHandler(this.CmboBoxPlayerPosition_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmboBoxPlayerPosition);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.labelPlayerPosition);
            this.Controls.Add(this.labelPlayerNum);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.tboxPlayerName);
            this.Controls.Add(this.tboxPlayerNum);
            this.Controls.Add(this.labelAddingPlayer);
            this.Controls.Add(this.labelTeamCity);
            this.Controls.Add(this.labelTeamCountry);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.labelAddingTeam);
            this.Controls.Add(this.tboxTeamName);
            this.Controls.Add(this.tboxTeamCountry);
            this.Controls.Add(this.tboxTeamCity);
            this.Controls.Add(this.labelChooseTeam);
            this.Controls.Add(this.labelChooseCountry);
            this.Controls.Add(this.labelSoccerTeamList);
            this.Controls.Add(this.ButtRmove);
            this.Controls.Add(this.listBoxTeamPlayer);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTeamPlayer;
        private System.Windows.Forms.Button ButtRmove;
        private System.Windows.Forms.Label labelSoccerTeamList;
        private System.Windows.Forms.Label labelChooseCountry;
        private System.Windows.Forms.Label labelChooseTeam;
        private System.Windows.Forms.TextBox tboxTeamCity;
        private System.Windows.Forms.TextBox tboxTeamCountry;
        private System.Windows.Forms.TextBox tboxTeamName;
        private System.Windows.Forms.Label labelAddingTeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelTeamCountry;
        private System.Windows.Forms.Label labelTeamCity;
        private System.Windows.Forms.Label labelAddingPlayer;
        private System.Windows.Forms.TextBox tboxPlayerNum;
        private System.Windows.Forms.TextBox tboxPlayerName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelPlayerNum;
        private System.Windows.Forms.Label labelPlayerPosition;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.ComboBox CmboBoxPlayerPosition;
    }
}

