namespace WindowsFormsApp3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxMAKANAN = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelMAKANAN = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxMAKANAN = new System.Windows.Forms.TextBox();
            this.textBoxTMPTMKN = new System.Windows.Forms.TextBox();
            this.labelTMPTMKN = new System.Windows.Forms.Label();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonPILIH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(460, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listBoxMAKANAN
            // 
            this.listBoxMAKANAN.FormattingEnabled = true;
            this.listBoxMAKANAN.Location = new System.Drawing.Point(272, 130);
            this.listBoxMAKANAN.Name = "listBoxMAKANAN";
            this.listBoxMAKANAN.Size = new System.Drawing.Size(182, 108);
            this.listBoxMAKANAN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // labelMAKANAN
            // 
            this.labelMAKANAN.AutoSize = true;
            this.labelMAKANAN.Location = new System.Drawing.Point(202, 70);
            this.labelMAKANAN.Name = "labelMAKANAN";
            this.labelMAKANAN.Size = new System.Drawing.Size(52, 13);
            this.labelMAKANAN.TabIndex = 4;
            this.labelMAKANAN.Text = "Makanan";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(60, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(60, 113);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxMAKANAN
            // 
            this.textBoxMAKANAN.Location = new System.Drawing.Point(292, 64);
            this.textBoxMAKANAN.Name = "textBoxMAKANAN";
            this.textBoxMAKANAN.Size = new System.Drawing.Size(100, 20);
            this.textBoxMAKANAN.TabIndex = 7;
            // 
            // textBoxTMPTMKN
            // 
            this.textBoxTMPTMKN.Location = new System.Drawing.Point(292, 90);
            this.textBoxTMPTMKN.Name = "textBoxTMPTMKN";
            this.textBoxTMPTMKN.Size = new System.Drawing.Size(100, 20);
            this.textBoxTMPTMKN.TabIndex = 8;
            // 
            // labelTMPTMKN
            // 
            this.labelTMPTMKN.AutoSize = true;
            this.labelTMPTMKN.Location = new System.Drawing.Point(202, 93);
            this.labelTMPTMKN.Name = "labelTMPTMKN";
            this.labelTMPTMKN.Size = new System.Drawing.Size(79, 13);
            this.labelTMPTMKN.TabIndex = 9;
            this.labelTMPTMKN.Text = "Tempat Makan";
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Location = new System.Drawing.Point(460, 186);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCLEAR.TabIndex = 10;
            this.buttonCLEAR.Text = "CLEAR";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            this.buttonCLEAR.Click += new System.EventHandler(this.buttonCLEAR_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(460, 215);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(75, 23);
            this.buttonDELETE.TabIndex = 11;
            this.buttonDELETE.Text = "DELETE";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonPILIH
            // 
            this.buttonPILIH.Location = new System.Drawing.Point(460, 157);
            this.buttonPILIH.Name = "buttonPILIH";
            this.buttonPILIH.Size = new System.Drawing.Size(75, 23);
            this.buttonPILIH.TabIndex = 12;
            this.buttonPILIH.Text = "PILIH";
            this.buttonPILIH.UseVisualStyleBackColor = true;
            this.buttonPILIH.Click += new System.EventHandler(this.buttonPILIH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPILIH);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.labelTMPTMKN);
            this.Controls.Add(this.textBoxTMPTMKN);
            this.Controls.Add(this.textBoxMAKANAN);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelMAKANAN);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxMAKANAN);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxMAKANAN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelMAKANAN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxMAKANAN;
        private System.Windows.Forms.TextBox textBoxTMPTMKN;
        private System.Windows.Forms.Label labelTMPTMKN;
        private System.Windows.Forms.Button buttonCLEAR;
        private System.Windows.Forms.Button buttonDELETE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonPILIH;
    }
}

