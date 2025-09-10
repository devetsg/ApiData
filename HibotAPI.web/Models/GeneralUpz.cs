using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralUpz
    {
        public GeneralUpz()
        {
            GeneralBarrios = new HashSet<GeneralBarrio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int LocalidadId { get; set; }

        public virtual GeneralLocalidad Localidad { get; set; } = null!;
        public virtual ICollection<GeneralBarrio> GeneralBarrios { get; set; }
    }
}
