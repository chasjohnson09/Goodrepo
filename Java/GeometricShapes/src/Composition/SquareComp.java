package Composition;

import Shapes.Rectangle;

public class SquareComp {
	private Rectangle rect = null;
	
	public int Perimeter() {
		return rect.perimeter();
	}
	
	public int Area() {
		return rect.area();
	}
	public void SquareC(int s1) {
		rect = new Rectangle(s1, s1);
	}
}
