using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class PasajerosPasajeroVehiculo
    {
        public int Id { get; set; }
        public int PasajeroId { get; set; }
        public int TipovehicleId { get; set; }

        public virtual PasajerosPasajero Pasajero { get; set; } = null!;
        public virtual VehiclesTipovehicle Tipovehicle { get; set; } = null!;
    }
}
