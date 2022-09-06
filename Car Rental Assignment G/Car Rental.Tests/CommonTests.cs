using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Classes;
using Car_Rental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Car_Rental.Tests
{
    public class CommonTests
    {
        [Fact]
        public void CanCreateCar()
        {
            IVehicle car = new Car(1, "Volvo", "123", 100, 1, VehicleStatuses.Available, VehicleTypes.Sedan);

            Assert.Equal("123", car.RegistrationNumber);
        }

        [Fact]

        public void CanCreateMotorcycle()

        {

            IVehicle motorcycle = new Motorcycle(1, "Volvo", "123", 100, 1, VehicleStatuses.Available, VehicleTypes.Sedan);

            Assert.Equal("123", motorcycle.RegistrationNumber);
        }

        [Fact]

        public void CanCreateBooking()

        {

            IVehicle motorcycle = new Motorcycle(1, "Volvo", "123", 100, 1, VehicleStatuses.Available, VehicleTypes.Sedan);
            IPerson customer = new Customer(1, "1234", "John", "Doe");
            IBooking booking = new Booking(1, motorcycle, customer);

            Assert.Equal(1, booking.Id);
        }

        [Fact]
        public void CanGetBookings()

        {

            IData data = new CollectionData();

            Assert.True(data.GetBookings().Count() > 0);
        }

        [Fact]
        public void CanGetAllBookings()

        {

            IData data = new CollectionData();

            Assert.True(data.GetVehicles().Count() > 0);
        }

        [Fact]
        public void CanGetVehiclesByStatuses()

        {

            IData data = new CollectionData();

            Assert.True(data.GetVehicles(VehicleStatuses.Booked).Count() > 0);
        }
    }
}

