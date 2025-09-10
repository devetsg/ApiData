using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class PasajerosTipodiscapacidad
    {
        public PasajerosTipodiscapacidad()
        {
            PasajerosPasajeros = new HashSet<PasajerosPasajero>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int EstadoId { get; set; }

        public virtual PasajerosEstadopasajero Estado { get; set; } = null!;
        public virtual ICollection<PasajerosPasajero> PasajerosPasajeros { get; set; }
    }
}
