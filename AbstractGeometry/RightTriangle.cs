using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class RightTriangle : AbstrTriangle
	{
		double hypotenuse;
		double cathetus_A;
		double cathetus_B;

		double Hypotenuse
		{
			get => hypotenuse;
			set => hypotenuse = SizeFilter(value);
		}
		double Cathetus_A
		{
			get => cathetus_A;
			set => cathetus_A = SizeFilter(value);
		}
		double Cathetus_B
		{
			get => cathetus_B;
			set => cathetus_B = SizeFilter(value);
		}

		public RightTriangle(
			double hypotenuse, double cathetus_A, double cathetus_B,
			int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color )
		{
			Hypotenuse = hypotenuse;
			Cathetus_A = cathetus_A;
			Cathetus_B = cathetus_B;
		}

		public override double GetHeight() => Cathetus_A * Cathetus_B / Hypotenuse;
		public override double GetArea() => Cathetus_A * Cathetus_B / 2;
		public override double GetPerimeter() => Cathetus_A + Cathetus_B + Hypotenuse;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = new Point[]
			{
				new Point(StartX, StartY),
				new Point(StartX + (int)Cathetus_A, StartY),
				new Point(StartX + (int)Cathetus_A, StartY + (int)Cathetus_B),
			};
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
