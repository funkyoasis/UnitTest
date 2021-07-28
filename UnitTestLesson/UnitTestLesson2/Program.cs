using System;

namespace CodeToTest
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int timeofday = 21;
			var myGreeting = Greeting(timeofday);
			Console.WriteLine(myGreeting);
			int ageOfViewer = 14;
			var classification = AvailableClassifications(ageOfViewer);
			Console.WriteLine(classification);



		}
		public static string Greeting(int timeofday)
		{
			string greeting;
			if (timeofday >= 5 && timeofday <= 12)
			{
				greeting = "Good morning!";
			}
			else if (timeofday >= 12 && timeofday <= 18)
			{
				greeting = "Good afternoon!";
			}
			else
			{
				greeting = "Good evening!";
			}
			return greeting;
		}
		public static string AvailableClassifications(int ageOfViewer)
		{
			string result;
			if (ageOfViewer < 8)
			{
				result = "U films are available.";
			}
			else if (ageOfViewer >= 8 && ageOfViewer < 12)
			{
				result = "U, PG films are available.";
			}
			else if (ageOfViewer >= 12 && ageOfViewer < 15)
			{
				result = "U, PG, 12 & 12A films are available.";
			}
			else if (ageOfViewer >= 15 && ageOfViewer <18)
			{
				result = "U, PG, 12 & 12A & 15 films are available.";
			}
			else
			{
				result = "All films are available.";
			}
			return result;
		}
	}
}


