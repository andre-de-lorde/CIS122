// Written by Andre
// 2/27/25

namespace Homework5;

// {{{ Parent Class Animal
public class Animal { //Hey, I've seen this before! \n What do you mean? It's brand new.
	public string Name {get;set;}

	public Animal(string pName) {
		this.Name = pName;
	}

	public virtual string MakeSound() {
		return "Splat";
	}

	public override string ToString() {
		return $"Animal: {this.Name}, Sound: {MakeSound()}";
	}
}
// }}} Parent Class Animal

// {{{ Child Classes Dog, Cat of Animal
public class Cat : Animal {
	
	public Cat(string pName) : base(pName) {}

	public override string MakeSound() {
		return "Meow.";
	}

	public override string ToString() {
		return $"Cat: {this.Name}, Sound: {MakeSound()}";
	}
}

public class Dog : Animal {
	public Dog(string pName) : base(pName) {}

	public override string MakeSound() {
		return "Woof.";
	}

	public override string ToString() {
		return $"Dog: {this.Name}, Sound: {MakeSound()}";
	}
}
// }}} Child Classes Dog, Cat of Animal

