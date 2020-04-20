using ACME.Interfaces;
using System.Reflection;
using static System.Configuration.ConfigurationManager;
using static System.Console;
using static System.Reflection.Assembly;


namespace ACME
{
	class Program
	{
		static void Main(string[] args)
		{
			string dllPath   = AppSettings["dllPath"];
			string className = AppSettings["className"];

			Assembly assembly = LoadFrom(dllPath);
			IExample obj      = (IExample)assembly.CreateInstance(className);
			string   output   = obj.Output();
			
			WriteLine(output);

			WriteLine("\nPress any key...");
			ReadLine();
		}
	}
}
