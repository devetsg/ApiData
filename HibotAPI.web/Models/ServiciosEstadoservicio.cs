using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosEstadoservicio
    {
        public ServiciosEstadoservicio()
        {
            NoveltyNovedadestadoservicios = new HashSet<NoveltyNovedadestadoservicio>();
            ServiciosServicios = new HashSet<ServiciosServicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int EstadoId { get; set; }

        public virtual ProcedimientosEstado Estado { get; set; } = null!;
        public virtual ICollection<NoveltyNovedadestadoservicio> NoveltyNovedadestadoservicios { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
    }
}
