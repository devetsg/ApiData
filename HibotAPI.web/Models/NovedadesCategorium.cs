using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NovedadesCategorium
    {
        public NovedadesCategorium()
        {
            NovedadesSubcategoria = new HashSet<NovedadesSubcategorium>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int? ReferenciaId { get; set; }

        public virtual NovedadesReferencium? Referencia { get; set; }
        public virtual ICollection<NovedadesSubcategorium> NovedadesSubcategoria { get; set; }
    }
}
