using System;

public class CanaryAfter4
{
	private int quantity;
	private double itemPrice;

	public void getPrice(){
		return basePrice() * discountFactor();
	}

	private double basePrice(){
		return quantity * itemPrice
	}

	private double discountFactor(){
		if(basePrice() > 1000)  
			return 0.95;
		else 
			return 0.98;
	}

}