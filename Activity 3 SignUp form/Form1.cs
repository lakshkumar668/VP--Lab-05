using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_3_SignUp_form
{
    public partial class txtContact1 : Form
    {
        Form2 obj = new Form2();
        public static string username;
        public static string password, conatctNo1, contactNo2;
        public txtContact1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            conatctNo1 = txtContactN0.Text;
            if()
 
            obj.ShowDialog();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            Label obj = new Label();
            obj.Name = "lblContact2";
            obj.Text = "Enter Conatct No# 2";
            obj.SetBounds(123, 237, 105, 13);
            this.Controls.Add(obj);

            TextBox obj1 = new TextBox();
            obj1.Name = "txtContact2";
            obj1.SetBounds(305, 232, 172, 20);
            this.Controls.Add(obj1);

            Button btn = btnAddMore;
            btn.SetBounds(515, 232, 75, 23);
            btnAddMore.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContactN0.Text = "";
        }
    }
}
