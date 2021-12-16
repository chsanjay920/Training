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
    public partial class Form2 : Form
    {
        public Delegate OnTextChanged { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public string Tbtext
        {
            get
            {
                return this.textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnTextChanged(textBox1.Text);
        }
    }
}
