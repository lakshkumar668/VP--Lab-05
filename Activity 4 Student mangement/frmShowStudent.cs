﻿using System;
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
    public partial class frmShowStudent : Form
    {
        public frmShowStudent()
        {
            InitializeComponent();
        }

        private void frmShowStudent_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.counter; i++) {

                listBox.Items.Add(Form1.stdData[i].firstname);
            }

        }
    }
}
