using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class AtencionesEstadoatencion
    {
        public AtencionesEstadoatencion()
        {
            AtencionesAtencions = new HashSet<AtencionesAtencion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<AtencionesAtencion> AtencionesAtencions { get; set; }
    }
}
