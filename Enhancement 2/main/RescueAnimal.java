package main;

import java.text.SimpleDateFormat;
import java.util.*;

public class RescueAnimal {

    // Instance variables
    private String name;
    private String animalID;
    private String type;
    private String sex;
    private int age;
    private float weight = 20;
    private SimpleDateFormat acquisitionDate;
    private SimpleDateFormat statusDate;
    private String acquisitionSource;
    private Boolean reserved;

    private String trainingLocation;
    private SimpleDateFormat trainingStart;
    private SimpleDateFormat trainingEnd;
    private String trainingStatus;

    private String inServiceCountry;
    private String inServiceCity;
    private String inServiceAgency;
    private String inServicePOC;
    private String inServiceEmail;
    private String inServicePhone;
    private String inServicePostalAddress;

    private Scanner scnr = new Scanner(System.in);



    // Constructor
    public RescueAnimal() {

    }

    // Add Accessor Methods here
    public String getName() {
    return this.name;
    }

    public String getAnimalID() {
        return this.animalID;
    }
    public String getType() {
        return this.type;
    }
    public String getSex() {
        return this.sex;
    }
    public int getAge() {
        return this.age;
    }
    public float getWeight() {
        return this.weight;
    }
    public SimpleDateFormat getAcquisitionDate() {
        return this.acquisitionDate;
    }
    public SimpleDateFormat getStatusDate() {
        return this.statusDate;
    }
    public String getAcquisitionSource() {
        return this.acquisitionSource;
    }
    public Boolean getReserved() {
        return this.reserved;
    }
    public String getTrainingLocation() {
        return this.trainingLocation;
    }
    public SimpleDateFormat getTrainingStart() {
        return this.trainingStart;
    }
    public SimpleDateFormat getTrainingEnd() {
        return this.trainingEnd;
    }
    public String getTrainingStatus() {
        return this.trainingStatus;
    }
    public String getInServiceCountry() {
        return this.inServiceCountry;
    }
    public String getInServiceCity() {
        return this.inServiceCity;
    }
    public String getInServiceAgency() {
        return this.inServiceAgency;
    }
    public String getInServicePOC() {
        return this.inServicePOC;
    }
    public String getInServiceEmail() {
        return this.inServiceEmail;
    }
    public String getInServicePhone() {
        return this.inServicePhone;
    }
    public String getInServicePostalAddress() {
        return this.inServicePostalAddress;
    }
    
    // Add Mutator Methods here

    public void setName(String name) {
        this.name = name;
    }
    public void setAnimalID(String animalID) {
        this.animalID = animalID;
    }
    public void setType(String type) {
        this.type = type;
    }
    public void setSex(String sex) {
        this.sex = sex;
    }
    public void setAge(int age) {
        this.age = age;
    }
    public void setWeight(float weight) {
        this.weight = weight;
    }
    public void setAcquisitionDate(SimpleDateFormat acquisitionDate) {
        this.acquisitionDate = acquisitionDate;
    }
    public void setStatusDate(SimpleDateFormat statusDate) {
        this.statusDate = statusDate;
    }
    public void setAcquisitionSource(String acquisitionSource) {
        this.acquisitionSource = acquisitionSource;
    }
    public void setReserved(Boolean reserved) {
        this.reserved = reserved;
    }
    public void setTrainingLocation(String trainingLocation) {
        this.trainingLocation = trainingLocation;
    }
    public void setTrainingStart(SimpleDateFormat trainingStart) {
        this.trainingStart = trainingStart;
    }
    public void setTrainingEnd(SimpleDateFormat trainingEnd) {
        this.trainingEnd = trainingEnd;
    }
    public void setTrainingStatus(String trainingStatus) {
        this.trainingStatus = trainingStatus;
    }
    public void setInServiceCountry(String inServiceCountry) {
        this.inServiceCountry = inServiceCountry;
    }
    public void setInServiceCity(String inServiceCity) {
        this.inServiceCity = inServiceCity;
    }
    public void setInServiceAgency(String inServiceAgency) {
        this.inServiceAgency = inServiceAgency;
    }
    public void setInServicePOC(String inServicePOC) {
        this.inServicePOC = inServicePOC;
    }
    public void setInServiceEmail(String inServiceEmail) {
        this.inServiceEmail = inServiceEmail;
    }
    public void setInServicePhone(String inServicePhone) {
        this.inServicePhone = inServicePhone;
    }
    public void setInServicePostalAddress(String inServicePostalAddress) {
        this.inServicePostalAddress = inServicePostalAddress;
    }
    /**
     * User is prompted to enter input for initial object attributes.
     * @throws Exception
     */
    public void setBasicAnimalInfo() throws Exception{
        System.out.println("Enter pet name: ");
        setName(scnr.nextLine());


        System.out.println("Enter pet sex: ");
        setSex(scnr.nextLine());

        System.out.println("Enter pet age: ");
        setAge(scnr.nextInt());

        System.out.println("Enter pet weight: ");
        setWeight(scnr.nextFloat());

        System.out.println("Enter resident city: ");
        setInServiceAgency(scnr.nextLine());
        scnr.nextLine();

        setAnimalID(Driver.rs.genAnimalID());
        System.out.println(getAnimalID());

        
    }
    /**
     * User is prompted to update one of four object attributes.
     * @throws Exception
     */
    public void updateAnimalInfo() throws Exception{
        int updateChoice;
        System.out.println("What you you like to update about this animal?");
        System.out.println("Enter a number from the list below.");
        System.out.println("0 Pet Name");
        System.out.println("1 Pet sex");
        System.out.println("2 Pet Age");
        System.out.println("3 Pet Weight");
        updateChoice = scnr.nextInt();

        switch(updateChoice){
            case 0:
                System.out.println("Enter name to change to :");
                String nameChange = scnr.nextLine();
                Driver.rs.findAnimal(animalID).setName(nameChange);
                break;
            case 1:
                System.out.println("Enter sex to change to :");
                String sexChange = scnr.nextLine();
                Driver.rs.findAnimal(animalID).setSex(sexChange);
                break;
            case 2:
                System.out.println("Enter age to change to :");
                int ageChange = scnr.nextInt();
                Driver.rs.findAnimal(animalID).setAge(ageChange);
                break;
            case 3:
                System.out.println("Enter weight to change to :");
                float weightChange = scnr.nextFloat();
                Driver.rs.findAnimal(animalID).setWeight(weightChange);
                break;
        }
    }   
    
}
