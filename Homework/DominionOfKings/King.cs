// Written by Shatranj
// Date: 1/30/25

namespace DominionOfKings;

public class King
{
	// {{{ Class Vars
	private string name = "n/a";
	private int estateCount   = -1;
	private int duchyCount    = -1; //formatted to be here because i like it that way
	private int provinceCount = -1;
	/// }}} End of Class Vars
	
	// {{{ Getters und Setters
	public string Name {
		set { this.name = value; }
		get { return this.name;  }
	}
	public int EstateCount {
		set { this.estateCount = value; }
		get { return this.estateCount;  }
	}
	public int DuchyCount {
		set { this.duchyCount = value; }
		get { return this.duchyCount;  }
	}
	public int ProvinceCount {
		set { this.provinceCount = value; }
		get { return this.provinceCount;  }
	}
	// }}} End of Getters und Setters
	
	public int Score() {
		int score = 0;
		score += estateCount   * 1; //multiply the counts by their respective values
		score += duchyCount    * 3;
		score += provinceCount * 6;
		return score;
	}
}
