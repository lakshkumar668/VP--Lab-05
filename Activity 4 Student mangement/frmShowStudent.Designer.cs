namespace Activity_4_Student_mangement
{
    partial class frmShowStudent
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Student LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mobile N0";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(255, 93);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(168, 20);
            this.studentName.TabIndex = 18;
            // 
            // studentLastname
            // 
            this.studentLastname.Location = new System.Drawing.Point(255, 138);
            this.studentLastname.Name = "studentLastname";
            this.studentLastname.Size = new System.Drawing.Size(168, 20);
            this.studentLastname.TabIndex = 19;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(255, 186);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(168, 20);
            this.address.TabIndex = 20;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(255, 227);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(168, 20);
            this.city.TabIndex = 21;
            // 
            // mobileNo
            // 
            this.mobileNo.Location = new System.Drawing.Point(255, 268);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(168, 20);
            this.mobileNo.TabIndex = 22;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(525, 93);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 199);
            this.listBox.TabIndex = 23;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // frmShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
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
            this.Name = "frmShowStudent";
            this.Text = "frmShowStudent";
            this.Load += new System.EventHandler(this.frmShowStudent_Load);
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
        private System.Windows.Forms.ListBox listBox;
    }
}