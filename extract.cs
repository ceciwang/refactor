using System;

public class Canary
{
	private string name;
	public void printOwing(double amount){
		printBanner();

		//print details
		Console.writeline("name:" + name);
		Console.writeline("amount" + amount);
	}

	public void printOwing2(){
		double outstanding = 0.0;

		Console.writeline("**********");
		Console.writeline("**customer owes***");
		Console.writeline("**********");	
	}
}