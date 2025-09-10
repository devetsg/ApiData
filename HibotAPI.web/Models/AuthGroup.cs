using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class AuthGroup
    {
        public AuthGroup()
        {
            AuthGroupPermissions = new HashSet<AuthGroupPermission>();
            AuthUserGroups = new HashSet<AuthUserGroup>();
            UsuariosAutorizados = new HashSet<UsuariosAutorizado>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; }
        public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual ICollection<UsuariosAutorizado> UsuariosAutorizados { get; set; }
    }
}
