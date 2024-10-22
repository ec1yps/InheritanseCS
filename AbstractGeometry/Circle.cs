using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle : Shape, IHaveDiameter
	{
		double radius;

		public double Radius
		{
			get => radius;
			set => radius = SizeFilter(value);
		}

		public Circle(
			double radius, int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{ 
			Radius = radius;
		}

		public double GetDiameter()
		{
			return 2 * Radius;
		}
		public override double GetArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
		public override double GetPerimeter()
		{
			return 2 * Math.PI * Radius;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)Radius * 2, (float)Radius * 2);
			DrawDiameter(e);
		}
		public void DrawDiameter(PaintEventArgs e)
		{
			int dx = (int)(Radius * (1 - 1/Math.Sqrt(2)));
			//e.Graphics.DrawLine(new Pen(Color, LineWidth), StartX, StartY + (float)Radius, StartX + (float)GetDiameter(), StartY + (float)Radius);
			e.Graphics.DrawLine(new Pen(Color, LineWidth), StartX + dx, StartY + dx, StartX + (int)GetDiameter() - dx, StartY + (int)GetDiameter() - dx);
		}
		public override void Info(PaintEventArgs e)
		{
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Радиус круга: {Radius}");
            Console.WriteLine($"Диаметр круга: {GetDiameter()}");
            base.Info(e);
		}
	}
}