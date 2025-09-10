using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresState
    {
        public ConductoresState()
        {
            ConductoresCodeverifies = new HashSet<ConductoresCodeverify>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ConductoresCodeverify> ConductoresCodeverifies { get; set; }
    }
}
