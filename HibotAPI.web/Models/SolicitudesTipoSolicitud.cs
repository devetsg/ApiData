using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class SolicitudesTipoSolicitud
    {
        public SolicitudesTipoSolicitud()
        {
            SolicitudesSolicituds = new HashSet<SolicitudesSolicitud>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<SolicitudesSolicitud> SolicitudesSolicituds { get; set; }
    }
}
