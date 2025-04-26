// Written by Andre
// 4/25/25
public class Solution {
    public char FindTheDifference(string s, string t) {
        List<char> db = t.ToList();
        foreach(char c in s) {
            db.Remove(c);
        }
        return db[0];
    }
}
public class Program {
	static void Main(string[] args) {
		string teststring1 = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
		string teststring2 = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaabaaaaaaaaaaaa";
		Solution sol = new Solution();
		Console.WriteLine(sol.FindTheDifference(teststring1,teststring2));
	}
}
