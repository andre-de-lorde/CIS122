// Written by Andre
// 4/26/25
using System.Diagnostics;
public class RecentCounter {
    List<int> pings = new List<int>();
    public RecentCounter() {
        //List<int> pings = new List<int>();
    }
    
    public int Ping(int t) {
        this.pings.Add(t);
        int output=0;
        for(int i=pings.Count-1; i>=0; i--) {
            if((t-pings[i])<=3000) {
                output++;
            } else {
                break;
            }
        }
		/*
		Console.Write("[");
		foreach(int i in pings) {
			Console.Write($"{i},");
		}
		Console.Write("\b]");
		*/
        return output;
    }
}
public class Program {
	static void Main(string[] args) {
		RecentCounter counter = new RecentCounter();
		Stopwatch sw = Stopwatch.StartNew();
		Console.WriteLine("Press any key to ping. Q to quit.");
		while(true) {
			Console.WriteLine($"Ping. There were {counter.Ping((int)sw.Elapsed.TotalMilliseconds)} pings in the last 3 seconds.");
			if (Console.ReadKey(true).Key==ConsoleKey.Q) {
				break;
			}
		}
	}
}
