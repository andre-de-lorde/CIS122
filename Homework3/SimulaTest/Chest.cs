// Written by Andre
// 2/17/25

namespace SimulaBox;
public enum ChestState { Locked, Closed, Open, Broken }
public class Chest {
	ChestState state = ChestState.Locked;

	public ChestState State {
		get { return this.state; }
		//no set, read only
	}

	public bool Action(string action) {
		switch (action) {
			case "lock":
				if (this.state == ChestState.Closed) {
					this.state = ChestState.Locked;
					return true;
				} else {
					return false;
				}
			case "unlock":
				if (this.state == ChestState.Locked) {
					this.state = ChestState.Closed;
					return true;
				} else {
					return false;
				}
			case "close":
				if (this.state == ChestState.Open) {
					this.state = ChestState.Closed;
					return true;
				} else {
					return false;
				}
			case "open":
				if (this.state == ChestState.Closed) {
					this.state = ChestState.Open;
					return true;
				} else {
					return false;
				}
			default:
				this.state = ChestState.Broken;
				return true;
		}
	}

	public override string ToString() {
		if      (this.state == ChestState.Locked) { return "locked"; }
		else if (this.state == ChestState.Closed) { return "closed"; }
		else if (this.state == ChestState.Open  ) { return "open"  ; }
		else                                      { return "broken"; }
	} 
}
