// OnlineFlightBooking.cs
using System;

class OnlineFlightBooking : FlightService, IPaymentGateway
{
    public static string Currency = "NPR";

    public void ProcessPayment(float amount)
    {
        // Implementation for processing payment in the online flight booking system
        Console.WriteLine($"Processing payment of {amount} {Currency}...");
    }

    public void GenerateBookingConfirmation()
    {
        // Implementation for generating booking confirmation
        Console.WriteLine("Generating booking confirmation...");
    }
}
