﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Design_for_Registration_and_Login
{
    public partial class MacBook : Form
    {
        public MacBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MacBooks f1 = new MacBooks();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart f1 = new cart();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((Convert.ToDouble(comboBox3.Text) * (variable.MAC.Search_by_name_size_color_for_user(label1.Text, Convert.ToInt32(comboBox2.Text), comboBox1.Text))).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(variable.MAC.Search_by_name_size_color_for_user(label1.Text, Convert.ToInt32(comboBox2.Text), comboBox1.Text)) == 0)
            {
                MessageBox.Show(" this product not found ");
            }
            else
            {
                variable.cart = new cart_product(label1.Text, Convert.ToInt32(comboBox2.Text), Convert.ToDouble(variable.MAC.Search_by_name_size_color_for_user(label1.Text, Convert.ToInt32(comboBox2.Text), comboBox1.Text)), comboBox1.Text, Convert.ToInt32(comboBox3.Text));//(label1.Text,Convert.ToInt32(comboBox2.Text),Convert.ToDouble(variable.IPHONE.Search_by_name_size_color_for_user(label1.Text, Convert.ToInt32(comboBox2.Text), comboBox1.Text)),comboBox1.Text,Convert.ToInt32(comboBox3.Text));
                variable.cart_list.Add(variable.cart);
            }
        }

        private void MacBook_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Asser Ayman\Desktop\P\Updated\Design for Registration and Login - Copy (2)\4K Video Downloader\The $900  MacBook  - Buy at Your Own Risk!.mp4");

        }
    }
}
