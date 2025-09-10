using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GalimaticosGalimatico
    {
        public string? Nit { get; set; }
        public string? NombreRazonSocial { get; set; }
        public int? BarrioId { get; set; }
        public int? EstadoId { get; set; }
        public int? SectorId { get; set; }
        public int UsuarioId { get; set; }

        public virtual GeneralBarrio? Barrio { get; set; }
        public virtual GalimaticosEstadogalimatico? Estado { get; set; }
        public virtual GalimaticosSector? Sector { get; set; }
        public virtual AuthUser Usuario { get; set; } = null!;
    }
}
