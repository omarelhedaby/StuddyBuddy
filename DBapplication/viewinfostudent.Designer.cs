namespace DBapplication
{
    partial class viewinfostudent
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
            this.name = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.collegename = new System.Windows.Forms.TextBox();
            this.facultyname = new System.Windows.Forms.TextBox();
            this.departmentname = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.decline = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rate1 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(103, 43);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(103, 80);
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Size = new System.Drawing.Size(100, 20);
            this.Phone.TabIndex = 2;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(103, 115);
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(100, 20);
            this.gender.TabIndex = 3;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(103, 141);
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 4;
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(103, 167);
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.Size = new System.Drawing.Size(100, 20);
            this.score.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "District";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "College Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Department Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Faculty Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(301, 40);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 15;
            // 
            // district
            // 
            this.district.Location = new System.Drawing.Point(468, 39);
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.Size = new System.Drawing.Size(100, 20);
            this.district.TabIndex = 16;
            // 
            // collegename
            // 
            this.collegename.Location = new System.Drawing.Point(360, 94);
            this.collegename.Name = "collegename";
            this.collegename.ReadOnly = true;
            this.collegename.Size = new System.Drawing.Size(156, 20);
            this.collegename.TabIndex = 17;
            // 
            // facultyname
            // 
            this.facultyname.Location = new System.Drawing.Point(359, 122);
            this.facultyname.Name = "facultyname";
            this.facultyname.ReadOnly = true;
            this.facultyname.Size = new System.Drawing.Size(157, 20);
            this.facultyname.TabIndex = 18;
            // 
            // departmentname
            // 
            this.departmentname.Location = new System.Drawing.Point(359, 148);
            this.departmentname.Name = "departmentname";
            this.departmentname.ReadOnly = true;
            this.departmentname.Size = new System.Drawing.Size(157, 20);
            this.departmentname.TabIndex = 19;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(359, 201);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 20;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // decline
            // 
            this.decline.Location = new System.Drawing.Point(451, 201);
            this.decline.Name = "decline";
            this.decline.Size = new System.Drawing.Size(75, 23);
            this.decline.TabIndex = 21;
            this.decline.Text = "Decline";
            this.decline.UseVisualStyleBackColor = true;
            this.decline.Click += new System.EventHandler(this.decline_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(317, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Choose the subject You want to accept or decline  the request for";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // rate1
            // 
            this.rate1.AutoSize = true;
            this.rate1.Location = new System.Drawing.Point(152, 209);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(69, 13);
            this.rate1.TabIndex = 27;
            this.rate1.Text = "Rate out of 5";
            // 
            // rate
            // 
            this.rate.FormattingEnabled = true;
            this.rate.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rate.Location = new System.Drawing.Point(227, 206);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(41, 21);
            this.rate.TabIndex = 28;
            // 
            // viewinfostudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 236);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.rate1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.departmentname);
            this.Controls.Add(this.facultyname);
            this.Controls.Add(this.collegename);
            this.Controls.Add(this.district);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.score);
            this.Controls.Add(this.age);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "viewinfostudent";
            this.Text = "viewinfostudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox collegename;
        private System.Windows.Forms.TextBox facultyname;
        private System.Windows.Forms.TextBox departmentname;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button decline;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label rate1;
        private System.Windows.Forms.ComboBox rate;
    }
}