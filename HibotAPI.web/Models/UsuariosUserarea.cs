using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosUserarea
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int UserId { get; set; }

        public virtual GeneralArea Area { get; set; } = null!;
        public virtual AuthUser User { get; set; } = null!;
    }
}
