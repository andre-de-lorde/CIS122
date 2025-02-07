// Written by Andre de Lorde
// 2/6/25
namespace BuyingInventory;
public class Program {
	static void Main(string[] args) {
		string menu = @"The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
What number do you want to see the price of? ";
		Console.Write(menu);
		int choice = Convert.ToInt32(Console.ReadLine());

		Console.Write("And what's your name? ");
		string name = Console.ReadLine();
		bool discounted = false;
		if (name == "Andre") {
			discounted = true;
		}

		string item = "Leaving";
		int price = -1;
		switch (choice) { // i really feel like using a dictionary of tuples right about now
			case 1:
				item = "Rope";
				price = 10;
				break;
			case 2:
				item = "Torch";
				price = 15;
				break;
			case 3:
				item = "Climbing Equipment";
				price = 25;
				break;
			case 4:
				item = "Clean Water";
				price = 1;
				break;
			case 5:
				item = "Machete";
				price = 20;
				break;
			case 6:
				item = "Canoe";
				price = 200;
				break;
			case 7:
				item = "Food Supplies";
				price = 1;
				break;
			default:
				Console.WriteLine("That's not an item, silly.");
				break;
		}

		Console.Write($"{item} will cost you ");
		if (price < 0) {
			Console.WriteLine("nothing.");
			if (item == "Leaving") {
				Console.WriteLine("Come back when you can order right!");
			}
		} else {
			Console.WriteLine($"{price} gold.");
		}
		
		if (discounted) {
			Console.WriteLine($"But for you, {name}, I'll give you it half off.");
			Console.WriteLine($"Only {price/2} gold for you, pal.");
		}
	}
}
