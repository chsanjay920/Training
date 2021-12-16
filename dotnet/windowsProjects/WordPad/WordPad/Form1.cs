using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Form1";
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.Text= openFileDialog.FileName;
                string ext = System.IO.Path.GetExtension(openFileDialog.FileName);
                if(ext.Equals(".txt"))
                {
                    richTextBox1.LoadFile(openFileDialog.FileName,RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Text == "Form1")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                DialogResult res = saveFileDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                    this.Text = saveFileDialog.FileName;
                    if (ext.Equals(".txt"))
                    {
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                }
            }
            else
            {   string ext = System.IO.Path.GetExtension(this.Text);
                if (ext.Equals(".txt"))
                {
                    richTextBox1.LoadFile(this.Text, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.LoadFile(this.Text, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor= true;
            fontDialog.Color = richTextBox1.SelectionColor;
            fontDialog.Font = richTextBox1.SelectionFont;
            DialogResult res = fontDialog.ShowDialog();
            if(res == DialogResult.OK)
            {
                richTextBox1.SelectionColor = fontDialog.Color;
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult res = colorDialog.ShowDialog();
            if(res==DialogResult.OK)
            {
                richTextBox1.SelectionColor=colorDialog.Color;
            }
        }

        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                if (ext.Equals(".txt"))
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }
    }
}
