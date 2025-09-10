using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosSolicitud
    {
        public ServiciosSolicitud()
        {
            ServiciosServicios = new HashSet<ServiciosServicio>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public DateTime Created { get; set; }
        public int Autorizados { get; set; }
        public int Prestados { get; set; }
        public DateTime Modifised { get; set; }
        public DateOnly? FechaInicioAutorizacion { get; set; }
        public DateOnly? FechaFinAutorizacion { get; set; }
        public int PasajeroId { get; set; }
        public int? TipoServicioId { get; set; }
        public int? UsuarioId { get; set; }
        public string ObservacionesSolicitud { get; set; } = null!;
        public int? ClienteId { get; set; }

        public virtual ClientesCliente? Cliente { get; set; }
        public virtual PasajerosPasajero Pasajero { get; set; } = null!;
        public virtual ServiciosTiposervicio? TipoServicio { get; set; }
        public virtual AuthUser? Usuario { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
    }
}
