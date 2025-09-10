using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresConductor
    {
        public ConductoresConductor()
        {
            ConductoresConductorlogs = new HashSet<ConductoresConductorlog>();
            ConductoresHorarios = new HashSet<ConductoresHorario>();
            ServiciosServicios = new HashSet<ServiciosServicio>();
        }

        public string? Foto { get; set; }
        public string Correo { get; set; } = null!;
        public int EstadoId { get; set; }
        public string? Calificacion { get; set; }
        public int UsuarioId { get; set; }
        public int? BarrioId { get; set; }
        public string? Cedula { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public int? TipoDocumentoId { get; set; }
        public int? VehiculoId { get; set; }
        public int? ContratacionId { get; set; }
        public string Latitude { get; set; } = null!;
        public string Longitude { get; set; } = null!;
        public DateTime? FechaIngreso { get; set; }

        public virtual GeneralBarrio? Barrio { get; set; }
        public virtual ConductoresContratacion? Contratacion { get; set; }
        public virtual ConductoresEstadoconductor Estado { get; set; } = null!;
        public virtual UsuariosTipodocumento? TipoDocumento { get; set; }
        public virtual AuthUser Usuario { get; set; } = null!;
        public virtual VehiclesVehicle? Vehiculo { get; set; }
        public virtual GeocodingsLocationdriver? GeocodingsLocationdriver { get; set; }
        public virtual ICollection<ConductoresConductorlog> ConductoresConductorlogs { get; set; }
        public virtual ICollection<ConductoresHorario> ConductoresHorarios { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
    }
}
