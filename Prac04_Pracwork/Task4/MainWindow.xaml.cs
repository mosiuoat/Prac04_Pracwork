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

namespace Task4
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Turtle tess;
		
		public MainWindow()
		{
			InitializeComponent();
			tess = new Turtle(canvas, 0, 200);
		}

		void DrawShape()
		{
			
		}
	
		void DrawMoreShapes(int num)
		{
			
		}

		void Clear()
		{

		}
		private void btnClear_Click(object sender, RoutedEventArgs e)
		{
			
		}
		
		private void btnTriangles_Click(object sender, RoutedEventArgs e)
		{
			
		}
	}
}
