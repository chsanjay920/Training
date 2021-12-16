using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string drive in System.IO.Directory.GetLogicalDrives())
            {
                comboBox1.Items.Add(drive);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string driector in System.IO.Directory.GetDirectories(comboBox1.SelectedItem.ToString()))
            {
                listBox1.Items.Add(driector);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (string file in System.IO.Directory.GetFiles(listBox1.SelectedItem.ToString()))
            {
                listBox2.Items.Add(file);
            }
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                System.Diagnostics.Process.Start(listBox2.SelectedItem.ToString());
        }
    }
}
