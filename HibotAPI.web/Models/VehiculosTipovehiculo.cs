using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiculosTipovehiculo
    {
        public VehiculosTipovehiculo()
        {
            VehiculosVehiculos = new HashSet<VehiculosVehiculo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Capacidad { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;

        public virtual ICollection<VehiculosVehiculo> VehiculosVehiculos { get; set; }
    }
}
