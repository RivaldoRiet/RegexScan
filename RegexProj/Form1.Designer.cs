namespace RegexProj
{
    partial class RietEmailExtracter
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.aevionCheckBox1 = new Aevion_r2.AevionCheckBox();
            this.aevionForm1 = new Aevion_r2.AevionForm();
            this.aevionLabel1 = new Aevion_r2.AevionLabel();
            this.aevionLabel2 = new Aevion_r2.AevionLabel();
            this.aevionLabel3 = new Aevion_r2.AevionLabel();
            this.aevionLabel4 = new Aevion_r2.AevionLabel();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(208, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 251);
            this.listBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "Plaintext"});
            this.comboBox1.Location = new System.Drawing.Point(15, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "nl",
            "be",
            "ru",
            "com"});
            this.comboBox2.Location = new System.Drawing.Point(98, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(38, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load Database // Combolist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // aevionCheckBox1
            // 
            this.aevionCheckBox1.Checked = false;
            this.aevionCheckBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aevionCheckBox1.Location = new System.Drawing.Point(15, 72);
            this.aevionCheckBox1.Name = "aevionCheckBox1";
            this.aevionCheckBox1.Size = new System.Drawing.Size(132, 16);
            this.aevionCheckBox1.TabIndex = 16;
            this.aevionCheckBox1.Text = "Use filter?";
            this.aevionCheckBox1.Click += new System.EventHandler(this.aevionCheckBox1_Click);
            // 
            // aevionForm1
            // 
            this.aevionForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.aevionForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aevionForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aevionForm1.ForeColor = System.Drawing.Color.White;
            this.aevionForm1.Location = new System.Drawing.Point(0, 0);
            this.aevionForm1.Name = "aevionForm1";
            this.aevionForm1.Size = new System.Drawing.Size(465, 325);
            this.aevionForm1.TabIndex = 15;
            this.aevionForm1.Text = "aevionForm1";
            // 
            // aevionLabel1
            // 
            this.aevionLabel1.AutoSize = true;
            this.aevionLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.aevionLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aevionLabel1.ForeColor = System.Drawing.Color.White;
            this.aevionLabel1.Location = new System.Drawing.Point(12, 54);
            this.aevionLabel1.Name = "aevionLabel1";
            this.aevionLabel1.Size = new System.Drawing.Size(190, 15);
            this.aevionLabel1.TabIndex = 17;
            this.aevionLabel1.Text = "Filter email extension (.com or .ru):";
            // 
            // aevionLabel2
            // 
            this.aevionLabel2.AutoSize = true;
            this.aevionLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.aevionLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aevionLabel2.ForeColor = System.Drawing.Color.White;
            this.aevionLabel2.Location = new System.Drawing.Point(12, 54);
            this.aevionLabel2.Name = "aevionLabel2";
            this.aevionLabel2.Size = new System.Drawing.Size(190, 15);
            this.aevionLabel2.TabIndex = 17;
            this.aevionLabel2.Text = "Filter email extension (.com or .ru):";
            // 
            // aevionLabel3
            // 
            this.aevionLabel3.AutoSize = true;
            this.aevionLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.aevionLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aevionLabel3.ForeColor = System.Drawing.Color.White;
            this.aevionLabel3.Location = new System.Drawing.Point(12, 108);
            this.aevionLabel3.Name = "aevionLabel3";
            this.aevionLabel3.Size = new System.Drawing.Size(60, 15);
            this.aevionLabel3.TabIndex = 18;
            this.aevionLabel3.Text = "Hashtype:";
            // 
            // aevionLabel4
            // 
            this.aevionLabel4.AutoSize = true;
            this.aevionLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.aevionLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aevionLabel4.ForeColor = System.Drawing.Color.White;
            this.aevionLabel4.Location = new System.Drawing.Point(12, 192);
            this.aevionLabel4.Name = "aevionLabel4";
            this.aevionLabel4.Size = new System.Drawing.Size(116, 15);
            this.aevionLabel4.TabIndex = 19;
            this.aevionLabel4.Text = "Waiting for text file...";
            // 
            // RietEmailExtracter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 325);
            this.Controls.Add(this.aevionLabel4);
            this.Controls.Add(this.aevionLabel3);
            this.Controls.Add(this.aevionLabel2);
            this.Controls.Add(this.aevionLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.aevionCheckBox1);
            this.Controls.Add(this.aevionForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RietEmailExtracter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RietEmailExtracter";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.RietEmailExtracter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Aevion_r2.AevionForm aevionForm1;
        private Aevion_r2.AevionCheckBox aevionCheckBox1;
        private Aevion_r2.AevionLabel aevionLabel1;
        private Aevion_r2.AevionLabel aevionLabel2;
        private Aevion_r2.AevionLabel aevionLabel3;
        private Aevion_r2.AevionLabel aevionLabel4;
    }
}

