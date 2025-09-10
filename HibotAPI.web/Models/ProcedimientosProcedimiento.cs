using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ProcedimientosProcedimiento
    {
        public ProcedimientosProcedimiento()
        {
            ServiciosServicios = new HashSet<ServiciosServicio>();
            SolicitudesSolicituds = new HashSet<SolicitudesSolicitud>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? EstadoId { get; set; }

        public virtual ProcedimientosEstado? Estado { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
        public virtual ICollection<SolicitudesSolicitud> SolicitudesSolicituds { get; set; }
    }
}
