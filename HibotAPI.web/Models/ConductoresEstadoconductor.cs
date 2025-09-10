using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresEstadoconductor
    {
        public ConductoresEstadoconductor()
        {
            ConductoresAdministratives = new HashSet<ConductoresAdministrative>();
            ConductoresConductors = new HashSet<ConductoresConductor>();
            ConductoresOperatives = new HashSet<ConductoresOperative>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ConductoresAdministrative> ConductoresAdministratives { get; set; }
        public virtual ICollection<ConductoresConductor> ConductoresConductors { get; set; }
        public virtual ICollection<ConductoresOperative> ConductoresOperatives { get; set; }
    }
}
