using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyCategorium
    {
        public NoveltyCategorium()
        {
            NoveltySubcategoria = new HashSet<NoveltySubcategorium>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<NoveltySubcategorium> NoveltySubcategoria { get; set; }
    }
}
