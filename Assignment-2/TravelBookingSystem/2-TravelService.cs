// TravelService.cs
using System;

abstract class TravelService : ITravelService
{
    public string ServiceName { get; set; }
    public string Location { get; set; }
    public readonly float Rating;
    protected int ServiceID;

    public abstract void GetServiceDetails();
}
