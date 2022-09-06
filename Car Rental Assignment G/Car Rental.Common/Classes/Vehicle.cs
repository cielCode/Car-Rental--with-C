using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using System;

namespace Car_Rental.Common.Classes
{
    public abstract class Vehicle : IVehicle
    {
       public int Id { get; }
       public string Make { get; }
       public string RegistrationNumber { get; }
       public double Odometer { get; }
       public double CostKm { get; }
       public double CostDay
        {
            get
            {
                return Type switch
                {
                    VehicleTypes.Sedan => 100,
                    VehicleTypes.Combi => 200,
                    VehicleTypes.Van => 300,
                    VehicleTypes.Motorcycle => 50,
                    _ => throw new ArgumentException("Vehicle type unavailable")
                };
            }
        }

       public VehicleStatuses Status { get; set; }
       public VehicleTypes Type { get; }

        public Vehicle(int id, string make, string registrationNumber, double odometer, double costKm, VehicleStatuses status, VehicleTypes type) 
        {
            Id = id;
            Make = make;
            RegistrationNumber = registrationNumber;
            Odometer = odometer;
            CostKm = costKm;
            Status = status;
            Type = type;
        }
        public void Drive(double distance) 
        {
            throw new NotImplementedException();
        }
    }
}
