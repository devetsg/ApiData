using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosServicio
    {
        public ServiciosServicio()
        {
            NoveltyRegistronovedads = new HashSet<NoveltyRegistronovedad>();
            ServiciosLogServices = new HashSet<ServiciosLogService>();
            ServiciosLogServicios = new HashSet<ServiciosLogServicio>();
        }

        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaServicio { get; set; }
        public string? NAutorizacion { get; set; }
        public string NDocumentoAcompañante { get; set; } = null!;
        public string NombreAcompañante { get; set; } = null!;
        public string ObservacionesServicio { get; set; } = null!;
        public string TelefonoAcompañante { get; set; } = null!;
        public int DocumentoAcompañanteId { get; set; }
        public int EstadoServicioId { get; set; }
        public string PreAutorizacion { get; set; } = null!;
        public int TipoAtencionId { get; set; }
        public int TipoProcedimientoId { get; set; }
        public int TipoRutaId { get; set; }
        public int TipoTrayectoId { get; set; }
        public int TipoAutorizacionId { get; set; }
        public int SeguimientoId { get; set; }
        public int? ConductorId { get; set; }
        public DateTime HoraRecogida { get; set; }
        public int TipoServicioId { get; set; }
        public int DestinoId { get; set; }
        public int OrigenId { get; set; }
        public string? Lote { get; set; }
        public int? CodigoServicioId { get; set; }
        public bool Detalle { get; set; }
        public DateOnly? FechaFinAutorizacion { get; set; }
        public DateOnly? FechaInicioAutorizacion { get; set; }
        public int PasajeroId { get; set; }
        public DateTime Modified { get; set; }
        public int? UsuarioId { get; set; }
        public int? SolicitudId { get; set; }
        public int? NovedadId { get; set; }
        public string Comentario { get; set; } = null!;
        public bool IsAssingMasive { get; set; }
        public string? Firma { get; set; }
        public string LatitudeFinish { get; set; } = null!;
        public string LatitudeStart { get; set; } = null!;
        public string LongitudeFinish { get; set; } = null!;
        public string LongitudeStart { get; set; } = null!;
        public string? Cierre { get; set; }
        public string? ObservacionesOperador { get; set; }
        public string AddressFinish { get; set; } = null!;
        public string AddressStart { get; set; } = null!;
        public DateTime? TimeInicio { get; set; }
        public int Bloqueado { get; set; }
        public DateTime? DateOffline { get; set; }

        public virtual ClientesCodigoCliente? CodigoServicio { get; set; }
        public virtual ConductoresConductor? Conductor { get; set; }
        public virtual DestinosDestino Destino { get; set; } = null!;
        public virtual UsuariosTipodocumento DocumentoAcompañante { get; set; } = null!;
        public virtual ServiciosEstadoservicio EstadoServicio { get; set; } = null!;
        public virtual NovedadesNovedad? Novedad { get; set; }
        public virtual DestinosDestino Origen { get; set; } = null!;
        public virtual PasajerosPasajero Pasajero { get; set; } = null!;
        public virtual ServiciosSeguimiento Seguimiento { get; set; } = null!;
        public virtual ServiciosSolicitud? Solicitud { get; set; }
        public virtual AtencionesAtencion TipoAtencion { get; set; } = null!;
        public virtual ServiciosTipoautorizacion TipoAutorizacion { get; set; } = null!;
        public virtual ProcedimientosProcedimiento TipoProcedimiento { get; set; } = null!;
        public virtual ServiciosTiporutum TipoRuta { get; set; } = null!;
        public virtual ServiciosTiposervicio TipoServicio { get; set; } = null!;
        public virtual TrayectosTrayecto TipoTrayecto { get; set; } = null!;
        public virtual AuthUser? Usuario { get; set; }
        public virtual GeocodingsGeocodingsroute? GeocodingsGeocodingsroute { get; set; }
        public virtual ICollection<NoveltyRegistronovedad> NoveltyRegistronovedads { get; set; }
        public virtual ICollection<ServiciosLogService> ServiciosLogServices { get; set; }
        public virtual ICollection<ServiciosLogServicio> ServiciosLogServicios { get; set; }
    }
}
