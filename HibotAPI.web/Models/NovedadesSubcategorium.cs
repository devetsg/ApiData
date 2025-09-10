using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NovedadesSubcategorium
    {
        public NovedadesSubcategorium()
        {
            NovedadesNovedads = new HashSet<NovedadesNovedad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int? CategoriaId { get; set; }

        public virtual NovedadesCategorium? Categoria { get; set; }
        public virtual ICollection<NovedadesNovedad> NovedadesNovedads { get; set; }
    }
}
