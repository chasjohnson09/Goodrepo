package banking;

public class SavingsAcconutComp {
	private account account = null;
	private double intRate = 0.12;
	
	public void deposit(double amount) throws Exception{
		account.deposit(amount);
	}
	public void withdraw(double amount) throws Exception{
		account.withdraw(amount);
	}
	public account getAccount() {
		return account;
	}
	public void setAccount(account account) {
		this.account = account;
	}
	public double getIntrate() {
		return intRate;
	}
	public void setIntrate(double intrate) {
		this.intRate = intRate;
	}
	public void transfer(double amount) throws Exception{
		account.Transfer(account, amount);
	}
	public void payInterest(int months) throws Exception{
		double interest = getBalance() * (intRate / 12) * months;
	}
	public double getBalance() {
		// TODO Auto-generated method stub
		return account.getBalance();
	}
	public SavingsAcconutComp(String description) {
		account = new account(description)
	}
	public SavingsAcconutComp() {
		this("New savings account");
	}
}
