using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class PasajerosPasajero
    {
        public PasajerosPasajero()
        {
            DestinosDestinos = new HashSet<DestinosDestino>();
            PasajerosPasajeroVehiculos = new HashSet<PasajerosPasajeroVehiculo>();
            PasajerosPasajerologs = new HashSet<PasajerosPasajerolog>();
            ServiciosServicios = new HashSet<ServiciosServicio>();
            ServiciosSolicituds = new HashSet<ServiciosSolicitud>();
        }

        public int Id { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string PrimerNombre { get; set; } = null!;
        public string PrimerApellido { get; set; } = null!;
        public string TelefonoCelular1 { get; set; } = null!;
        public string TelefonoCelular2 { get; set; } = null!;
        public string Whatsapp { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public string? Usuario { get; set; }
        public string Lote { get; set; } = null!;
        public int CategoriaPasajeroId { get; set; }
        public int? ClienteId { get; set; }
        public int EstadoId { get; set; }
        public int MedioId { get; set; }
        public int TipoDocumentoId { get; set; }
        public string? Firma { get; set; }
        public int? TipoDiscapacidadId { get; set; }

        public virtual PasajerosCategoriapasajero CategoriaPasajero { get; set; } = null!;
        public virtual ClientesCliente? Cliente { get; set; }
        public virtual PasajerosEstadopasajero Estado { get; set; } = null!;
        public virtual MediosApoyoMedioapoyo Medio { get; set; } = null!;
        public virtual PasajerosTipodiscapacidad? TipoDiscapacidad { get; set; }
        public virtual UsuariosTipodocumento TipoDocumento { get; set; } = null!;
        public virtual ICollection<DestinosDestino> DestinosDestinos { get; set; }
        public virtual ICollection<PasajerosPasajeroVehiculo> PasajerosPasajeroVehiculos { get; set; }
        public virtual ICollection<PasajerosPasajerolog> PasajerosPasajerologs { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
        public virtual ICollection<ServiciosSolicitud> ServiciosSolicituds { get; set; }
    }
}
