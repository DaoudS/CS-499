package main;
import java.util.*;

public class Driver {
    public static Scanner scnr = new Scanner(System.in);  
    public static RescueService rs = new RescueService();


    public static void main(String[] args) throws Exception {
        System.out.println("           Welcome to XXX.");
        System.out.println("           Select a service below."); 
        
        mainMenu(); 
    }
/**
 * Used to return program to main menu after complection of service.
 * @throws Exception
 */
    public static void mainMenu() throws Exception{
        int serviceChoice = 0;

        System.out.println("***************************************************"
                        + "\n*(1)       Request Animal Service                 *"
                        + "\n*(2)       Update Animal  Info                    *"
                        + "\n*(3)       Out Process Animal                     *"
                        + "\n*(4)       Find Animal                            *"
                        + "\n*(5)       ***Debug*** Generate Random Dog        *"
                        + "\n*(6)       ***Debug*** Generate Random Cat        *"
                        + "\n*(7)       ***Debug*** Generate Random Monkey     *"
                        + "\n***************************************************");
        serviceChoice = scnr.nextInt();

        selectService(serviceChoice);
    }
    /**
     * User menu where choice if menu service is selected. User only has 4 options.
     * @param serviceChoice
     * @throws Exception
     */
    public static void selectService(int serviceChoice) throws Exception{
        // Takes input for service selection as listed above and call requestAnimal method based on animalType
        switch(serviceChoice) {
            case 1:{
                requestAnimal();
                break;
            }
            case 2: {
                mainMenu();
                break;
            }
            case 3: {
                System.out.println("Enter animal ID: ");
                scnr.nextLine();
                outProcessAnimal(scnr.nextLine());
                mainMenu();
                break;
            }
            case 4: {
                System.out.println("Enter animal ID: ");
                scnr.nextLine();
                RescueAnimal animal = rs.findAnimal(scnr.nextLine());
                System.out.println("Animal ID Identified...");
                System.out.println("***************************"
                + "\nAnimal Name: " + animal.getName()
                + "\nAnimal Sex: " + animal.getSex()
                + "\nAnimal Age: " + animal.getAge()
                + "\nAnimal Weight: " + animal.getWeight()
                + "\nAnimal ID: " +  animal.getAnimalID()
                );
            
                mainMenu();
                break;
            }
            case 5: {
                generateRandomDog();
                mainMenu();
                break;
            }
            case 6: {
                generateRandomCat();
                mainMenu();
                break;
            }
            case 7: {
                generateRandomMonkey();
                mainMenu();
                break;
            }
        }
    }

/**
 * User selects one of three animal object types and is prompted to provide baisc object attributes.
 * @throws Exception
 */
    public static void requestAnimal() throws Exception{
        System.out.println("Is animal of type (1)CAT, (2)DOG, OR (3)MONKEY.");
        int caseInt = scnr.nextInt();

        switch(caseInt) {
            case 1: {
                Cat animal = new Cat();
                animal.setBasicAnimalInfo();
                rs.addAnimal(animal);
                mainMenu();
                break;
            }
            case 2: {
                Dog animal = new Dog();
                animal.setBasicAnimalInfo();
                rs.addAnimal(animal);
                mainMenu();
                break;
            }
            case 3: { 
                Monkey animal = new Monkey();
                animal.setBasicAnimalInfo();
                rs.addAnimal(animal);
                mainMenu();
                break;
            }
        }
    }
/**
 * Method to update one of three variable of animal object. 
 * @param aID AKA animal ID
 * @throws Exception
 */
    public static void updateAnimalInfo(String aID) throws Exception { 
        System.out.println("Select animal attribute to update"); 
        System.out.println("(1)Name, (2)Age, (3)Weight");
        int caseInt = scnr.nextInt();
        switch (caseInt) {
            case 1: {
                System.out.println("Enter name: ");
                rs.findAnimal(aID).setName(scnr.nextLine());
            }
            case 2: {
                System.out.println("Enter age: ");
                rs.findAnimal(aID).setAge(scnr.nextInt());
            }
            case 3: {
                System.out.println("Enter float: ");
                rs.findAnimal(aID).setWeight(scnr.nextFloat());
            }
            default:
                break;
        }
    }
/**
 * Animal object is remove from animals collection upon sucess of findAnimal method
 * @param aID
 * @throws Exception
 */
    public static void outProcessAnimal(String aID) throws Exception {
        System.out.println("Removal of animal of id: " + aID + " suceeded.");
        rs.remove(aID);
    }

    //
    // Functions to generate objects of type Cat, Dog, or Monkey with basic variables assigned.
    //
/**
 * Generates object of type dog using random attributes and adds object to animals collection.
 */
    public static void generateRandomDog() {
        Dog randomDog = new Dog();
    
        Random r = new Random();
    
        List<String> namesList = Arrays.asList("Bob", "Dylan", "Archie");
        List<String> names = new ArrayList<String>();
        names.addAll(namesList);
        randomDog.setName(names.get( r.nextInt(names.size())));
    
    
        List<String> sexesList = Arrays.asList("Male", "Female");
        List<String> sexes = new ArrayList<String>();
        sexes.addAll(sexesList);
        randomDog.setSex(sexes.get(r.nextInt(sexes.size())));
    
        int age = r.nextInt(25) + 1;
        randomDog.setAge(age);
        float weight = r.nextFloat() * (25-10);
        randomDog.setWeight(weight);
        randomDog.setAnimalID(rs.genAnimalID());
    
        System.out.println("Random Animal Generated...");
        System.out.println("***************************"
        + "\nAnimal Name: " + randomDog.getName()
        + "\nAnimal Sex: " + randomDog.getSex()
        + "\nAnimal Age: " + randomDog.getAge()
        + "\nAnimal Weight: " + randomDog.getWeight()
        + "\nAnimal ID: " +  randomDog.getAnimalID()
        );
    
        rs.addAnimal(randomDog);
    }
    /**
 * Generates object of type cat using random attributes and adds object to animals collection.
 */
    public static void generateRandomCat() {
        Cat randomCat = new Cat();
    
        Random r = new Random();
    
        List<String> namesList = Arrays.asList("Bob", "Dylan", "Archie");
        List<String> names = new ArrayList<String>();
        names.addAll(namesList);
        randomCat.setName(names.get( r.nextInt(names.size())));
        
    
    
        List<String> sexesList = Arrays.asList("Male", "Female");
        List<String> sexes = new ArrayList<String>();
        sexes.addAll(sexesList);
        randomCat.setSex(sexes.get( r.nextInt(sexes.size())));
    
        int age = r.nextInt(25) + 1;
        randomCat.setAge(age);
        float weight = r.nextFloat() * (25-10);
        randomCat.setWeight(weight);
        randomCat.setAnimalID(rs.genAnimalID());
    
        System.out.println("Random Animal Generated...");
        System.out.println("***************************"
        + "\nAnimal Name: " + randomCat.getName()
        + "\nAnimal Sex: " + randomCat.getSex()
        + "\nAnimal Age: " + randomCat.getAge()
        + "\nAnimal Weight: " + randomCat.getWeight()
        + "\nAnimal ID: " +  randomCat.getAnimalID()
        );
        
        rs.addAnimal(randomCat);
    }
    /**
 * Generates object of type monkey using random attributes and adds object to animals collection.
 */
    public static void generateRandomMonkey() {
        Monkey randomMonkey = new Monkey();
    
        Random r = new Random();
    
        List<String> namesList = Arrays.asList("Bob", "Dylan", "Archie");
        List<String> names = new ArrayList<String>();
        names.addAll(namesList);
        randomMonkey.setName(names.get( r.nextInt(names.size())));
    
    
        List<String> sexesList = Arrays.asList("Male", "Female");
        List<String> sexes = new ArrayList<String>();
        sexes.addAll(sexesList);
        randomMonkey.setSex(sexes.get( r.nextInt(sexes.size())));
    
        int age = r.nextInt(25) + 1;
        randomMonkey.setAge(age);
        float weight = r.nextFloat() * (25-10);
        randomMonkey.setWeight(weight);
        randomMonkey.setAnimalID(rs.genAnimalID());
    
        System.out.println("Random Animal Generated...");
        System.out.println("***************************"
        + "\nAnimal Name: " + randomMonkey.getName()
        + "\nAnimal Sex: " + randomMonkey.getSex()
        + "\nAnimal Age: " + randomMonkey.getAge()
        + "\nAnimal Weight: " + randomMonkey.getWeight()
        + "\nAnimal ID: " +  randomMonkey.getAnimalID()
        );
        
        rs.addAnimal(randomMonkey);
    }
}
