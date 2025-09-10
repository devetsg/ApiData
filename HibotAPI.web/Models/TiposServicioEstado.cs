using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class TiposServicioEstado
    {
        public TiposServicioEstado()
        {
            TiposServicioTiposervicios = new HashSet<TiposServicioTiposervicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<TiposServicioTiposervicio> TiposServicioTiposervicios { get; set; }
    }
}
