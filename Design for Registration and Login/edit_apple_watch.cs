﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class edit_apple_watch : Form
    {
        public edit_apple_watch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_product f1 = new edit_product();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variable.APPLE_WATCH.edit_By_name_color_size(comboBox1.Text, Convert.ToInt32(comboBox3.Text), Convert.ToDouble(textBox1.Text), comboBox2.Text, comboBox5.Text, comboBox6.Text, Convert.ToInt32(comboBox4.Text));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
