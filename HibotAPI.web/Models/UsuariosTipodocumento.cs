using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosTipodocumento
    {
        public UsuariosTipodocumento()
        {
            ClientesTeleoperadors = new HashSet<ClientesTeleoperador>();
            ConductoresConductors = new HashSet<ConductoresConductor>();
            PasajerosPasajeros = new HashSet<PasajerosPasajero>();
            ServiciosServicios = new HashSet<ServiciosServicio>();
            SolicitudesSolicituds = new HashSet<SolicitudesSolicitud>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Sigla { get; set; }

        public virtual ICollection<ClientesTeleoperador> ClientesTeleoperadors { get; set; }
        public virtual ICollection<ConductoresConductor> ConductoresConductors { get; set; }
        public virtual ICollection<PasajerosPasajero> PasajerosPasajeros { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
        public virtual ICollection<SolicitudesSolicitud> SolicitudesSolicituds { get; set; }
    }
}
