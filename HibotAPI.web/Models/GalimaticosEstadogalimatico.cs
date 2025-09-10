using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GalimaticosEstadogalimatico
    {
        public GalimaticosEstadogalimatico()
        {
            GalimaticosGalimaticos = new HashSet<GalimaticosGalimatico>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<GalimaticosGalimatico> GalimaticosGalimaticos { get; set; }
    }
}
