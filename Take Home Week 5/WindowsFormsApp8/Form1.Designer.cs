namespace WindowsFormsApp8
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
            this.dataGridViewPRODUK = new System.Windows.Forms.DataGridView();
            this.comBoxFilterCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCATEGORY = new System.Windows.Forms.Button();
            this.comboBoxCategoryPRODUK = new System.Windows.Forms.ComboBox();
            this.textBoxNamaPRODUK = new System.Windows.Forms.TextBox();
            this.textBoxStockPRODUK = new System.Windows.Forms.TextBox();
            this.dataGridViewCATEGORY = new System.Windows.Forms.DataGridView();
            this.lblIputNamaCategory = new System.Windows.Forms.Label();
            this.btnRemoveCATEGORY = new System.Windows.Forms.Button();
            this.btnAddPRODUK = new System.Windows.Forms.Button();
            this.btnEditPRODUK = new System.Windows.Forms.Button();
            this.btnRemovePRODUK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFILTER = new System.Windows.Forms.Button();
            this.textBoxHargaProduk = new System.Windows.Forms.TextBox();
            this.textBoxNamaCATEGORY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCATEGORY)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewPRODUK
            // 
            this.dataGridViewPRODUK.AllowUserToAddRows = false;
            this.dataGridViewPRODUK.AllowUserToDeleteRows = false;
            this.dataGridViewPRODUK.AllowUserToResizeColumns = false;
            this.dataGridViewPRODUK.AllowUserToResizeRows = false;
            this.dataGridViewPRODUK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUK.Location = new System.Drawing.Point(73, 69);
            this.dataGridViewPRODUK.Name = "dataGridViewPRODUK";
            this.dataGridViewPRODUK.ReadOnly = true;
            this.dataGridViewPRODUK.RowHeadersVisible = false;
            this.dataGridViewPRODUK.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPRODUK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPRODUK.Size = new System.Drawing.Size(412, 204);
            this.dataGridViewPRODUK.TabIndex = 1;
            this.dataGridViewPRODUK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPRODUK_CellClick);
            this.dataGridViewPRODUK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPRODUK_CellContentClick);
            // 
            // comBoxFilterCat
            // 
            this.comBoxFilterCat.Enabled = false;
            this.comBoxFilterCat.FormattingEnabled = true;
            this.comBoxFilterCat.Location = new System.Drawing.Point(364, 39);
            this.comBoxFilterCat.Name = "comBoxFilterCat";
            this.comBoxFilterCat.Size = new System.Drawing.Size(121, 21);
            this.comBoxFilterCat.TabIndex = 2;
            this.comBoxFilterCat.SelectedIndexChanged += new System.EventHandler(this.comBoxFilterCat_SelectedIndexChanged);
            this.comBoxFilterCat.DisplayMemberChanged += new System.EventHandler(this.comBoxFilterCat_DisplayMemberChanged);
            this.comBoxFilterCat.Click += new System.EventHandler(this.comBoxFilterCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODUCT";
            // 
            // btnAddCATEGORY
            // 
            this.btnAddCATEGORY.Location = new System.Drawing.Point(589, 304);
            this.btnAddCATEGORY.Name = "btnAddCATEGORY";
            this.btnAddCATEGORY.Size = new System.Drawing.Size(65, 52);
            this.btnAddCATEGORY.TabIndex = 7;
            this.btnAddCATEGORY.Text = "Add Category";
            this.btnAddCATEGORY.UseVisualStyleBackColor = true;
            this.btnAddCATEGORY.Click += new System.EventHandler(this.btnAddCATEGORY_Click);
            // 
            // comboBoxCategoryPRODUK
            // 
            this.comboBoxCategoryPRODUK.FormattingEnabled = true;
            this.comboBoxCategoryPRODUK.Location = new System.Drawing.Point(114, 348);
            this.comboBoxCategoryPRODUK.Name = "comboBoxCategoryPRODUK";
            this.comboBoxCategoryPRODUK.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoryPRODUK.TabIndex = 11;
            this.comboBoxCategoryPRODUK.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryPRODUK_SelectedIndexChanged);
            this.comboBoxCategoryPRODUK.Click += new System.EventHandler(this.comboBoxCategoryPRODUK_Click);
            // 
            // textBoxNamaPRODUK
            // 
            this.textBoxNamaPRODUK.Location = new System.Drawing.Point(114, 321);
            this.textBoxNamaPRODUK.Name = "textBoxNamaPRODUK";
            this.textBoxNamaPRODUK.Size = new System.Drawing.Size(202, 20);
            this.textBoxNamaPRODUK.TabIndex = 12;
            // 
            // textBoxStockPRODUK
            // 
            this.textBoxStockPRODUK.Location = new System.Drawing.Point(114, 403);
            this.textBoxStockPRODUK.Name = "textBoxStockPRODUK";
            this.textBoxStockPRODUK.Size = new System.Drawing.Size(121, 20);
            this.textBoxStockPRODUK.TabIndex = 14;
            this.textBoxStockPRODUK.TextChanged += new System.EventHandler(this.textBoxStockPRODUK_TextChanged);
            // 
            // dataGridViewCATEGORY
            // 
            this.dataGridViewCATEGORY.AllowUserToAddRows = false;
            this.dataGridViewCATEGORY.AllowUserToDeleteRows = false;
            this.dataGridViewCATEGORY.AllowUserToResizeColumns = false;
            this.dataGridViewCATEGORY.AllowUserToResizeRows = false;
            this.dataGridViewCATEGORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCATEGORY.Location = new System.Drawing.Point(548, 69);
            this.dataGridViewCATEGORY.Name = "dataGridViewCATEGORY";
            this.dataGridViewCATEGORY.ReadOnly = true;
            this.dataGridViewCATEGORY.RowHeadersVisible = false;
            this.dataGridViewCATEGORY.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCATEGORY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCATEGORY.Size = new System.Drawing.Size(197, 191);
            this.dataGridViewCATEGORY.TabIndex = 15;
            this.dataGridViewCATEGORY.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCATEGORY_CellClick);
            this.dataGridViewCATEGORY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCATEGORY_CellContentClick);
            // 
            // lblIputNamaCategory
            // 
            this.lblIputNamaCategory.AutoSize = true;
            this.lblIputNamaCategory.Location = new System.Drawing.Point(529, 273);
            this.lblIputNamaCategory.Name = "lblIputNamaCategory";
            this.lblIputNamaCategory.Size = new System.Drawing.Size(41, 13);
            this.lblIputNamaCategory.TabIndex = 16;
            this.lblIputNamaCategory.Text = "Nama :";
            // 
            // btnRemoveCATEGORY
            // 
            this.btnRemoveCATEGORY.Location = new System.Drawing.Point(660, 304);
            this.btnRemoveCATEGORY.Name = "btnRemoveCATEGORY";
            this.btnRemoveCATEGORY.Size = new System.Drawing.Size(65, 52);
            this.btnRemoveCATEGORY.TabIndex = 17;
            this.btnRemoveCATEGORY.Text = "Remove Category";
            this.btnRemoveCATEGORY.UseVisualStyleBackColor = true;
            this.btnRemoveCATEGORY.Click += new System.EventHandler(this.btnRemoveCATEGORY_Click);
            // 
            // btnAddPRODUK
            // 
            this.btnAddPRODUK.Location = new System.Drawing.Point(278, 348);
            this.btnAddPRODUK.Name = "btnAddPRODUK";
            this.btnAddPRODUK.Size = new System.Drawing.Size(65, 52);
            this.btnAddPRODUK.TabIndex = 18;
            this.btnAddPRODUK.Text = "Add Produk";
            this.btnAddPRODUK.UseVisualStyleBackColor = true;
            this.btnAddPRODUK.Click += new System.EventHandler(this.btnAddPRODUK_Click);
            // 
            // btnEditPRODUK
            // 
            this.btnEditPRODUK.Location = new System.Drawing.Point(349, 348);
            this.btnEditPRODUK.Name = "btnEditPRODUK";
            this.btnEditPRODUK.Size = new System.Drawing.Size(65, 52);
            this.btnEditPRODUK.TabIndex = 19;
            this.btnEditPRODUK.Text = "Edit Produk";
            this.btnEditPRODUK.UseVisualStyleBackColor = true;
            this.btnEditPRODUK.Click += new System.EventHandler(this.btnEditPRODUK_Click);
            // 
            // btnRemovePRODUK
            // 
            this.btnRemovePRODUK.Location = new System.Drawing.Point(420, 348);
            this.btnRemovePRODUK.Name = "btnRemovePRODUK";
            this.btnRemovePRODUK.Size = new System.Drawing.Size(65, 52);
            this.btnRemovePRODUK.TabIndex = 20;
            this.btnRemovePRODUK.Text = "Remove Produk";
            this.btnRemovePRODUK.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Harga :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Stock :";
            // 
            // buttonFILTER
            // 
            this.buttonFILTER.Location = new System.Drawing.Point(306, 38);
            this.buttonFILTER.Name = "buttonFILTER";
            this.buttonFILTER.Size = new System.Drawing.Size(37, 21);
            this.buttonFILTER.TabIndex = 25;
            this.buttonFILTER.Text = "Filter :";
            this.buttonFILTER.UseVisualStyleBackColor = true;
            this.buttonFILTER.Click += new System.EventHandler(this.buttonFILTER_Click);
            // 
            // textBoxHargaProduk
            // 
            this.textBoxHargaProduk.Location = new System.Drawing.Point(114, 375);
            this.textBoxHargaProduk.Name = "textBoxHargaProduk";
            this.textBoxHargaProduk.Size = new System.Drawing.Size(121, 20);
            this.textBoxHargaProduk.TabIndex = 26;
            this.textBoxHargaProduk.TextChanged += new System.EventHandler(this.textBoxHargaProduk_TextChanged);
            // 
            // textBoxNamaCATEGORY
            // 
            this.textBoxNamaCATEGORY.Location = new System.Drawing.Point(589, 270);
            this.textBoxNamaCATEGORY.Name = "textBoxNamaCATEGORY";
            this.textBoxNamaCATEGORY.Size = new System.Drawing.Size(121, 20);
            this.textBoxNamaCATEGORY.TabIndex = 27;
            this.textBoxNamaCATEGORY.TextChanged += new System.EventHandler(this.textBoxNamaCATEGORY_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNamaCATEGORY);
            this.Controls.Add(this.textBoxHargaProduk);
            this.Controls.Add(this.buttonFILTER);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemovePRODUK);
            this.Controls.Add(this.btnEditPRODUK);
            this.Controls.Add(this.btnAddPRODUK);
            this.Controls.Add(this.btnRemoveCATEGORY);
            this.Controls.Add(this.lblIputNamaCategory);
            this.Controls.Add(this.dataGridViewCATEGORY);
            this.Controls.Add(this.textBoxStockPRODUK);
            this.Controls.Add(this.textBoxNamaPRODUK);
            this.Controls.Add(this.comboBoxCategoryPRODUK);
            this.Controls.Add(this.btnAddCATEGORY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxFilterCat);
            this.Controls.Add(this.dataGridViewPRODUK);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCATEGORY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPRODUK;
        private System.Windows.Forms.ComboBox comBoxFilterCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCATEGORY;
        private System.Windows.Forms.ComboBox comboBoxCategoryPRODUK;
        private System.Windows.Forms.TextBox textBoxNamaPRODUK;
        private System.Windows.Forms.TextBox textBoxStockPRODUK;
        private System.Windows.Forms.DataGridView dataGridViewCATEGORY;
        private System.Windows.Forms.Label lblIputNamaCategory;
        private System.Windows.Forms.Button btnRemoveCATEGORY;
        private System.Windows.Forms.Button btnAddPRODUK;
        private System.Windows.Forms.Button btnEditPRODUK;
        private System.Windows.Forms.Button btnRemovePRODUK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFILTER;
        private System.Windows.Forms.TextBox textBoxHargaProduk;
        private System.Windows.Forms.TextBox textBoxNamaCATEGORY;
    }
}

