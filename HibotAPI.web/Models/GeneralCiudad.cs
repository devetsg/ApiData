using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralCiudad
    {
        public GeneralCiudad()
        {
            GeneralLocalidads = new HashSet<GeneralLocalidad>();
            VehiclesPicoplacas = new HashSet<VehiclesPicoplaca>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int DepartamentoId { get; set; }

        public virtual GeneralDepartamento Departamento { get; set; } = null!;
        public virtual ICollection<GeneralLocalidad> GeneralLocalidads { get; set; }
        public virtual ICollection<VehiclesPicoplaca> VehiclesPicoplacas { get; set; }
    }
}
