using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4_Student_mangement
{
    
    public partial class Form1 : Form
    {
        string[] stdData = new string[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentName.Text = "";
            studentLastname.Text = "";
            address.Text = "";
            city.Text = "";
            mobileNo.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentData obj = new StudentData();
           
        }

    }
    public class StudentData
    {
        StudentData()
        {

        }
    }


}

