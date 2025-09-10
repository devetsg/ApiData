using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosPermiso
    {
        public UsuariosPermiso()
        {
            UsuariosAutorizados = new HashSet<UsuariosAutorizado>();
        }

        public int Id { get; set; }
        public int AccionId { get; set; }
        public int FuncionalidadId { get; set; }

        public virtual UsuariosAccion Accion { get; set; } = null!;
        public virtual UsuariosFuncionalidad Funcionalidad { get; set; } = null!;
        public virtual ICollection<UsuariosAutorizado> UsuariosAutorizados { get; set; }
    }
}
