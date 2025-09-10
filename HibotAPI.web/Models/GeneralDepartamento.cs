using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralDepartamento
    {
        public GeneralDepartamento()
        {
            GeneralCiudads = new HashSet<GeneralCiudad>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int PaisId { get; set; }

        public virtual GeneralPai Pais { get; set; } = null!;
        public virtual ICollection<GeneralCiudad> GeneralCiudads { get; set; }
    }
}
