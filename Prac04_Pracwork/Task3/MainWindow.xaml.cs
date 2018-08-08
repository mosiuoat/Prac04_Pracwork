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
using ThinkLib;

namespace Task3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Turtle tess;
		enum Size { Small, Medium, Large };
		// these are the dimensions of the canvas
		double canvasHeight = 640;
		double canvasWidth = 760;

		public MainWindow()
		{
			InitializeComponent();
		}

		void Circle(double size)
		{
			
		}

		void House(double length, double width)
		{

		}

		void Triangle(double size)
		{
			
		}

		void Square(double size)
		{
			
		}

		void Rectangle(double length, double width)
		{
			
		}

		void setHouseSize(Size size)
		{
			
		}
		void setCircleSize(Size size)
		{
			
		}

		private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			
		}
		void warpTo(double x, double y)
		{
			
		}

		private void btnCircle_Click(object sender, RoutedEventArgs e)
		{
			
		}

		private void btnHouse_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnClear_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
