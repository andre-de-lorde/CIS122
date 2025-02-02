// Written by Shatranj
// 1/30/25

namespace DominionOfKings;

public class Program {
	static void Main(string[] args) {
		Console.Write("How many kings are there? ");
		int kingCount = Convert.ToInt32(Console.ReadLine()); // read user input into integer
		//no need for newline, user input does that

		King kingBuffer; // this is a surprise tool that will help us later
		List<King> Kings = new List<King>();

		int loopCount = 0;
		while (loopCount < kingCount) {
			kingBuffer = new King();
			Console.WriteLine($"Input values for King {loopCount+1}:");

			Console.Write("King's Name: ");
			kingBuffer.Name = Console.ReadLine();

			Console.Write("Estate Count: ");
			kingBuffer.EstateCount   = Convert.ToInt32(Console.ReadLine());

			Console.Write("Duchy Count: ");
			kingBuffer.DuchyCount    = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Province Count: ");
			kingBuffer.ProvinceCount = Convert.ToInt32(Console.ReadLine());

			Kings.Add(kingBuffer);
			loopCount++;
		}

		King winner = new King();
		foreach (King contender in Kings) {
			if (winner.Score() < contender.Score()) {
				winner = contender;
			}
		}

		Console.Write("\n"); //go to newline
		Console.WriteLine($"The winner is {winner.Name} with {winner.Score()} points!");
		Console.WriteLine($"Breakdown: {winner.EstateCount} estates, {winner.DuchyCount} duchies, and {winner.ProvinceCount} provinces.");
	}
}
