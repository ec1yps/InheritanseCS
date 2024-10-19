using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Squre : Rectangle
	{
		public Squre(double side, int startX, int startY, int lineWidth, Color color) :
			base(side, side, startX, startY, lineWidth, color) 
		{ }
		public override double GetArea()
		{
			return base.GetArea();
		}
		public override double GetPerimeter()
		{
			return base.GetPerimeter();
		}
		public override void Draw(PaintEventArgs e)
		{
			base.Draw(e);
		}
	}
}
