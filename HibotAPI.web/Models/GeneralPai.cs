using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralPai
    {
        public GeneralPai()
        {
            GeneralDepartamentos = new HashSet<GeneralDepartamento>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<GeneralDepartamento> GeneralDepartamentos { get; set; }
    }
}
