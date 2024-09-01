public class AircraftManager
{
    //Manager class is created for manipulating the Aircraft Objects.
    List<Aircraft> aircrafts = new List<Aircraft>(); // declaring list of aircraft

    // Adding new Aircraft to the List
    public void AddAircraft ()
    {
        //Model,Capacity,Company,AirCraft No
        Console.WriteLine("Enter the Model Number");
        string modelName = Console.ReadLine();
        Console.WriteLine("Enter the Capacity of the Aircraft");
        int aircraftCapacity = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Company Name");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter the Aircraft Number");
        string aircraftNumber = Console.ReadLine();

        // Creating Object of Aircraft(aircraft)
        Aircraft aircraft = new Aircraft();
        aircraft.Model = modelName;
        aircraft.Capacity = aircraftCapacity;
        aircraft.Company = companyName;
        aircraft.AircraftNumber = aircraftNumber;

        //Adding the new object to the List(aircraft to aircrafts)
        aircrafts.Add(aircraft);
        Console.WriteLine("New aircraft added successfully");
    }
    public void ViewAircrafts ()
    {
        foreach (var aircraft in aircrafts)
        {
            Console.WriteLine($"{aircraft.Model}, {aircraft.Capacity},{aircraft.Company},{aircraft.AircraftNumber}");
        }
    }
    public Aircraft GetAircraft()
    {
        Console.WriteLine("Enter your Aircraft Number");
        string aircraftNumber = Console.ReadLine();
        foreach (var aircraft in aircrafts)
        {
            if(aircraft.AircraftNumber == aircraftNumber)
            {
                Console.WriteLine("Aircraft found");
                return aircraft;
            }

        }
        Console.WriteLine("Aircraft cannot be found");
        return null;
    }
}