package Shapes;

public class Quad {

	
	public Quad() {}
	
	public int side1;
	public int side2;
	public int side3;
	public int side4;
	
	public int perimeter() {
		return side1 + side2 + side3 + side4;
	}
	
	public Quad(int s1, int s2, int s3, int s4) {
		side1 = s1;
		side2 = s2;
		side3 = s3;
		side4 = s4;
	}
}
