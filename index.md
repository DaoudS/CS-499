# Daoud Sogoba 
<daoud.sogoba@gmail.com>
## CS-499 Computer Science Capstone ePortfolio
### Professional self-assessment

#### Self Assessment 



### Initial Code Review
[Initial Code Review](https://www.youtube.com/watch?v=1k84q5B1Oro)


# Enhancement One

### Artifact Description
The project originates from my CS-320: Software Testing, Automation, and Quality Assurance class. Its focus was on creating a number of services that revolved on new objects and types that we would create. The service code that we wrote focused on manipulation attributes of hte object not too dissimilar to crud operations. It was create during term 21EW6.

####Justification for Inclusion
This artifact was included as it demonstrates at a base level my understanding of use cases for practical unit tests applied to a development project. More than anything it shows my ability to understand abstract object oriented programming techniques and my ability to make use of varying frameworks to produce the same outcome across languages. 



#### Reflect
Throughout the transformation of the code into the new language, I most definitely became more familiar with visual studios and the tools it offers developers when it comes to making unit tests. I found the interface and documentation for the uses of MSTest to be efficiently presented and in abundance. Interest, I was also able to see a lot of the mistakes I had made in the original Java project. Whether that was simple spelling mistakes, or the use of wrong methods or completely unnecessary lines of code. Truthfully the most challenging part was working through the syntax of functions that are similar in C# but not quite the same in java. I imagine I would have had a more challenging time had I chosen languages that were not so closely related and similarly designed. 

Throughout the conversion of the code from Java to C# I made fine edits into the various lines of code. I ensure that during the reconstruction all naming conventions and standards were adhered to for the new code base as it was severely lacking in the Java project. I also made use of extensive use of document strings and the like to ensure that users always understood what the purpose of my classes and methods were. I left none of these items ambiguous in their function or purpose. I also tried to cut down on unnecessary lines of code. Mainly variable that were created but never referenced, ensuring variables that need not be access by outside classes are private and ensuring that excess space was removed.

I do think that I met my original goals set forth in my initial description from module one. Though I did somewhat reduce my original intention in scope. The project as it was in java consisted of three or so smaller projects where I was creating an item and an item service. Take for example Contact and ContactService. There were two others just like and after having converted all of them, I did not think it necessary to create unit tests for all six files know that they all did the same thing with a very slight deviation.
#### Code Snippets
<code> 

		public Contact FindContact(string contactID) {
			int index = 0;
			while (index < contacts.Count) {
				if (contactID.Equals(contacts[index].contactID)) {
					return contacts[index];
				}
				index++;
			}
			throw new Exception("Contact does not exist");
</code>

		public void AddContact(string firstName, string lastName, string phoneNumber, string address) {
			Contact contact = new Contact(GenContactID(), firstName, lastName, phoneNumber, address);
			contacts.Add(contact);
<code>
</code>
<code>
		[TestMethod()]
		public void UpdateContactLastNameTest() {
			string lastNamePasses = "Sogoba";

			ContactService cs = new ContactService();
			List<Contact> contacts = cs.GetContacts();
			cs.AddContact();
			contacts[0].lastName = lastNamePasses;

			Assert.AreEqual(lastNamePasses, contacts[0].GetLastName());
		}  
</code>





#Enhancement Two
#### Artifact Description
This was a project consisting of java code submitted in project two of my  IT-145: Foundation in Application class during term 20EW5.

#### Justification for Inclusion
I decided to include this artifact because I felt that my understanding of the original intentions of the project and the codebase at its current point would be very helpful in my ability to modify the project and bring it up to standards that are more in line with my current ability. Not too far off from the previous project I submitted, this project showcased my ability to take a program that was not designed in a modular manner or not for use by the programs and turn it into just that. I took inspiration from my previous project as it was also a project that was originally done in Java. 

#### Reflect

I was able to complete and flesh out the rest of the services specified in the code base. Before this project they had been left with the output of not yet implemented when selected. Also added classes that were extensions of a primary class just too practice develop my ability to work with class inheritance.
I do think that I was able to meet the goal that I had set in module one about the intent for these enhancements. Some enhancements I made were not even identified until I was able to start programming in delve more deeply into the workings of the code. One of the smaller things I learned while developing this codebase was that one kid separate the scope a variable in switch statements by using curly braces. Now that does sound like a simple thing to understand it and it is but, it wasn't something I needed to know until working on this codebase. Like any other project it forced me to become more familiar with the troubleshooting tools provided by the software I was using at the time. In this case that was VScode. I think one of the larger challenges I faced was not so much with the code but more with myself. Fatigue found me struggling to troubleshoot some portions of the codebase because I was overlooking variable references or method calls. It was sort of a friendly reminder to me that resident corporation is just as important as anything else will developing.

#### Code Snippets
<code>
/**
 * Animal object is remove from animals collection upon sucess of findAnimal method
 * @param aID
 * @throws Exception
 */

    public static void outProcessAnimal(String aID) throws Exception {
        System.out.println("Removal of animal of id: " + aID + " suceeded.");
        rs.remove(aID);
    }
</code>

<code>
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
</code>


## Enhancement Three

#### Artifact Description
This artifact was a project submitted during my CS:340 Client/Server Development class during term 21EW1. It consisted of a mongoDB database that was modified only using a python script that performed crud operation on the database. We also created a jupyter notebook that made use of the scripts that we had created and produced a dashboard that further utilized said scripts. 

#### Justification for Inclusion
I wanted to include this artifact because being able to accomplish this feat, demonstrated my ability to interact with a given database and generate data that is both customizable and adaptable to the needs of the user requesting the data. I also felt that it was one of the clearer examples of database-based projects that I had worked on during my time thus far at SNHU. It was also a project that was not fully complete when I had originally submitted in the last term. Though I had spent more than 15 plus hours on it, there were some aspects that I was unable to complete. Using it for this enhancement allowed me to go back and complete them while also completing my enhancement goals. A two for one sort of deal. 

##### Reflect
To reach my goal of increasing the complexity of the code submitted, I made use of additional Dash components to allow user manipulation of that data being displayed on the dashboard. This was accomplished via the implementation of a new bar chart that allows the users to modify. Comments were refined, add, and or deleted as necessary to remove anything extra. I also made use of the docstrings functionality that python provides to make the purpose of methods and classes clearer. I of course brought the naming conventions of the various items within the code up to python standards. 
During the process of the enhancement, I found myself struggling with some of the same issues I had encountered when I had originally worked in this project. Most notably was getting the radio items, or the selection options at the top of the data table working. I required me to spend a lot more time with the Dash documentation and watching examples that youtubers provided. Similar issues were found when I added more dash components to the project, as these were items, I had no previous experience with. They did however further enhance my ability to work with the documentation frameworks provided. Though, I’m sure future projects may have me working with frameworks that have little if any documentation to go off. 

#### Code Snippets

<code>
    def update(self, filter, update):
        """Update document in DB.

        Keyword arguments:
        filter -- dictonary with db document to select
        update -- dictonary with changes to the filtered db document
        """
        if filter and update is not None:
            data_result = self.collection.update_one(filter, update)
            return data_result
        else:
            raise Exception("Data Param is empty")
</code>
<code> 
def update_dashboard(value):

    if value == 'all':
        df = pd.DataFrame.from_records(shelter.read({}))
    elif value == 'WR':
        df = pd.DataFrame.from_records(shelter.read({"breed":{"$in":["Labrador Retriever Mix","Chesapeake Bay Retriever","Newfoundland"]}, "sex_upon_outcome":"Intact Female", "age_upon_outcome_in_weeks":{"$gt":"26"},"age_upon_outcome_in_weeks":{"$lt":"156"}}))
    elif value == 'MoW':
        df = pd.DataFrame.from_records(shelter.read({"breed":{"$in":["German Shepherd,","Alaskan Malamute","Old English Sheepdog", "Siberian Husky", "Rottweiler" ]}, "sex_upon_outcome":"Intact Male", "age_upon_outcome_in_weeks":{"$gt":"26"},"age_upon_outcome_in_weeks":{"$lt":"156"}}))
    elif value == 'DoIT':
        df = pd.DataFrame.from_records(shelter.read({"breed":{"$in":["Doberman Pinscher", "German Shepherd", "Golden Retriever", "Bloodhound", "Rottweiler"]}, "sex_upon_outcome":"Intact Male", "age_upon_outcome_in_weeks":{"$gt":"20"},"age_upon_outcome_in_weeks":{"$lt":"300"}}))   
    
    return df.to_dict('records')
</code>