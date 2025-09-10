using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosModuloprincipal
    {
        public UsuariosModuloprincipal()
        {
            UsuariosFuncionalidads = new HashSet<UsuariosFuncionalidad>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<UsuariosFuncionalidad> UsuariosFuncionalidads { get; set; }
    }
}
