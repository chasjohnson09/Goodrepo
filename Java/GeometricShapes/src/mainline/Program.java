package mainline;

import Shapes.Quad;
import Shapes.Square;
import Shapes.Rectangle;



public class Program {

	public static void main(String[] args) {
		
		Quad quad1 = new Quad(3,4,5,6);
		quad1.perimeter();
		System.out.println("Perimeter of the Quad is " + quad1.perimeter());
		System.out.println("  ");
		
		Rectangle rectangle = new Rectangle(3,4);
		rectangle.perimeter();
		rectangle.area();
		System.out.println("Perimeter of the Rectangle is " + rectangle.perimeter());
		System.out.println("Area of the Rectangle is " + rectangle.area());
		System.out.println("   ");
		
		Square square = new Square(3);
		square.perimeter();
		square.area();
		System.out.println("Perimeter of the Square is " + square.perimeter());
		System.out.println("Area of the Square is " + square.area());
	}

}
