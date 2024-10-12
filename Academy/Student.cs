using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Academy
{
	internal class Student : Human
	{
		static readonly int SPECIALITY_WIDTH = 24;
		static readonly int GROUP_WIDTH = 8;
		static readonly int RATING_WIDTH = 8;
		static readonly int ATTANDANCE_WIDTH = 8;
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attandance { get; set; }

		public Student
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attandance
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attandance = attandance;
            Console.WriteLine($"SConstructor:{GetHashCode()}");
        }
		~Student()
		{
			Console.WriteLine($"SDestructor:{GetHashCode()}");
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality} {Group} {Rating} {Attandance}");
		}
		public override string ToString()
		{
			return base.ToString() + $" {Speciality.PadRight(SPECIALITY_WIDTH)} {Group.PadRight(GROUP_WIDTH)} {Rating.ToString().PadRight(RATING_WIDTH)} {Attandance.ToString().PadRight(ATTANDANCE_WIDTH)}";
		}
		public override string ToFileString()
		{
			return base.ToFileString() + $";{Speciality};{Group};{Rating};{Attandance}";
		}
	}
}
