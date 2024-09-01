public class FlightTripManager
{
    List<FlightTrip> flightTrips = new List<FlightTrip>();
    public void AddFlightTrip()
    {
        Console.WriteLine("Enter the the Flight number ");
        string flightNumber = Console.ReadLine();
        Console.WriteLine("Enter your Aircraft number");  
        string aircraftNumber = Console.ReadLine();
        Console.WriteLine("Enter your departure location");
        string departureLocation = Console.ReadLine();
        Console.WriteLine("Enter your arival location");
        string arrivalLocation = Console.ReadLine();
        Console.WriteLine("Enter your date");
        DateOnly date = DateOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter your time");
        TimeOnly time = TimeOnly.Parse(Console.ReadLine());
        Console.WriteLine("Enter your cost");
        decimal cost = decimal.Parse(Console.ReadLine());
        
        FlightTrip flightTrip = new FlightTrip();
        flightTrip.FlightNumber = flightNumber;
        flightTrip.AircraftNumber = aircraftNumber;
        flightTrip.DepartureLocation = departureLocation;
        flightTrip.ArrivalLocation = arrivalLocation;
        flightTrip.TripDate = date;
        flightTrip.TripTime = time;
        flightTrip.Cost = cost;

        flightTrips.Add(flightTrip);
        Console.WriteLine($"Your flight{flightTrip.FlightNumber} successfully added");
    }
    
    public void ViewflightTrips()
    {
        foreach(var flightTrip in flightTrips)
        {
            Console.WriteLine($"{flightTrip.FlightNumber} {flightTrip.AircraftNumber} {flightTrip.DepartureLocation} {flightTrip.ArrivalLocation} {flightTrip.TripDate} {flightTrip.TripTime} {flightTrip.Cost}");
        }
    }

    public void SearchFlightTrips()
    {
       Console.WriteLine("Enter your departure location");
       string departureLocation = Console.ReadLine();
       Console.WriteLine("Enter your arrival location");
       string arrivalLocation = Console.ReadLine();
       Console.WriteLine("Enter departure date");
       DateOnly date = DateOnly.Parse( Console.ReadLine());

       List<FlightTrip> availableFlights = new List<FlightTrip>();
       foreach(var flightTrip in flightTrips)
       {
        if (flightTrip.DepartureLocation == departureLocation && flightTrip.ArrivalLocation == arrivalLocation && flightTrip.TripDate == date)
        {
           availableFlights.Add(flightTrip);
        }
       }

       if(availableFlights.Count > 0 )
       {
          foreach(var flightTrip in availableFlights)
        {
            Console.WriteLine($"{flightTrip.FlightNumber} {flightTrip.AircraftNumber} {flightTrip.DepartureLocation} {flightTrip.ArrivalLocation} {flightTrip.TripDate} {flightTrip.TripTime} {flightTrip.Cost}");
        } 
       } 
         else 
         {
           Console.WriteLine("No flight found");
         } 
    }
}

