using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiculosEstadovehiculo
    {
        public VehiculosEstadovehiculo()
        {
            VehiculosVehiculos = new HashSet<VehiculosVehiculo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<VehiculosVehiculo> VehiculosVehiculos { get; set; }
    }
}
