using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosFuncionalidad
    {
        public UsuariosFuncionalidad()
        {
            UsuariosPermisos = new HashSet<UsuariosPermiso>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ModuloPrincipalId { get; set; }

        public virtual UsuariosModuloprincipal ModuloPrincipal { get; set; } = null!;
        public virtual ICollection<UsuariosPermiso> UsuariosPermisos { get; set; }
    }
}
