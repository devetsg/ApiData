using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class UsuariosDispositivo
    {
        public int Id { get; set; }
        public string? PushToken { get; set; }
        public int? OperatingSystem { get; set; }
        public int UserId { get; set; }

        public virtual AuthUser User { get; set; } = null!;
    }
}
