using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiclesVehicle
    {
        public VehiclesVehicle()
        {
            ConductoresConductors = new HashSet<ConductoresConductor>();
        }

        public int Id { get; set; }
        public int Modelo { get; set; }
        public string? Foto { get; set; }
        public string? Codigo { get; set; }
        public int EstadoId { get; set; }
        public int? MarcaId { get; set; }
        public int TipoId { get; set; }
        public string? Placa { get; set; }
        public string? CaracteristicaPrincipal { get; set; }
        public string? CaracteristicaSecundaria { get; set; }
        public int? CaracteristicaPrincipalId { get; set; }
        public int? CaracteristicaSecundariaId { get; set; }
        public int? ConvenioId { get; set; }
        public string? CodigoQr { get; set; }

        public virtual VehiclesPrincipal? CaracteristicaPrincipalNavigation { get; set; }
        public virtual VehiclesSecundarium? CaracteristicaSecundariaNavigation { get; set; }
        public virtual VehiclesConvenio? Convenio { get; set; }
        public virtual VehiclesEstadovehicle Estado { get; set; } = null!;
        public virtual VehiclesMarcavehicle? Marca { get; set; }
        public virtual VehiclesTipovehicle Tipo { get; set; } = null!;
        public virtual ICollection<ConductoresConductor> ConductoresConductors { get; set; }
    }
}
