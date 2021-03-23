package banking;

public class account {
	
	public account account;
		
	public account getAccount() {
		return account;
	}
	public void setAccount(account account) {
		this.account = account;
	}
	private String Accountnumber;
	private String getAccountnumber() {
		return Accountnumber;
	}
	private void setAccountnumber(String accountnumber) {
		Accountnumber = accountnumber;
	}
	public String Description;
	public String getDescription() {
		return Description;
	}
	public void setDescription(String description) {
		Description = description;
	}
	private Double Balance = 0.00;
	public Double getBalance() {
		return Balance;
	}
	private void setBalance(Double balance) {
		Balance = balance;
	}
	
	
	
	public void deposit(double amount) throws Exception {
		if(amount < 0) {
			throw new Exception("Must be greater than ZERO");
		}else {
			setBalance(getBalance() + amount);
		}
	}
		
	public void withdraw(double amount) throws Exception {
		if(amount < 0) {
			throw new Exception("Must be greater than ZERO");
		}if(amount > Balance) {
			throw new Exception("Insufficient Funds");
		}
		setBalance(getBalance()- amount);
	}
	
	public void Transfer(account toAccount, double amount) throws Exception{
		withdraw(amount);
		toAccount.deposit(amount);
	}
	
	public account(String Accountnumber, String Description, Double Balance) {
		super();
		this.Accountnumber = Accountnumber;
		this.Description = Description;
		this.Balance = Balance;
	}
	public account() {
		this("New Account");
	}
	public account(String description2) {
		// TODO Auto-generated constructor stub
	}
}
