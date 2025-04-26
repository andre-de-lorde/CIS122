// Written by Andre
// 4/25/25
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string output = "";
        for(int i = 0; (i < word1.Length) | (i < word2.Length); i++) {
            if (i<word1.Length){
               output += word1[i];
            }
            if (i<word2.Length) {
                output += word2[i];
            }
        }
        return output;
    }
}
public class Program {
	static void Main(string[] args) {
		string teststring1 = "Iv oet aea noneet hdwteHdeo sa";
		string teststring2 = "'ecm omk nanucmn,Sao h eghgi -";
		Solution sol = new Solution();
		Console.WriteLine(teststring1);
		Console.WriteLine(teststring2);
		Console.WriteLine(sol.MergeAlternately(teststring1,teststring2));
	}
}
