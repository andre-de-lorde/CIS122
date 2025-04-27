// Written by Andre
// 4/27/25
public class Solution {
    public bool IsHappy(int n) {
        int counter = 0;
        string oldsum;
        int sum = n;
        while(sum != 1 && counter < 10) {
            oldsum = Convert.ToString(sum);
            sum = 0;
            foreach(char c in oldsum) {
                sum += ((byte)c-48)*((byte)c-48); //48 is the index for 0 on the ascii table
            }
            counter++;
        }
        return sum == 1;
    }
}
public class Program {
	static void Main(string[] args) {
		if(args.Count() == 0) {
			Console.WriteLine("Input a number as a command line argument.");
			return;
		}
		Console.WriteLine($"Printing all happy numbers up to {args[0]}");
		Solution sol = new Solution();
		for(int i = 0; i<=Int32.Parse(args[0]); i++) {
			if(sol.IsHappy(i)) {
				Console.Write($"{i},");
			}
		}
		Console.WriteLine("\b ");
	}
}

