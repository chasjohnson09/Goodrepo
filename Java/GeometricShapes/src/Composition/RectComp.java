package Composition;

import Shapes.Quad;

public class RectComp {
	
	private Quad quad = null;
	
	public int perimeter() {
		return quad.perimeter();
	}
	
	public int area() {
		return quad.side1 * quad.side2;
	}
	public void RectC(int s1, int s2) {
		quad = new Quad(s1, s2, s1, s2);
	}
}
	
	

