using System;

namespace Cosole2
{
	class MainClass
	{
		private static int N = 10;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");



			for (int i = 0; i < N; i++)
			{
				Prn ();

			}
				
		}

		private static void Prn()
		{
			Console.Write ("#");
		}
	}
}
