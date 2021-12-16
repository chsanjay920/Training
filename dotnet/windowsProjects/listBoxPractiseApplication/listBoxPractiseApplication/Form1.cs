using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBoxPractiseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*foreach(object item in listBox1.Items)
            {
                listBox2.Items.Add((string)item);
            }
            listBox1.Items.Clear();
            */
            int len = listBox1.Items.Count;
            for(int i = 0;i<len; i++)
            {
                listBox2.Items.Add(listBox1.Items[0].ToString());
                listBox1.Items.Remove(listBox1.Items[0]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*foreach (object item in listBox2.Items)
            {
                listBox1.Items.Add((string)item);
            }
            listBox2.Items.Clear();
            */
            int len = listBox2.Items.Count;
            for (int i = 0; i<len; i++)
            {
                listBox1.Items.Add(listBox2.Items[0].ToString());
                listBox2.Items.Remove(listBox2.Items[0]);
            }
        }
    }
}
