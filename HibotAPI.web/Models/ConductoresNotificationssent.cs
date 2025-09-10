using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresNotificationssent
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public string Title { get; set; } = null!;
        public DateTime Modified { get; set; }
        public int UserId { get; set; }
        public string SendTo { get; set; } = null!;

        public virtual AuthUser User { get; set; } = null!;
    }
}
