# Topic: Behavioral Design Patterns
## Author: Pereteatcu Arina FAF-223
## Objectives:
1. Study and understand the Behavioral Design Patterns.
2. As a continuation of the previous laboratory work, think about what communication between software entities might be involed in your system.
3. Implement some additional functionalities using behavioral design patterns.

## Theoretical background:
A subset of design patterns known as behavioral patterns concentrate on how objects interact and communicate with one another. They make it simpler to manage intricate control flow and communication in a system by defining how objects cooperate and divide responsibilities among themselves.
Some examples from this category of design patterns are :

* Chain of Responsibility - An object can forward a request along a chain of handlers using the Chain of Responsibility design pattern. The decision to process the request or forward it to the subsequent handler is made by each handler in the chain.

* Command- A request is transformed into a command—a stand-alone object—by the Command Design Pattern. This pattern allows you to record all of the elements of a request, such as the method itself, the parameters for the method, and the object that owns the method. 

* Interpreter- A method for interpreting and assessing language grammar or phrases is defined by the Interpreter design pattern. By describing a language's grammar as a collection of classes, it offers a way to assess sentences in that language. 

* Iterator-offers a method for progressively accessing an aggregate object's (such as a list's) elements without disclosing the representation that underlies it. It allows the aggregate to change its internal structure without changing how its elements are accessed by defining a distinct object, known as an iterator, that contains the information of traversing the aggregate's elements.

* Mediator-An entity that captures the interactions between a group of items is defined by the Mediator Design Pattern. By preventing items from explicitly referring to one another, the mediator encourages loose coupling and differs from their interaction alone. 

* Observer- establishes a one-to-many dependency between objects such that all of its dependents are immediately updated and notified when one object changes state.

* Strategy-It encapsulates and defines a family of algorithms that are interchangeable. Strategy enables the algorithm to change without relying on the users.

 ## Main tasks :
By extending  project, implement at least 1 behavioral design pattern in the project:
  * The implemented design pattern should help to perform the tasks involved in the system.
  * The behavioral DPs can be integrated into functionalities alongside the structural ones.
  * There should only be one client for the whole system.

## Implementation:
I implemented Strategy method in my project to extend it. I chose this one because my code already does behaviour dynamic changes: Character creation and modification are already possible within the system thanks to the pool and factory patterns. This is naturally extended by strategy patterns, which allow characters to alter their combat strategy at runtime.

```
namespace CreationalDesignPattern.Domain.Combat
{
    public interface ICombatStrategy
    {
        void ExecuteAttack(Character character);
    }
}

```
I added the interface that defines the contract for all combat strategies with the method ExecuteAttack.

One of the combat style is the Aggressive one:

```
 public class AggressiveCombatStrategy : ICombatStrategy
 {
     public void ExecuteAttack(Character character)
     {
         Console.WriteLine($"{character.Name} uses aggressive combat style!");
         character.Attack();
         Console.WriteLine("Follows up with a powerful strike!");
     }
 }
```
The class implements the interface ICombatStrategy, and uses the ExecuteAttack method. Then it is outputted the message of the character chosen from input and the combat style. Then the Attack method is called, and finally the console shows an additional message.

## Conclusion:
As an extension of the last study, I investigated and applied a behavioral design pattern in this lab work. In particular, I improved the system's capacity to handle dynamic behavior changes by applying the Strategy Pattern. Since the Factory and Pool templates already allowed for character creation and alteration, this pattern was a perfect fit for the project. I further expanded the framework by including the Strategy Pattern, which permits characters' battle strategies to vary at runtime. The lab work effectively illustrated how behavioral design patterns support software architecture that is clear, modular, and extendable. I was able to concentrate on creating dependable and reusable behaviors thanks to the Strategy Pattern, which made the system more dynamic and manageable.
