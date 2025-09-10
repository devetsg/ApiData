using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class CodigosQrCodigosqr
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Foto { get; set; }
        public int EstadoId { get; set; }

        public virtual CodigosQrEstadocodigoqr Estado { get; set; } = null!;
        public virtual VehiculosVehiculo? VehiculosVehiculo { get; set; }
    }
}
