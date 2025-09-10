using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiclesTipovehicle
    {
        public VehiclesTipovehicle()
        {
            PasajerosPasajeroVehiculos = new HashSet<PasajerosPasajeroVehiculo>();
            VehiclesVehicles = new HashSet<VehiclesVehicle>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Capacidad { get; set; } = null!;
        public int? EstadoId { get; set; }
        public string Completo { get; set; } = null!;

        public virtual VehiclesEstadovehicle? Estado { get; set; }
        public virtual ICollection<PasajerosPasajeroVehiculo> PasajerosPasajeroVehiculos { get; set; }
        public virtual ICollection<VehiclesVehicle> VehiclesVehicles { get; set; }
    }
}
