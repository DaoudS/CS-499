package main;
public class Monkey extends RescueAnimal{
	// Instance variable
	public String species;
	private double tailLength;
	private double height;
	private double bodyLength;
	private double torsoMeas;
	private double skullMeas;
	private double neckMeas;

	// Constructor
	public Monkey(){
	}

	// Accessor Method
	public String getSpecies() {
		return species;
	}
	public double getTailLength() {
		return this.tailLength;
	}
	public double getHeight() {
		return this.height;
	}
	public double getBodyLength() {
		return this.bodyLength;
	}
	public double getTorsoMeas() {
		return this.torsoMeas;
	}
	public double getSkullMeas() {
		return this.skullMeas;
	}
	public double getNeckMeas() {
		return this.neckMeas;
	}
	
	// Mutator Method
	public void setSpecies(String monkeySpecies){
		species = monkeySpecies;
	}
	
	public void setTailLength(double tailLength) {
		this.tailLength = tailLength;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	public void setBodyLength(double bodyLength) {
		this.bodyLength = bodyLength;
	}

	public void setTorsoMeas(double torsoMeas) {
		this.torsoMeas = torsoMeas;
	}

	public void setSkullMeas(double skullMeas) {
		this.skullMeas = skullMeas;
	}

	public void setNeckMeas(double neckMeas) {
		this.neckMeas = neckMeas;
	}
}