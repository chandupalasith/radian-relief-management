﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Program.classno = 1001;
            Program.clzno = 1001;
            Relief.classload();
            Relief.teachertime();
            label1.Text = Program.classname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relief.timeget();
        }
    }
}