namespace WindowsFormsApp5
{
    partial class DeleteStudentProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudentProfil));
            this.SDeleteBtn = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SDeleteBtn
            // 
            this.SDeleteBtn.AutoSize = true;
            this.SDeleteBtn.BackColor = System.Drawing.Color.Cyan;
            this.SDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SDeleteBtn.Location = new System.Drawing.Point(143, 40);
            this.SDeleteBtn.Name = "SDeleteBtn";
            this.SDeleteBtn.Size = new System.Drawing.Size(507, 31);
            this.SDeleteBtn.TabIndex = 0;
            this.SDeleteBtn.Text = "ARE YOU SURE WANT TO DELETE?";
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.YesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.ForeColor = System.Drawing.Color.Red;
            this.YesBtn.Location = new System.Drawing.Point(305, 143);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(139, 58);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "YES";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DimGray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(149, 278);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(139, 58);
            this.Back.TabIndex = 2;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(699, 42);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 38);
            this.LogoutBtn.TabIndex = 16;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // DeleteStudentProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.SDeleteBtn);
            this.Name = "DeleteStudentProfil";
            this.Text = "DeleteStudentProfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SDeleteBtn;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button LogoutBtn;
    }
}