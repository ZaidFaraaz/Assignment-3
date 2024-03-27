using System;

public class RentalAgency
{
    private Vehicle[] Fleet { get; set; }
    private decimal TotalRevenue { get; set; }

    // Constructor
    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
        TotalRevenue = 0;
    }

    // Method to add a vehicle to the fleet
    public void AddVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == null)
            {
                Fleet[i] = vehicle;
                Console.WriteLine($"Added {vehicle.Manufacturer} {vehicle.Model} to the fleet.");
                return;
            }
        }
        Console.WriteLine("Fleet is full. Cannot add more vehicles.");
    }

    // Method to remove a vehicle from the fleet
    public void RemoveVehicle(string model)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] != null && Fleet[i].Model.Equals(model, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Removed {Fleet[i].Manufacturer} {Fleet[i].Model} from the fleet.");
                Fleet[i] = null;
                return;
            }
        }
        Console.WriteLine($"Vehicle with model '{model}' not found in the fleet.");
    }

    // Method to rent a vehicle
    public void RentVehicle(string model, int days)
    {
        foreach (var vehicle in Fleet)
        {
            if (vehicle != null && vehicle.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
            {
                decimal rentalCost = vehicle.RentalPrice * days;
                Console.WriteLine($"Rented {vehicle.Manufacturer} {vehicle.Model} for {days} days. Total cost: {rentalCost:C}");
                TotalRevenue += rentalCost;
                return;
            }
        }
        Console.WriteLine($"Vehicle with model '{model}' not found in the fleet.");
    }

    // Method to display total revenue
    public void DisplayTotalRevenue()
    {
        Console.WriteLine($"Total Revenue: {TotalRevenue:C}");
    }
}
