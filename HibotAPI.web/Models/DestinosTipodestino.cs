using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class DestinosTipodestino
    {
        public DestinosTipodestino()
        {
            DestinosDestinos = new HashSet<DestinosDestino>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<DestinosDestino> DestinosDestinos { get; set; }
    }
}
