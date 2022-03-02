using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Latihan_4
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Halo " + this.textBox1.Text + " dengan NIM "+ this.textBox2.Text + " dari " + this.textBox3.Text + "! Selamat belajar " + this.textBox4.Text + " :)");			
		}
	}
}
