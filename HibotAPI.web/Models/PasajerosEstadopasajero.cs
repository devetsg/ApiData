using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class PasajerosEstadopasajero
    {
        public PasajerosEstadopasajero()
        {
            PasajerosPasajeros = new HashSet<PasajerosPasajero>();
            PasajerosTipodiscapacidads = new HashSet<PasajerosTipodiscapacidad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<PasajerosPasajero> PasajerosPasajeros { get; set; }
        public virtual ICollection<PasajerosTipodiscapacidad> PasajerosTipodiscapacidads { get; set; }
    }
}
