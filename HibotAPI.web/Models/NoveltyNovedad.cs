using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyNovedad
    {
        public NoveltyNovedad()
        {
            NoveltyNovedadestadoservicios = new HashSet<NoveltyNovedadestadoservicio>();
            NoveltyRegistronovedads = new HashSet<NoveltyRegistronovedad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool IsActive { get; set; }
        public int? SubCategoriaId { get; set; }
        public int? AreaId { get; set; }

        public virtual GeneralArea? Area { get; set; }
        public virtual NoveltySubcategorium? SubCategoria { get; set; }
        public virtual ICollection<NoveltyNovedadestadoservicio> NoveltyNovedadestadoservicios { get; set; }
        public virtual ICollection<NoveltyRegistronovedad> NoveltyRegistronovedads { get; set; }
    }
}
