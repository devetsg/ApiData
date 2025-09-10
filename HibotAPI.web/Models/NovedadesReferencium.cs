using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NovedadesReferencium
    {
        public NovedadesReferencium()
        {
            NovedadesCategoria = new HashSet<NovedadesCategorium>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<NovedadesCategorium> NovedadesCategoria { get; set; }
    }
}
