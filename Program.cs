using System;

AircraftManager aircraftManager = new AircraftManager();
FlightTripManager flightTripManager = new FlightTripManager();

int Option;
do
{
Console.WriteLine("\nWelcome To OperaKenny Aerospace Limited");
Console.WriteLine("1. Add Aircraft");
Console.WriteLine("2. View Aircraft");
Console.WriteLine("3. Get Aircraft");
Console.WriteLine("4. Add Flight Trip");
Console.WriteLine("5. View Flight Trip");
Console.WriteLine("6. Get Flight Trip");
Console.WriteLine("7. Exit");
Console.WriteLine("What would you love to do today");
Option = int.Parse(Console.ReadLine());
 
switch (Option)
 
{
    case 1:
    aircraftManager.AddAircraft();
    break;

    case 2:
    aircraftManager.ViewAircrafts();
    break;

    case 3:
    aircraftManager.GetAircraft();
    break;

    case 4:
    flightTripManager.AddFlightTrip();
    break;

    case 5:
    flightTripManager.ViewflightTrips();
    break;

    case 6:
    flightTripManager.SearchFlightTrips();
    break;
}

}while (Option !=7);