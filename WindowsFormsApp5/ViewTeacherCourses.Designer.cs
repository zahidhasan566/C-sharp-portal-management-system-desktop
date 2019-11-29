namespace WindowsFormsApp5
{
    partial class ViewTeacherCourses
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tBackBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeacherCourses = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "View My Courses:";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(669, 10);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 20;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // tBackBtn
            // 
            this.tBackBtn.BackColor = System.Drawing.Color.Lime;
            this.tBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBackBtn.Location = new System.Drawing.Point(567, 11);
            this.tBackBtn.Name = "tBackBtn";
            this.tBackBtn.Size = new System.Drawing.Size(80, 29);
            this.tBackBtn.TabIndex = 21;
            this.tBackBtn.Text = "BACK";
            this.tBackBtn.UseVisualStyleBackColor = false;
            this.tBackBtn.Click += new System.EventHandler(this.tBackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.LogoutBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tBackBtn);
            this.panel1.Controls.Add(this.TeacherCourses);
            this.panel1.Location = new System.Drawing.Point(6, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 565);
            this.panel1.TabIndex = 23;
            // 
            // TeacherCourses
            // 
            this.TeacherCourses.AllowUserToAddRows = false;
            this.TeacherCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherCourses.Location = new System.Drawing.Point(28, 65);
            this.TeacherCourses.Name = "TeacherCourses";
            this.TeacherCourses.Size = new System.Drawing.Size(721, 259);
            this.TeacherCourses.TabIndex = 0;
            this.TeacherCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewTeacherCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ViewTeacherCourses";
            this.Text = "ViewTeacherCourses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button tBackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TeacherCourses;
    }
}