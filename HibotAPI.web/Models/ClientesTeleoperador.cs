using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesTeleoperador
    {
        public ClientesTeleoperador()
        {
            SolicitudesSolicituds = new HashSet<SolicitudesSolicitud>();
        }

        public int UsuarioId { get; set; }
        public string? CargoContacto { get; set; }
        public string? CelularContacto { get; set; }
        public int? ClienteId { get; set; }
        public int? EstadoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public int? TipoId { get; set; }

        public virtual ClientesCliente? Cliente { get; set; }
        public virtual ClientesEstadoteleoperador? Estado { get; set; }
        public virtual UsuariosTipodocumento? Tipo { get; set; }
        public virtual AuthUser Usuario { get; set; } = null!;
        public virtual ICollection<SolicitudesSolicitud> SolicitudesSolicituds { get; set; }
    }
}
