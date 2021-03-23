package Shapes;

public class Rectangle {

	public Rectangle() {}
	
	public int side1;
	public int side2;
	
	public int perimeter() {
		return (side1 + side2) * 2;
	}
	
	public int area() {
		return side1 * side2;
	}
	
	public Rectangle(int s1, int s2) {
		side1=s1;
		side2=s2;
	}
}
	
