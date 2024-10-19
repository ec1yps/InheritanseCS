using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Triangle : Shape
	{
		double sideA;
		double sideB;
		double sideC;

		public double SideA
		{
			get => sideA;
			set => sideA = SizeFilter(value);
		}
		public double SideB
		{
			get => sideB;
			set => sideB = SizeFilter(value);
		}
		public double SideC
		{
			get => sideC;
			set => sideC = SizeFilter(value);
		}

		public Triangle(
			double sideA, double sideB, double sideC,
			int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public override double GetArea()
		{
			double p = GetPerimeter() / 2;
			return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
		}
		public override double GetPerimeter()
		{
			return SideA + SideB + SideC;
		}
		public double GetHeight(double side)
		{
			return 2 * GetArea() / side;

		}
		public double GetMaxSide()
		{
			return SideA > SideB && SideA > SideC ? SideA : SideB > SideA && SideB > SideC ? SideB : SideC;
		}
		public double GetMinSide()
		{
			return SideA < SideB && SideA < SideC ? SideA : SideB < SideA && SideB < SideC ? SideB : SideC;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			PointF[] points =
			{
				new PointF(StartX, StartY),
				new PointF(
							StartX + (float)Math.Sqrt(Math.Pow(GetHeight(GetMaxSide()), 2) + Math.Pow(GetMinSide(), 2)),
							StartY - (float)GetHeight(GetMaxSide())
						  ),
				new PointF(StartX + (float)GetMaxSide(), StartY)
			};
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}
