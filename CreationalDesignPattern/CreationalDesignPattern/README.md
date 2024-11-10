# Topic: Creational Design Patterns
## Author: Pereteatcu Arina
## Objectives:

1. Study and understand the Creational Design Patterns.
2. Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.
3. Use some creational design patterns for object instantiation in a sample project.

## Theory:
Creational design patterns are like special blueprints that help build objects in easy and smart way.

* ***Singleton pattern*** makes sute than only one instance of a class is ever created. It can be useful when you need a single connection to a database.

* ***Builder pattern*** helps to create objects step by step and keep everything in order.

* ***Prototype pattern*** lets you create copies of existing objects. It is useful for when you want to make small differences to objects.

* ***Object Pooling*** manages reusable objects. It is useful for not slowing down process by creating and destroying objects all the time.

* ***Factory Method*** pattern creates objects for you hiding the details and process.

* ***Abstract Factory*** pattern helps when you need to create a whole set of things that belong together.

## Implementation:

My sample project simulates a system of creating and managing different types of game characters. 
I used 3 Creational Design Patterns for this. The first one is **Singleton Pattern** which handles the creation of characters which should be only one
instance of each. 

```
 public class CharacterCreationService
 {
     private static CharacterCreationService _instance;

     private CharacterCreationService() { }

     public static CharacterCreationService Instance
     {
         get
         {
             if (_instance == null)
             {
                 _instance = new CharacterCreationService();
             }
             return _instance;
         }
     }
```
Here the constructor is private so that other classes can not create directly instances of it. If the instance is null it creates a new one
if not it simply returns the existing one, to ensure that only one exists.

The second pattern I implemented is **Factory Method Pattern** to create different types of characters, such as Warrior, Wizard and Archer. 
```
public class CharacterFactory
{
    public Character CreateCharacter(string characterType)
    {
        switch (characterType)
        {
            case "Warrior":
                return new Warrior();
            case "Wizard":
                return new Wizard();
            case "Archer":
                return new Archer();
            default:
                throw new ArgumentException("Unknown character type.");
        }
    }
}
```
This method takes a string and based on input it creates the object, it uses a switch statement to check which type of character would be
created. If the input doesnt match any of the cases, then it gives an exception error.

The third pattern used is **Object Pooling Pattern** which ensures that once a character is created, the system can reuse them instead of creating a new one,
it is very useful for not overflowing the memory and prevent it's fragmentation. 

```
 public class CharacterPool
 {
     private List<Character> availableCharacters = new List<Character>();
     private List<Character> inUseCharacters = new List<Character>();

     public Character GetCharacter(string type)
     {
         // Check if there is an available character in the pool
         Character character = availableCharacters.FirstOrDefault(c => c.GetType().Name == type);

         if (character == null) // If not, create a new one
         {
             character = CharacterCreationService.Instance.CreateCharacter(type);
             availableCharacters.Add(character);
         }

         // Move character from available to in-use
         availableCharacters.Remove(character);
         inUseCharacters.Add(character);

         return character;
     }

     public void ReturnCharacter(Character character)
     {
         // Return character from in-use back to available
         inUseCharacters.Remove(character);
         availableCharacters.Add(character);
     }
 }
```
This class contains a list of characters that are not currently in use and a list that tracks objects that are being used.
The method *GetCharacter* retrieves a specific Character from the pool and it checks if it matches a Character it is removed from
availableCharacters list and moved to the other one. If there are not matches, the created object is added to the pool for the future use.
In the end, the character is returned to the pool for reusability. 


## Conclusion
During this lab, I investigated how to effectively create and manage game characters in a system using three creational design patterns:
Object Pooling, Factory Method, and Singleton. 
These patterns result in more structured and reusable code by optimizing the object generation process and improving memory management.
