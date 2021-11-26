package main;
import java.util.*;

public class RescueService {
    private List<RescueAnimal> animals = new ArrayList<>();
    /**
     * Animal Object ID is generate between integers 1 and 100. Intger is then stored as type string.
     * @return animalID
     */
    public String genAnimalID() {
        Random r = new Random();
        int RandomInt = r.nextInt(100) + 1;
        String animalID = String.valueOf(RandomInt);
        return animalID;
    }
    /**
     * Animal object is added to animals collection
     * @param animal
     */
    public void addAnimal(RescueAnimal animal) {
        animals.add(animal);
    }
    /**
     * Animal object is found via findAnimal(animalID) and is removed from animals collection.
     * @param animalID
     * @throws Exception
     */
    public void remove (String animalID) throws Exception {
        animals.remove(findAnimal(animalID));
    }
    /**
     * Animals collection is interated through to find RescueAnimal object by ID.
     * @param aID
     * @return RescueAnimal
     * @throws Exception
     */
    public RescueAnimal findAnimal(String aID) throws Exception {
        int index = 0;
        while (index < animals.size()) {
            if(aID.equals(animals.get(index).getAnimalID())) {
                return animals.get(index);
            }
            index++;
        }
        throw new Exception ("OPERATION FAILED: ID does not exist");
    }
/**
 * Returns RescueAnimal collection
 * @return
 */
    public List<RescueAnimal> getRescueAnimals() {
        return animals;
    }
}
