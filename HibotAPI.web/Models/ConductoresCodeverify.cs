using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresCodeverify
    {
        public int UserId { get; set; }
        public string Code { get; set; } = null!;
        public int? StateId { get; set; }

        public virtual ConductoresState? State { get; set; }
        public virtual AuthUser User { get; set; } = null!;
    }
}
