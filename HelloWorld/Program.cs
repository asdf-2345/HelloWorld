using System;
using System.Threading;
namespace HelloWorld
{
	class Program
	{
		public static void Main()
		{
			Write("HelloWorld!", 100);
			Console.ReadKey();
		}
		public static void Write(string str, int waitingTime){
			char[] a = str.ToCharArray();
			for(int b = 0; b < a.Length; b++){
				Console.Write(a[b]);
				Thread.Sleep(waitingTime);
			}
			Console.WriteLine();
		}
	}
}
