using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosLogServicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Datos { get; set; } = null!;
        public int? EventoId { get; set; }
        public int? ServicioId { get; set; }
        public int? UsuarioId { get; set; }
        public string? Estado { get; set; }

        public virtual ServiciosEventosLog? Evento { get; set; }
        public virtual ServiciosServicio? Servicio { get; set; }
        public virtual AuthUser? Usuario { get; set; }
    }
}
