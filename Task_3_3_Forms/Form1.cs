using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_3_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private double f(double x)
		{
			double y;

			if (x < 0) y = -4;
			else if (x >= 0 && x <= 1) y = x * x + 3 * x + 4;
			else y = 2;
			return y;
		}

		private void f(double x, out double y)
		{
			if (x < 0) y = -4;
			else if (x >= 0 && x <= 1) y = x * x + 3 * x + 4;
			else y = 2;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				double h = Convert.ToDouble(textBox1.Text);
				double a = Convert.ToDouble(textBox3.Text);
				double b =Convert.ToDouble(textBox4.Text);

				double y;

				textBox2.Text += String.Format("При возврате значений\r\n");
				for (double i = a; i <= b; i+=h)
				{
					textBox2.Text += String.Format("При X = {0}    Y = {1}\r\n", i, f(i));
				}

				textBox2.Text += String.Format("\r\nПри передаче по ссылке\r\n");

				for (double i = a; i <= b; i+=h)
				{
					f(i, out y);
					textBox2.Text += String.Format("При X = {0}    Y = {1}\r\n", i, y);
				}
			} catch
			{
				textBox2.Text = "X должен быть числом";
			}
		}
	}
}
