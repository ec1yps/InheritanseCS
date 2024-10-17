using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
			SetDirectory();

			StreamWriter sw = new StreamWriter(filename);

            foreach (Human i in group)
			{
				sw.WriteLine(i.ToFileString());
			}
			
			sw.Close();
			
			Process.Start("excel", filename);
		}
		internal static string SetDirectory()
		{
			string location = System.Reflection.Assembly.GetEntryAssembly().Location;
			string path = System.IO.Path.GetDirectoryName(location);
            Console.WriteLine(location);
            Console.WriteLine(path);
			Directory.SetCurrentDirectory($"{path}\\..\\..");
			Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine(delimiter);
            return Directory.GetCurrentDirectory();
		}
		internal static Human[] Load(string filename)
		{
			SetDirectory();

            List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);

			try
			{
				while (!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					string[] values = buffer.Split(';');
					values = values.Where(i => i != "").ToArray();
					if (values.Length == 1) continue;
                    Console.WriteLine(buffer);
					/*Human human = HumanFactory.Create(values[0]);
					human.Init(values);
					group.Add(human);*/
					group.Add(HumanFactory.Create(values[0]).Init(values));
                }
				sr.Close();
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }

			return group.ToArray();
		}
	}
}
