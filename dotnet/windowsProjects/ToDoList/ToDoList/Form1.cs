using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text+"\t\ttime:"+dateTimePicker1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(("AM"));
            comboBox1.Items.Add("PM");
            for (int i = 1; i<13; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
            for(int i = 1; i<=60;i++)
            {
                comboBox3.Items.Add(i.ToString());
            }    

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
