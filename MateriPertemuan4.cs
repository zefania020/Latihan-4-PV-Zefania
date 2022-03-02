using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Materi_Pertemuan_4
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Hello World " + this.textBox1.Text);
		}
	}
}
