using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresHorario
    {
        public int Id { get; set; }
        public DateOnly? Fecha { get; set; }
        public TimeOnly? HoraInicial { get; set; }
        public TimeOnly? HoraFinal { get; set; }
        public int ConductorId { get; set; }
        public string? Comentario { get; set; }
        public int EstadoId { get; set; }
        public int? UserId { get; set; }
        public DateTime Modified { get; set; }

        public virtual ConductoresConductor Conductor { get; set; } = null!;
        public virtual ConductoresEstadoHorario Estado { get; set; } = null!;
        public virtual AuthUser? User { get; set; }
    }
}
