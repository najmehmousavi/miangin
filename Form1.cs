using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miangin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] nums = new int[20];
        private int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int a = int.Parse(textBox1.Text);
                if (count < nums.Length)
                {
                    nums[count] = a;
                    count++;
                }
                int sum = 0;
                for(int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }
                double avr = sum / count;
                label2.Text = avr.ToString();
                if (count > 19)
                {
                    MessageBox.Show("press clear");
                    return;
                }
                else
                {
                    listBox1.Items.Add(a);
                }
                textBox1.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            count = 0;
            label2.Text = "";
        }
    }
}
