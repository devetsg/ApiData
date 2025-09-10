using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class TrayectosTrayecto
    {
        public TrayectosTrayecto()
        {
            ServiciosServicios = new HashSet<ServiciosServicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string CodigoInterno { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int EstadoId { get; set; }

        public virtual TrayectosEstadotrayecto Estado { get; set; } = null!;
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
    }
}
