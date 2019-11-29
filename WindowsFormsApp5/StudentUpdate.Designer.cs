namespace WindowsFormsApp5
{
    partial class StudentUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentUpdate));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profilTextBox = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.NewPassword = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.PassChngBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 108);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(212, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "UPDATE STUDENT PROFIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "NEW ADDRESS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // profilTextBox
            // 
            this.profilTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilTextBox.Location = new System.Drawing.Point(291, 241);
            this.profilTextBox.Name = "profilTextBox";
            this.profilTextBox.Size = new System.Drawing.Size(287, 29);
            this.profilTextBox.TabIndex = 3;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.SeaShell;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.Color.Blue;
            this.Confirm.Location = new System.Drawing.Point(598, 241);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(136, 31);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "CONFIRM";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkGray;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(44, 370);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(102, 45);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(695, 36);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 16;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.BackColor = System.Drawing.Color.White;
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.Location = new System.Drawing.Point(107, 298);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(168, 24);
            this.NewPassword.TabIndex = 17;
            this.NewPassword.Text = "NEW PASSWORD";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTextBox.Location = new System.Drawing.Point(289, 294);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(287, 29);
            this.PassTextBox.TabIndex = 18;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            // 
            // PassChngBtn
            // 
            this.PassChngBtn.BackColor = System.Drawing.Color.SeaShell;
            this.PassChngBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassChngBtn.ForeColor = System.Drawing.Color.Blue;
            this.PassChngBtn.Location = new System.Drawing.Point(598, 292);
            this.PassChngBtn.Name = "PassChngBtn";
            this.PassChngBtn.Size = new System.Drawing.Size(136, 31);
            this.PassChngBtn.TabIndex = 19;
            this.PassChngBtn.Text = "CHANGE";
            this.PassChngBtn.UseVisualStyleBackColor = false;
            this.PassChngBtn.Click += new System.EventHandler(this.PassChngBtn_Click);
            // 
            // StudentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.PassChngBtn);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.profilTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentUpdate";
            this.Text = "StudentUpdate";
            this.Load += new System.EventHandler(this.StudentUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profilTextBox;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Button PassChngBtn;
    }
}