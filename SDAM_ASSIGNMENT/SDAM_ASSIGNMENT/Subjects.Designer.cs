namespace SDAM_ASSIGNMENT
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SubjectsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.Location = new System.Drawing.Point(645, 162);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(81, 40);
            this.ResetBtn.TabIndex = 59;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SNameTb
            // 
            this.SNameTb.Location = new System.Drawing.Point(252, 105);
            this.SNameTb.Name = "SNameTb";
            this.SNameTb.Size = new System.Drawing.Size(828, 23);
            this.SNameTb.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(55, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 32);
            this.label8.TabIndex = 51;
            this.label8.Text = "SUBJECT NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(425, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 48;
            this.label3.Text = "STUDENTS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(271, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "SUBJECTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "QUESTIONS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(528, 162);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 40);
            this.EditBtn.TabIndex = 45;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(401, 162);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(85, 40);
            this.SaveBtn.TabIndex = 44;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SubjectsDGV
            // 
            this.SubjectsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjectsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SubjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsDGV.Location = new System.Drawing.Point(174, 232);
            this.SubjectsDGV.Name = "SubjectsDGV";
            this.SubjectsDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SubjectsDGV.RowTemplate.Height = 25;
            this.SubjectsDGV.Size = new System.Drawing.Size(771, 300);
            this.SubjectsDGV.StandardTab = true;
            this.SubjectsDGV.TabIndex = 60;
            this.SubjectsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectsDGV_CellContentClick);
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 655);
            this.Controls.Add(this.SubjectsDGV);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SNameTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ResetBtn;
        private TextBox SNameTb;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button EditBtn;
        private Button SaveBtn;
        private DataGridView SubjectsDGV;
    }
}