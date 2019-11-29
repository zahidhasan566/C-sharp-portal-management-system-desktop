namespace WindowsFormsApp5
{
    partial class Assign
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
            this.tt = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidBox = new System.Windows.Forms.TextBox();
            this.TidBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AssignBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tBackBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CidBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.ForeColor = System.Drawing.Color.Navy;
            this.tt.Location = new System.Drawing.Point(235, 13);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(131, 44);
            this.tt.TabIndex = 38;
            this.tt.Text = "SELECTED BY\r\nSTUDENTS:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(237, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(210, 267);
            this.dataGridView2.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.CidBox);
            this.panel2.Controls.Add(this.tt);
            this.panel2.Controls.Add(this.SidBox);
            this.panel2.Controls.Add(this.TidBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.AssignBtn);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 433);
            this.panel2.TabIndex = 42;
            // 
            // SidBox
            // 
            this.SidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidBox.Location = new System.Drawing.Point(163, 342);
            this.SidBox.Name = "SidBox";
            this.SidBox.Size = new System.Drawing.Size(129, 22);
            this.SidBox.TabIndex = 39;
            this.SidBox.Text = "Enter Student\'s ID";
            this.SidBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SidBox_MouseClick);
            // 
            // TidBox
            // 
            this.TidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TidBox.Location = new System.Drawing.Point(21, 342);
            this.TidBox.Name = "TidBox";
            this.TidBox.Size = new System.Drawing.Size(126, 22);
            this.TidBox.TabIndex = 40;
            this.TidBox.Text = "Enter Teacher\'s ID";
            this.TidBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TidBox_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 44);
            this.label3.TabIndex = 39;
            this.label3.Text = "PREFERRED BY\r\nTEACHERS:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(210, 267);
            this.dataGridView1.TabIndex = 37;
            // 
            // AssignBtn
            // 
            this.AssignBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AssignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AssignBtn.Location = new System.Drawing.Point(166, 370);
            this.AssignBtn.Name = "AssignBtn";
            this.AssignBtn.Size = new System.Drawing.Size(126, 40);
            this.AssignBtn.TabIndex = 35;
            this.AssignBtn.Text = "ASSIGN";
            this.AssignBtn.UseVisualStyleBackColor = false;
            this.AssignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Assign Teachers To Students:";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(702, 30);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 38;
            this.LogoutBtn.Text = "LOG OUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // tBackBtn
            // 
            this.tBackBtn.BackColor = System.Drawing.Color.Lime;
            this.tBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBackBtn.Location = new System.Drawing.Point(616, 29);
            this.tBackBtn.Name = "tBackBtn";
            this.tBackBtn.Size = new System.Drawing.Size(80, 29);
            this.tBackBtn.TabIndex = 39;
            this.tBackBtn.Text = "BACK";
            this.tBackBtn.UseVisualStyleBackColor = false;
            this.tBackBtn.Click += new System.EventHandler(this.tBackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(476, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 433);
            this.panel1.TabIndex = 43;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(13, 60);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(336, 350);
            this.dataGridView3.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "ASSIGNED COURSES:";
            // 
            // CidBox
            // 
            this.CidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CidBox.Location = new System.Drawing.Point(309, 342);
            this.CidBox.Name = "CidBox";
            this.CidBox.Size = new System.Drawing.Size(129, 22);
            this.CidBox.TabIndex = 41;
            this.CidBox.Text = "Enter Course ID";
            this.CidBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CidBox_MouseClick);
            // 
            // Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.tBackBtn);
            this.Name = "Assign";
            this.Text = "Assign";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SidBox;
        private System.Windows.Forms.TextBox TidBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AssignBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button tBackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox CidBox;
    }
}