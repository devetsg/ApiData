using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class AuthUser
    {
        public AuthUser()
        {
            AccountEmailaddresses = new HashSet<AccountEmailaddress>();
            AuthUserGroups = new HashSet<AuthUserGroup>();
            AuthUserUserPermissions = new HashSet<AuthUserUserPermission>();
            ConductoresConductorlogs = new HashSet<ConductoresConductorlog>();
            ConductoresHorarios = new HashSet<ConductoresHorario>();
            ConductoresLocationdrivers = new HashSet<ConductoresLocationdriver>();
            ConductoresNotificationssents = new HashSet<ConductoresNotificationssent>();
            DjangoAdminLogs = new HashSet<DjangoAdminLog>();
            LocationsLocations = new HashSet<LocationsLocation>();
            NoveltyMessages = new HashSet<NoveltyMessage>();
            NoveltyRegistronovedadConductors = new HashSet<NoveltyRegistronovedad>();
            NoveltyRegistronovedadOperarios = new HashSet<NoveltyRegistronovedad>();
            PasajerosPasajerologs = new HashSet<PasajerosPasajerolog>();
            ServiciosHistorycertificados = new HashSet<ServiciosHistorycertificado>();
            ServiciosLogServices = new HashSet<ServiciosLogService>();
            ServiciosLogServicios = new HashSet<ServiciosLogServicio>();
            ServiciosServicios = new HashSet<ServiciosServicio>();
            ServiciosSolicituds = new HashSet<ServiciosSolicitud>();
            SolicitudesComentarioSolicituds = new HashSet<SolicitudesComentarioSolicitud>();
        }

        public int Id { get; set; }
        public string Password { get; set; } = null!;
        public DateTime? LastLogin { get; set; }
        public bool IsSuperuser { get; set; }
        public string Username { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool IsStaff { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateJoined { get; set; }

        public virtual AuthtokenToken? AuthtokenToken { get; set; }
        public virtual ClientesTeleoperador? ClientesTeleoperador { get; set; }
        public virtual ConductoresAdministrative? ConductoresAdministrative { get; set; }
        public virtual ConductoresCodeverify? ConductoresCodeverify { get; set; }
        public virtual ConductoresConductor? ConductoresConductor { get; set; }
        public virtual ConductoresOperative? ConductoresOperative { get; set; }
        public virtual GalimaticosGalimatico? GalimaticosGalimatico { get; set; }
        public virtual UsuariosDispositivo? UsuariosDispositivo { get; set; }
        public virtual UsuariosUserarea? UsuariosUserarea { get; set; }
        public virtual ICollection<AccountEmailaddress> AccountEmailaddresses { get; set; }
        public virtual ICollection<AuthUserGroup> AuthUserGroups { get; set; }
        public virtual ICollection<AuthUserUserPermission> AuthUserUserPermissions { get; set; }
        public virtual ICollection<ConductoresConductorlog> ConductoresConductorlogs { get; set; }
        public virtual ICollection<ConductoresHorario> ConductoresHorarios { get; set; }
        public virtual ICollection<ConductoresLocationdriver> ConductoresLocationdrivers { get; set; }
        public virtual ICollection<ConductoresNotificationssent> ConductoresNotificationssents { get; set; }
        public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; }
        public virtual ICollection<LocationsLocation> LocationsLocations { get; set; }
        public virtual ICollection<NoveltyMessage> NoveltyMessages { get; set; }
        public virtual ICollection<NoveltyRegistronovedad> NoveltyRegistronovedadConductors { get; set; }
        public virtual ICollection<NoveltyRegistronovedad> NoveltyRegistronovedadOperarios { get; set; }
        public virtual ICollection<PasajerosPasajerolog> PasajerosPasajerologs { get; set; }
        public virtual ICollection<ServiciosHistorycertificado> ServiciosHistorycertificados { get; set; }
        public virtual ICollection<ServiciosLogService> ServiciosLogServices { get; set; }
        public virtual ICollection<ServiciosLogServicio> ServiciosLogServicios { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
        public virtual ICollection<ServiciosSolicitud> ServiciosSolicituds { get; set; }
        public virtual ICollection<SolicitudesComentarioSolicitud> SolicitudesComentarioSolicituds { get; set; }
    }
}
