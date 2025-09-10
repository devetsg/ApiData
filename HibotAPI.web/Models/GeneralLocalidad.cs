using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralLocalidad
    {
        public GeneralLocalidad()
        {
            GeneralUpzs = new HashSet<GeneralUpz>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int CiudadId { get; set; }

        public virtual GeneralCiudad Ciudad { get; set; } = null!;
        public virtual ICollection<GeneralUpz> GeneralUpzs { get; set; }
    }
}
