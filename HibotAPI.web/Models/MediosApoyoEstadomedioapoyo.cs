using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class MediosApoyoEstadomedioapoyo
    {
        public MediosApoyoEstadomedioapoyo()
        {
            MediosApoyoMedioapoyos = new HashSet<MediosApoyoMedioapoyo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<MediosApoyoMedioapoyo> MediosApoyoMedioapoyos { get; set; }
    }
}
