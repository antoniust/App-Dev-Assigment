namespace WindowsFormsApp1
{
    partial class FormNBAMatch
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
            this.dataGridViewNBAMatch = new System.Windows.Forms.DataGridView();
            this.dtpNBAMatch = new System.Windows.Forms.DateTimePicker();
            this.textBoxHome = new System.Windows.Forms.TextBox();
            this.buttonADDMatch = new System.Windows.Forms.Button();
            this.labelVS = new System.Windows.Forms.Label();
            this.comboBoxHome = new System.Windows.Forms.ComboBox();
            this.comboBoxAWAY = new System.Windows.Forms.ComboBox();
            this.textBoxAWAY = new System.Windows.Forms.TextBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNBAMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNBAMatch
            // 
            this.dataGridViewNBAMatch.AllowUserToAddRows = false;
            this.dataGridViewNBAMatch.AllowUserToDeleteRows = false;
            this.dataGridViewNBAMatch.AllowUserToResizeColumns = false;
            this.dataGridViewNBAMatch.AllowUserToResizeRows = false;
            this.dataGridViewNBAMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNBAMatch.Location = new System.Drawing.Point(112, 12);
            this.dataGridViewNBAMatch.Name = "dataGridViewNBAMatch";
            this.dataGridViewNBAMatch.Size = new System.Drawing.Size(652, 248);
            this.dataGridViewNBAMatch.TabIndex = 1;
            this.dataGridViewNBAMatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNBAMatch_CellContentClick);
            // 
            // dtpNBAMatch
            // 
            this.dtpNBAMatch.Location = new System.Drawing.Point(355, 266);
            this.dtpNBAMatch.Name = "dtpNBAMatch";
            this.dtpNBAMatch.Size = new System.Drawing.Size(200, 20);
            this.dtpNBAMatch.TabIndex = 2;
            // 
            // textBoxHome
            // 
            this.textBoxHome.Location = new System.Drawing.Point(344, 339);
            this.textBoxHome.Name = "textBoxHome";
            this.textBoxHome.Size = new System.Drawing.Size(100, 20);
            this.textBoxHome.TabIndex = 3;
            this.textBoxHome.TextChanged += new System.EventHandler(this.textBoxHome_TextChanged);
            // 
            // buttonADDMatch
            // 
            this.buttonADDMatch.Location = new System.Drawing.Point(368, 384);
            this.buttonADDMatch.Name = "buttonADDMatch";
            this.buttonADDMatch.Size = new System.Drawing.Size(76, 38);
            this.buttonADDMatch.TabIndex = 4;
            this.buttonADDMatch.Text = "ADD MATCH";
            this.buttonADDMatch.UseVisualStyleBackColor = true;
            this.buttonADDMatch.Click += new System.EventHandler(this.buttonADDMatch_Click);
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(435, 306);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(21, 13);
            this.labelVS.TabIndex = 5;
            this.labelVS.Text = "VS";
            // 
            // comboBoxHome
            // 
            this.comboBoxHome.FormattingEnabled = true;
            this.comboBoxHome.Location = new System.Drawing.Point(301, 303);
            this.comboBoxHome.Name = "comboBoxHome";
            this.comboBoxHome.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHome.TabIndex = 6;
            this.comboBoxHome.SelectedIndexChanged += new System.EventHandler(this.comboBoxHome_SelectedIndexChanged);
            // 
            // comboBoxAWAY
            // 
            this.comboBoxAWAY.FormattingEnabled = true;
            this.comboBoxAWAY.Location = new System.Drawing.Point(476, 303);
            this.comboBoxAWAY.Name = "comboBoxAWAY";
            this.comboBoxAWAY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAWAY.TabIndex = 7;
            this.comboBoxAWAY.SelectedIndexChanged += new System.EventHandler(this.comboBoxAWAY_SelectedIndexChanged);
            // 
            // textBoxAWAY
            // 
            this.textBoxAWAY.Location = new System.Drawing.Point(450, 339);
            this.textBoxAWAY.Name = "textBoxAWAY";
            this.textBoxAWAY.Size = new System.Drawing.Size(100, 20);
            this.textBoxAWAY.TabIndex = 9;
            this.textBoxAWAY.TextChanged += new System.EventHandler(this.textBoxAWAY_TextChanged);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(450, 384);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(76, 38);
            this.buttonAddTeam.TabIndex = 10;
            this.buttonAddTeam.Text = "ADD TEAM";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(94, 286);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(76, 38);
            this.buttonDELETE.TabIndex = 11;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // FormNBAMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.textBoxAWAY);
            this.Controls.Add(this.comboBoxAWAY);
            this.Controls.Add(this.comboBoxHome);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.buttonADDMatch);
            this.Controls.Add(this.textBoxHome);
            this.Controls.Add(this.dtpNBAMatch);
            this.Controls.Add(this.dataGridViewNBAMatch);
            this.Name = "FormNBAMatch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormNBAMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNBAMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNBAMatch;
        private System.Windows.Forms.DateTimePicker dtpNBAMatch;
        private System.Windows.Forms.TextBox textBoxHome;
        private System.Windows.Forms.Button buttonADDMatch;
        private System.Windows.Forms.Label labelVS;
        private System.Windows.Forms.ComboBox comboBoxHome;
        private System.Windows.Forms.ComboBox comboBoxAWAY;
        private System.Windows.Forms.TextBox textBoxAWAY;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonDELETE;
    }
}

