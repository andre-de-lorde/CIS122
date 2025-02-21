// Written by Andre
// 2/20/25


namespace Homework4;

public class Program {
	static int countWords(string data) {
		//there's a better way to do this using flags to account for stuff like em dashes and stuff but i don't really wanna
		return data.Split(" ").Length; // splits the sentence by spaces and returns however many words we're guessing there are
	}
	static string flipEndChars(string data) {
		if (data.Length == 2) {	return "Incompatible.";	}
		char first_letter = data[0];
		char last_letter  = data[^1];
		if (first_letter == last_letter) { return "Two's a pair."; }


		string output = "";
		output += last_letter;
		for (int i = 1; i<data.Length-1; i++) {
			output += data[i];
		}
		output += first_letter;

		return output;
	}
	static bool isInOrder(string data) {
		char char_buffer = (char) 0; //that type cast that i hate
		foreach (char i in data) {
			if (char_buffer > i) {
				return false;
			}
			char_buffer = i;
		}
		return true;
	}
	static string firstNVowels(string data, int N) {
		int index = 0;
		string output = "";
		while ((index < data.Length) && (N > 0)) {
			if ("aeiou".Contains(data.ToLower()[index])) { //yeah i know and sometimes W and Y but i'm not doing phoenetic analysis dude
				// ^the above code converts the character at index in data to lowercase and checks if it's inside the [kinda] list of vowels
				output += data[index];
				N--;
			}
			index++;
		}
		return output;
	}
	static string move(string data) {
		string output = "";
		for (int i = 0; i < data.Length; i++) {
			char c_buf = data[i];
			c_buf++;
			output += c_buf; //increment the character
		}
		return output;
	}
	static void Main(string[] args) {
		Console.WriteLine($"countWords(\"Did you know?\") = {countWords("Did you know?")}");

		Console.WriteLine($"flipEndChars(\"abc\") = {flipEndChars("abc")}");
		Console.WriteLine($"flipEndChars(\"ab\") = {flipEndChars("ab")}");
		Console.WriteLine($"flipEndChars(\"aba\") = {flipEndChars("aba")}");

		Console.WriteLine($"isInOrder(\"abc\") = {isInOrder("abc")}");
		Console.WriteLine($"isInOrder(\"cba\") = {isInOrder("cba")}");

		Console.WriteLine($"firstNVowels(\"John Madden.\", 3) = {firstNVowels("John Madden.", 3)}");
		
		Console.WriteLine($"move(\"out of the way\") = {move("out of the way")}");
	}
}
