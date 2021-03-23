package library;

public class Mathematics {
	
	public int add(int a, int b) {
		return a + b;
	}
	public int subtract(int a, int b) {
		return a - b;
	}
	public int multiply(int a, int b) {
		return a * b;
	}
	public int divide(int a, int b) {
		return a / b;
	}
	public int modulo(int a, int b) {
		return a % b;
	}
	public int pow(int a, int b) {
		int power = 1;
		for(int i= 0; i < b; i++) {
			power *= a;
		}
		return power;
	}

}
