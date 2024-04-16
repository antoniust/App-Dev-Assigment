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
            this.buttonAMBIL = new System.Windows.Forms.Button();
            this.buttonTULIS = new System.Windows.Forms.Button();
            this.textboxNAMA = new System.Windows.Forms.TextBox();
            this.textBoxALAMAT = new System.Windows.Forms.TextBox();
            this.textBoxNOTELP = new System.Windows.Forms.TextBox();
            this.NAMA = new System.Windows.Forms.Label();
            this.labelALAMAT = new System.Windows.Forms.Label();
            this.labelNoTelp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonLIHAT = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.buttonprev = new System.Windows.Forms.Button();
            this.buttonkEMBALI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAMBIL
            // 
            this.buttonAMBIL.Location = new System.Drawing.Point(1183, 498);
            this.buttonAMBIL.Name = "buttonAMBIL";
            this.buttonAMBIL.Size = new System.Drawing.Size(581, 369);
            this.buttonAMBIL.TabIndex = 0;
            this.buttonAMBIL.Text = "buttonAMBIL";
            this.buttonAMBIL.UseVisualStyleBackColor = true;
            this.buttonAMBIL.Click += new System.EventHandler(this.buttonAMBIL_Click);
            // 
            // buttonTULIS
            // 
            this.buttonTULIS.Location = new System.Drawing.Point(379, 515);
            this.buttonTULIS.Name = "buttonTULIS";
            this.buttonTULIS.Size = new System.Drawing.Size(581, 369);
            this.buttonTULIS.TabIndex = 1;
            this.buttonTULIS.Text = "TULIS";
            this.buttonTULIS.UseVisualStyleBackColor = true;
            this.buttonTULIS.Click += new System.EventHandler(this.buttonTULIS_Click);
            // 
            // textboxNAMA
            // 
            this.textboxNAMA.Location = new System.Drawing.Point(315, 94);
            this.textboxNAMA.Name = "textboxNAMA";
            this.textboxNAMA.Size = new System.Drawing.Size(229, 31);
            this.textboxNAMA.TabIndex = 2;
            // 
            // textBoxALAMAT
            // 
            this.textBoxALAMAT.Location = new System.Drawing.Point(315, 131);
            this.textBoxALAMAT.Name = "textBoxALAMAT";
            this.textBoxALAMAT.Size = new System.Drawing.Size(229, 31);
            this.textBoxALAMAT.TabIndex = 3;
            // 
            // textBoxNOTELP
            // 
            this.textBoxNOTELP.Location = new System.Drawing.Point(315, 168);
            this.textBoxNOTELP.Name = "textBoxNOTELP";
            this.textBoxNOTELP.Size = new System.Drawing.Size(229, 31);
            this.textBoxNOTELP.TabIndex = 4;
            // 
            // NAMA
            // 
            this.NAMA.AutoSize = true;
            this.NAMA.Location = new System.Drawing.Point(158, 100);
            this.NAMA.Name = "NAMA";
            this.NAMA.Size = new System.Drawing.Size(73, 25);
            this.NAMA.TabIndex = 5;
            this.NAMA.Text = "NAMA";
            // 
            // labelALAMAT
            // 
            this.labelALAMAT.AutoSize = true;
            this.labelALAMAT.Location = new System.Drawing.Point(158, 137);
            this.labelALAMAT.Name = "labelALAMAT";
            this.labelALAMAT.Size = new System.Drawing.Size(97, 25);
            this.labelALAMAT.TabIndex = 6;
            this.labelALAMAT.Text = "ALAMAT";
            // 
            // labelNoTelp
            // 
            this.labelNoTelp.AutoSize = true;
            this.labelNoTelp.Location = new System.Drawing.Point(158, 174);
            this.labelNoTelp.Name = "labelNoTelp";
            this.labelNoTelp.Size = new System.Drawing.Size(87, 25);
            this.labelNoTelp.TabIndex = 7;
            this.labelNoTelp.Text = "No Telp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(277, 232);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(97, 39);
            this.buttonSimpan.TabIndex = 9;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonLIHAT
            // 
            this.buttonLIHAT.Location = new System.Drawing.Point(390, 232);
            this.buttonLIHAT.Name = "buttonLIHAT";
            this.buttonLIHAT.Size = new System.Drawing.Size(97, 39);
            this.buttonLIHAT.TabIndex = 10;
            this.buttonLIHAT.Text = "Lihat";
            this.buttonLIHAT.UseVisualStyleBackColor = true;
            this.buttonLIHAT.Click += new System.EventHandler(this.buttonLIHAT_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(765, 91);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(97, 34);
            this.buttonFile.TabIndex = 11;
            this.buttonFile.Text = "File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.Location = new System.Drawing.Point(390, 235);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(97, 37);
            this.buttonnext.TabIndex = 12;
            this.buttonnext.Text = "Next";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // buttonprev
            // 
            this.buttonprev.Location = new System.Drawing.Point(277, 235);
            this.buttonprev.Name = "buttonprev";
            this.buttonprev.Size = new System.Drawing.Size(97, 37);
            this.buttonprev.TabIndex = 13;
            this.buttonprev.Text = "Prev";
            this.buttonprev.UseVisualStyleBackColor = true;
            this.buttonprev.Click += new System.EventHandler(this.buttonprev_Click);
            // 
            // buttonkEMBALI
            // 
            this.buttonkEMBALI.Location = new System.Drawing.Point(515, 235);
            this.buttonkEMBALI.Name = "buttonkEMBALI";
            this.buttonkEMBALI.Size = new System.Drawing.Size(97, 36);
            this.buttonkEMBALI.TabIndex = 14;
            this.buttonkEMBALI.Text = "Kembali";
            this.buttonkEMBALI.UseVisualStyleBackColor = true;
            this.buttonkEMBALI.Click += new System.EventHandler(this.buttonkEMBALI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 983);
            this.Controls.Add(this.buttonkEMBALI);
            this.Controls.Add(this.buttonprev);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonLIHAT);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNoTelp);
            this.Controls.Add(this.labelALAMAT);
            this.Controls.Add(this.NAMA);
            this.Controls.Add(this.textBoxNOTELP);
            this.Controls.Add(this.textBoxALAMAT);
            this.Controls.Add(this.textboxNAMA);
            this.Controls.Add(this.buttonTULIS);
            this.Controls.Add(this.buttonAMBIL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAMBIL;
        private System.Windows.Forms.Button buttonTULIS;
        private System.Windows.Forms.TextBox textboxNAMA;
        private System.Windows.Forms.TextBox textBoxALAMAT;
        private System.Windows.Forms.TextBox textBoxNOTELP;
        private System.Windows.Forms.Label NAMA;
        private System.Windows.Forms.Label labelALAMAT;
        private System.Windows.Forms.Label labelNoTelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonLIHAT;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.Button buttonprev;
        private System.Windows.Forms.Button buttonkEMBALI;
    }
}

