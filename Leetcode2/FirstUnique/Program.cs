// Written by Andre
// 4/25/25
public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> db = new Dictionary<char,int>();
        foreach(char c in s) {
            if(db.ContainsKey(c)) {
                db[c]++;
            } else {
                db[c]=1;
            }
        }
        for(int i = 0; i<s.Length; i++) {
            if (db[s[i]] == 1) {
                return i;
            }
        }
        return -1;
    }
}
public class Program {
	static void Main(string[] args) {
		string teststring = "aaaabaaaa";
		Solution sol = new Solution();
		Console.WriteLine(sol.FirstUniqChar(teststring));
	}
}
