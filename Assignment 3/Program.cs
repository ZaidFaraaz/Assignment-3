using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a rental agency with a fleet size of 10
        RentalAgency agency = new RentalAgency(10);

        // Adding vehicles to the fleet
        Car car1 = new Car("Civic", "Honda", 2023, 60.0m, 5, "Gasoline", "Automatic", false);
        agency.AddVehicle(car1);

        Motorcycle motorcycle1 = new Motorcycle("Ninja", "Kawasaki", 2023, 70.0m, 1000, "Gasoline", true);
        agency.AddVehicle(motorcycle1);

        // Renting vehicles
        agency.RentVehicle("Civic", 3);
        agency.RentVehicle("Ninja", 5);

        // Displaying total revenue
        agency.DisplayTotalRevenue();

        // Removing a vehicle from the fleet
        agency.RemoveVehicle("Civic");

        // Trying to rent a removed vehicle
        agency.RentVehicle("Civic", 3);

        // Displaying total revenue again
        agency.DisplayTotalRevenue();
    }
}
