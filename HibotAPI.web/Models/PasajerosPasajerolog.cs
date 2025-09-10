using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class PasajerosPasajerolog
    {
        public int Id { get; set; }
        public string Accion { get; set; } = null!;
        public string? CampoModificado { get; set; }
        public DateTime? Fecha { get; set; }
        public int PasajeroId { get; set; }
        public int? UsuarioId { get; set; }

        public virtual PasajerosPasajero Pasajero { get; set; } = null!;
        public virtual AuthUser? Usuario { get; set; }
    }
}
