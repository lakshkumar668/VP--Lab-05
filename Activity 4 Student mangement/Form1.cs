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
        public static StudentData[] stdData = new StudentData[10];
        public static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearData();

        }
        public void clearData()
        {
            studentName.Text = "";
            studentLastname.Text = "";
            studentAddress.Text = "";
            studentCity.Text = "";
            studentmobileNo.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = studentName.Text;
            string lastname = studentLastname.Text;
            string address = studentAddress.Text;
            string city = studentCity.Text;
            string mobileNo = studentmobileNo.Text;

            StudentData obj = new StudentData(firstname, lastname, address,city, mobileNo);
            stdData[counter] = obj;
            counter++;
            clearData();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            frmShowStudent obj = new frmShowStudent();
            obj.ShowDialog();
        }
    }
    public class StudentData
    {
        public string firstname, lastname, address, city, mobileNo;
       public StudentData(string firstname, string lastname, string address, string city, string mobileNo)
        {
            this.firstname = firstname;
            this.lastname= lastname;
            this.address= address;
            this.city= city;
            this.mobileNo = mobileNo;
        }
    }


}

