using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Classes;
using Car_Rental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Rental.Business.Classes
{
   public class BookingProcessor
    {
        private readonly IData _db = new CollectionData();

        public IEnumerable<Customer> GetCustomers() 
        {
            return _db.GetPersons().Cast<Customer>();
        }
        public IEnumerable<IBooking> GetBookings() 
        {
            try 
            {
                return _db.GetBookings();
            }
            catch 
            {
                throw;
            }
        }
        public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default) 
        {
            try 
            {
                return _db.GetVehicles(status);
            }
            catch 
            {
                throw;
            }
        }

        public string[] VehicleTypeNames => _db.VehicleTypeNames;
    }

}
