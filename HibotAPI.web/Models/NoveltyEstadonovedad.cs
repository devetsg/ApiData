using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyEstadonovedad
    {
        public NoveltyEstadonovedad()
        {
            NoveltyEstadoscerrados = new HashSet<NoveltyEstadoscerrado>();
            NoveltyRegistronovedads = new HashSet<NoveltyRegistronovedad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<NoveltyEstadoscerrado> NoveltyEstadoscerrados { get; set; }
        public virtual ICollection<NoveltyRegistronovedad> NoveltyRegistronovedads { get; set; }
    }
}
