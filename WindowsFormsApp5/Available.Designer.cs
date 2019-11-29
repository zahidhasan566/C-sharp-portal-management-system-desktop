namespace WindowsFormsApp5
{
    partial class Available
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Available));
            this.label1 = new System.Windows.Forms.Label();
            this.Cse1 = new System.Windows.Forms.CheckBox();
            this.Math1 = new System.Windows.Forms.CheckBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(306, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses";
            // 
            // Cse1
            // 
            this.Cse1.AutoSize = true;
            this.Cse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cse1.Location = new System.Drawing.Point(237, 115);
            this.Cse1.Name = "Cse1";
            this.Cse1.Size = new System.Drawing.Size(42, 28);
            this.Cse1.TabIndex = 2;
            this.Cse1.Text = "C";
            this.Cse1.UseVisualStyleBackColor = false;
            this.Cse1.CheckedChanged += new System.EventHandler(this.Cse1_CheckedChanged);
            // 
            // Math1
            // 
            this.Math1.AutoSize = true;
            this.Math1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Math1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Math1.Location = new System.Drawing.Point(396, 115);
            this.Math1.Name = "Math1";
            this.Math1.Size = new System.Drawing.Size(111, 28);
            this.Math1.TabIndex = 5;
            this.Math1.Text = "MATHS 1";
            this.Math1.UseVisualStyleBackColor = false;
            this.Math1.CheckedChanged += new System.EventHandler(this.Math1_CheckedChanged);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ConfirmBtn.Location = new System.Drawing.Point(279, 219);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(121, 38);
            this.ConfirmBtn.TabIndex = 8;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(660, 45);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 17;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DimGray;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(182, 294);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(97, 36);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(163, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "*YOU MUST  TAKE  ALL OF THESE SUBJECTS";
            // 
            // Available
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.Math1);
            this.Controls.Add(this.Cse1);
            this.Controls.Add(this.label1);
            this.Name = "Available";
            this.Text = "Available";
            this.Load += new System.EventHandler(this.Available_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Cse1;
        private System.Windows.Forms.CheckBox Math1;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label2;
    }
}