namespace WindowsFormsApp5
{
    partial class DeleteTeacherAccount
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonConfirm.Location = new System.Drawing.Point(298, 178);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(142, 45);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.Lime;
            this.buttonback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonback.Location = new System.Drawing.Point(616, 29);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(80, 29);
            this.buttonback.TabIndex = 1;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(294, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm Deletion ?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(702, 30);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 39;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // DeleteTeacherAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonConfirm);
            this.MinimizeBox = false;
            this.Name = "DeleteTeacherAccount";
            this.Text = "DeleteTeacherAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutBtn;
    }
}