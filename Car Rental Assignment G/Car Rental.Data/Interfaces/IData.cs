using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Data.Interfaces
{
    public interface IData
    {
        IEnumerable<IPerson> GetPersons();
        IEnumerable<IBooking> GetBookings();
        IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);

        public string[] VehicleTypeNames => Enum.GetNames(typeof(VehicleTypes));

    }
}
