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
public class PayPalPaymentProcess : IProcessPayment
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing Paypal payment");
    }
}
public class BinancePaymentProcess : IProcessPayment
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing Binance payment");
    }
}


