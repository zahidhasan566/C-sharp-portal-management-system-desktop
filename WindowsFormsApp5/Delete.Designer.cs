namespace WindowsFormsApp5
{
    partial class Delete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tBackBtn = new System.Windows.Forms.Button();
            this.SDelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TDelBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SidBox = new System.Windows.Forms.TextBox();
            this.TidBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.SidBox);
            this.panel1.Controls.Add(this.tt);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SDelBtn);
            this.panel1.Location = new System.Drawing.Point(30, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 433);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Delete:";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(699, 30);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 16;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // tBackBtn
            // 
            this.tBackBtn.BackColor = System.Drawing.Color.Lime;
            this.tBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBackBtn.Location = new System.Drawing.Point(613, 29);
            this.tBackBtn.Name = "tBackBtn";
            this.tBackBtn.Size = new System.Drawing.Size(80, 29);
            this.tBackBtn.TabIndex = 17;
            this.tBackBtn.Text = "BACK";
            this.tBackBtn.UseVisualStyleBackColor = false;
            this.tBackBtn.Click += new System.EventHandler(this.tBackBtn_Click);
            // 
            // SDelBtn
            // 
            this.SDelBtn.BackColor = System.Drawing.Color.Red;
            this.SDelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SDelBtn.Location = new System.Drawing.Point(120, 380);
            this.SDelBtn.Name = "SDelBtn";
            this.SDelBtn.Size = new System.Drawing.Size(129, 40);
            this.SDelBtn.TabIndex = 35;
            this.SDelBtn.Text = "DELETE";
            this.SDelBtn.UseVisualStyleBackColor = false;
            this.SDelBtn.Click += new System.EventHandler(this.SDelBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.TidBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.TDelBtn);
            this.panel2.Location = new System.Drawing.Point(433, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 433);
            this.panel2.TabIndex = 37;
            // 
            // TDelBtn
            // 
            this.TDelBtn.BackColor = System.Drawing.Color.Red;
            this.TDelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TDelBtn.Location = new System.Drawing.Point(124, 380);
            this.TDelBtn.Name = "TDelBtn";
            this.TDelBtn.Size = new System.Drawing.Size(126, 40);
            this.TDelBtn.TabIndex = 35;
            this.TDelBtn.Text = "DELETE";
            this.TDelBtn.UseVisualStyleBackColor = false;
            this.TDelBtn.Click += new System.EventHandler(this.TDelBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(336, 281);
            this.dataGridView1.TabIndex = 36;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(336, 281);
            this.dataGridView2.TabIndex = 37;
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.ForeColor = System.Drawing.Color.Navy;
            this.tt.Location = new System.Drawing.Point(19, 16);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(320, 27);
            this.tt.TabIndex = 38;
            this.tt.Text = "REQUESTED BY STUDENTS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "REQUESTED BY TEACHERS:";
            // 
            // SidBox
            // 
            this.SidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidBox.Location = new System.Drawing.Point(120, 354);
            this.SidBox.Name = "SidBox";
            this.SidBox.Size = new System.Drawing.Size(129, 22);
            this.SidBox.TabIndex = 39;
            this.SidBox.Text = "Enter Student\'s ID";
            this.SidBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SidBox_MouseClick);
            // 
            // TidBox
            // 
            this.TidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TidBox.Location = new System.Drawing.Point(124, 354);
            this.TidBox.Name = "TidBox";
            this.TidBox.Size = new System.Drawing.Size(126, 22);
            this.TidBox.TabIndex = 40;
            this.TidBox.Text = "Enter Teacher\'s ID";
            this.TidBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TidtBox_MouseClick);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.tBackBtn);
            this.Name = "Delete";
            this.Text = "Delete";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button tBackBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SDelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TDelBtn;
        private System.Windows.Forms.TextBox SidBox;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.TextBox TidBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}