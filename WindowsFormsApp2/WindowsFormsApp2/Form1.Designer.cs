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
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxjurusan = new System.Windows.Forms.TextBox();
            this.labelInputNIM = new System.Windows.Forms.Label();
            this.labelInputNama = new System.Windows.Forms.Label();
            this.labelInputJurusan = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonUPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(740, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Location = new System.Drawing.Point(1042, 541);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(161, 101);
            this.buttonsubmit.TabIndex = 1;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(712, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(775, 379);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(1112, 321);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(238, 31);
            this.textBoxNIM.TabIndex = 6;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(1112, 390);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(238, 31);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxjurusan
            // 
            this.textBoxjurusan.Location = new System.Drawing.Point(1112, 462);
            this.textBoxjurusan.Name = "textBoxjurusan";
            this.textBoxjurusan.Size = new System.Drawing.Size(238, 31);
            this.textBoxjurusan.TabIndex = 8;
            this.textBoxjurusan.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelInputNIM
            // 
            this.labelInputNIM.AutoSize = true;
            this.labelInputNIM.Location = new System.Drawing.Point(984, 324);
            this.labelInputNIM.Name = "labelInputNIM";
            this.labelInputNIM.Size = new System.Drawing.Size(50, 25);
            this.labelInputNIM.TabIndex = 9;
            this.labelInputNIM.Text = "NIM";
            // 
            // labelInputNama
            // 
            this.labelInputNama.AutoSize = true;
            this.labelInputNama.Location = new System.Drawing.Point(984, 393);
            this.labelInputNama.Name = "labelInputNama";
            this.labelInputNama.Size = new System.Drawing.Size(68, 25);
            this.labelInputNama.TabIndex = 10;
            this.labelInputNama.Text = "Nama";
            // 
            // labelInputJurusan
            // 
            this.labelInputJurusan.AutoSize = true;
            this.labelInputJurusan.Location = new System.Drawing.Point(984, 465);
            this.labelInputJurusan.Name = "labelInputJurusan";
            this.labelInputJurusan.Size = new System.Drawing.Size(89, 25);
            this.labelInputJurusan.TabIndex = 11;
            this.labelInputJurusan.Text = "Jurusan";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1042, 717);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 82);
            this.button2.TabIndex = 12;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(1237, 717);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(127, 82);
            this.buttonDELETE.TabIndex = 13;
            this.buttonDELETE.Text = "Delete";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttonUPDATE
            // 
            this.buttonUPDATE.Location = new System.Drawing.Point(1237, 541);
            this.buttonUPDATE.Name = "buttonUPDATE";
            this.buttonUPDATE.Size = new System.Drawing.Size(161, 101);
            this.buttonUPDATE.TabIndex = 14;
            this.buttonUPDATE.Text = "Update";
            this.buttonUPDATE.UseVisualStyleBackColor = true;
            this.buttonUPDATE.Click += new System.EventHandler(this.buttonUPDATE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 898);
            this.Controls.Add(this.buttonUPDATE);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelInputJurusan);
            this.Controls.Add(this.labelInputNama);
            this.Controls.Add(this.labelInputNIM);
            this.Controls.Add(this.textBoxjurusan);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxjurusan;
        private System.Windows.Forms.Label labelInputNIM;
        private System.Windows.Forms.Label labelInputNama;
        private System.Windows.Forms.Label labelInputJurusan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonUPDATE;
    }
}

