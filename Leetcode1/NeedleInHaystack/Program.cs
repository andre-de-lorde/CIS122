// Written by Andre
// 4/3/25

namespace NeedleInHaystack;
public class Program {
	static int FindNeedle(string haystack, string needle) { //uh oh i might've done this question on the quiz wrong if it was just a normal string here instead of a list oops
		if (needle.Length > haystack.Length) { return -1; }
		for (int i = 0; i <= haystack.Length-needle.Length; i++) { // simplified version of earlier code that returned -1 if the the length of needle no longer fit in haystack given the value of i
			if (haystack.Substring(i, needle.Length) == needle) { return i;  }
		}
		return -1;
	}

	static void Main(string[] args) {
		string haystack = "ATAOJIFAJUIJKSNUIABNIUJFUHBAUHFUBFhNARJOAINROKSANKNDOIAMSD";
		string needle   = "h";
		int    position = FindNeedle(haystack,needle);
		Console.WriteLine($"The needle is at position {position}");
		Console.WriteLine(haystack);
		for (int i = 0; i < position; i++) {
			Console.Write(" ");
		}
		Console.WriteLine("↑ there, see?"); // i don't have to do this but i did it because i will do what i so wish according to my own whim and flights of fancy and no king or other upstart tyrannical sovereign can cease my whimsy
	}
}
