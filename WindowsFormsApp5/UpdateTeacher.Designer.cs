namespace WindowsFormsApp5
{
    partial class UpdateTeacher
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.LogoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonUpdate.Location = new System.Drawing.Point(141, 136);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(142, 45);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.Lime;
            this.buttonback.Location = new System.Drawing.Point(616, 29);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(80, 29);
            this.buttonback.TabIndex = 1;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(141, 77);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(142, 20);
            this.textName.TabIndex = 2;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(141, 37);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(142, 20);
            this.textAddress.TabIndex = 3;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(49, 40);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(70, 13);
            this.labelAdress.TabIndex = 4;
            this.labelAdress.Text = "New Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(49, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "New Name";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.AllowUserToAddRows = false;
            this.dataGridViewTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(28, 263);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.ReadOnly = true;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(798, 150);
            this.dataGridViewTeacher.TabIndex = 6;
            this.dataGridViewTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellContentClick);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(702, 30);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 25;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.dataGridViewTeacher);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "UpdateTeacher";
            this.Text = "UpdateTeacher";
            this.Load += new System.EventHandler(this.UpdateTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.Button LogoutBtn;
    }
}