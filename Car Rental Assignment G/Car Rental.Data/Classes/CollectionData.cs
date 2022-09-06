using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental.Data.Classes
{
    public class CollectionData : IData
    {
        readonly List<IPerson> _persons = new List<IPerson>();
        readonly List<IVehicle> _vehicles = new List<IVehicle>();
        readonly List<IBooking> _bookings = new List<IBooking>();

        #region
        public int NextPersonId => _persons.Count.Equals(0) ? 1 : _persons.Max(b => b.Id) + 1;
       
        #endregion

        public CollectionData()
        {
            SeedData();
        }
        private void SeedData()
        {
            _persons.Add(new Customer(1, "12345", "John", "Doe"));
            _persons.Add(new Customer(2, "98765", "Jane", "Doe"));

            _vehicles.AddRange(new List<IVehicle>
            {
                new Car(1, "Volvo", "ABC123", 1000, 1, VehicleStatuses.Available, VehicleTypes.Combi),
                new Car(2, "Saab", "DEF456", 2000, 1, VehicleStatuses.Available, VehicleTypes.Sedan),
                new Car(3, "Tesla", "GHI789", 1000, 3, VehicleStatuses.Available, VehicleTypes.Sedan),
                new Car(4, "Jeep", "JKL012", 5000, 1.5, VehicleStatuses.Available, VehicleTypes.Van),
                new Motorcycle(5, "Yamaha", "MNO234", 30000, 0.5, VehicleStatuses.Available, VehicleTypes.Motorcycle)
            });

            var vehicle1 = _vehicles.Single(v => v.Id.Equals(3));
            vehicle1.Status = VehicleStatuses.Booked;
            var person1 = _persons.Single(v=> v.Id.Equals(1));
            _bookings.Add(new Booking(1, vehicle1, person1));

            var vehicles2 = _vehicles.Single(v => v.Id.Equals(4));
            var person2 = _persons.Single(v => v.Id.Equals(2));
            var booking = new Booking(2, vehicles2, person2);
            _bookings.Add(booking);

        }

        public IEnumerable<IPerson> GetPersons() => _persons;
        public IEnumerable<IBooking> GetBookings() => _bookings;
        public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
        {
            if (status == default) return _vehicles;
            return _vehicles.Where(v => v.Status.Equals(status));
        }
    }
}
