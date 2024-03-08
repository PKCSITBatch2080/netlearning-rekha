// FlightService.cs
using System;

class FlightService : TravelService, IFlightService
{
    public string Airlines { get; set; }
    public string FlightNumber { get; set; }

    public override void GetServiceDetails()
    {
        // Implementation for getting flight service details
        Console.WriteLine("Getting flight service details...");
    }

    public void BookTicket()
    {
        // Implementation for booking a flight ticket
        Console.WriteLine("Booking a flight ticket...");
    }

    public void CheckFlightStatus()
    {
        // Implementation for checking the flight status
        Console.WriteLine("Checking flight status...");
    }
}
