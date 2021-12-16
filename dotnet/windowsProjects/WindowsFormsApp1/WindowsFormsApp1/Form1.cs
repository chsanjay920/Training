using System;
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
    public partial class Form1 : Form
    {
        int j = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                for(int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location=new Point(j*100,j*100);
                    pictureBox.SizeMode=PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromFile(openFileDialog.FileNames[i]);
                    
                }
            }
        }
    }
}
