namespace WindowsFormsApp1
{
    partial class FormPremierLeague
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
            this.labelTimID = new System.Windows.Forms.Label();
            this.textBoxTimID = new System.Windows.Forms.TextBox();
            this.dataGridViewLeage = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKapasitas = new System.Windows.Forms.TextBox();
            this.textBoxStadium = new System.Windows.Forms.TextBox();
            this.textBoxTimName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKota = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.textBoxKota = new System.Windows.Forms.TextBox();
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTimID
            // 
            this.labelTimID.AutoSize = true;
            this.labelTimID.Location = new System.Drawing.Point(110, 19);
            this.labelTimID.Name = "labelTimID";
            this.labelTimID.Size = new System.Drawing.Size(38, 13);
            this.labelTimID.TabIndex = 0;
            this.labelTimID.Text = "Tim ID";
            // 
            // textBoxTimID
            // 
            this.textBoxTimID.Enabled = false;
            this.textBoxTimID.Location = new System.Drawing.Point(230, 19);
            this.textBoxTimID.Name = "textBoxTimID";
            this.textBoxTimID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimID.TabIndex = 1;
            this.textBoxTimID.TextChanged += new System.EventHandler(this.textBoxTimID_TextChanged);
            // 
            // dataGridViewLeage
            // 
            this.dataGridViewLeage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeage.Location = new System.Drawing.Point(113, 223);
            this.dataGridViewLeage.Name = "dataGridViewLeage";
            this.dataGridViewLeage.Size = new System.Drawing.Size(573, 215);
            this.dataGridViewLeage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Stadium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Tim";
            // 
            // textBoxKapasitas
            // 
            this.textBoxKapasitas.Location = new System.Drawing.Point(230, 102);
            this.textBoxKapasitas.Name = "textBoxKapasitas";
            this.textBoxKapasitas.Size = new System.Drawing.Size(100, 20);
            this.textBoxKapasitas.TabIndex = 4;
            // 
            // textBoxStadium
            // 
            this.textBoxStadium.Location = new System.Drawing.Point(230, 76);
            this.textBoxStadium.Name = "textBoxStadium";
            this.textBoxStadium.Size = new System.Drawing.Size(100, 20);
            this.textBoxStadium.TabIndex = 5;
            // 
            // textBoxTimName
            // 
            this.textBoxTimName.Location = new System.Drawing.Point(230, 48);
            this.textBoxTimName.Name = "textBoxTimName";
            this.textBoxTimName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimName.TabIndex = 6;
            this.textBoxTimName.TextChanged += new System.EventHandler(this.textBoxTimName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kapasitas";
            // 
            // labelKota
            // 
            this.labelKota.AutoSize = true;
            this.labelKota.Location = new System.Drawing.Point(110, 128);
            this.labelKota.Name = "labelKota";
            this.labelKota.Size = new System.Drawing.Size(29, 13);
            this.labelKota.TabIndex = 8;
            this.labelKota.Text = "Kota";
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(110, 153);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(80, 13);
            this.labelManager.TabIndex = 9;
            this.labelManager.Text = "Nama Manager";
            this.labelManager.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxKota
            // 
            this.textBoxKota.Location = new System.Drawing.Point(230, 125);
            this.textBoxKota.Name = "textBoxKota";
            this.textBoxKota.Size = new System.Drawing.Size(100, 20);
            this.textBoxKota.TabIndex = 10;
            // 
            // textBoxManager
            // 
            this.textBoxManager.Location = new System.Drawing.Point(230, 150);
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.Size = new System.Drawing.Size(100, 20);
            this.textBoxManager.TabIndex = 11;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(197, 185);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 12;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // FormPremierLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxManager);
            this.Controls.Add(this.textBoxKota);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelKota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTimName);
            this.Controls.Add(this.textBoxStadium);
            this.Controls.Add(this.textBoxKapasitas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewLeage);
            this.Controls.Add(this.textBoxTimID);
            this.Controls.Add(this.labelTimID);
            this.Name = "FormPremierLeague";
            this.Text = "FormPremier League";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimID;
        private System.Windows.Forms.TextBox textBoxTimID;
        private System.Windows.Forms.DataGridView dataGridViewLeage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKapasitas;
        private System.Windows.Forms.TextBox textBoxStadium;
        private System.Windows.Forms.TextBox textBoxTimName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKota;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.TextBox textBoxKota;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Button buttonInput;
    }
}

