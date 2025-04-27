// Written by Andre
// 4/27/25
public class Solution {
    public int LengthOfLastWord(string s) {
        string[] data = s.Split(' ');
        for(int i = data.Count()-1; i>=0; i--) {
            if(data[i]!="") {
                return data[i].Length;
            }
        }
        return -1;
    }
}
public class Program {
	static void Main(string[] args) {
		string teststring = "Test string with last word length of four";
		Solution sol = new Solution();

		Console.WriteLine(sol.LengthOfLastWord(teststring));
	}
}
