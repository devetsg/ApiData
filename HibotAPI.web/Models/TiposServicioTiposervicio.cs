using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class TiposServicioTiposervicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int? EstadoId { get; set; }

        public virtual TiposServicioEstado? Estado { get; set; }
    }
}
