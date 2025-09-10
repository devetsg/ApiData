using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosTiposervicio
    {
        public ServiciosTiposervicio()
        {
            ServiciosServicios = new HashSet<ServiciosServicio>();
            ServiciosSolicituds = new HashSet<ServiciosSolicitud>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
        public virtual ICollection<ServiciosSolicitud> ServiciosSolicituds { get; set; }
    }
}
