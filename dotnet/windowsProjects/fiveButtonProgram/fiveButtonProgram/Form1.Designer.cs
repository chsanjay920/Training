namespace fiveButtonProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            int count = 1;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5;j++)
                {
                    this.button1 = new System.Windows.Forms.Button();
                    this.SuspendLayout();
                    // 
                    // button1
                    // 
                    this.button1.Location = new System.Drawing.Point(100*i, 50*j);
                    this.button1.Name = "button1";
                    this.button1.Size = new System.Drawing.Size(75, 23);
                    this.button1.TabIndex = 0;
                    this.button1.Text = count.ToString();
                    this.button1.UseVisualStyleBackColor = true;
                    this.button1.Click += new System.EventHandler(this.button1_Click);
                    // 
                    // Form1
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.ClientSize = new System.Drawing.Size(615, 299);
                    this.Controls.Add(this.button1);
                    this.Name = "Form1";
                    this.Text = "Form1";
                    count++;
                    this.ResumeLayout(false);
                }
            }
        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}

