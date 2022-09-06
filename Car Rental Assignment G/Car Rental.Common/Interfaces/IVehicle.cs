using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces
{
    public interface IVehicle
    {
        int Id { get; }
        string Make { get; }
        string RegistrationNumber { get; }
        double Odometer { get; }
        double CostKm { get; }
        double CostDay { get; }
        VehicleStatuses Status { get; set; }
        VehicleTypes Type { get; }

        void Drive(double distance);
    }
}
