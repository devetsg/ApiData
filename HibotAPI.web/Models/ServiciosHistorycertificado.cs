using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosHistorycertificado
    {
        public int Id { get; set; }
        public string Evento { get; set; } = null!;
        public string? Solicitud { get; set; }
        public string? Documento { get; set; }
        public DateOnly? FechaInicial { get; set; }
        public DateOnly? FechaFinal { get; set; }
        public DateTime FechaEvento { get; set; }
        public int UserId { get; set; }

        public virtual AuthUser User { get; set; } = null!;
    }
}
