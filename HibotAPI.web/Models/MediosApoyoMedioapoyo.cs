using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class MediosApoyoMedioapoyo
    {
        public MediosApoyoMedioapoyo()
        {
            PasajerosPasajeros = new HashSet<PasajerosPasajero>();
            SolicitudesSolicituds = new HashSet<SolicitudesSolicitud>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int EstadoId { get; set; }

        public virtual MediosApoyoEstadomedioapoyo Estado { get; set; } = null!;
        public virtual ICollection<PasajerosPasajero> PasajerosPasajeros { get; set; }
        public virtual ICollection<SolicitudesSolicitud> SolicitudesSolicituds { get; set; }
    }
}
