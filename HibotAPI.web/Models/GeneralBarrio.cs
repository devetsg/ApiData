using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralBarrio
    {
        public GeneralBarrio()
        {
            ClientesClientes = new HashSet<ClientesCliente>();
            ConductoresConductors = new HashSet<ConductoresConductor>();
            DestinosDestinos = new HashSet<DestinosDestino>();
            GalimaticosGalimaticos = new HashSet<GalimaticosGalimatico>();
            LocationsLocations = new HashSet<LocationsLocation>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int UpzId { get; set; }

        public virtual GeneralUpz Upz { get; set; } = null!;
        public virtual ICollection<ClientesCliente> ClientesClientes { get; set; }
        public virtual ICollection<ConductoresConductor> ConductoresConductors { get; set; }
        public virtual ICollection<DestinosDestino> DestinosDestinos { get; set; }
        public virtual ICollection<GalimaticosGalimatico> GalimaticosGalimaticos { get; set; }
        public virtual ICollection<LocationsLocation> LocationsLocations { get; set; }
    }
}
