// Written by Shatranj
// 1/30/25

namespace DefenseOfConsolas;

using System;
using System.Threading;

public class Program {
	static void Main(string[] args) {
		string backupTitle;
		ConsoleColor backupColor = Console.ForegroundColor;
		if (System.OperatingSystem.IsWindows()) {
			backupTitle = Console.Title; //archive the console title so we can set it back later like a good little program
		} else {
			backupTitle = "Defense of Consolas"; //unlucky lol
		}
		Console.Title = "Defense of Consolas";

		Console.Write("Target Row/X Coordinate? ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.Write("Target Column/Y Coordinate? ? ");
		int y = Convert.ToInt32(Console.ReadLine());

		List<Tuple<int,int>> offsets = new List<Tuple<int,int>>();
		offsets.Add(new Tuple<int,int>(0,1));
		offsets.Add(new Tuple<int,int>(1,0));
		offsets.Add(new Tuple<int,int>(0,-1));
		offsets.Add(new Tuple<int,int>(-1,0));
		Console.ForegroundColor = ConsoleColor.Yellow;

		Console.Write("Deploy to: ");
		foreach (Tuple<int,int> offset in offsets) {
			int off_x=offset.Item1;
			int off_y=offset.Item2;
			Console.Write($"({x+off_x},{y+off_y})");
		}
		Console.Write("\b\n"); //delete the trailing comma and go to newline

		
		Console.Beep(); //shave and a haircut
		Thread.Sleep(250);
		Console.Beep();
		Thread.Sleep(250);
		Console.Beep();
		Thread.Sleep(125);
		Console.Beep();
		Thread.Sleep(250);
		Console.Beep();
		Thread.Sleep(600);
		Console.Beep(); //two bits
		Thread.Sleep(250);
		Console.Beep();

		Console.Title=backupTitle;
		Console.ForegroundColor = backupColor;
	}
}
