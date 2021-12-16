using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiveButtonApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
			InitializeComponent();
			int count = 1;
			for (int i = 1; i<=5; i++)
			{
				for (int j = 1; j<6; j++)
				{
					InitializeComponent(10+j*100, 10+i*50,count.ToString());
					count++;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
        {
			//System.Windows.Forms.MessageBox.Show(((System.Windows.Forms.Button)o).Text);
		}
    }
}
