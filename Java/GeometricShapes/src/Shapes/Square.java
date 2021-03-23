package Shapes;

public class Square {

	public Square() {}
	
	public int side1;
	
	public int perimeter() {
		return side1 * 4;
	}
	
	public int area() {
		return side1 * side1;
	}
	
	public Square(int s1) {
		side1 = s1;
	}
}
