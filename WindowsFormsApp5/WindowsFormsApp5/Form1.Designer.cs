namespace WindowsFormsApp5
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
            this.buttonTEST = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelINPUT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTEST
            // 
            this.buttonTEST.Location = new System.Drawing.Point(355, 25);
            this.buttonTEST.Name = "buttonTEST";
            this.buttonTEST.Size = new System.Drawing.Size(75, 23);
            this.buttonTEST.TabIndex = 0;
            this.buttonTEST.Text = "ANJAYY";
            this.buttonTEST.UseVisualStyleBackColor = true;
            this.buttonTEST.Click += new System.EventHandler(this.buttonTEST_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelINPUT
            // 
            this.labelINPUT.AutoSize = true;
            this.labelINPUT.Location = new System.Drawing.Point(138, 30);
            this.labelINPUT.Name = "labelINPUT";
            this.labelINPUT.Size = new System.Drawing.Size(74, 13);
            this.labelINPUT.TabIndex = 2;
            this.labelINPUT.Text = "Jumlah Button";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelINPUT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTEST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTEST;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelINPUT;
    }
}

