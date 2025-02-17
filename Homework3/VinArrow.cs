// Written by Andre
// 2/17/25

namespace Arrows;


public enum Arrowheads { Steel, Wood, Obsidian };
public enum Fletchings { Plastic, TurkeyFeathers, GooseFeathers };
public class Arrow {
	public Arrowheads Arrowhead {get; set;}
	public int ShaftLength { get; }
	public Fletchings Fletching {get; set;}

	// {{{ Gets & Sets
	public Arrow(Arrowheads arrowhead, int shaftLength, Fletchings fletching) {
		if (shaftLength < 60) {
			ShaftLength = 60;
		} else if (shaftLength > 100) {
			ShaftLength = 100;
		} else {
			ShaftLength = shaftLength;
		}
		Arrowhead = arrowhead;
		Fletching = fletching;
	}
	// }}} Gets & Sets

	public float GetCost() {
		float cost = 0;
		switch (Arrowhead) {
			case Arrowheads.Steel:
				cost += 10;
				break;
			case Arrowheads.Wood:
				cost += 3;
				break;
			case Arrowheads.Obsidian:
				cost += 5;
				break;
			default:
				cost += 1773; //should never happen so i use a random number
				break;
		}
		switch (Fletching) {
			case Fletchings.Plastic:
				cost += 10;
				break;
			case Fletchings.TurkeyFeathers:
				cost += 5;
				break;
			case Fletchings.GooseFeathers:
				cost += 3;
				break;
			default:
				cost += 1773; //refer to above comment
				break;
		}
		cost += (float) (0.05 * this.ShaftLength); //HATE
		return cost;
	}
}
