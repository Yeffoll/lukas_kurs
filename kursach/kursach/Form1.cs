﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._250px_Flag_of_Ukraine_svg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._250px_Flag_of_Russia_svg;
        }
    }
}
