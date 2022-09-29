namespace Activity_3_SignUp_form
{
    partial class txtContact1
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblContact1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtContactN0 = new System.Windows.Forms.TextBox();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(145, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Enter Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(145, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Enter Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblContact1
            // 
            this.lblContact1.AutoSize = true;
            this.lblContact1.Location = new System.Drawing.Point(123, 188);
            this.lblContact1.Name = "lblContact1";
            this.lblContact1.Size = new System.Drawing.Size(105, 13);
            this.lblContact1.TabIndex = 2;
            this.lblContact1.Text = "Enter Contact No# 1";
            this.lblContact1.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(305, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(305, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtContactN0
            // 
            this.txtContactN0.Location = new System.Drawing.Point(305, 188);
            this.txtContactN0.Name = "txtContactN0";
            this.txtContactN0.Size = new System.Drawing.Size(172, 20);
            this.txtContactN0.TabIndex = 5;
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(515, 188);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(75, 23);
            this.btnAddMore.TabIndex = 6;
            this.btnAddMore.Text = "Add More";
            this.btnAddMore.UseVisualStyleBackColor = true;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(305, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(402, 267);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtContact1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.txtContactN0);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblContact1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "txtContact1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblContact1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtContactN0;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
    }
}

