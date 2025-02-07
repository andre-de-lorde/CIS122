// Written by Andre de Lorde
// 2/6/25
namespace Watchtower;

public class Program {
	static void Main(string[] args) {
		Console.Write("X: ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.Write("Y: ");
		int y = Convert.ToInt32(Console.ReadLine());
		bool north = false;
		bool east = false;
		bool south = false;
		bool west = false;
		if (x > 0) {
			east = true;
		} else if (x < 0) {
			west = true;
		}

		if (y > 0) {
			north = true;
		} else if (y < 0) {
			south = true;
		}
		if (!(north|east|south|west)) {
			Console.WriteLine("The enemy is upon us!");
		} else {
			Console.Write("The enemy is to the ");
			if (north) { Console.Write("north"); }
			if (east ) { Console.Write("east");  }
			if (south) { Console.Write("south"); }
			if (west ) { Console.Write("west");  }
			Console.Write("!\n");
		}
	}
}
