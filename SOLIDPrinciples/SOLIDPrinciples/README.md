# SOLID LETTERS

## Author: Pereteatcu Arina

----

## Objectives:
* Get familiar with SOLID principles;
* Implement 2 SOLID letters in a simple project;

## Implementation:

**SOLID** is an acronym for the five object-oriented design (OOD) principles. 
**Single-Responsability Principle**  states that a class should have only one responsibility, therefore have only one reason to change.
It helps to easier change and test if the class has only one responsibility.

SRP is the perequisite for **Open-Closed Principle**, therefore I used the OCP principle as a second letter for 
the laboratory work. 
OCP states that classes should be open for extension, but closed for modification.

## Code:

```
using System;

public class Order
{
    public int Id { get; set; }
    public double Amount { get; set; }
}

```

This c# code defines an implementation of a basic payment processing system using diverse methods. 
The order class contains 2 properties Id and Amount and encapsulates order data. 
Using SRP, the class only stores order-related data.

```
public interface IProcessPayment
{
    void ProcessPayment(Order order);
}
```

The ProcessPayment interface defines the contract for payment processing and contains a method that accepts and Order object and processes the payment. Using OCP, it is closed to modification but open to extension, we can add new payment methods without changing the existing codebase.

```
public class CreditCardPaymentProcess : IProcessPayment
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing payment");
    }
}
```
The classes CreditCardPaymentProcess, PaypalPaymentProcess, BinancePaymentProcess, BankTransferPaymentProcess implement the interface and provide their own implementation of the method used in the interface. 

```
public class DataBase
{
    public void SaveToDataBase(Order order)
    {
        Console.WriteLine("Saving order to database");
    }

    public Order LoadFromDataBase(int orderID)
    {
        Console.WriteLine("Loading order from database");
        return new Order();
    }
}
```
The DataBase class gives methods for saving an order and retrieving an order. Using SRP, the class is responsible for handling order storage and retrieval.

## Conclusion


