using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class SolicitudesPrestacion
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string NumeroAutorizacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public DateTime FechaServicio { get; set; }
        public string? Lote { get; set; }
        public DateOnly? FechaFinAutorizacion { get; set; }
        public DateOnly? FechaInicioAutorizacion { get; set; }
        public string ObservacionesServicio { get; set; } = null!;
        public string? DestinoNombre { get; set; }

        public virtual ClientesCliente Cliente { get; set; } = null!;
    }
}
