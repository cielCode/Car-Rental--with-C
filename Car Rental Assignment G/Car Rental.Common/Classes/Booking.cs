using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Common.Classes
{
   public class Booking : IBooking
    {

        public int Id { get; }
        public int VehicleId { get; }
        public string RegistrationNumber { get; }
        public IPerson Person { get; }
        public DateTime Rented { get; }
        public DateTime Returned { get; }
        public  double Cost { get; }
        public double OdometerRented { get; }
        public  double OdometerReturned { get; }

        public Booking(int id, IVehicle vehicle, IPerson person) 
        {
            if (id < 0|| vehicle.Id < 0 || person == default)
                throw new AggregateException();

            Id = id;
            RegistrationNumber = vehicle.RegistrationNumber;
            VehicleId = vehicle.Id;
            Person = person;
            Rented = DateTime.Now;
            OdometerRented = vehicle.Odometer;
        }

        public void ReturnVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}

