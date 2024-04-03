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
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonTampil = new System.Windows.Forms.Button();
            this.buttonPREV = new System.Windows.Forms.Button();
            this.buttonchange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Location = new System.Drawing.Point(270, 74);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(227, 243);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            // 
            // buttonTampil
            // 
            this.buttonTampil.Location = new System.Drawing.Point(568, 149);
            this.buttonTampil.Name = "buttonTampil";
            this.buttonTampil.Size = new System.Drawing.Size(75, 23);
            this.buttonTampil.TabIndex = 1;
            this.buttonTampil.Text = "NEXT";
            this.buttonTampil.UseVisualStyleBackColor = true;
            this.buttonTampil.Click += new System.EventHandler(this.buttonTampil_Click);
            // 
            // buttonPREV
            // 
            this.buttonPREV.Location = new System.Drawing.Point(99, 149);
            this.buttonPREV.Name = "buttonPREV";
            this.buttonPREV.Size = new System.Drawing.Size(75, 23);
            this.buttonPREV.TabIndex = 2;
            this.buttonPREV.Text = "PREV";
            this.buttonPREV.UseVisualStyleBackColor = true;
            this.buttonPREV.Click += new System.EventHandler(this.buttonPREV_Click);
            // 
            // buttonchange
            // 
            this.buttonchange.Location = new System.Drawing.Point(338, 352);
            this.buttonchange.Name = "buttonchange";
            this.buttonchange.Size = new System.Drawing.Size(75, 23);
            this.buttonchange.TabIndex = 3;
            this.buttonchange.Text = "CHANGE";
            this.buttonchange.UseVisualStyleBackColor = true;
            this.buttonchange.Click += new System.EventHandler(this.buttonchange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonchange);
            this.Controls.Add(this.buttonPREV);
            this.Controls.Add(this.buttonTampil);
            this.Controls.Add(this.pBoxLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Button buttonTampil;
        private System.Windows.Forms.Button buttonPREV;
        private System.Windows.Forms.Button buttonchange;
    }
}

