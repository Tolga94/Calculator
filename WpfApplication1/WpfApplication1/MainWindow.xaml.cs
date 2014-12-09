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

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		CalcClass calc1 = new CalcClass();

        public MainWindow()
        {
			InitializeComponent();
        }

		private Boolean checkIfZero(String x)
		{
			if (MainBox.Text == "0")
			{
				MainBox.Text = x;
				return true;
			}
			else
			{
				MainBox.Text += x;
				return false;
			}
		}

		private void clearout()
		{
			MainBox.Text = "0";
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			checkIfZero("1");
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			checkIfZero("2");
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			checkIfZero("3");
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			checkIfZero("4");
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			checkIfZero("5");
		}

		private void Button_Click_6(object sender, RoutedEventArgs e)
		{
			checkIfZero("6");
		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{
			checkIfZero("7");
		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{
			checkIfZero("8");
		}

		private void Button_Click_9(object sender, RoutedEventArgs e)
		{
			checkIfZero("9");
		}

		private void Button_Click_10(object sender, RoutedEventArgs e)
		{
			double x;
			x = Convert.ToDouble(MainBox.Text);
			calc1.setNumber1(x);
			calc1.setOp('+');
			clearout();
		}

		private void Button_Click_11(object sender, RoutedEventArgs e)
		{
			double x;
			x = Convert.ToDouble(MainBox.Text);
			calc1.setNumber1(x);
			calc1.setOp('-');
			clearout();
		}

		private void Button_Click_12(object sender, RoutedEventArgs e)
		{
			double x;
			x = Convert.ToDouble(MainBox.Text);
			calc1.setNumber1(x);
			calc1.setOp('*');
			clearout();
		}

		private void Button_Click_13(object sender, RoutedEventArgs e)
		{
			double x;
			x = Convert.ToDouble(MainBox.Text);
			calc1.setNumber1(x);
			calc1.setOp('/');
			clearout();
		}

		private void Button_Click_14(object sender, RoutedEventArgs e)
		{
			double x;
			x = Convert.ToDouble(MainBox.Text);
			calc1.setNumber2(x);
			MainBox.Text = calc1.calculate().ToString();
		}
    }
}
