using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class AccountEmailaddress
    {
        public AccountEmailaddress()
        {
            AccountEmailconfirmations = new HashSet<AccountEmailconfirmation>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public bool Verified { get; set; }
        public bool Primary { get; set; }
        public int UserId { get; set; }

        public virtual AuthUser User { get; set; } = null!;
        public virtual ICollection<AccountEmailconfirmation> AccountEmailconfirmations { get; set; }
    }
}
