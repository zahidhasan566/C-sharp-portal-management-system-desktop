namespace WindowsFormsApp5
{
    partial class TeacherDashBoard
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.StudentInformationBtn = new System.Windows.Forms.Button();
            this.UploadGradeBtn = new System.Windows.Forms.Button();
            this.VIEWTEACHERCOURSESBtn = new System.Windows.Forms.Button();
            this.AvailableBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.Location = new System.Drawing.Point(183, 386);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(436, 47);
            this.DeleteBtn.TabIndex = 25;
            this.DeleteBtn.Text = "REQUEST TO DELETE A PROFILE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(183, 325);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(436, 47);
            this.UpdateBtn.TabIndex = 24;
            this.UpdateBtn.Text = "UPDATE PROFILE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(616, 29);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 23;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // StudentInformationBtn
            // 
            this.StudentInformationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StudentInformationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInformationBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentInformationBtn.Location = new System.Drawing.Point(183, 264);
            this.StudentInformationBtn.Name = "StudentInformationBtn";
            this.StudentInformationBtn.Size = new System.Drawing.Size(436, 47);
            this.StudentInformationBtn.TabIndex = 22;
            this.StudentInformationBtn.Text = "STUDENT INFORMATION";
            this.StudentInformationBtn.UseVisualStyleBackColor = false;
            this.StudentInformationBtn.Click += new System.EventHandler(this.StudentInfoBtn_Click);
            // 
            // UploadGradeBtn
            // 
            this.UploadGradeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UploadGradeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadGradeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadGradeBtn.Location = new System.Drawing.Point(183, 207);
            this.UploadGradeBtn.Name = "UploadGradeBtn";
            this.UploadGradeBtn.Size = new System.Drawing.Size(436, 47);
            this.UploadGradeBtn.TabIndex = 21;
            this.UploadGradeBtn.Text = "UPLOAD GRADE";
            this.UploadGradeBtn.UseVisualStyleBackColor = false;
            this.UploadGradeBtn.Click += new System.EventHandler(this.UploadGradeBtn_Click);
            // 
            // VIEWTEACHERCOURSESBtn
            // 
            this.VIEWTEACHERCOURSESBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VIEWTEACHERCOURSESBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIEWTEACHERCOURSESBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VIEWTEACHERCOURSESBtn.Location = new System.Drawing.Point(183, 145);
            this.VIEWTEACHERCOURSESBtn.Name = "VIEWTEACHERCOURSESBtn";
            this.VIEWTEACHERCOURSESBtn.Size = new System.Drawing.Size(436, 47);
            this.VIEWTEACHERCOURSESBtn.TabIndex = 20;
            this.VIEWTEACHERCOURSESBtn.Text = " VIEW TEACHER COURSES";
            this.VIEWTEACHERCOURSESBtn.UseVisualStyleBackColor = false;
            this.VIEWTEACHERCOURSESBtn.Click += new System.EventHandler(this.VIEWTEACHERCOURSESBtn_Click);
            // 
            // AvailableBtn
            // 
            this.AvailableBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AvailableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvailableBtn.Location = new System.Drawing.Point(183, 83);
            this.AvailableBtn.Name = "AvailableBtn";
            this.AvailableBtn.Size = new System.Drawing.Size(436, 47);
            this.AvailableBtn.TabIndex = 19;
            this.AvailableBtn.Text = "AVAILABLE COURSES";
            this.AvailableBtn.UseVisualStyleBackColor = false;
            this.AvailableBtn.Click += new System.EventHandler(this.AvailableBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "TEACHER DASHBOARD:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeacherDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.StudentInformationBtn);
            this.Controls.Add(this.UploadGradeBtn);
            this.Controls.Add(this.VIEWTEACHERCOURSESBtn);
            this.Controls.Add(this.AvailableBtn);
            this.Controls.Add(this.label1);
            this.Name = "TeacherDashBoard";
            this.Text = "TeacherDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button StudentInformationBtn;
        private System.Windows.Forms.Button UploadGradeBtn;
        private System.Windows.Forms.Button VIEWTEACHERCOURSESBtn;
        private System.Windows.Forms.Button AvailableBtn;
        private System.Windows.Forms.Label label1;
    }
}