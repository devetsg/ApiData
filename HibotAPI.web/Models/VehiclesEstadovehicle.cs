using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiclesEstadovehicle
    {
        public VehiclesEstadovehicle()
        {
            VehiclesMarcavehicles = new HashSet<VehiclesMarcavehicle>();
            VehiclesTipovehicles = new HashSet<VehiclesTipovehicle>();
            VehiclesVehicles = new HashSet<VehiclesVehicle>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<VehiclesMarcavehicle> VehiclesMarcavehicles { get; set; }
        public virtual ICollection<VehiclesTipovehicle> VehiclesTipovehicles { get; set; }
        public virtual ICollection<VehiclesVehicle> VehiclesVehicles { get; set; }
    }
}
