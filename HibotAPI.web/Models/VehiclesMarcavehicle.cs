using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiclesMarcavehicle
    {
        public VehiclesMarcavehicle()
        {
            VehiclesVehicles = new HashSet<VehiclesVehicle>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int? EstadoId { get; set; }

        public virtual VehiclesEstadovehicle? Estado { get; set; }
        public virtual ICollection<VehiclesVehicle> VehiclesVehicles { get; set; }
    }
}
