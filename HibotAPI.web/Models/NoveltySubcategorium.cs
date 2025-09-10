using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltySubcategorium
    {
        public NoveltySubcategorium()
        {
            NoveltyNovedads = new HashSet<NoveltyNovedad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool IsActive { get; set; }
        public int? CategoriaId { get; set; }

        public virtual NoveltyCategorium? Categoria { get; set; }
        public virtual ICollection<NoveltyNovedad> NoveltyNovedads { get; set; }
    }
}
