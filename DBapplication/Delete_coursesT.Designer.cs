namespace DBapplication
{
    partial class Delete_coursesT
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
            this.back3 = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back3
            // 
            this.back3.Location = new System.Drawing.Point(22, 26);
            this.back3.Name = "back3";
            this.back3.Size = new System.Drawing.Size(75, 23);
            this.back3.TabIndex = 0;
            this.back3.Text = "BACK";
            this.back3.UseVisualStyleBackColor = true;
            this.back3.Click += new System.EventHandler(this.back3_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(452, 274);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 1;
            this.done.Text = "DONE";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHOOSE COURSE :";
            // 
            // Delete_coursesT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.done);
            this.Controls.Add(this.back3);
            this.Name = "Delete_coursesT";
            this.Text = "Delete_coursesT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delete_coursesT_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back3;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}