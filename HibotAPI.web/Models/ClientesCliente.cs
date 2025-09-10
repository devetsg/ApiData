using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesCliente
    {
        public ClientesCliente()
        {
            ClientesCodigoClientes = new HashSet<ClientesCodigoCliente>();
            ClientesTeleoperadors = new HashSet<ClientesTeleoperador>();
            PasajerosPasajeros = new HashSet<PasajerosPasajero>();
            ServiciosSolicituds = new HashSet<ServiciosSolicitud>();
            SolicitudesPrestacions = new HashSet<SolicitudesPrestacion>();
        }

        public int Id { get; set; }
        public string? Nit { get; set; }
        public string? NombreRazonSocial { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int? EstadoId { get; set; }
        public int? SectorId { get; set; }
        public int? BarrioId { get; set; }
        public string? Correo { get; set; }

        public virtual GeneralBarrio? Barrio { get; set; }
        public virtual ClientesEstadocliente? Estado { get; set; }
        public virtual ClientesSector? Sector { get; set; }
        public virtual ICollection<ClientesCodigoCliente> ClientesCodigoClientes { get; set; }
        public virtual ICollection<ClientesTeleoperador> ClientesTeleoperadors { get; set; }
        public virtual ICollection<PasajerosPasajero> PasajerosPasajeros { get; set; }
        public virtual ICollection<ServiciosSolicitud> ServiciosSolicituds { get; set; }
        public virtual ICollection<SolicitudesPrestacion> SolicitudesPrestacions { get; set; }
    }
}
