import library.GermanShepherd;
import library.Mathematics;
import library.*;

public class Program {

	public static void main(String[] args) {
		System.out.println("Hello world");
		GermanShepherd gs = new GermanShepherd("King", "Woof",2);	// adding a dog to gs
		gs.birthday();
		
		Collie col = new Collie("Lassie", "Hello", 50);	// adding a collie to the class
//		Dog[] dogs = new Dog[] {gs, col};				// setting an array 
		IBirthday[] dogs = new IBirthday[2];
		dogs[0]= gs;						// these are the same thing just two different ways
		dogs[1]= col;
		for(IBirthday dog : dogs) {		// for each statement 
			System.out.printf("The dog's birthday:  ");
			dog.birthday();
		}
								// "\n" makes the print method start a new line for the next index
//		IBirthday[] dogs = new IBirthday[2];
//		Mathematics math = new Mathematics();
//		int a = 12;
//		int b = 3;

	}

}
