using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class SolicitudesSolicitud
    {
        public SolicitudesSolicitud()
        {
            SolicitudesComentarioSolicituds = new HashSet<SolicitudesComentarioSolicitud>();
        }

        public int Id { get; set; }
        public string CiudadOrigen { get; set; } = null!;
        public string CiudadDestino { get; set; } = null!;
        public string DireccionOrigen { get; set; } = null!;
        public string DireccionDestino { get; set; } = null!;
        public string? HoraCita { get; set; }
        public string NumeroAutorizacion { get; set; } = null!;
        public string NumeroPreAutorizacion { get; set; } = null!;
        public string NumeroDocumento { get; set; } = null!;
        public string? NumeroServicio { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Telefono1 { get; set; } = null!;
        public string Telefono2 { get; set; } = null!;
        public bool Acompañamte { get; set; }
        public string Observaciones { get; set; } = null!;
        public int? EstadoId { get; set; }
        public int? MedioApoyoId { get; set; }
        public int? TeleOperadorId { get; set; }
        public int? TipoDocumentoId { get; set; }
        public int? TipoProcedimientoId { get; set; }
        public int? TipoSolicitudId { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public DateTime? FechaServicio { get; set; }
        public bool TipoPeticion { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual SolicitudesEstadoSolicitud? Estado { get; set; }
        public virtual MediosApoyoMedioapoyo? MedioApoyo { get; set; }
        public virtual ClientesTeleoperador? TeleOperador { get; set; }
        public virtual UsuariosTipodocumento? TipoDocumento { get; set; }
        public virtual ProcedimientosProcedimiento? TipoProcedimiento { get; set; }
        public virtual SolicitudesTipoSolicitud? TipoSolicitud { get; set; }
        public virtual ICollection<SolicitudesComentarioSolicitud> SolicitudesComentarioSolicituds { get; set; }
    }
}
