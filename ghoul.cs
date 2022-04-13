using System;
using System.Threading;
namespace ghoul
{

    public class Program 
    {
        public static void Main()
        {
        	byte x = 0;
			for (int i = 1000; i>0; i-=7)
			{
				Random rnd = new Random();
				int Color = rnd.Next(0, 11);
				  switch (Color)
				  {
				  case 0:
				  Console.ForegroundColor = ConsoleColor.Red;
				  break;
				  case 1:
				  Console.ForegroundColor = ConsoleColor.Blue;
				  break;
				  case 2:
				  Console.ForegroundColor = ConsoleColor.Cyan;
				  break;
				  case 3:
				  Console.ForegroundColor = ConsoleColor.Gray;
				  break;
				  case 4:
				  Console.ForegroundColor = ConsoleColor.DarkGreen;
				  break;
				  case 5:
				  Console.ForegroundColor = ConsoleColor.Green;
				  break;
				  case 6:
				  Console.ForegroundColor = ConsoleColor.Yellow;
				  break;
				  case 7:
				  Console.ForegroundColor = ConsoleColor.DarkRed;
				  break;
				  case 8:
				  Console.ForegroundColor = ConsoleColor.Magenta;
				  break;
				  case 9:
				  Console.ForegroundColor = ConsoleColor.DarkBlue;
				  break;
				  case 10:
				  Console.ForegroundColor = ConsoleColor.DarkCyan;
				  break;
			}
			Console.WriteLine($"          {i}-7={i-7}");
			Thread.Sleep(100);
        }
        }
}
}