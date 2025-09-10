using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class AuthtokenToken
    {
        public string Key { get; set; } = null!;
        public DateTime Created { get; set; }
        public int UserId { get; set; }

        public virtual AuthUser User { get; set; } = null!;
    }
}
