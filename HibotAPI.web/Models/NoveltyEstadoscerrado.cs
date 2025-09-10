using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyEstadoscerrado
    {
        public NoveltyEstadoscerrado()
        {
            NoveltyRegistronovedads = new HashSet<NoveltyRegistronovedad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool IsActive { get; set; }
        public int EstadoNovedadId { get; set; }

        public virtual NoveltyEstadonovedad EstadoNovedad { get; set; } = null!;
        public virtual ICollection<NoveltyRegistronovedad> NoveltyRegistronovedads { get; set; }
    }
}
