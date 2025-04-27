// Written by Andre
// 4/26/25
public class Solution {
    public bool IsValid(string s) {
        List<byte> db = new List<byte>();
        foreach(char i in s) {
            switch(i) {
                case '(':
                    db.Add(0);
                    break;
                case ')':
                    if(db.Count > 0 && db[^1]==0) {
                        db.RemoveAt(db.Count-1);
                    } else {
                        return false;
                    }
                    break;
                case '[':
                    db.Add(1);
                    break;
                case ']':
                    if(db.Count > 0 && db[^1]==1) {
                        db.RemoveAt(db.Count-1);
                    } else {
                        return false;
                    }
                    break;
                case '{':
                    db.Add(2);
                    break;
                case '}':
                    if(db.Count > 0 && db[^1]==2) {
                        db.RemoveAt(db.Count-1);
                    } else {
                        return false;
                    }
                    break;
            }
        }
        return db.Count==0;
    }
}
public class Program {
	static void Main(string[] args) {
		string teststring = "((((({{{{{}}}}})))))";
		Solution sol = new Solution();
		Console.WriteLine(sol.IsValid(teststring));
	}
}
