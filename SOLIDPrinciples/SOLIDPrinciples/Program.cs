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
public class BankTransferPaymentProcess : IProcessPayment
{
    public void ProcessPayment(Order order)
    {
        Console.WriteLine("Processing bank transfer");
    }
}


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

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create a new order
//        Order newOrder = new Order { Id = 1, Amount = 250.00 };

//        // Save order to the database
//        DataBase db = new DataBase();
//        db.SaveToDataBase(newOrder);

//        // Process the payment with Binance
//        IProcessPayment paymentProcessor = new BinancePaymentProcess();
//        paymentProcessor.ProcessPayment(newOrder);

//        // Load order from the database
//        Order loadedOrder = db.LoadFromDataBase(1);
//        Console.WriteLine("Loaded order #{0}, amount: {1}", loadedOrder.Id, loadedOrder.Amount);
//    }
//}



