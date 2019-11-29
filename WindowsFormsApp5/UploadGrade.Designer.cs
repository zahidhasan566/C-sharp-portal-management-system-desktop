namespace WindowsFormsApp5
{
    partial class UploadGrade
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
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tBackBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.Label();
            this.StudentIdlabel = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SubjBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MarkBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(683, 47);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 26;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // tBackBtn
            // 
            this.tBackBtn.BackColor = System.Drawing.Color.Lime;
            this.tBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBackBtn.Location = new System.Drawing.Point(581, 48);
            this.tBackBtn.Name = "tBackBtn";
            this.tBackBtn.Size = new System.Drawing.Size(80, 29);
            this.tBackBtn.TabIndex = 27;
            this.tBackBtn.Text = "BACK";
            this.tBackBtn.UseVisualStyleBackColor = false;
            this.tBackBtn.Click += new System.EventHandler(this.tBackBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 169);
            this.dataGridView1.TabIndex = 28;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(67, 25);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(46, 13);
            this.Subject.TabIndex = 29;
            this.Subject.Text = "Subject:";
            // 
            // StudentIdlabel
            // 
            this.StudentIdlabel.AutoSize = true;
            this.StudentIdlabel.Location = new System.Drawing.Point(52, 63);
            this.StudentIdlabel.Name = "StudentIdlabel";
            this.StudentIdlabel.Size = new System.Drawing.Size(61, 13);
            this.StudentIdlabel.TabIndex = 30;
            this.StudentIdlabel.Text = "Student ID:";
            this.StudentIdlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(643, 372);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(119, 38);
            this.ConfirmBtn.TabIndex = 33;
            this.ConfirmBtn.Text = "CONFIRM";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(119, 61);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(121, 20);
            this.IdBox.TabIndex = 34;
            // 
            // SubjBox
            // 
            this.SubjBox.Location = new System.Drawing.Point(119, 22);
            this.SubjBox.Name = "SubjBox";
            this.SubjBox.Size = new System.Drawing.Size(121, 20);
            this.SubjBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "GRADE";
            // 
            // MarkBox
            // 
            this.MarkBox.Location = new System.Drawing.Point(119, 129);
            this.MarkBox.Name = "MarkBox";
            this.MarkBox.ReadOnly = true;
            this.MarkBox.Size = new System.Drawing.Size(100, 20);
            this.MarkBox.TabIndex = 38;
            this.MarkBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "MARK";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UploadGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MarkBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.StudentIdlabel);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.tBackBtn);
            this.Name = "UploadGrade";
            this.Text = "UploadGrade";
            this.Load += new System.EventHandler(this.UploadGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button tBackBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label StudentIdlabel;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox SubjBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MarkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}