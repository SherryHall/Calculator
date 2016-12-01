using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>

	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			var currNum1 = double.Parse(this.inputNum1.Text);
			var currNum2 = double.Parse(this.inputNum2.Text);
			var result = currNum1 + currNum2;
			this.answer.Text = result.ToString();
		}

		private void Sutract_Click(object sender, RoutedEventArgs e)
		{
			var currNum1 = double.Parse(this.inputNum1.Text);
			var currNum2 = double.Parse(this.inputNum2.Text);
			var result = currNum1 - currNum2;
			this.answer.Text = result.ToString();
		}

		private void Multiply_Click(object sender, RoutedEventArgs e)
		{
			var currNum1 = double.Parse(this.inputNum1.Text);
			var currNum2 = double.Parse(this.inputNum2.Text);
			var result = currNum1 * currNum2;
			this.answer.Text = result.ToString();
		}

		private void Divide_Click(object sender, RoutedEventArgs e)
		{
			var currNum1 = double.Parse(this.inputNum1.Text);
			var currNum2 = double.Parse(this.inputNum2.Text);
			var result = currNum1 / currNum2;
			this.answer.Text = result.ToString();
		}


		private void Modulus_Click(object sender, RoutedEventArgs e)
		{
			var currNum1 = double.Parse(this.inputNum1.Text);
			var currNum2 = double.Parse(this.inputNum2.Text);
			var result = currNum1 % currNum2;
			this.answer.Text = result.ToString();
		}
	}
}
