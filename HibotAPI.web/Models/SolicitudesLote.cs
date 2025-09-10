using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class SolicitudesLote
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string NumeroLote { get; set; } = null!;
        public DateTime? FechaLote { get; set; }
    }
}
