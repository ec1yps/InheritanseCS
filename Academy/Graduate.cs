using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate : Student
	{
		public string Theme { get; set; }

		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double ratirng, double attandance,
			string theme
			) : base(lastName, firstName, age, speciality, group, ratirng, attandance)
		{
			Theme = theme;
            Console.WriteLine($"GConstructor:{GetHashCode()}");
        }
		~Graduate() 
		{
            Console.WriteLine($"GDestructor:{GetHashCode()}");
		}

		public override void Print()
		{
			base.Print();
            Console.WriteLine($"{Theme}");
        }
		public override string ToString()
		{
			return base.ToString() + $" {Theme}";
		}
		public override string ToFileString()
		{
			return base.ToFileString() + $",{Theme}";
		}
	}
}
