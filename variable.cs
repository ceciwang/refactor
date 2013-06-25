using System;

public class Canary5
{
	private string platform;
	private string browser;
	private int resize;

	public void ShowCase(){
		if((platform.toUpperCase().indexOf('MAC') > -1) &&
			(browser.toUpperCase().indexOf("IE") > -1) &&
			wasInitialized() && resize > 0)
		{
			// do sth
		}
		
	}

	private boolean wasInitialized(){
		return true;
	}


	private int quantity;
	private double itemPrice;
	//reality
	double price(){
		return quantity * itemPrice -
		Math.max(0, quantity - 500) * itemPrice * 0.05 +
		Math.min(quantity* itemPrice * 0.1, 100.0);
	}

}