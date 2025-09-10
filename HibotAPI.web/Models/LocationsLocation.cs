using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class LocationsLocation
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? AK { get; set; }
        public int? BarrioId { get; set; }
        public int? UsuarioId { get; set; }

        public virtual GeneralBarrio? Barrio { get; set; }
        public virtual AuthUser? Usuario { get; set; }
    }
}
