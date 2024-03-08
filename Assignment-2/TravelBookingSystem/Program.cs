
// Program.cs
class Program
{
    static void Main()
    {
        OnlineFlightBooking bookingSystem = new OnlineFlightBooking();
        bookingSystem.GetServiceDetails();
        bookingSystem.BookTicket();
        bookingSystem.CheckFlightStatus();
        bookingSystem.ProcessPayment(5000.0f);
        bookingSystem.GenerateBookingConfirmation();
    }
}
