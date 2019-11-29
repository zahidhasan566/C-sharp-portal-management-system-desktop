namespace WindowsFormsApp5
{
    partial class Student_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_1));
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.TeacherInfoBtn = new System.Windows.Forms.Button();
            this.CompleteCourseBtn = new System.Windows.Forms.Button();
            this.CourseTakenBtn = new System.Windows.Forms.Button();
            this.AvailableBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(183, 319);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(436, 47);
            this.UpdateBtn.TabIndex = 16;
            this.UpdateBtn.Text = "UPDATE PROFILE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(690, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 15;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // TeacherInfoBtn
            // 
            this.TeacherInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TeacherInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TeacherInfoBtn.Location = new System.Drawing.Point(183, 258);
            this.TeacherInfoBtn.Name = "TeacherInfoBtn";
            this.TeacherInfoBtn.Size = new System.Drawing.Size(436, 47);
            this.TeacherInfoBtn.TabIndex = 14;
            this.TeacherInfoBtn.Text = "TEACHER INFORMATION";
            this.TeacherInfoBtn.UseVisualStyleBackColor = false;
            this.TeacherInfoBtn.Click += new System.EventHandler(this.TeacherInfoBtn_Click);
            // 
            // CompleteCourseBtn
            // 
            this.CompleteCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CompleteCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteCourseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CompleteCourseBtn.Location = new System.Drawing.Point(183, 201);
            this.CompleteCourseBtn.Name = "CompleteCourseBtn";
            this.CompleteCourseBtn.Size = new System.Drawing.Size(436, 47);
            this.CompleteCourseBtn.TabIndex = 13;
            this.CompleteCourseBtn.Text = " COMPLETED COURSES";
            this.CompleteCourseBtn.UseVisualStyleBackColor = false;
            this.CompleteCourseBtn.Click += new System.EventHandler(this.CompleteCourseBtn_Click);
            // 
            // CourseTakenBtn
            // 
            this.CourseTakenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CourseTakenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseTakenBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseTakenBtn.Location = new System.Drawing.Point(183, 139);
            this.CourseTakenBtn.Name = "CourseTakenBtn";
            this.CourseTakenBtn.Size = new System.Drawing.Size(436, 47);
            this.CourseTakenBtn.TabIndex = 11;
            this.CourseTakenBtn.Text = " COURSES TAKEN";
            this.CourseTakenBtn.UseVisualStyleBackColor = false;
            this.CourseTakenBtn.Click += new System.EventHandler(this.CourseTakenBtn_Click);
            // 
            // AvailableBtn
            // 
            this.AvailableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AvailableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvailableBtn.Location = new System.Drawing.Point(183, 77);
            this.AvailableBtn.Name = "AvailableBtn";
            this.AvailableBtn.Size = new System.Drawing.Size(436, 47);
            this.AvailableBtn.TabIndex = 10;
            this.AvailableBtn.Text = "AVAILABLE COURSES";
            this.AvailableBtn.UseVisualStyleBackColor = false;
            this.AvailableBtn.Click += new System.EventHandler(this.AvailableBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "SRUDENT DASHBOARD:";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(183, 380);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(436, 47);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "REQUEST TO DELETE A PROFILE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Student_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.TeacherInfoBtn);
            this.Controls.Add(this.CompleteCourseBtn);
            this.Controls.Add(this.CourseTakenBtn);
            this.Controls.Add(this.AvailableBtn);
            this.Controls.Add(this.label1);
            this.Name = "Student_1";
            this.Text = "Student_1";
            this.Load += new System.EventHandler(this.Student_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button TeacherInfoBtn;
        private System.Windows.Forms.Button CompleteCourseBtn;
        private System.Windows.Forms.Button CourseTakenBtn;
        private System.Windows.Forms.Button AvailableBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBtn;
    }
}