//#define INHERITANCE_CHECK
#define HUMAN_ARRAY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{

#if INHERITANCE_CHECK
			Human human = new Human("Montana", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96);
			student.Print();
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Print();
			Console.WriteLine(teacher);

			Graduate graduate = new Graduate("Mercer", "Alex", 45, "Biology", "AA_123", 90, 90, "Biomutation");
			graduate.Print();
			Console.WriteLine(graduate);
#endif
#if HUMAN_ARRAY
			Human[] group =
			{
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 95, 96),
				new Human("Montana", "Antonio", 25),
				new Graduate("Mercer", "Alex", 45, "Biology", "AA_123", 90, 90, "Biomutation"),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
			};
			Streamer.Print(group);

			string filename = "Group.txt";
			Streamer.Save(group, filename);
			//Load(filename);
#endif
		}

		
		static void Load(string filename)
		{
			StreamReader sr = new StreamReader(filename);
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
			sr.Close();
		}
	}
}
