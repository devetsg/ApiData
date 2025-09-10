using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosAccion
    {
        public UsuariosAccion()
        {
            UsuariosPermisos = new HashSet<UsuariosPermiso>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<UsuariosPermiso> UsuariosPermisos { get; set; }
    }
}
