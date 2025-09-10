using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GalimaticosSector
    {
        public GalimaticosSector()
        {
            GalimaticosGalimaticos = new HashSet<GalimaticosGalimatico>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int EstadoId { get; set; }

        public virtual GalimaticosEstadosector Estado { get; set; } = null!;
        public virtual ICollection<GalimaticosGalimatico> GalimaticosGalimaticos { get; set; }
    }
}
