using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chattingWindow
{
    public delegate void Delegate(String str);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Tbtext = textBox1.Text;
            frm.OnTextChanged += new Delegate(txtChanged);
            frm.Show();
        }
        private void txtChanged(String str)
        {
            textBox1.Text = str;
        }
    }
}
