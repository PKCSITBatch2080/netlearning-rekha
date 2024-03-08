// IFlightService.cs
interface IFlightService
{
    string Airlines { get; set; }
    string FlightNumber { get; set; }
    void BookTicket();
    void CheckFlightStatus();
}
