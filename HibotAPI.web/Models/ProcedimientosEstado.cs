using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ProcedimientosEstado
    {
        public ProcedimientosEstado()
        {
            ProcedimientosProcedimientos = new HashSet<ProcedimientosProcedimiento>();
            ServiciosEstadoservicios = new HashSet<ServiciosEstadoservicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ProcedimientosProcedimiento> ProcedimientosProcedimientos { get; set; }
        public virtual ICollection<ServiciosEstadoservicio> ServiciosEstadoservicios { get; set; }
    }
}
