// Written by Andre
// 2/27/25

using System;

namespace Homework5;

// this one specified abstract, should i not have done the other ones abstract
// eh, it didn't say i couldn't, and there should be no side effects from doing it that way
// i like to not give anyone the ability to do things they don't or shouldn't need to
// principle of least privilege and all that jazz
//
// EDIT: nevermind changing the others

// {{{ Abstract Parent Class Shape
public abstract class Shape {
	public string Color {get;set;}
	
	public abstract double GetArea();

	public Shape(string pColor) { // didn't tell us to but i'm doing it anyways because i can
		this.Color = pColor;
	}

	public override string ToString() { // i have no clue why i need to implement this if we're gonna override it anyways
		return $"{this.Color} Shape";   // this is an abstract class by definition it's never going to be used i think
	}
}
// }}} Abstract Parent Class Shape

// {{{ Child Classes Circle, Rectangle of Shape
public class Circle : Shape {
	public double Radius {get;set;}
	
	public Circle(string pColor, double pRadius) : base(pColor) {
		this.Radius = pRadius;
	}

	public override double GetArea() {
		return Math.PI * this.Radius * this.Radius;
	}

	public override string ToString() {
		return $"{this.Color} Circle with area {GetArea()}";
	}
}

public class Rectangle : Shape {
	public double Width  {get;set;}
	public double Height {get;set;}

	public Rectangle(string pColor, double pWidth, double pHeight) : base(pColor) {
		this.Width  = pWidth;
		this.Height = pHeight;
	}

	public override double GetArea() {
		return this.Width * this.Height;
	}

	public override string ToString() {
		return $"{this.Color} Rectangle with area {GetArea()}";
	}
}
/// }}} Child Classes Circle, Rectangle of Shape

