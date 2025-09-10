using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesLote
    {
        public int Id { get; set; }
        public string? NombreUsuario { get; set; }
        public string NumeroLote { get; set; } = null!;
        public DateTime? FechaLote { get; set; }
    }
}
