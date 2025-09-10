using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GalimaticosEstadosector
    {
        public GalimaticosEstadosector()
        {
            GalimaticosSectors = new HashSet<GalimaticosSector>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<GalimaticosSector> GalimaticosSectors { get; set; }
    }
}
