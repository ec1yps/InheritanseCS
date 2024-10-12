using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Streamer
	{
		static readonly string delimiter = "\n---------------------------------------------------\n";
		internal static void Print(Human[] group)
		{
			Console.WriteLine(delimiter);
			foreach (Human i in group)
			{
				Console.WriteLine(i.ToString());
			}
			Console.WriteLine($"Количество человек в группе: {group.Length}");
			Console.WriteLine(delimiter);
		}
		internal static void Save(Human[] group, string filename)
		{
			StreamWriter sw = new StreamWriter(filename);
			foreach (Human i in group)
			{
				sw.WriteLine(i.ToFileString());
			}
			sw.Close();
			Process.Start("notepad", filename);
		}
	}
}
