using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1,j=1;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            DialogResult dialogResult  = ofd.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                foreach(string file in ofd.FileNames)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(i*110, j*120);
                    pictureBox.Image = Image.FromFile(file);
                    pictureBox.Size = new Size(100, 100);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Name= file;
                    System.EventHandler s = new System.EventHandler(img_click);
                    pictureBox.Click += s;
                    this.Controls.Add(pictureBox);
                    i++;
                    if (i>5)
                    {
                        j++;
                        i=1;
                    }
                }
            }
        }
        private void img_click(Object o,EventArgs e)
        {
            //MessageBox.Show(((PictureBox)o).Name);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = ((PictureBox)o).Image;
                //Image.FromFile(((PictureBox)o).Name);
        }
    }
}
