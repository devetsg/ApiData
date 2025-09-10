using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiclesSecundarium
    {
        public VehiclesSecundarium()
        {
            VehiclesVehicles = new HashSet<VehiclesVehicle>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<VehiclesVehicle> VehiclesVehicles { get; set; }
    }
}
