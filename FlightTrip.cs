public class FlightTrip
{
    public string FlightNumber {get; set;}
    public string AircraftNumber {get; set;}
    public string DepartureLocation {get; set;}
    public string ArrivalLocation {get; set;}
    public DateOnly TripDate {get; set;}
    public TimeOnly TripTime {get; set;}
    public decimal Cost {get; set;}
}