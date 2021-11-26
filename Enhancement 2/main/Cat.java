package main;
public class Cat extends RescueAnimal {
    // Instance variable
    public String breed;
    public float whiskerLen;
    // Constructor
    public Cat() {

    }
    // Accessor Method
    public String getBreed() {
        return breed;
    }
    // Mutator Method
    public void setBreed(String breed) {
        this.breed = breed;
    }
}
