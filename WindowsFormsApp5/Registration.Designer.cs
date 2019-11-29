namespace WindowsFormsApp5
{
    partial class Registration
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StudentTab = new System.Windows.Forms.TabPage();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FemaleRb = new System.Windows.Forms.RadioButton();
            this.MaleRb = new System.Windows.Forms.RadioButton();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TeacherTab = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tPassBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tFemaleRb = new System.Windows.Forms.RadioButton();
            this.tMaleRb = new System.Windows.Forms.RadioButton();
            this.tNameBox = new System.Windows.Forms.TextBox();
            this.tAddressBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tRegBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.StudentTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TeacherTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StudentTab);
            this.tabControl1.Controls.Add(this.TeacherTab);
            this.tabControl1.Location = new System.Drawing.Point(30, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // StudentTab
            // 
            this.StudentTab.Controls.Add(this.ViewBtn);
            this.StudentTab.Controls.Add(this.PassBox);
            this.StudentTab.Controls.Add(this.label7);
            this.StudentTab.Controls.Add(this.dateTimePicker1);
            this.StudentTab.Controls.Add(this.comboBox1);
            this.StudentTab.Controls.Add(this.groupBox1);
            this.StudentTab.Controls.Add(this.NameText);
            this.StudentTab.Controls.Add(this.AddressText);
            this.StudentTab.Controls.Add(this.label3);
            this.StudentTab.Controls.Add(this.label6);
            this.StudentTab.Controls.Add(this.label5);
            this.StudentTab.Controls.Add(this.label4);
            this.StudentTab.Controls.Add(this.RegBtn);
            this.StudentTab.Controls.Add(this.label2);
            this.StudentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentTab.Location = new System.Drawing.Point(4, 22);
            this.StudentTab.Name = "StudentTab";
            this.StudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTab.Size = new System.Drawing.Size(778, 388);
            this.StudentTab.TabIndex = 0;
            this.StudentTab.Text = "Student";
            this.StudentTab.UseVisualStyleBackColor = true;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(139, 255);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(504, 22);
            this.PassBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(503, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FemaleRb);
            this.groupBox1.Controls.Add(this.MaleRb);
            this.groupBox1.Location = new System.Drawing.Point(140, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // FemaleRb
            // 
            this.FemaleRb.AutoSize = true;
            this.FemaleRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleRb.Location = new System.Drawing.Point(95, 18);
            this.FemaleRb.Name = "FemaleRb";
            this.FemaleRb.Size = new System.Drawing.Size(80, 24);
            this.FemaleRb.TabIndex = 1;
            this.FemaleRb.Text = "Female";
            this.FemaleRb.UseVisualStyleBackColor = true;
            // 
            // MaleRb
            // 
            this.MaleRb.AutoSize = true;
            this.MaleRb.Checked = true;
            this.MaleRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleRb.Location = new System.Drawing.Point(6, 18);
            this.MaleRb.Name = "MaleRb";
            this.MaleRb.Size = new System.Drawing.Size(61, 24);
            this.MaleRb.TabIndex = 0;
            this.MaleRb.TabStop = true;
            this.MaleRb.Text = "Male";
            this.MaleRb.UseVisualStyleBackColor = true;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(140, 14);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(504, 22);
            this.NameText.TabIndex = 13;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(140, 153);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(504, 22);
            this.AddressText.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Education:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address:";
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.Blue;
            this.RegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegBtn.Location = new System.Drawing.Point(54, 301);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(676, 40);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Register";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // TeacherTab
            // 
            this.TeacherTab.Controls.Add(this.comboBox3);
            this.TeacherTab.Controls.Add(this.label14);
            this.TeacherTab.Controls.Add(this.tPassBox);
            this.TeacherTab.Controls.Add(this.label8);
            this.TeacherTab.Controls.Add(this.dateTimePicker2);
            this.TeacherTab.Controls.Add(this.comboBox2);
            this.TeacherTab.Controls.Add(this.groupBox2);
            this.TeacherTab.Controls.Add(this.tNameBox);
            this.TeacherTab.Controls.Add(this.tAddressBox);
            this.TeacherTab.Controls.Add(this.label9);
            this.TeacherTab.Controls.Add(this.label10);
            this.TeacherTab.Controls.Add(this.label11);
            this.TeacherTab.Controls.Add(this.label12);
            this.TeacherTab.Controls.Add(this.tRegBtn);
            this.TeacherTab.Controls.Add(this.label13);
            this.TeacherTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherTab.Location = new System.Drawing.Point(4, 22);
            this.TeacherTab.Name = "TeacherTab";
            this.TeacherTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeacherTab.Size = new System.Drawing.Size(778, 388);
            this.TeacherTab.TabIndex = 1;
            this.TeacherTab.Text = "Teacher";
            this.TeacherTab.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(493, 105);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 24);
            this.comboBox3.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(386, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 24);
            this.label14.TabIndex = 32;
            this.label14.Text = "Salary:";
            // 
            // tPassBox
            // 
            this.tPassBox.Location = new System.Drawing.Point(146, 255);
            this.tPassBox.Name = "tPassBox";
            this.tPassBox.Size = new System.Drawing.Size(504, 22);
            this.tPassBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Password:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(147, 206);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(147, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 24);
            this.comboBox2.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tFemaleRb);
            this.groupBox2.Controls.Add(this.tMaleRb);
            this.groupBox2.Location = new System.Drawing.Point(147, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 57);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // tFemaleRb
            // 
            this.tFemaleRb.AutoSize = true;
            this.tFemaleRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFemaleRb.Location = new System.Drawing.Point(95, 18);
            this.tFemaleRb.Name = "tFemaleRb";
            this.tFemaleRb.Size = new System.Drawing.Size(80, 24);
            this.tFemaleRb.TabIndex = 1;
            this.tFemaleRb.Text = "Female";
            this.tFemaleRb.UseVisualStyleBackColor = true;
            // 
            // tMaleRb
            // 
            this.tMaleRb.AutoSize = true;
            this.tMaleRb.Checked = true;
            this.tMaleRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMaleRb.Location = new System.Drawing.Point(6, 18);
            this.tMaleRb.Name = "tMaleRb";
            this.tMaleRb.Size = new System.Drawing.Size(61, 24);
            this.tMaleRb.TabIndex = 0;
            this.tMaleRb.TabStop = true;
            this.tMaleRb.Text = "Male";
            this.tMaleRb.UseVisualStyleBackColor = true;
            // 
            // tNameBox
            // 
            this.tNameBox.Location = new System.Drawing.Point(147, 14);
            this.tNameBox.Name = "tNameBox";
            this.tNameBox.Size = new System.Drawing.Size(504, 22);
            this.tNameBox.TabIndex = 26;
            // 
            // tAddressBox
            // 
            this.tAddressBox.Location = new System.Drawing.Point(147, 153);
            this.tAddressBox.Name = "tAddressBox";
            this.tAddressBox.Size = new System.Drawing.Size(504, 22);
            this.tAddressBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Education:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Gender:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date Of Birth:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Address:";
            // 
            // tRegBtn
            // 
            this.tRegBtn.BackColor = System.Drawing.Color.Blue;
            this.tRegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRegBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tRegBtn.Location = new System.Drawing.Point(47, 307);
            this.tRegBtn.Name = "tRegBtn";
            this.tRegBtn.Size = new System.Drawing.Size(676, 40);
            this.tRegBtn.TabIndex = 20;
            this.tRegBtn.Text = "Register";
            this.tRegBtn.UseVisualStyleBackColor = false;
            this.tRegBtn.Click += new System.EventHandler(this.tRegBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 19;
            this.label13.Text = "Name:";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogoutBtn.Location = new System.Drawing.Point(699, 30);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(80, 29);
            this.LogoutBtn.TabIndex = 8;
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
            this.tBackBtn.TabIndex = 9;
            this.tBackBtn.Text = "BACK";
            this.tBackBtn.UseVisualStyleBackColor = false;
            this.tBackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registration:";
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.Green;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(352, 347);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(80, 29);
            this.ViewBtn.TabIndex = 11;
            this.ViewBtn.Text = "VIEW";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBackBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.tabControl1.ResumeLayout(false);
            this.StudentTab.ResumeLayout(false);
            this.StudentTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TeacherTab.ResumeLayout(false);
            this.TeacherTab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StudentTab;
        private System.Windows.Forms.TabPage TeacherTab;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button tBackBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FemaleRb;
        private System.Windows.Forms.RadioButton MaleRb;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tPassBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tFemaleRb;
        private System.Windows.Forms.RadioButton tMaleRb;
        private System.Windows.Forms.TextBox tNameBox;
        private System.Windows.Forms.TextBox tAddressBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button tRegBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ViewBtn;
    }
}