// Written by Andre
// 4/26/25
public class Solution {
    public int CalPoints(string[] operations) {
        List<int> record = new List<int>();
        foreach(string i in operations) {
            switch(i) {
                case "+":
                    record.Add(record[^1]+record[^2]);
                    break;
                case "D":
                    record.Add(record[^1]*2);
                    break;
                case "C":
                    record.RemoveAt(record.Count()-1);
                    break;
                default:
                    record.Add(Convert.ToInt32(i));
                    break;
            }
        }
        return record.Sum();
    }
}
public class Program {
	static void Main(string[] args) {
		Console.WriteLine("11+++++++++++++++D");
		Solution sol = new Solution();
		string[] testarray = {"1","1","+","+","+","+","+","+","+","+","+","+","+","+","+","+","+","D"};
		Console.WriteLine(sol.CalPoints(testarray));
	}
}
