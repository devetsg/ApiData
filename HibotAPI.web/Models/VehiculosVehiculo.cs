using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiculosVehiculo
    {
        public int Id { get; set; }
        public int Modelo { get; set; }
        public string? Foto { get; set; }
        public int CodigoId { get; set; }
        public int TipoId { get; set; }
        public int EstadoId { get; set; }

        public virtual CodigosQrCodigosqr Codigo { get; set; } = null!;
        public virtual VehiculosEstadovehiculo Estado { get; set; } = null!;
        public virtual VehiculosTipovehiculo Tipo { get; set; } = null!;
    }
}
