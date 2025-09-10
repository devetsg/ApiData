using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosAutorizado
    {
        public int Id { get; set; }
        public int PermisoId { get; set; }
        public int RolId { get; set; }

        public virtual UsuariosPermiso Permiso { get; set; } = null!;
        public virtual AuthGroup Rol { get; set; } = null!;
    }
}
