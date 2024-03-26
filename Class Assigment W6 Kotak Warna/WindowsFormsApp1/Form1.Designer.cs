namespace WindowsFormsApp1
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
            this.textBoxUKURAN = new System.Windows.Forms.TextBox();
            this.panelMAIN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSTART = new System.Windows.Forms.Button();
            this.panelMAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUKURAN
            // 
            this.textBoxUKURAN.Location = new System.Drawing.Point(386, 141);
            this.textBoxUKURAN.Name = "textBoxUKURAN";
            this.textBoxUKURAN.Size = new System.Drawing.Size(100, 20);
            this.textBoxUKURAN.TabIndex = 1;
            this.textBoxUKURAN.TextChanged += new System.EventHandler(this.textBoxUKURAN_TextChanged);
            // 
            // panelMAIN
            // 
            this.panelMAIN.Controls.Add(this.buttonSTART);
            this.panelMAIN.Controls.Add(this.label1);
            this.panelMAIN.Controls.Add(this.textBoxUKURAN);
            this.panelMAIN.Location = new System.Drawing.Point(12, 12);
            this.panelMAIN.Name = "panelMAIN";
            this.panelMAIN.Size = new System.Drawing.Size(786, 426);
            this.panelMAIN.TabIndex = 2;
            this.panelMAIN.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMAIN_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masukan Ukuran ";
            // 
            // buttonSTART
            // 
            this.buttonSTART.Location = new System.Drawing.Point(350, 189);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(75, 23);
            this.buttonSTART.TabIndex = 4;
            this.buttonSTART.Text = "START";
            this.buttonSTART.UseVisualStyleBackColor = true;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMAIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMAIN.ResumeLayout(false);
            this.panelMAIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUKURAN;
        private System.Windows.Forms.Panel panelMAIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSTART;
    }
}

