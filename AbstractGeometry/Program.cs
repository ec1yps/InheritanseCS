using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
					Console.WindowLeft, Console.WindowTop,
					Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

            Rectangle rectangle = new Rectangle(100, 50, 600, 50, 3, System.Drawing.Color.Red);
			rectangle.Info(e);

			Squre square = new Squre(100, 600, 200, 3, System.Drawing.Color.Green);
			square.Info(e);

			Circle circle = new Circle(50, 750, 50, 3, System.Drawing.Color.Yellow);
			circle.Info(e);

			Triangle triangle = new Triangle(70, 80, 100, 750, 300, 3, System.Drawing.Color.Blue);
			triangle.Info(e);

			IsoscalesTriangle i_triangle = new IsoscalesTriangle(50, 100, 600, 350, 3, System.Drawing.Color.Green);
			i_triangle.Info(e);

			EquilateralTriangle e_triangle = new EquilateralTriangle(150, 750, 350, 3, System.Drawing.Color.GreenYellow);
			e_triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
