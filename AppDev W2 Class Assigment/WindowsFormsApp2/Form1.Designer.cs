namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_angka1 = new System.Windows.Forms.TextBox();
            this.textBox_angka2 = new System.Windows.Forms.TextBox();
            this.labelangka1 = new System.Windows.Forms.Label();
            this.labelangka2 = new System.Windows.Forms.Label();
            this.LabelHasil = new System.Windows.Forms.Label();
            this.radbut1 = new System.Windows.Forms.RadioButton();
            this.radbut2 = new System.Windows.Forms.RadioButton();
            this.radbut3 = new System.Windows.Forms.RadioButton();
            this.radbut4 = new System.Windows.Forms.RadioButton();
            this.labelangka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_angka1
            // 
            this.textBox_angka1.Location = new System.Drawing.Point(158, 94);
            this.textBox_angka1.Name = "textBox_angka1";
            this.textBox_angka1.Size = new System.Drawing.Size(100, 20);
            this.textBox_angka1.TabIndex = 1;
            this.textBox_angka1.TextChanged += new System.EventHandler(this.textBox_angka1_TextChanged);
            // 
            // textBox_angka2
            // 
            this.textBox_angka2.Location = new System.Drawing.Point(158, 134);
            this.textBox_angka2.Name = "textBox_angka2";
            this.textBox_angka2.Size = new System.Drawing.Size(100, 20);
            this.textBox_angka2.TabIndex = 2;
            // 
            // labelangka1
            // 
            this.labelangka1.AutoSize = true;
            this.labelangka1.Location = new System.Drawing.Point(72, 94);
            this.labelangka1.Name = "labelangka1";
            this.labelangka1.Size = new System.Drawing.Size(44, 13);
            this.labelangka1.TabIndex = 3;
            this.labelangka1.Text = "Angka1";
            this.labelangka1.Click += new System.EventHandler(this.labelangka1_Click);
            // 
            // labelangka2
            // 
            this.labelangka2.AutoSize = true;
            this.labelangka2.Location = new System.Drawing.Point(72, 134);
            this.labelangka2.Name = "labelangka2";
            this.labelangka2.Size = new System.Drawing.Size(44, 13);
            this.labelangka2.TabIndex = 4;
            this.labelangka2.Text = "Angka2";
            // 
            // LabelHasil
            // 
            this.LabelHasil.AutoSize = true;
            this.LabelHasil.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHasil.Location = new System.Drawing.Point(398, 94);
            this.LabelHasil.Name = "LabelHasil";
            this.LabelHasil.Size = new System.Drawing.Size(97, 32);
            this.LabelHasil.TabIndex = 5;
            this.LabelHasil.Text = "Hasil";
            this.LabelHasil.Click += new System.EventHandler(this.LabelHasil_Click);
            // 
            // radbut1
            // 
            this.radbut1.AutoSize = true;
            this.radbut1.Location = new System.Drawing.Point(294, 95);
            this.radbut1.Name = "radbut1";
            this.radbut1.Size = new System.Drawing.Size(68, 17);
            this.radbut1.TabIndex = 6;
            this.radbut1.TabStop = true;
            this.radbut1.Text = "JUMLAH";
            this.radbut1.UseVisualStyleBackColor = true;
            // 
            // radbut2
            // 
            this.radbut2.AutoSize = true;
            this.radbut2.Location = new System.Drawing.Point(294, 119);
            this.radbut2.Name = "radbut2";
            this.radbut2.Size = new System.Drawing.Size(71, 17);
            this.radbut2.TabIndex = 7;
            this.radbut2.TabStop = true;
            this.radbut2.Text = "KURANG";
            this.radbut2.UseVisualStyleBackColor = true;
            // 
            // radbut3
            // 
            this.radbut3.AutoSize = true;
            this.radbut3.Location = new System.Drawing.Point(294, 143);
            this.radbut3.Name = "radbut3";
            this.radbut3.Size = new System.Drawing.Size(48, 17);
            this.radbut3.TabIndex = 8;
            this.radbut3.TabStop = true;
            this.radbut3.Text = "KALI";
            this.radbut3.UseVisualStyleBackColor = true;
            // 
            // radbut4
            // 
            this.radbut4.AutoSize = true;
            this.radbut4.Location = new System.Drawing.Point(294, 167);
            this.radbut4.Name = "radbut4";
            this.radbut4.Size = new System.Drawing.Size(50, 17);
            this.radbut4.TabIndex = 9;
            this.radbut4.TabStop = true;
            this.radbut4.Text = "BAGI";
            this.radbut4.UseVisualStyleBackColor = true;
            // 
            // labelangka
            // 
            this.labelangka.AutoSize = true;
            this.labelangka.Font = new System.Drawing.Font("Magneto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelangka.Location = new System.Drawing.Point(582, 100);
            this.labelangka.Name = "labelangka";
            this.labelangka.Size = new System.Drawing.Size(98, 32);
            this.labelangka.TabIndex = 10;
            this.labelangka.Text = "0000";
            this.labelangka.Click += new System.EventHandler(this.labelangka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelangka);
            this.Controls.Add(this.radbut4);
            this.Controls.Add(this.radbut3);
            this.Controls.Add(this.radbut2);
            this.Controls.Add(this.radbut1);
            this.Controls.Add(this.LabelHasil);
            this.Controls.Add(this.labelangka2);
            this.Controls.Add(this.labelangka1);
            this.Controls.Add(this.textBox_angka2);
            this.Controls.Add(this.textBox_angka1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Angka 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_angka1;
        private System.Windows.Forms.TextBox textBox_angka2;
        private System.Windows.Forms.Label labelangka1;
        private System.Windows.Forms.Label labelangka2;
        private System.Windows.Forms.Label LabelHasil;
        private System.Windows.Forms.RadioButton radbut1;
        private System.Windows.Forms.RadioButton radbut2;
        private System.Windows.Forms.RadioButton radbut3;
        private System.Windows.Forms.RadioButton radbut4;
        private System.Windows.Forms.Label labelangka;
    }
}

