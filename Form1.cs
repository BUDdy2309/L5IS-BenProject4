using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenProject4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool buttonwasclicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            buttonwasclicked = true;

            On_siteVisit ov = new On_siteVisit();

            if (ov.ShowDialog() == DialogResult.OK)
            {
                if (ov.radioButton1.Checked == true)
                    button1.Text = ov.radioButton1.Text;
                else if (ov.radioButton2.Checked == true)
                    button1.Text = ov.radioButton2.Text;
                else if (ov.radioButton3.Checked == true)
                    button1.Text = ov.radioButton3.Text;
                else if (ov.radioButton4.Checked == true)
                    button1.Text = ov.radioButton4.Text;
            }
        }
        void clearInfo()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            numericUpDown1.ResetText();
            numericUpDown2.ResetText();

            comboBox1.ResetText();

            button1.ResetText();

            dateTimePicker1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name is required");
                textBox1.BackColor = Color.OrangeRed;
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                textBox1.BackColor = Color.White;
                MessageBox.Show("Surname must be filled up");
                textBox2.BackColor = Color.OrangeRed;
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Mobile number is required");
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
            }
            else if (int.TryParse(textBox3.Text, out num) == false)
            {
                textBox2.BackColor = Color.White;
                MessageBox.Show("Mobile Number can't contains letters/symbols");
                textBox3.BackColor = Color.Red;
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                textBox3.BackColor = Color.White;
                MessageBox.Show("Email should not be left empty");
                textBox4.BackColor = Color.Red;
                textBox4.Focus();
            }
            else if (textBox4.Text == "") 
            {
                textBox4.BackColor = Color.White;
            }
            else if (numericUpDown1.Value == 0)
            {
                textBox4.BackColor = Color.White;
                MessageBox.Show("Please enter the hour time");
                numericUpDown1.BackColor = Color.OrangeRed;
                numericUpDown2.BackColor = Color.OrangeRed;
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a person to meet");
            }
            else if (buttonwasclicked == false)
            {
                MessageBox.Show("Please select a meeting aim");
            }
            else
            {
                listBox1.Items.Add("Fullname: " + textBox1.Text + " " + textBox2.Text);
                listBox1.Items.Add("Mobile Number: " + textBox3.Text);
                listBox1.Items.Add("Email: " + textBox4.Text);
                listBox1.Items.Add("Meeting time: " + numericUpDown1.Value + ":" + numericUpDown2.Value);
                listBox1.Items.Add("Meeting with: " + comboBox1.SelectedItem);
                listBox1.Items.Add("Meeting Aim: " + button1.Text);

                clearInfo();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
