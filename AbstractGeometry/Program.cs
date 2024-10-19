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

            Rectangle rectangle = new Rectangle(100, 50, 100, 300, 3, System.Drawing.Color.Red);
			rectangle.Info(e);

			Squre square = new Squre(100, 100, 400, 3, System.Drawing.Color.Green);
			square.Info(e);

			Circle circle = new Circle(50, 250, 300, 3, System.Drawing.Color.Yellow);
			circle.Info(e);

			Triangle triangle = new Triangle(70, 80, 100, 250, 500, 3, System.Drawing.Color.Red);
			triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
