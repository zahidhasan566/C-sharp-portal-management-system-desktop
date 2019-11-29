namespace WindowsFormsApp5
{
    partial class StudentInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBackBtn = new System.Windows.Forms.Button();
            this.StudentCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(702, 30);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 24;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Student Information:";
            // 
            // tBackBtn
            // 
            this.tBackBtn.BackColor = System.Drawing.Color.Lime;
            this.tBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBackBtn.Location = new System.Drawing.Point(616, 29);
            this.tBackBtn.Name = "tBackBtn";
            this.tBackBtn.Size = new System.Drawing.Size(80, 29);
            this.tBackBtn.TabIndex = 25;
            this.tBackBtn.Text = "BACK";
            this.tBackBtn.UseVisualStyleBackColor = false;
            this.tBackBtn.Click += new System.EventHandler(this.tBackBtn_Click);
            // 
            // StudentCourses
            // 
            this.StudentCourses.AllowUserToAddRows = false;
            this.StudentCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentCourses.Location = new System.Drawing.Point(42, 123);
            this.StudentCourses.Name = "StudentCourses";
            this.StudentCourses.Size = new System.Drawing.Size(721, 259);
            this.StudentCourses.TabIndex = 23;
            this.StudentCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentCourses_CellContentClick);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBackBtn);
            this.Controls.Add(this.StudentCourses);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tBackBtn;
        private System.Windows.Forms.DataGridView StudentCourses;
    }
}