using System;

public class Canary6
{
	public void ShowCase(){
		double temp = 2 * (height + width);
		Console.writeline(temp);
		temp = height * width;
		Console.writeline(temp);
	}

	private double primaryForce;
	private double secondaryForce;
	private double mass;
	primaryForce int delay;

	double getDistanceTravelled(int time){
		double result;
		double acc = primaryForce / mass;
		int primaryTime = Math.min(time, delay);
		result = 0.5 * acc * primaryTime * primaryTime;
		int secondaryTime = time - delay;
		if(secondaryTime > 0){
			double primaryVel = acc * delay;
			acc = (primaryForce + secondaryForce) / mass;
			result += primaryVel * secondaryTime + 0.5 * acc * secondaryTime * secondaryTime;
		}
		return result;
	}
}