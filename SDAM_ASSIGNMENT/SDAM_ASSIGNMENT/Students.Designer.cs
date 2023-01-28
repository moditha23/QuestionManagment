namespace SDAM_ASSIGNMENT
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.CandidatesDGV = new System.Windows.Forms.DataGridView();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.CAgeTb = new System.Windows.Forms.TextBox();
            this.CNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CandidatesDGV
            // 
            this.CandidatesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CandidatesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CandidatesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CandidatesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CandidatesDGV.Location = new System.Drawing.Point(100, 313);
            this.CandidatesDGV.Name = "CandidatesDGV";
            this.CandidatesDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CandidatesDGV.RowTemplate.Height = 25;
            this.CandidatesDGV.Size = new System.Drawing.Size(920, 300);
            this.CandidatesDGV.StandardTab = true;
            this.CandidatesDGV.TabIndex = 43;
            this.CandidatesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CandidatesDGV_CellContentClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.Location = new System.Drawing.Point(644, 252);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(81, 40);
            this.ResetBtn.TabIndex = 42;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(701, 186);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(371, 23);
            this.PhoneTb.TabIndex = 41;
            this.PhoneTb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(701, 145);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(371, 23);
            this.AddressTb.TabIndex = 40;
            this.AddressTb.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(209, 186);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(251, 23);
            this.PasswordTb.TabIndex = 39;
            this.PasswordTb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CAgeTb
            // 
            this.CAgeTb.Location = new System.Drawing.Point(209, 145);
            this.CAgeTb.Name = "CAgeTb";
            this.CAgeTb.Size = new System.Drawing.Size(251, 23);
            this.CAgeTb.TabIndex = 37;
            this.CAgeTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CNameTb
            // 
            this.CNameTb.Location = new System.Drawing.Point(209, 105);
            this.CNameTb.Name = "CNameTb";
            this.CNameTb.Size = new System.Drawing.Size(863, 23);
            this.CNameTb.TabIndex = 36;
            this.CNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(560, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "PHONE";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(560, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "ADDRESS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(49, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 31;
            this.label8.Text = "NAME";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(49, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 32);
            this.label7.TabIndex = 30;
            this.label7.Text = "AGE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(49, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "PASSWORD";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(422, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "STUDENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(268, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "SUBJECTS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUESTIONS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(527, 252);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 40);
            this.EditBtn.TabIndex = 24;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(400, 252);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(85, 40);
            this.SaveBtn.TabIndex = 23;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 655);
            this.Controls.Add(this.CandidatesDGV);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.CAgeTb);
            this.Controls.Add(this.CNameTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.CandidatesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView CandidatesDGV;
        private Button ResetBtn;
        private TextBox PhoneTb;
        private TextBox AddressTb;
        private TextBox PasswordTb;
        private TextBox CAgeTb;
        private TextBox CNameTb;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button EditBtn;
        private Button SaveBtn;
    }
}