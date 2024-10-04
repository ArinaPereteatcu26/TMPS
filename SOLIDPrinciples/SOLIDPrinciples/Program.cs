using System;

public class Order
{
    public int Id { get; set; }
    public double Amount { get; set; }
}

public interface IProcessPayment
{
    void ProcessPayment(Order order);
}

public class CreditCardPaymentProcess : IProcessPayment
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing payment");
    }
}
