using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class Rectangle : Shape, IHaveDiagonal
	{
		double width;
		double height;

		public double Width
		{
			get => width;
			set => width = SizeFilter(value);
		}
		public double Height
		{
			get => height;
			set => height = SizeFilter(value);
		}

		public Rectangle(
			double width, double height, 
			int startX, int startY, int lineWidth, Color color
			) 
			: base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}

		public double GetDiagonal()
		{
			return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
		}
		public override double GetArea() => Width * Height;
		public override double GetPerimeter() => 2 * (Width + Height);
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)Width, (int)Height);
			DrawDiagonal(e);
        }
		public void DrawDiagonal(PaintEventArgs e)
		{
			e.Graphics.DrawLine(new Pen(Color, LineWidth), StartX, StartY, (float)(StartX + Width), (float)(StartY + Height));
		}
		public override void Info(PaintEventArgs e)
		{
            Console.WriteLine(this.GetType());
			Console.WriteLine($"Ширина прямоугольника: {Width}");
			Console.WriteLine($"Высота прямоугольника: {Height}");
            base.Info(e);
		}
	}
}
