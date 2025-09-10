using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosLogService
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string? AcompañanteServicio { get; set; }
        public string? AutorizacionServicio { get; set; }
        public string? BarrioDestinoServicio { get; set; }
        public string? BarrioOrigenServicio { get; set; }
        public string? CiudadDestinoServicio { get; set; }
        public string? CiudadOrigenServicio { get; set; }
        public string? ClienteServicio { get; set; }
        public string? CodigoServicioServicio { get; set; }
        public string? DestinoServicio { get; set; }
        public string? DetalleServicio { get; set; }
        public string? DireccionDestinoServicio { get; set; }
        public string? DireccionOrigenServicio { get; set; }
        public string? DocumentoAcompañanteServicio { get; set; }
        public string? DocumentoServicio { get; set; }
        public string? EstadoServicioServicio { get; set; }
        public string? FechaRecogidaServicio { get; set; }
        public string? FechaServicioServicio { get; set; }
        public string? HoraRecogidaServicio { get; set; }
        public string? HoraServicioServicio { get; set; }
        public string? IdServicio { get; set; }
        public string? IdentificaciónServicio { get; set; }
        public string? LocalidadDestinoServicio { get; set; }
        public string? LocalidadOrigenServicio { get; set; }
        public string? MedioApoyoServicio { get; set; }
        public string? Observaciones { get; set; }
        public string? OrigenServicio { get; set; }
        public string? RegionalDestinoServicio { get; set; }
        public string? RegionalOrigenServicio { get; set; }
        public string? SeguimientoServicio { get; set; }
        public string? SolicitudServicio { get; set; }
        public string? Telefono1Servicio { get; set; }
        public string? Telefono2Servicio { get; set; }
        public string? TelefonoAcompañanteServicio { get; set; }
        public string? TipoAtencionServicio { get; set; }
        public string? TipoAutorizacionServicio { get; set; }
        public string? TipoProcedimientoServicio { get; set; }
        public string? TipoRutaServicio { get; set; }
        public string? TipoTrayectoServicio { get; set; }
        public string? TipoServicioServicio { get; set; }
        public string? UpzDestinoServicio { get; set; }
        public string? UpzOrigenServicio { get; set; }
        public string? UsuarioServicio { get; set; }
        public string? WhatsappServicio { get; set; }
        public int? ServicioId { get; set; }
        public int? UsuarioId { get; set; }
        public int? NovedadId { get; set; }
        public string Comentario { get; set; } = null!;

        public virtual NovedadesNovedad? Novedad { get; set; }
        public virtual ServiciosServicio? Servicio { get; set; }
        public virtual AuthUser? Usuario { get; set; }
    }
}
