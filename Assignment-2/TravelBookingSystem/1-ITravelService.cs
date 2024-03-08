// ITravelService.cs
using System;

interface ITravelService
{
    string ServiceName { get; set; }
    string Location { get; set; }
    void GetServiceDetails();
}
