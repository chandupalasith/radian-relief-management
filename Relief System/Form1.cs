﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relief_System
{

    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.tno = 1001;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.tname = textBox1.Text;
            Program.sec = textBox2.Text;
            Teacher.tadd();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}