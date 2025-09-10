using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyEstadoleido
    {
        public NoveltyEstadoleido()
        {
            NoveltyRegistronovedads = new HashSet<NoveltyRegistronovedad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<NoveltyRegistronovedad> NoveltyRegistronovedads { get; set; }
    }
}
