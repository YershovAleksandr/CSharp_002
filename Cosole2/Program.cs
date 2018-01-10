using System;

namespace Cosole2
{
	class MainClass
	{
		//private static int N = 9;
		private static int N = 5;

		private static int[,] Data;
		private static int[,] ResData;

		private static int dgr = 45;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");


			Data = new int[N,N];
			ResData = new int[N,N];

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
				
					Data [i,j] = 10 * (i + 1) + j + 1;
					Prn (Data[i, j]);
				}

				Console.WriteLine ("");
			}

			Console.WriteLine ("All Data");

			PrnAll(Data);

			Console.WriteLine ("All Res Data");

			PrnAll(ResData);
				
		}

		private static void Prn(int data)
		{
			
			//Console.Write ("#");
			Console.Write (" " + data.ToString());
		}

		private static void PrnAll(int[,] data)
		{
			for (int i = 0; i < N; i ++)
			{
				for (int j = 0; j < N; j++)
				{
					Prn(data[i,j]);
				}
				Console.WriteLine ("");
			}
		}

	}
}
