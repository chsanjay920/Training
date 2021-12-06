class button{
	
	public static void Main()
	{
		System.Windows.Forms.Form frm = new System.Windows.Forms.Form();
		System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
		btn.Text = "OK";
		btn.Location = new System.Drawing.Point(100,100);
		btn.Click += new System.EventHandler(btn_click);
		frm.Controls.Add(btn);
		System.Windows.Forms.Application.Run(frm);
	}
	private static void btn_click(System.Object o,System.EventArgs e)
	{	
		System.Windows.Forms.MessageBox.Show("em ra bai");
	}
}