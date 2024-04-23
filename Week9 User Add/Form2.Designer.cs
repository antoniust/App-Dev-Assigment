namespace WindowsFormsApp1
{
    partial class Form2
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
            this.textBoxPWREGIS = new System.Windows.Forms.TextBox();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUSERREGIS = new System.Windows.Forms.TextBox();
            this.textBoxrepeatPW = new System.Windows.Forms.TextBox();
            this.labelREPEATPW = new System.Windows.Forms.Label();
            this.buttonREGISTER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPWREGIS
            // 
            this.textBoxPWREGIS.Location = new System.Drawing.Point(291, 174);
            this.textBoxPWREGIS.Name = "textBoxPWREGIS";
            this.textBoxPWREGIS.Size = new System.Drawing.Size(190, 31);
            this.textBoxPWREGIS.TabIndex = 7;
            this.textBoxPWREGIS.UseSystemPasswordChar = true;
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(66, 177);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(118, 25);
            this.labelPW.TabIndex = 6;
            this.labelPW.Text = "Password :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(66, 118);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(122, 25);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username :";
            // 
            // textBoxUSERREGIS
            // 
            this.textBoxUSERREGIS.Location = new System.Drawing.Point(291, 115);
            this.textBoxUSERREGIS.Name = "textBoxUSERREGIS";
            this.textBoxUSERREGIS.Size = new System.Drawing.Size(190, 31);
            this.textBoxUSERREGIS.TabIndex = 4;
            // 
            // textBoxrepeatPW
            // 
            this.textBoxrepeatPW.Location = new System.Drawing.Point(291, 230);
            this.textBoxrepeatPW.Name = "textBoxrepeatPW";
            this.textBoxrepeatPW.Size = new System.Drawing.Size(190, 31);
            this.textBoxrepeatPW.TabIndex = 8;
            this.textBoxrepeatPW.UseSystemPasswordChar = true;
            // 
            // labelREPEATPW
            // 
            this.labelREPEATPW.AutoSize = true;
            this.labelREPEATPW.Location = new System.Drawing.Point(57, 236);
            this.labelREPEATPW.Name = "labelREPEATPW";
            this.labelREPEATPW.Size = new System.Drawing.Size(193, 25);
            this.labelREPEATPW.TabIndex = 9;
            this.labelREPEATPW.Text = "Repeat Password :";
            // 
            // buttonREGISTER
            // 
            this.buttonREGISTER.Location = new System.Drawing.Point(190, 318);
            this.buttonREGISTER.Name = "buttonREGISTER";
            this.buttonREGISTER.Size = new System.Drawing.Size(177, 63);
            this.buttonREGISTER.TabIndex = 10;
            this.buttonREGISTER.Text = "REGISTER";
            this.buttonREGISTER.UseVisualStyleBackColor = true;
            this.buttonREGISTER.Click += new System.EventHandler(this.buttonREGISTER_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 656);
            this.Controls.Add(this.buttonREGISTER);
            this.Controls.Add(this.labelREPEATPW);
            this.Controls.Add(this.textBoxrepeatPW);
            this.Controls.Add(this.textBoxPWREGIS);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUSERREGIS);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPWREGIS;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUSERREGIS;
        private System.Windows.Forms.TextBox textBoxrepeatPW;
        private System.Windows.Forms.Label labelREPEATPW;
        private System.Windows.Forms.Button buttonREGISTER;
    }
}