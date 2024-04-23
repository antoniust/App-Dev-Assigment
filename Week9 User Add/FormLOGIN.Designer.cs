namespace WindowsFormsApp1
{
    partial class FormLOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.textBoxPWLOGIN = new System.Windows.Forms.TextBox();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUSERNAMELOGIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME";
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.Location = new System.Drawing.Point(292, 321);
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.Size = new System.Drawing.Size(168, 59);
            this.buttonLOGIN.TabIndex = 10;
            this.buttonLOGIN.Text = "LOG IN";
            this.buttonLOGIN.UseVisualStyleBackColor = true;
            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            // 
            // textBoxPWLOGIN
            // 
            this.textBoxPWLOGIN.Location = new System.Drawing.Point(379, 238);
            this.textBoxPWLOGIN.Name = "textBoxPWLOGIN";
            this.textBoxPWLOGIN.Size = new System.Drawing.Size(190, 31);
            this.textBoxPWLOGIN.TabIndex = 9;
            this.textBoxPWLOGIN.UseSystemPasswordChar = true;
            this.textBoxPWLOGIN.TextChanged += new System.EventHandler(this.textBoxPWLOGIN_TextChanged);
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(191, 241);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(118, 25);
            this.labelPW.TabIndex = 8;
            this.labelPW.Text = "Password :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(191, 182);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(122, 25);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username :";
            // 
            // textBoxUSERNAMELOGIN
            // 
            this.textBoxUSERNAMELOGIN.Location = new System.Drawing.Point(379, 177);
            this.textBoxUSERNAMELOGIN.Name = "textBoxUSERNAMELOGIN";
            this.textBoxUSERNAMELOGIN.Size = new System.Drawing.Size(190, 31);
            this.textBoxUSERNAMELOGIN.TabIndex = 6;
            // 
            // FormLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLOGIN);
            this.Controls.Add(this.textBoxPWLOGIN);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUSERNAMELOGIN);
            this.Name = "FormLOGIN";
            this.Text = "FormLOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.TextBox textBoxPWLOGIN;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUSERNAMELOGIN;
    }
}