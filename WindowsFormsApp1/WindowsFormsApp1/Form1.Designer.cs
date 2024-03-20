namespace WindowsFormsApp1
{
    partial class Form_premier
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
            this.components = new System.ComponentModel.Container();
            this.tb_tim = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_namat = new System.Windows.Forms.TextBox();
            this.tb_stadium = new System.Windows.Forms.TextBox();
            this.tb_kapasitas = new System.Windows.Forms.TextBox();
            this.tb_kota = new System.Windows.Forms.TextBox();
            this.lb_tim = new System.Windows.Forms.Label();
            this.lb_namat = new System.Windows.Forms.Label();
            this.lb_stadium = new System.Windows.Forms.Label();
            this.lb_kapasitas = new System.Windows.Forms.Label();
            this.lb_kota = new System.Windows.Forms.Label();
            this.lb_manager = new System.Windows.Forms.Label();
            this.tb_manager = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_input = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tim
            // 
            this.tb_tim.Enabled = false;
            this.tb_tim.Location = new System.Drawing.Point(230, 61);
            this.tb_tim.Name = "tb_tim";
            this.tb_tim.Size = new System.Drawing.Size(172, 31);
            this.tb_tim.TabIndex = 0;
            this.tb_tim.TextChanged += new System.EventHandler(this.tb_tim_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_namat
            // 
            this.tb_namat.Location = new System.Drawing.Point(230, 127);
            this.tb_namat.Name = "tb_namat";
            this.tb_namat.Size = new System.Drawing.Size(172, 31);
            this.tb_namat.TabIndex = 2;
            this.tb_namat.TextChanged += new System.EventHandler(this.tb_namat_TextChanged);
            // 
            // tb_stadium
            // 
            this.tb_stadium.Location = new System.Drawing.Point(230, 182);
            this.tb_stadium.Name = "tb_stadium";
            this.tb_stadium.Size = new System.Drawing.Size(172, 31);
            this.tb_stadium.TabIndex = 3;
            this.tb_stadium.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_kapasitas
            // 
            this.tb_kapasitas.Location = new System.Drawing.Point(230, 245);
            this.tb_kapasitas.Name = "tb_kapasitas";
            this.tb_kapasitas.Size = new System.Drawing.Size(172, 31);
            this.tb_kapasitas.TabIndex = 4;
            // 
            // tb_kota
            // 
            this.tb_kota.Location = new System.Drawing.Point(230, 302);
            this.tb_kota.Name = "tb_kota";
            this.tb_kota.Size = new System.Drawing.Size(172, 31);
            this.tb_kota.TabIndex = 5;
            this.tb_kota.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lb_tim
            // 
            this.lb_tim.AutoSize = true;
            this.lb_tim.Location = new System.Drawing.Point(34, 67);
            this.lb_tim.Name = "lb_tim";
            this.lb_tim.Size = new System.Drawing.Size(70, 25);
            this.lb_tim.TabIndex = 6;
            this.lb_tim.Text = "Tim id";
            this.lb_tim.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_namat
            // 
            this.lb_namat.AutoSize = true;
            this.lb_namat.Location = new System.Drawing.Point(34, 127);
            this.lb_namat.Name = "lb_namat";
            this.lb_namat.Size = new System.Drawing.Size(102, 25);
            this.lb_namat.TabIndex = 7;
            this.lb_namat.Text = "Nama tim";
            this.lb_namat.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_stadium
            // 
            this.lb_stadium.AutoSize = true;
            this.lb_stadium.Location = new System.Drawing.Point(34, 188);
            this.lb_stadium.Name = "lb_stadium";
            this.lb_stadium.Size = new System.Drawing.Size(152, 25);
            this.lb_stadium.TabIndex = 8;
            this.lb_stadium.Text = "Nama Stadium";
            // 
            // lb_kapasitas
            // 
            this.lb_kapasitas.AutoSize = true;
            this.lb_kapasitas.Location = new System.Drawing.Point(34, 251);
            this.lb_kapasitas.Name = "lb_kapasitas";
            this.lb_kapasitas.Size = new System.Drawing.Size(107, 25);
            this.lb_kapasitas.TabIndex = 9;
            this.lb_kapasitas.Text = "Kapasitas";
            // 
            // lb_kota
            // 
            this.lb_kota.AutoSize = true;
            this.lb_kota.Location = new System.Drawing.Point(34, 308);
            this.lb_kota.Name = "lb_kota";
            this.lb_kota.Size = new System.Drawing.Size(56, 25);
            this.lb_kota.TabIndex = 10;
            this.lb_kota.Text = "Kota";
            // 
            // lb_manager
            // 
            this.lb_manager.AutoSize = true;
            this.lb_manager.Location = new System.Drawing.Point(34, 369);
            this.lb_manager.Name = "lb_manager";
            this.lb_manager.Size = new System.Drawing.Size(158, 25);
            this.lb_manager.TabIndex = 11;
            this.lb_manager.Text = "Nama manager";
            // 
            // tb_manager
            // 
            this.tb_manager.Location = new System.Drawing.Point(230, 366);
            this.tb_manager.Name = "tb_manager";
            this.tb_manager.Size = new System.Drawing.Size(172, 31);
            this.tb_manager.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(553, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 588);
            this.dataGridView1.TabIndex = 13;
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(249, 431);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(97, 46);
            this.bt_input.TabIndex = 14;
            this.bt_input.Text = "input";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // Form_premier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2018, 987);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_manager);
            this.Controls.Add(this.lb_manager);
            this.Controls.Add(this.lb_kota);
            this.Controls.Add(this.lb_kapasitas);
            this.Controls.Add(this.lb_stadium);
            this.Controls.Add(this.lb_namat);
            this.Controls.Add(this.lb_tim);
            this.Controls.Add(this.tb_kota);
            this.Controls.Add(this.tb_kapasitas);
            this.Controls.Add(this.tb_stadium);
            this.Controls.Add(this.tb_namat);
            this.Controls.Add(this.tb_tim);
            this.Name = "Form_premier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tim;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_namat;
        private System.Windows.Forms.TextBox tb_stadium;
        private System.Windows.Forms.TextBox tb_kapasitas;
        private System.Windows.Forms.TextBox tb_kota;
        private System.Windows.Forms.Label lb_tim;
        private System.Windows.Forms.Label lb_namat;
        private System.Windows.Forms.Label lb_stadium;
        private System.Windows.Forms.Label lb_kapasitas;
        private System.Windows.Forms.Label lb_kota;
        private System.Windows.Forms.Label lb_manager;
        private System.Windows.Forms.TextBox tb_manager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_input;
    }
}

