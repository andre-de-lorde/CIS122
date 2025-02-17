// Written by Andre
// 2/17/25

namespace SimulaBox;
public class Program {
	static void Main(string[] args) {
		string action = "nothing";
		Chest chest = new Chest();
		while (action != "quit") {
			Console.WriteLine($"The chest is {chest}.");
			Console.Write("What do you want to do? ");
			action = Console.ReadLine();
			if (action != "quit") {
				if (chest.Action(action)) {
					Console.WriteLine($"You {action}ed the chest.");
					if (chest.State == ChestState.Broken) {
						Console.WriteLine("You broke it. Nice.");
					}
				} else {
					Console.WriteLine($"You can't {action} the chest right now.");
				}
			}
		}
	}
}



