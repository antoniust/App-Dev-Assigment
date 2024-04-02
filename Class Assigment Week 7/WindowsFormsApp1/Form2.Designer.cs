namespace WindowsFormsApp1
{
    partial class Form2AddTeam
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
            this.textBoxNamaTeam = new System.Windows.Forms.TextBox();
            this.labelmasukannamateam = new System.Windows.Forms.Label();
            this.buttonNambahTeamm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNamaTeam
            // 
            this.textBoxNamaTeam.Location = new System.Drawing.Point(222, 174);
            this.textBoxNamaTeam.Name = "textBoxNamaTeam";
            this.textBoxNamaTeam.Size = new System.Drawing.Size(315, 20);
            this.textBoxNamaTeam.TabIndex = 0;
            // 
            // labelmasukannamateam
            // 
            this.labelmasukannamateam.AutoSize = true;
            this.labelmasukannamateam.Location = new System.Drawing.Point(323, 144);
            this.labelmasukannamateam.Name = "labelmasukannamateam";
            this.labelmasukannamateam.Size = new System.Drawing.Size(112, 13);
            this.labelmasukannamateam.TabIndex = 1;
            this.labelmasukannamateam.Text = "Masukan Nama Team";
            // 
            // buttonNambahTeamm
            // 
            this.buttonNambahTeamm.Location = new System.Drawing.Point(342, 212);
            this.buttonNambahTeamm.Name = "buttonNambahTeamm";
            this.buttonNambahTeamm.Size = new System.Drawing.Size(75, 23);
            this.buttonNambahTeamm.TabIndex = 2;
            this.buttonNambahTeamm.Text = "ADD TEAM";
            this.buttonNambahTeamm.UseVisualStyleBackColor = true;
            this.buttonNambahTeamm.Click += new System.EventHandler(this.buttonNambahTeamm_Click);
            // 
            // Form2AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNambahTeamm);
            this.Controls.Add(this.labelmasukannamateam);
            this.Controls.Add(this.textBoxNamaTeam);
            this.Name = "Form2AddTeam";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2AddTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNamaTeam;
        private System.Windows.Forms.Label labelmasukannamateam;
        private System.Windows.Forms.Button buttonNambahTeamm;
    }
}