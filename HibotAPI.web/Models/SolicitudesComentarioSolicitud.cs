using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class SolicitudesComentarioSolicitud
    {
        public int Id { get; set; }
        public string Descripcpion { get; set; } = null!;
        public int? SolicitudId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? FechaComentario { get; set; }
        public string? Estado { get; set; }

        public virtual SolicitudesSolicitud? Solicitud { get; set; }
        public virtual AuthUser? Usuario { get; set; }
    }
}
