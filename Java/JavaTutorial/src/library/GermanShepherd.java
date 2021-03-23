package library;

public class GermanShepherd extends Dog implements IBirthday // "extends" is how the class is inherited
{
	public void birthday() {		// method to add one to the age of the dog 
		
		System.out.println("Prev age is " + getAge());
		setAge(getAge() +1);
		System.out.println("Current age is " + getAge());
	}
	public GermanShepherd (String name, String bark, int age) {
		super(name, bark, age);
	}
	public GermanShepherd() {			// default constructor for the class
		super();
	}
}
