namespace Activity_4_Student_mangement
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentLastname = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.mobileNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile N0";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(297, 16);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(168, 20);
            this.studentName.TabIndex = 5;
            // 
            // studentLastname
            // 
            this.studentLastname.Location = new System.Drawing.Point(297, 61);
            this.studentLastname.Name = "studentLastname";
            this.studentLastname.Size = new System.Drawing.Size(168, 20);
            this.studentLastname.TabIndex = 6;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(297, 109);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(168, 20);
            this.address.TabIndex = 7;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(297, 150);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(168, 20);
            this.city.TabIndex = 8;
            // 
            // mobileNo
            // 
            this.mobileNo.Location = new System.Drawing.Point(297, 191);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(168, 20);
            this.mobileNo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "Shoe Student Info";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mobileNo);
            this.Controls.Add(this.city);
            this.Controls.Add(this.address);
            this.Controls.Add(this.studentLastname);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox studentLastname;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox mobileNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

