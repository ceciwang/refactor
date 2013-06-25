using System;

public class Canary3
{
	private int numberOfLateDeliveries;

	public int GetRating(){
		return (MoreThanFiveLateDeliveries()) ? 2 : 1;
	}

	private boolean MoreThanFiveLateDeliveries (){
		return numberOfLateDeliveries > 5;
	}

}