using System;

public class Canary4
{

	public void ShowCase(){
		double basePrice = anOrder.basePrice();
		return (basePrice > 1000)
	}

	private int quantity;
	private double itemPrice;

	public void ShowCase2(){
		double basePrice = quantity * itemPrice;
		if(basePrice > 1000)
			return basePrice * 0.95;
		else
			return basePrice * 0.98;
	}


//reality

	public void getPrice(){
		int basePrice = quantity * itemPrice;
		double discountFactor;
		if(basePrice > 1000)  
			discountFactor = 0.95;
		else 
			discountFactor = 0.98;
		return basePrice * discountFactor;
	}

}