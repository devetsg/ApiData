using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresConductorlog
    {
        public int Id { get; set; }
        public string Accion { get; set; } = null!;
        public string? CampoModificado { get; set; }
        public DateTime? Fecha { get; set; }
        public int ConductorId { get; set; }
        public int? UsuarioId { get; set; }

        public virtual ConductoresConductor Conductor { get; set; } = null!;
        public virtual AuthUser? Usuario { get; set; }
    }
}
