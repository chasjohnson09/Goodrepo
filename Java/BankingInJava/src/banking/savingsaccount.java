package banking;

public class savingsaccount extends account {

	
	private double intRate = 0.12;
	
	public double getIntRate() { return intRate;}
	public void setIntRate(double intRate) {
		this.intRate = intRate;
	}
	public void payInterest(int months) throws Exception{
		double interest = getBalance() * (intRate/12) * months;
	}
	public savingsaccount(String description) {
		super(description);
	}
	
	public savingsaccount() {
		this("New Savings");
	}

}
