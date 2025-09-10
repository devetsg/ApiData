using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HibotAPI.web.Models
{
    public partial class sg368newContext : DbContext
    {
        public sg368newContext()
        {
        }

        public sg368newContext(DbContextOptions<sg368newContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountEmailaddress> AccountEmailaddresses { get; set; } = null!;
        public virtual DbSet<AccountEmailconfirmation> AccountEmailconfirmations { get; set; } = null!;
        public virtual DbSet<AtencionesAtencion> AtencionesAtencions { get; set; } = null!;
        public virtual DbSet<AtencionesEstadoatencion> AtencionesEstadoatencions { get; set; } = null!;
        public virtual DbSet<AuthGroup> AuthGroups { get; set; } = null!;
        public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; } = null!;
        public virtual DbSet<AuthPermission> AuthPermissions { get; set; } = null!;
        public virtual DbSet<AuthUser> AuthUsers { get; set; } = null!;
        public virtual DbSet<AuthUserGroup> AuthUserGroups { get; set; } = null!;
        public virtual DbSet<AuthUserUserPermission> AuthUserUserPermissions { get; set; } = null!;
        public virtual DbSet<AuthtokenToken> AuthtokenTokens { get; set; } = null!;
        public virtual DbSet<ClientesCliente> ClientesClientes { get; set; } = null!;
        public virtual DbSet<ClientesCodigoCliente> ClientesCodigoClientes { get; set; } = null!;
        public virtual DbSet<ClientesEstadocliente> ClientesEstadoclientes { get; set; } = null!;
        public virtual DbSet<ClientesEstadocodigo> ClientesEstadocodigos { get; set; } = null!;
        public virtual DbSet<ClientesEstadosector> ClientesEstadosectors { get; set; } = null!;
        public virtual DbSet<ClientesEstadoteleoperador> ClientesEstadoteleoperadors { get; set; } = null!;
        public virtual DbSet<ClientesLote> ClientesLotes { get; set; } = null!;
        public virtual DbSet<ClientesSector> ClientesSectors { get; set; } = null!;
        public virtual DbSet<ClientesTeleoperador> ClientesTeleoperadors { get; set; } = null!;
        public virtual DbSet<CodigosQrCodigosqr> CodigosQrCodigosqrs { get; set; } = null!;
        public virtual DbSet<CodigosQrEstadocodigoqr> CodigosQrEstadocodigoqrs { get; set; } = null!;
        public virtual DbSet<ConductoresAdministrative> ConductoresAdministratives { get; set; } = null!;
        public virtual DbSet<ConductoresCodeverify> ConductoresCodeverifies { get; set; } = null!;
        public virtual DbSet<ConductoresConductor> ConductoresConductors { get; set; } = null!;
        public virtual DbSet<ConductoresConductorlog> ConductoresConductorlogs { get; set; } = null!;
        public virtual DbSet<ConductoresContratacion> ConductoresContratacions { get; set; } = null!;
        public virtual DbSet<ConductoresEstadoHorario> ConductoresEstadoHorarios { get; set; } = null!;
        public virtual DbSet<ConductoresEstadoconductor> ConductoresEstadoconductors { get; set; } = null!;
        public virtual DbSet<ConductoresHorario> ConductoresHorarios { get; set; } = null!;
        public virtual DbSet<ConductoresLocationdriver> ConductoresLocationdrivers { get; set; } = null!;
        public virtual DbSet<ConductoresNotificationssent> ConductoresNotificationssents { get; set; } = null!;
        public virtual DbSet<ConductoresOperative> ConductoresOperatives { get; set; } = null!;
        public virtual DbSet<ConductoresState> ConductoresStates { get; set; } = null!;
        public virtual DbSet<DestinosClasedestino> DestinosClasedestinos { get; set; } = null!;
        public virtual DbSet<DestinosDestino> DestinosDestinos { get; set; } = null!;
        public virtual DbSet<DestinosEstado> DestinosEstados { get; set; } = null!;
        public virtual DbSet<DestinosTipodestino> DestinosTipodestinos { get; set; } = null!;
        public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; } = null!;
        public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; } = null!;
        public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; } = null!;
        public virtual DbSet<DjangoSession> DjangoSessions { get; set; } = null!;
        public virtual DbSet<DjangoSite> DjangoSites { get; set; } = null!;
        public virtual DbSet<GalimaticosEstadogalimatico> GalimaticosEstadogalimaticos { get; set; } = null!;
        public virtual DbSet<GalimaticosEstadosector> GalimaticosEstadosectors { get; set; } = null!;
        public virtual DbSet<GalimaticosGalimatico> GalimaticosGalimaticos { get; set; } = null!;
        public virtual DbSet<GalimaticosSector> GalimaticosSectors { get; set; } = null!;
        public virtual DbSet<GeneralAppmovile> GeneralAppmoviles { get; set; } = null!;
        public virtual DbSet<GeneralArea> GeneralAreas { get; set; } = null!;
        public virtual DbSet<GeneralBarrio> GeneralBarrios { get; set; } = null!;
        public virtual DbSet<GeneralCiudad> GeneralCiudads { get; set; } = null!;
        public virtual DbSet<GeneralDepartamento> GeneralDepartamentos { get; set; } = null!;
        public virtual DbSet<GeneralLocalidad> GeneralLocalidads { get; set; } = null!;
        public virtual DbSet<GeneralPai> GeneralPais { get; set; } = null!;
        public virtual DbSet<GeneralUpz> GeneralUpzs { get; set; } = null!;
        public virtual DbSet<GeocodingsGeocodingsroute> GeocodingsGeocodingsroutes { get; set; } = null!;
        public virtual DbSet<GeocodingsLocationdriver> GeocodingsLocationdrivers { get; set; } = null!;
        public virtual DbSet<LocationsLocation> LocationsLocations { get; set; } = null!;
        public virtual DbSet<MediosApoyoEstadomedioapoyo> MediosApoyoEstadomedioapoyos { get; set; } = null!;
        public virtual DbSet<MediosApoyoMedioapoyo> MediosApoyoMedioapoyos { get; set; } = null!;
        public virtual DbSet<NovedadesCategorium> NovedadesCategoria { get; set; } = null!;
        public virtual DbSet<NovedadesNovedad> NovedadesNovedads { get; set; } = null!;
        public virtual DbSet<NovedadesReferencium> NovedadesReferencia { get; set; } = null!;
        public virtual DbSet<NovedadesSubcategorium> NovedadesSubcategoria { get; set; } = null!;
        public virtual DbSet<NoveltyCategorium> NoveltyCategoria { get; set; } = null!;
        public virtual DbSet<NoveltyEstadoleido> NoveltyEstadoleidos { get; set; } = null!;
        public virtual DbSet<NoveltyEstadonovedad> NoveltyEstadonovedads { get; set; } = null!;
        public virtual DbSet<NoveltyEstadoscerrado> NoveltyEstadoscerrados { get; set; } = null!;
        public virtual DbSet<NoveltyMessage> NoveltyMessages { get; set; } = null!;
        public virtual DbSet<NoveltyNovedad> NoveltyNovedads { get; set; } = null!;
        public virtual DbSet<NoveltyNovedadestadoservicio> NoveltyNovedadestadoservicios { get; set; } = null!;
        public virtual DbSet<NoveltyRegistronovedad> NoveltyRegistronovedads { get; set; } = null!;
        public virtual DbSet<NoveltySubcategorium> NoveltySubcategoria { get; set; } = null!;
        public virtual DbSet<PasajerosCategoriapasajero> PasajerosCategoriapasajeros { get; set; } = null!;
        public virtual DbSet<PasajerosEstadopasajero> PasajerosEstadopasajeros { get; set; } = null!;
        public virtual DbSet<PasajerosOrigenpasajero> PasajerosOrigenpasajeros { get; set; } = null!;
        public virtual DbSet<PasajerosPasajero> PasajerosPasajeros { get; set; } = null!;
        public virtual DbSet<PasajerosPasajeroVehiculo> PasajerosPasajeroVehiculos { get; set; } = null!;
        public virtual DbSet<PasajerosPasajerolog> PasajerosPasajerologs { get; set; } = null!;
        public virtual DbSet<PasajerosTipodiscapacidad> PasajerosTipodiscapacidads { get; set; } = null!;
        public virtual DbSet<ProcedimientosEstado> ProcedimientosEstados { get; set; } = null!;
        public virtual DbSet<ProcedimientosProcedimiento> ProcedimientosProcedimientos { get; set; } = null!;
        public virtual DbSet<ServiciosEstadoservicio> ServiciosEstadoservicios { get; set; } = null!;
        public virtual DbSet<ServiciosEventosLog> ServiciosEventosLogs { get; set; } = null!;
        public virtual DbSet<ServiciosHistorycertificado> ServiciosHistorycertificados { get; set; } = null!;
        public virtual DbSet<ServiciosLogService> ServiciosLogServices { get; set; } = null!;
        public virtual DbSet<ServiciosLogServicio> ServiciosLogServicios { get; set; } = null!;
        public virtual DbSet<ServiciosLote> ServiciosLotes { get; set; } = null!;
        public virtual DbSet<ServiciosSeguimiento> ServiciosSeguimientos { get; set; } = null!;
        public virtual DbSet<ServiciosServicio> ServiciosServicios { get; set; } = null!;
        public virtual DbSet<ServiciosServicioreasignado> ServiciosServicioreasignados { get; set; } = null!;
        public virtual DbSet<ServiciosSolicitud> ServiciosSolicituds { get; set; } = null!;
        public virtual DbSet<ServiciosTipoautorizacion> ServiciosTipoautorizacions { get; set; } = null!;
        public virtual DbSet<ServiciosTiporutum> ServiciosTiporuta { get; set; } = null!;
        public virtual DbSet<ServiciosTiposervicio> ServiciosTiposervicios { get; set; } = null!;
        public virtual DbSet<SolicitudesComentarioSolicitud> SolicitudesComentarioSolicituds { get; set; } = null!;
        public virtual DbSet<SolicitudesEstadoSolicitud> SolicitudesEstadoSolicituds { get; set; } = null!;
        public virtual DbSet<SolicitudesLote> SolicitudesLotes { get; set; } = null!;
        public virtual DbSet<SolicitudesPrestacion> SolicitudesPrestacions { get; set; } = null!;
        public virtual DbSet<SolicitudesSolicitud> SolicitudesSolicituds { get; set; } = null!;
        public virtual DbSet<SolicitudesTipoSolicitud> SolicitudesTipoSolicituds { get; set; } = null!;
        public virtual DbSet<TiposServicioEstado> TiposServicioEstados { get; set; } = null!;
        public virtual DbSet<TiposServicioTiposervicio> TiposServicioTiposervicios { get; set; } = null!;
        public virtual DbSet<TrayectosEstadotrayecto> TrayectosEstadotrayectos { get; set; } = null!;
        public virtual DbSet<TrayectosTrayecto> TrayectosTrayectos { get; set; } = null!;
        public virtual DbSet<UsuariosAccion> UsuariosAccions { get; set; } = null!;
        public virtual DbSet<UsuariosAutorizado> UsuariosAutorizados { get; set; } = null!;
        public virtual DbSet<UsuariosCategoriausuario> UsuariosCategoriausuarios { get; set; } = null!;
        public virtual DbSet<UsuariosDispositivo> UsuariosDispositivos { get; set; } = null!;
        public virtual DbSet<UsuariosEstadousuario> UsuariosEstadousuarios { get; set; } = null!;
        public virtual DbSet<UsuariosFuncionalidad> UsuariosFuncionalidads { get; set; } = null!;
        public virtual DbSet<UsuariosGenero> UsuariosGeneros { get; set; } = null!;
        public virtual DbSet<UsuariosModuloprincipal> UsuariosModuloprincipals { get; set; } = null!;
        public virtual DbSet<UsuariosPermiso> UsuariosPermisos { get; set; } = null!;
        public virtual DbSet<UsuariosTipodocumento> UsuariosTipodocumentos { get; set; } = null!;
        public virtual DbSet<UsuariosUserarea> UsuariosUserareas { get; set; } = null!;
        public virtual DbSet<VehiclesConvenio> VehiclesConvenios { get; set; } = null!;
        public virtual DbSet<VehiclesEstadovehicle> VehiclesEstadovehicles { get; set; } = null!;
        public virtual DbSet<VehiclesMarcavehicle> VehiclesMarcavehicles { get; set; } = null!;
        public virtual DbSet<VehiclesPicoplaca> VehiclesPicoplacas { get; set; } = null!;
        public virtual DbSet<VehiclesPrincipal> VehiclesPrincipals { get; set; } = null!;
        public virtual DbSet<VehiclesSecundarium> VehiclesSecundaria { get; set; } = null!;
        public virtual DbSet<VehiclesTipovehicle> VehiclesTipovehicles { get; set; } = null!;
        public virtual DbSet<VehiclesVehicle> VehiclesVehicles { get; set; } = null!;
        public virtual DbSet<VehiculosEstadovehiculo> VehiculosEstadovehiculos { get; set; } = null!;
        public virtual DbSet<VehiculosTipovehiculo> VehiculosTipovehiculos { get; set; } = null!;
        public virtual DbSet<VehiculosVehiculo> VehiculosVehiculos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=10.128.50.19;Port=5432;Database=sg368new;Username=integracion_app1;Password=Integracion123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountEmailaddress>(entity =>
            {
                entity.ToTable("account_emailaddress");

                entity.HasIndex(e => e.Email, "account_emailaddress_email_03be32b2_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Email, "account_emailaddress_email_key")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "account_emailaddress_user_id_2c513194");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.Primary).HasColumnName("primary");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Verified).HasColumnName("verified");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountEmailaddresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("account_emailaddress_user_id_2c513194_fk_auth_user_id");
            });

            modelBuilder.Entity<AccountEmailconfirmation>(entity =>
            {
                entity.ToTable("account_emailconfirmation");

                entity.HasIndex(e => e.EmailAddressId, "account_emailconfirmation_email_address_id_5b7f8c58");

                entity.HasIndex(e => e.Key, "account_emailconfirmation_key_f43612bd_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Key, "account_emailconfirmation_key_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.EmailAddressId).HasColumnName("email_address_id");

                entity.Property(e => e.Key)
                    .HasMaxLength(64)
                    .HasColumnName("key");

                entity.Property(e => e.Sent).HasColumnName("sent");

                entity.HasOne(d => d.EmailAddress)
                    .WithMany(p => p.AccountEmailconfirmations)
                    .HasForeignKey(d => d.EmailAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("account_emailconfirm_email_address_id_5b7f8c58_fk_account_e");
            });

            modelBuilder.Entity<AtencionesAtencion>(entity =>
            {
                entity.ToTable("Atenciones_atencion");

                entity.HasIndex(e => e.EstadoId, "Atenciones_atencion_estado_id_7d695a0b");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.AtencionesAtencions)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Atenciones_atencion_estado_id_7d695a0b_fk_Atencione");
            });

            modelBuilder.Entity<AtencionesEstadoatencion>(entity =>
            {
                entity.ToTable("Atenciones_estadoatencion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<AuthGroup>(entity =>
            {
                entity.ToTable("auth_group");

                entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Name, "auth_group_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AuthGroupPermission>(entity =>
            {
                entity.ToTable("auth_group_permissions");

                entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

                entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthGroupPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
            });

            modelBuilder.Entity<AuthPermission>(entity =>
            {
                entity.ToTable("auth_permission");

                entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

                entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Codename)
                    .HasMaxLength(100)
                    .HasColumnName("codename");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.AuthPermissions)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
            });

            modelBuilder.Entity<AuthUser>(entity =>
            {
                entity.ToTable("auth_user");

                entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Username, "auth_user_username_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateJoined).HasColumnName("date_joined");

                entity.Property(e => e.Email)
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsStaff).HasColumnName("is_staff");

                entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");

                entity.Property(e => e.LastLogin).HasColumnName("last_login");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(128)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(150)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<AuthUserGroup>(entity =>
            {
                entity.ToTable("auth_user_groups");

                entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

                entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

                entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthUserUserPermission>(entity =>
            {
                entity.ToTable("auth_user_user_permissions");

                entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

                entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

                entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthUserUserPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
            });

            modelBuilder.Entity<AuthtokenToken>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("authtoken_token_pkey");

                entity.ToTable("authtoken_token");

                entity.HasIndex(e => e.Key, "authtoken_token_key_10f0b77e_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.UserId, "authtoken_token_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Key)
                    .HasMaxLength(40)
                    .HasColumnName("key");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AuthtokenToken)
                    .HasForeignKey<AuthtokenToken>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("authtoken_token_user_id_35299eff_fk_auth_user_id");
            });

            modelBuilder.Entity<ClientesCliente>(entity =>
            {
                entity.ToTable("clientes_cliente");

                entity.HasIndex(e => e.BarrioId, "clientes_cliente_barrio_id_99216df2");

                entity.HasIndex(e => e.EstadoId, "clientes_cliente_estado_id_1ab613a5");

                entity.HasIndex(e => e.Nit, "clientes_cliente_nit_da8089d7_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Nit, "clientes_cliente_nit_da8089d7_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.SectorId, "clientes_cliente_sector_id_dbde5bf8");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BarrioId).HasColumnName("barrio_id");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nit)
                    .HasMaxLength(50)
                    .HasColumnName("nit");

                entity.Property(e => e.NombreRazonSocial)
                    .HasMaxLength(50)
                    .HasColumnName("nombreRazonSocial");

                entity.Property(e => e.SectorId).HasColumnName("sector_id");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.Barrio)
                    .WithMany(p => p.ClientesClientes)
                    .HasForeignKey(d => d.BarrioId)
                    .HasConstraintName("clientes_cliente_barrio_id_99216df2_fk_general_barrio_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ClientesClientes)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("clientes_cliente_estado_id_1ab613a5_fk_clientes_");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.ClientesClientes)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("clientes_cliente_sector_id_dbde5bf8_fk_clientes_sector_id");
            });

            modelBuilder.Entity<ClientesCodigoCliente>(entity =>
            {
                entity.ToTable("clientes_codigo_cliente");

                entity.HasIndex(e => e.ClienteId, "clientes_codigo_cliente_cliente_id_92c85e33");

                entity.HasIndex(e => e.EstadoId, "clientes_codigo_cliente_estado_id_dedbf55e");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Atributo)
                    .HasMaxLength(100)
                    .HasColumnName("atributo");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Lote)
                    .HasMaxLength(100)
                    .HasColumnName("lote");

                entity.Property(e => e.Mayor)
                    .HasMaxLength(100)
                    .HasColumnName("mayor");

                entity.Property(e => e.Menor)
                    .HasMaxLength(100)
                    .HasColumnName("menor");

                entity.Property(e => e.Valor)
                    .HasMaxLength(100)
                    .HasColumnName("valor");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ClientesCodigoClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("clientes_codigo_clie_cliente_id_92c85e33_fk_clientes_");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ClientesCodigoClientes)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_codigo_clie_estado_id_dedbf55e_fk_clientes_");
            });

            modelBuilder.Entity<ClientesEstadocliente>(entity =>
            {
                entity.ToTable("clientes_estadocliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ClientesEstadocodigo>(entity =>
            {
                entity.ToTable("clientes_estadocodigo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ClientesEstadosector>(entity =>
            {
                entity.ToTable("clientes_estadosector");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ClientesEstadoteleoperador>(entity =>
            {
                entity.ToTable("clientes_estadoteleoperador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ClientesLote>(entity =>
            {
                entity.ToTable("clientes_lote");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaLote).HasColumnName("fecha_lote");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_Usuario");

                entity.Property(e => e.NumeroLote)
                    .HasMaxLength(100)
                    .HasColumnName("numero_lote");
            });

            modelBuilder.Entity<ClientesSector>(entity =>
            {
                entity.ToTable("clientes_sector");

                entity.HasIndex(e => e.EstadoId, "clientes_sector_estado_id_58ddcf97");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ClientesSectors)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_sector_estado_id_58ddcf97_fk_clientes_estadosector_id");
            });

            modelBuilder.Entity<ClientesTeleoperador>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("clientes_teleoperador_pkey");

                entity.ToTable("clientes_teleoperador");

                entity.HasIndex(e => e.ClienteId, "clientes_teleoperador_cliente_id_0d862912");

                entity.HasIndex(e => e.EstadoId, "clientes_teleoperador_estado_id_1cd83683");

                entity.HasIndex(e => e.TipoId, "clientes_teleoperador_tipo_id_a4e346c4");

                entity.Property(e => e.UsuarioId)
                    .ValueGeneratedNever()
                    .HasColumnName("usuario_id");

                entity.Property(e => e.CargoContacto)
                    .HasMaxLength(50)
                    .HasColumnName("cargoContacto");

                entity.Property(e => e.CelularContacto)
                    .HasMaxLength(50)
                    .HasColumnName("celularContacto");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(50)
                    .HasColumnName("numero_Documento");

                entity.Property(e => e.TipoId).HasColumnName("tipo_id");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ClientesTeleoperadors)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("clientes_teleoperado_cliente_id_0d862912_fk_clientes_");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ClientesTeleoperadors)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("clientes_teleoperado_estado_id_1cd83683_fk_clientes_");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.ClientesTeleoperadors)
                    .HasForeignKey(d => d.TipoId)
                    .HasConstraintName("clientes_teleoperado_tipo_id_a4e346c4_fk_usuarios_");

                entity.HasOne(d => d.Usuario)
                    .WithOne(p => p.ClientesTeleoperador)
                    .HasForeignKey<ClientesTeleoperador>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_teleoperador_usuario_id_4bd4580c_fk_auth_user_id");
            });

            modelBuilder.Entity<CodigosQrCodigosqr>(entity =>
            {
                entity.ToTable("codigosQR_codigosqr");

                entity.HasIndex(e => e.EstadoId, "codigosQR_codigosqr_estado_id_666fced3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Foto)
                    .HasMaxLength(100)
                    .HasColumnName("foto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.CodigosQrCodigosqrs)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("codigosQR_codigosqr_estado_id_666fced3_fk_codigosQR");
            });

            modelBuilder.Entity<CodigosQrEstadocodigoqr>(entity =>
            {
                entity.ToTable("codigosQR_estadocodigoqr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ConductoresAdministrative>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("conductores_administrative_pkey");

                entity.ToTable("conductores_administrative");

                entity.HasIndex(e => e.EstadoId, "conductores_administrative_estado_id_ae499aea");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ConductoresAdministratives)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("conductores_administ_estado_id_ae499aea_fk_conductor");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.ConductoresAdministrative)
                    .HasForeignKey<ConductoresAdministrative>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_administrative_user_id_8dfe35c3_fk_auth_user_id");
            });

            modelBuilder.Entity<ConductoresCodeverify>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("conductores_codeverify_pkey");

                entity.ToTable("conductores_codeverify");

                entity.HasIndex(e => e.StateId, "conductores_codeverify_state_id_64f9f34b");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .HasColumnName("code");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ConductoresCodeverifies)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("conductores_codeveri_state_id_64f9f34b_fk_conductor");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.ConductoresCodeverify)
                    .HasForeignKey<ConductoresCodeverify>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_codeverify_user_id_c99bf1b9_fk_auth_user_id");
            });

            modelBuilder.Entity<ConductoresConductor>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("conductores_conductor_usuario_id_e7a6b2af_pk");

                entity.ToTable("conductores_conductor");

                entity.HasIndex(e => e.BarrioId, "conductores_conductor_barrio_id_2dc588fb");

                entity.HasIndex(e => e.ContratacionId, "conductores_conductor_contratacion_id_7a96eed7");

                entity.HasIndex(e => e.EstadoId, "conductores_conductor_estado_id_9a038412");

                entity.HasIndex(e => e.TipoDocumentoId, "conductores_conductor_tipoDocumento_id_7deea6a7");

                entity.HasIndex(e => e.VehiculoId, "conductores_conductor_vehiculo_id_ed4ebbe1");

                entity.Property(e => e.UsuarioId)
                    .ValueGeneratedNever()
                    .HasColumnName("usuario_id");

                entity.Property(e => e.BarrioId).HasColumnName("barrio_id");

                entity.Property(e => e.Calificacion)
                    .HasMaxLength(3)
                    .HasColumnName("calificacion");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(50)
                    .HasColumnName("cedula");

                entity.Property(e => e.ContratacionId).HasColumnName("contratacion_id");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.FechaIngreso).HasColumnName("fecha_ingreso");

                entity.Property(e => e.Foto)
                    .HasMaxLength(100)
                    .HasColumnName("foto");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(30)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(30)
                    .HasColumnName("longitude");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .HasColumnName("telefono");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumento_id");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculo_id");

                entity.HasOne(d => d.Barrio)
                    .WithMany(p => p.ConductoresConductors)
                    .HasForeignKey(d => d.BarrioId)
                    .HasConstraintName("conductores_conductor_barrio_id_2dc588fb_fk_general_barrio_id");

                entity.HasOne(d => d.Contratacion)
                    .WithMany(p => p.ConductoresConductors)
                    .HasForeignKey(d => d.ContratacionId)
                    .HasConstraintName("conductores_conducto_contratacion_id_7a96eed7_fk_conductor");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ConductoresConductors)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_conducto_estado_id_9a038412_fk_conductor");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.ConductoresConductors)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .HasConstraintName("conductores_conducto_tipoDocumento_id_7deea6a7_fk_usuarios_");

                entity.HasOne(d => d.Usuario)
                    .WithOne(p => p.ConductoresConductor)
                    .HasForeignKey<ConductoresConductor>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_conductor_usuario_id_e7a6b2af_fk_auth_user_id");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.ConductoresConductors)
                    .HasForeignKey(d => d.VehiculoId)
                    .HasConstraintName("conductores_conducto_vehiculo_id_ed4ebbe1_fk_vehicles_");
            });

            modelBuilder.Entity<ConductoresConductorlog>(entity =>
            {
                entity.ToTable("conductores_conductorlog");

                entity.HasIndex(e => e.ConductorId, "conductores_conductorlog_conductor_id_64544b71");

                entity.HasIndex(e => e.UsuarioId, "conductores_conductorlog_usuario_id_cb68532f");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accion)
                    .HasMaxLength(50)
                    .HasColumnName("accion");

                entity.Property(e => e.CampoModificado)
                    .HasMaxLength(800)
                    .HasColumnName("campo_modificado");

                entity.Property(e => e.ConductorId).HasColumnName("conductor_id");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Conductor)
                    .WithMany(p => p.ConductoresConductorlogs)
                    .HasForeignKey(d => d.ConductorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_conducto_conductor_id_64544b71_fk_conductor");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ConductoresConductorlogs)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("conductores_conductorlog_usuario_id_cb68532f_fk_auth_user_id");
            });

            modelBuilder.Entity<ConductoresContratacion>(entity =>
            {
                entity.ToTable("conductores_contratacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ConductoresEstadoHorario>(entity =>
            {
                entity.ToTable("conductores_estado_horario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ConductoresEstadoconductor>(entity =>
            {
                entity.ToTable("conductores_estadoconductor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ConductoresHorario>(entity =>
            {
                entity.ToTable("conductores_horario");

                entity.HasIndex(e => e.ConductorId, "conductores_horario_conductor_id_a7a53a04");

                entity.HasIndex(e => e.EstadoId, "conductores_horario_estado_id_253ddaaa");

                entity.HasIndex(e => e.UserId, "conductores_horario_user_id_e9ae09d9");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .HasColumnName("comentario");

                entity.Property(e => e.ConductorId).HasColumnName("conductor_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.HoraFinal).HasColumnName("hora_final");

                entity.Property(e => e.HoraInicial).HasColumnName("hora_inicial");

                entity.Property(e => e.Modified).HasColumnName("modified");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Conductor)
                    .WithMany(p => p.ConductoresHorarios)
                    .HasForeignKey(d => d.ConductorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_horario_conductor_id_a7a53a04_fk_conductor");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ConductoresHorarios)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_horario_estado_id_253ddaaa_fk_conductor");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConductoresHorarios)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("conductores_horario_user_id_e9ae09d9_fk_auth_user_id");
            });

            modelBuilder.Entity<ConductoresLocationdriver>(entity =>
            {
                entity.ToTable("conductores_locationdriver");

                entity.HasIndex(e => e.DriverId, "conductores_locationdriver_driver_id_c26e4cf4");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(30)
                    .HasColumnName("latitude");

                entity.Property(e => e.Load).HasColumnName("load");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(30)
                    .HasColumnName("longitude");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.ConductoresLocationdrivers)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_locationdriver_driver_id_c26e4cf4_fk_auth_user_id");
            });

            modelBuilder.Entity<ConductoresNotificationssent>(entity =>
            {
                entity.ToTable("conductores_notificationssent");

                entity.HasIndex(e => e.UserId, "conductores_notificationssent_user_id_72cc70ee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Modified).HasColumnName("modified");

                entity.Property(e => e.SendTo).HasColumnName("send_to");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConductoresNotificationssents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_notificationssent_user_id_72cc70ee_fk_auth_user_id");
            });

            modelBuilder.Entity<ConductoresOperative>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("conductores_operative_pkey");

                entity.ToTable("conductores_operative");

                entity.HasIndex(e => e.EstadoId, "conductores_operative_estado_id_3389dfcd");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ConductoresOperatives)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("conductores_operativ_estado_id_3389dfcd_fk_conductor");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.ConductoresOperative)
                    .HasForeignKey<ConductoresOperative>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conductores_operative_user_id_b066fd8e_fk_auth_user_id");
            });

            modelBuilder.Entity<ConductoresState>(entity =>
            {
                entity.ToTable("conductores_state");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DestinosClasedestino>(entity =>
            {
                entity.ToTable("destinos_clasedestino");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<DestinosDestino>(entity =>
            {
                entity.ToTable("destinos_destino");

                entity.HasIndex(e => e.ClaseDestinoId, "destinos_destino_ClaseDestino_id_65f72ea8");

                entity.HasIndex(e => e.BarrioId, "destinos_destino_barrio_id_dd956bf1");

                entity.HasIndex(e => e.EstadoId, "destinos_destino_estado_id_8c50d487");

                entity.HasIndex(e => e.PasajeroId, "destinos_destino_pasajero_id_b2f4b587");

                entity.HasIndex(e => e.TipoDestinoId, "destinos_destino_tipoDestino_id_18d7824a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AK)
                    .HasMaxLength(100)
                    .HasColumnName("aK");

                entity.Property(e => e.BarrioId).HasColumnName("barrio_id");

                entity.Property(e => e.ClaseDestinoId).HasColumnName("claseDestino_id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .HasColumnName("direccion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(30)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(30)
                    .HasColumnName("longitude");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.PasajeroId).HasColumnName("pasajero_id");

                entity.Property(e => e.TipoDestinoId).HasColumnName("tipoDestino_id");

                entity.HasOne(d => d.Barrio)
                    .WithMany(p => p.DestinosDestinos)
                    .HasForeignKey(d => d.BarrioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("destinos_destino_barrio_id_dd956bf1_fk_general_barrio_id");

                entity.HasOne(d => d.ClaseDestino)
                    .WithMany(p => p.DestinosDestinos)
                    .HasForeignKey(d => d.ClaseDestinoId)
                    .HasConstraintName("destinos_destino_claseDestino_id_72bdecf4_fk_destinos_");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.DestinosDestinos)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("destinos_destino_estado_id_8c50d487_fk_destinos_estado_id");

                entity.HasOne(d => d.Pasajero)
                    .WithMany(p => p.DestinosDestinos)
                    .HasForeignKey(d => d.PasajeroId)
                    .HasConstraintName("destinos_destino_pasajero_id_b2f4b587_fk_pasajeros_pasajero_id");

                entity.HasOne(d => d.TipoDestino)
                    .WithMany(p => p.DestinosDestinos)
                    .HasForeignKey(d => d.TipoDestinoId)
                    .HasConstraintName("destinos_destino_tipoDestino_id_18d7824a_fk_destinos_");
            });

            modelBuilder.Entity<DestinosEstado>(entity =>
            {
                entity.ToTable("destinos_estado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<DestinosTipodestino>(entity =>
            {
                entity.ToTable("destinos_tipodestino");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<DjangoAdminLog>(entity =>
            {
                entity.ToTable("django_admin_log");

                entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

                entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionFlag).HasColumnName("action_flag");

                entity.Property(e => e.ActionTime).HasColumnName("action_time");

                entity.Property(e => e.ChangeMessage).HasColumnName("change_message");

                entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectRepr)
                    .HasMaxLength(200)
                    .HasColumnName("object_repr");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DjangoAdminLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
            });

            modelBuilder.Entity<DjangoContentType>(entity =>
            {
                entity.ToTable("django_content_type");

                entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppLabel)
                    .HasMaxLength(100)
                    .HasColumnName("app_label");

                entity.Property(e => e.Model)
                    .HasMaxLength(100)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<DjangoMigration>(entity =>
            {
                entity.ToTable("django_migrations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.App)
                    .HasMaxLength(255)
                    .HasColumnName("app");

                entity.Property(e => e.Applied).HasColumnName("applied");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<DjangoSession>(entity =>
            {
                entity.HasKey(e => e.SessionKey)
                    .HasName("django_session_pkey");

                entity.ToTable("django_session");

                entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

                entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(40)
                    .HasColumnName("session_key");

                entity.Property(e => e.ExpireDate).HasColumnName("expire_date");

                entity.Property(e => e.SessionData).HasColumnName("session_data");
            });

            modelBuilder.Entity<DjangoSite>(entity =>
            {
                entity.ToTable("django_site");

                entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Domain)
                    .HasMaxLength(100)
                    .HasColumnName("domain");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<GalimaticosEstadogalimatico>(entity =>
            {
                entity.ToTable("galimaticos_estadogalimatico");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<GalimaticosEstadosector>(entity =>
            {
                entity.ToTable("galimaticos_estadosector");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<GalimaticosGalimatico>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("galimaticos_galimatico_usuario_id_ea90cfc4_pk");

                entity.ToTable("galimaticos_galimatico");

                entity.HasIndex(e => e.BarrioId, "galimaticos_galimatico_barrio_id_b8d12349");

                entity.HasIndex(e => e.EstadoId, "galimaticos_galimatico_estado_id_e447f4c0");

                entity.HasIndex(e => e.SectorId, "galimaticos_galimatico_sector_id_33b825c7");

                entity.HasIndex(e => e.UsuarioId, "galimaticos_galimatico_usuario_id_ea90cfc4_uniq")
                    .IsUnique();

                entity.Property(e => e.UsuarioId)
                    .ValueGeneratedNever()
                    .HasColumnName("usuario_id");

                entity.Property(e => e.BarrioId).HasColumnName("barrio_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nit)
                    .HasMaxLength(50)
                    .HasColumnName("nit");

                entity.Property(e => e.NombreRazonSocial)
                    .HasMaxLength(50)
                    .HasColumnName("nombreRazonSocial");

                entity.Property(e => e.SectorId).HasColumnName("sector_id");

                entity.HasOne(d => d.Barrio)
                    .WithMany(p => p.GalimaticosGalimaticos)
                    .HasForeignKey(d => d.BarrioId)
                    .HasConstraintName("galimaticos_galimatico_barrio_id_b8d12349_fk_general_barrio_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.GalimaticosGalimaticos)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("galimaticos_galimati_estado_id_e447f4c0_fk_galimatic");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.GalimaticosGalimaticos)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("galimaticos_galimati_sector_id_33b825c7_fk_galimatic");

                entity.HasOne(d => d.Usuario)
                    .WithOne(p => p.GalimaticosGalimatico)
                    .HasForeignKey<GalimaticosGalimatico>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("galimaticos_galimatico_usuario_id_ea90cfc4_fk_auth_user_id");
            });

            modelBuilder.Entity<GalimaticosSector>(entity =>
            {
                entity.ToTable("galimaticos_sector");

                entity.HasIndex(e => e.EstadoId, "galimaticos_sector_estado_id_c499296c");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.GalimaticosSectors)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("galimaticos_sector_estado_id_c499296c_fk_galimatic");
            });

            modelBuilder.Entity<GeneralAppmovile>(entity =>
            {
                entity.ToTable("general_appmovile");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Modified).HasColumnName("modified");

                entity.Property(e => e.NumberOfServicesDownload).HasColumnName("number_of_services_download");

                entity.Property(e => e.TasWebValidation).HasColumnName("tas_web_validation");

                entity.Property(e => e.TimeDelayStartService).HasColumnName("time_delay_start_service");

                entity.Property(e => e.Version)
                    .HasMaxLength(5)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<GeneralArea>(entity =>
            {
                entity.ToTable("general_area");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<GeneralBarrio>(entity =>
            {
                entity.ToTable("general_barrio");

                entity.HasIndex(e => e.UpzId, "general_barrio_Upz_id_87c2fc3f");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('general_barrio_id_seq1'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.UpzId).HasColumnName("Upz_id");

                entity.HasOne(d => d.Upz)
                    .WithMany(p => p.GeneralBarrios)
                    .HasForeignKey(d => d.UpzId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("general_barrio_Upz_id_87c2fc3f_fk_general_upz_id");
            });

            modelBuilder.Entity<GeneralCiudad>(entity =>
            {
                entity.ToTable("general_ciudad");

                entity.HasIndex(e => e.DepartamentoId, "general_ciudad_Departamento_id_9c9d891e");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepartamentoId).HasColumnName("Departamento_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Departamento)
                    .WithMany(p => p.GeneralCiudads)
                    .HasForeignKey(d => d.DepartamentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("general_ciudad_Departamento_id_9c9d891e_fk_general_d");
            });

            modelBuilder.Entity<GeneralDepartamento>(entity =>
            {
                entity.ToTable("general_departamento");

                entity.HasIndex(e => e.PaisId, "general_departamento_Pais_id_617f5095");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.GeneralDepartamentos)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("general_departamento_pais_id_ac360638_fk_general_pais_id");
            });

            modelBuilder.Entity<GeneralLocalidad>(entity =>
            {
                entity.ToTable("general_localidad");

                entity.HasIndex(e => e.CiudadId, "general_localidad_Ciudad_id_a2e443a6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CiudadId).HasColumnName("Ciudad_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.GeneralLocalidads)
                    .HasForeignKey(d => d.CiudadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("general_localidad_Ciudad_id_a2e443a6_fk_general_ciudad_id");
            });

            modelBuilder.Entity<GeneralPai>(entity =>
            {
                entity.ToTable("general_pais");

                entity.HasIndex(e => e.Nombre, "general_pais_nombre_8b2c1ec3_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Nombre, "general_pais_nombre_8b2c1ec3_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<GeneralUpz>(entity =>
            {
                entity.ToTable("general_upz");

                entity.HasIndex(e => e.LocalidadId, "general_barrio_Localidad_id_c462e896");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('general_barrio_id_seq'::regclass)");

                entity.Property(e => e.LocalidadId).HasColumnName("Localidad_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Localidad)
                    .WithMany(p => p.GeneralUpzs)
                    .HasForeignKey(d => d.LocalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("general_barrio_Localidad_id_c462e896_fk_general_localidad_id");
            });

            modelBuilder.Entity<GeocodingsGeocodingsroute>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("geocodings_geocodingsroute_pkey");

                entity.ToTable("geocodings_geocodingsroute");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("service_id");

                entity.Property(e => e.Route).HasColumnName("route");

                entity.HasOne(d => d.Service)
                    .WithOne(p => p.GeocodingsGeocodingsroute)
                    .HasForeignKey<GeocodingsGeocodingsroute>(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geocodings_geocoding_service_id_1a603b6f_fk_servicios");
            });

            modelBuilder.Entity<GeocodingsLocationdriver>(entity =>
            {
                entity.HasKey(e => e.DriverId)
                    .HasName("geocodings_locationdriver_pkey");

                entity.ToTable("geocodings_locationdriver");

                entity.Property(e => e.DriverId)
                    .ValueGeneratedNever()
                    .HasColumnName("driver_id");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .HasColumnName("lat");

                entity.Property(e => e.Lon)
                    .HasMaxLength(20)
                    .HasColumnName("lon");

                entity.Property(e => e.Modified).HasColumnName("modified");

                entity.HasOne(d => d.Driver)
                    .WithOne(p => p.GeocodingsLocationdriver)
                    .HasForeignKey<GeocodingsLocationdriver>(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("geocodings_locationd_driver_id_5e9da417_fk_conductor");
            });

            modelBuilder.Entity<LocationsLocation>(entity =>
            {
                entity.ToTable("locations_location");

                entity.HasIndex(e => e.BarrioId, "locations_location_barrio_id_1ce958bc");

                entity.HasIndex(e => e.UsuarioId, "locations_location_usuario_id_48aa4ef6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AK)
                    .HasMaxLength(100)
                    .HasColumnName("aK");

                entity.Property(e => e.BarrioId).HasColumnName("barrio_id");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Barrio)
                    .WithMany(p => p.LocationsLocations)
                    .HasForeignKey(d => d.BarrioId)
                    .HasConstraintName("locations_location_barrio_id_1ce958bc_fk_general_barrio_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.LocationsLocations)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("locations_location_usuario_id_48aa4ef6_fk_auth_user_id");
            });

            modelBuilder.Entity<MediosApoyoEstadomedioapoyo>(entity =>
            {
                entity.ToTable("mediosApoyo_estadomedioapoyo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<MediosApoyoMedioapoyo>(entity =>
            {
                entity.ToTable("mediosApoyo_medioapoyo");

                entity.HasIndex(e => e.EstadoId, "mediosApoyo_medioapoyo_EstadoMedioApoyo_id_17298f8d");

                entity.HasIndex(e => e.Nombre, "mediosApoyo_medioapoyo_nombre_5a5f60af_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Nombre, "mediosApoyo_medioapoyo_nombre_5a5f60af_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.MediosApoyoMedioapoyos)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mediosApoyo_medioapo_estado_id_8c8caa32_fk_mediosApo");
            });

            modelBuilder.Entity<NovedadesCategorium>(entity =>
            {
                entity.ToTable("novedades_categoria");

                entity.HasIndex(e => e.ReferenciaId, "novedades_categoria_referencia_id_bf7af8b3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.ReferenciaId).HasColumnName("referencia_id");

                entity.HasOne(d => d.Referencia)
                    .WithMany(p => p.NovedadesCategoria)
                    .HasForeignKey(d => d.ReferenciaId)
                    .HasConstraintName("novedades_categoria_referencia_id_bf7af8b3_fk_novedades");
            });

            modelBuilder.Entity<NovedadesNovedad>(entity =>
            {
                entity.ToTable("novedades_novedad");

                entity.HasIndex(e => e.SubCategoriaId, "novedades_descripcion_subCategoria_id_64327649");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('novedades_estadonovedad_id_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.SubCategoriaId).HasColumnName("subCategoria_id");

                entity.HasOne(d => d.SubCategoria)
                    .WithMany(p => p.NovedadesNovedads)
                    .HasForeignKey(d => d.SubCategoriaId)
                    .HasConstraintName("novedades_descripcio_subCategoria_id_64327649_fk_novedades");
            });

            modelBuilder.Entity<NovedadesReferencium>(entity =>
            {
                entity.ToTable("novedades_referencia");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('novedades_rolnovedad_id_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<NovedadesSubcategorium>(entity =>
            {
                entity.ToTable("novedades_subcategoria");

                entity.HasIndex(e => e.CategoriaId, "novedades_subcategoria_categoria_id_c1d5cace");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoriaId).HasColumnName("categoria_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.NovedadesSubcategoria)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("novedades_subcategor_categoria_id_c1d5cace_fk_novedades");
            });

            modelBuilder.Entity<NoveltyCategorium>(entity =>
            {
                entity.ToTable("novelty_categoria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<NoveltyEstadoleido>(entity =>
            {
                entity.ToTable("novelty_estadoleido");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<NoveltyEstadonovedad>(entity =>
            {
                entity.ToTable("novelty_estadonovedad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<NoveltyEstadoscerrado>(entity =>
            {
                entity.ToTable("novelty_estadoscerrados");

                entity.HasIndex(e => e.EstadoNovedadId, "novelty_estadoscerrados_estado_novedad_id_3d00dfa8");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoNovedadId).HasColumnName("estado_novedad_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.EstadoNovedad)
                    .WithMany(p => p.NoveltyEstadoscerrados)
                    .HasForeignKey(d => d.EstadoNovedadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_estadoscerra_estado_novedad_id_3d00dfa8_fk_novelty_e");
            });

            modelBuilder.Entity<NoveltyMessage>(entity =>
            {
                entity.ToTable("novelty_message");

                entity.HasIndex(e => e.RegistroNovedadId, "novelty_message_registro_novedad_id_529ebc61");

                entity.HasIndex(e => e.TransmitterId, "novelty_message_transmitter_id_7f24c901");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .HasColumnName("image");

                entity.Property(e => e.RegistroNovedadId).HasColumnName("registro_novedad_id");

                entity.Property(e => e.TransmitterId).HasColumnName("transmitter_id");

                entity.HasOne(d => d.RegistroNovedad)
                    .WithMany(p => p.NoveltyMessages)
                    .HasForeignKey(d => d.RegistroNovedadId)
                    .HasConstraintName("novelty_message_registro_novedad_id_529ebc61_fk_novelty_r");

                entity.HasOne(d => d.Transmitter)
                    .WithMany(p => p.NoveltyMessages)
                    .HasForeignKey(d => d.TransmitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_message_transmitter_id_7f24c901_fk_auth_user_id");
            });

            modelBuilder.Entity<NoveltyNovedad>(entity =>
            {
                entity.ToTable("novelty_novedad");

                entity.HasIndex(e => e.AreaId, "novelty_novedad_area_id_e90e4441");

                entity.HasIndex(e => e.SubCategoriaId, "novelty_novedad_subCategoria_id_cb1fd471");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.SubCategoriaId).HasColumnName("sub_categoria_id");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.NoveltyNovedads)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("novelty_novedad_area_id_e90e4441_fk_general_area_id");

                entity.HasOne(d => d.SubCategoria)
                    .WithMany(p => p.NoveltyNovedads)
                    .HasForeignKey(d => d.SubCategoriaId)
                    .HasConstraintName("novelty_novedad_sub_categoria_id_d293bf06_fk_novelty_s");
            });

            modelBuilder.Entity<NoveltyNovedadestadoservicio>(entity =>
            {
                entity.ToTable("novelty_novedadestadoservicio");

                entity.HasIndex(e => e.EstadoServicioId, "novelty_novedadestadoservicio_estado_servicio_id_e2dc9a2d");

                entity.HasIndex(e => e.NovedadId, "novelty_novedadestadoservicio_novedad_id_ec73c351");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoServicioId).HasColumnName("estado_servicio_id");

                entity.Property(e => e.NovedadId).HasColumnName("novedad_id");

                entity.HasOne(d => d.EstadoServicio)
                    .WithMany(p => p.NoveltyNovedadestadoservicios)
                    .HasForeignKey(d => d.EstadoServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_novedadestad_estado_servicio_id_e2dc9a2d_fk_servicios");

                entity.HasOne(d => d.Novedad)
                    .WithMany(p => p.NoveltyNovedadestadoservicios)
                    .HasForeignKey(d => d.NovedadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_novedadestad_novedad_id_ec73c351_fk_novelty_n");
            });

            modelBuilder.Entity<NoveltyRegistronovedad>(entity =>
            {
                entity.ToTable("novelty_registronovedad");

                entity.HasIndex(e => e.ConductorId, "novelty_registronovedad_conductor_id_7f51822c");

                entity.HasIndex(e => e.EstadoCerradoId, "novelty_registronovedad_estado_cerrado_id_afd56a8f");

                entity.HasIndex(e => e.EstadoLeidoId, "novelty_registronovedad_estado_leido_id_31f938cd");

                entity.HasIndex(e => e.EstadoNovedadId, "novelty_registronovedad_estado_novedad_id_d4100b76");

                entity.HasIndex(e => e.NovedadId, "novelty_registronovedad_novedad_id_e2ee43d7");

                entity.HasIndex(e => e.OperarioId, "novelty_registronovedad_operario_id_87603d1c");

                entity.HasIndex(e => e.ServicioId, "novelty_registronovedad_servicio_id_d81fe5e6");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConductorId).HasColumnName("conductor_id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EstadoCerradoId).HasColumnName("estado_cerrado_id");

                entity.Property(e => e.EstadoLeidoApp).HasColumnName("estado_leido_app");

                entity.Property(e => e.EstadoLeidoId).HasColumnName("estado_leido_id");

                entity.Property(e => e.EstadoNovedadId).HasColumnName("estado_novedad_id");

                entity.Property(e => e.NovedadId).HasColumnName("novedad_id");

                entity.Property(e => e.OperarioId).HasColumnName("operario_id");

                entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

                entity.HasOne(d => d.Conductor)
                    .WithMany(p => p.NoveltyRegistronovedadConductors)
                    .HasForeignKey(d => d.ConductorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_registronovedad_conductor_id_7f51822c_fk_auth_user_id");

                entity.HasOne(d => d.EstadoCerrado)
                    .WithMany(p => p.NoveltyRegistronovedads)
                    .HasForeignKey(d => d.EstadoCerradoId)
                    .HasConstraintName("novelty_registronove_estado_cerrado_id_afd56a8f_fk_novelty_e");

                entity.HasOne(d => d.EstadoLeido)
                    .WithMany(p => p.NoveltyRegistronovedads)
                    .HasForeignKey(d => d.EstadoLeidoId)
                    .HasConstraintName("novelty_registronove_estado_leido_id_31f938cd_fk_novelty_e");

                entity.HasOne(d => d.EstadoNovedad)
                    .WithMany(p => p.NoveltyRegistronovedads)
                    .HasForeignKey(d => d.EstadoNovedadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_registronove_estado_novedad_id_d4100b76_fk_novelty_e");

                entity.HasOne(d => d.Novedad)
                    .WithMany(p => p.NoveltyRegistronovedads)
                    .HasForeignKey(d => d.NovedadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_registronove_novedad_id_e2ee43d7_fk_novelty_n");

                entity.HasOne(d => d.Operario)
                    .WithMany(p => p.NoveltyRegistronovedadOperarios)
                    .HasForeignKey(d => d.OperarioId)
                    .HasConstraintName("novelty_registronovedad_operario_id_87603d1c_fk_auth_user_id");

                entity.HasOne(d => d.Servicio)
                    .WithMany(p => p.NoveltyRegistronovedads)
                    .HasForeignKey(d => d.ServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("novelty_registronove_servicio_id_d81fe5e6_fk_servicios");
            });

            modelBuilder.Entity<NoveltySubcategorium>(entity =>
            {
                entity.ToTable("novelty_subcategoria");

                entity.HasIndex(e => e.CategoriaId, "novelty_subcategoria_categoria_id_b9b32e31");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoriaId).HasColumnName("categoria_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.NoveltySubcategoria)
                    .HasForeignKey(d => d.CategoriaId)
                    .HasConstraintName("novelty_subcategoria_categoria_id_b9b32e31_fk_novelty_c");
            });

            modelBuilder.Entity<PasajerosCategoriapasajero>(entity =>
            {
                entity.ToTable("pasajeros_categoriapasajero");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<PasajerosEstadopasajero>(entity =>
            {
                entity.ToTable("pasajeros_estadopasajero");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<PasajerosOrigenpasajero>(entity =>
            {
                entity.ToTable("pasajeros_origenpasajero");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<PasajerosPasajero>(entity =>
            {
                entity.ToTable("pasajeros_pasajero");

                entity.HasIndex(e => e.CategoriaPasajeroId, "pasajeros_pasajero_categoria_Pasajero_id_c1fe81e0");

                entity.HasIndex(e => e.ClienteId, "pasajeros_pasajero_cliente_id_8e8a191c");

                entity.HasIndex(e => e.EstadoId, "pasajeros_pasajero_estado_id_8b9a28ce");

                entity.HasIndex(e => e.MedioId, "pasajeros_pasajero_medio_id_d2951a5a");

                entity.HasIndex(e => e.NumeroDocumento, "pasajeros_pasajero_numero_documento_728cdaad_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.NumeroDocumento, "pasajeros_pasajero_numero_documento_key")
                    .IsUnique();

                entity.HasIndex(e => e.TipoDiscapacidadId, "pasajeros_pasajero_tipoDiscapacidad_id_960c421c");

                entity.HasIndex(e => e.TipoDocumentoId, "pasajeros_pasajero_tipoDocumento_id_6141d8d1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoriaPasajeroId).HasColumnName("categoria_Pasajero_id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Firma)
                    .HasMaxLength(100)
                    .HasColumnName("firma");

                entity.Property(e => e.Lote)
                    .HasMaxLength(100)
                    .HasColumnName("lote");

                entity.Property(e => e.MedioId).HasColumnName("medio_id");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(50)
                    .HasColumnName("numero_documento");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .HasColumnName("observaciones");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .HasColumnName("primer_apellido");

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(50)
                    .HasColumnName("primer_nombre");

                entity.Property(e => e.TelefonoCelular1)
                    .HasMaxLength(10)
                    .HasColumnName("telefono_Celular1");

                entity.Property(e => e.TelefonoCelular2)
                    .HasMaxLength(10)
                    .HasColumnName("telefono_Celular2");

                entity.Property(e => e.TipoDiscapacidadId).HasColumnName("tipoDiscapacidad_id");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipoDocumento_id");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .HasColumnName("usuario");

                entity.Property(e => e.Whatsapp)
                    .HasMaxLength(10)
                    .HasColumnName("whatsapp");

                entity.HasOne(d => d.CategoriaPasajero)
                    .WithMany(p => p.PasajerosPasajeros)
                    .HasForeignKey(d => d.CategoriaPasajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_pasajero_categoria_Pasajero_i_c1fe81e0_fk_pasajeros");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.PasajerosPasajeros)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("pasajeros_pasajero_cliente_id_8e8a191c_fk_clientes_cliente_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.PasajerosPasajeros)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_pasajero_estado_id_8b9a28ce_fk_pasajeros");

                entity.HasOne(d => d.Medio)
                    .WithMany(p => p.PasajerosPasajeros)
                    .HasForeignKey(d => d.MedioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_pasajero_medio_id_d2951a5a_fk_mediosApo");

                entity.HasOne(d => d.TipoDiscapacidad)
                    .WithMany(p => p.PasajerosPasajeros)
                    .HasForeignKey(d => d.TipoDiscapacidadId)
                    .HasConstraintName("pasajeros_pasajero_tipoDiscapacidad_id_960c421c_fk_pasajeros");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.PasajerosPasajeros)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_pasajero_tipoDocumento_id_6141d8d1_fk_usuarios_");
            });

            modelBuilder.Entity<PasajerosPasajeroVehiculo>(entity =>
            {
                entity.ToTable("pasajeros_pasajero_vehiculo");

                entity.HasIndex(e => new { e.PasajeroId, e.TipovehicleId }, "pasajeros_pasajero_vehic_pasajero_id_tipovehicle__87767bbd_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.PasajeroId, "pasajeros_pasajero_vehiculo_pasajero_id_abc3b340");

                entity.HasIndex(e => e.TipovehicleId, "pasajeros_pasajero_vehiculo_tipovehicle_id_50fa7b85");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PasajeroId).HasColumnName("pasajero_id");

                entity.Property(e => e.TipovehicleId).HasColumnName("tipovehicle_id");

                entity.HasOne(d => d.Pasajero)
                    .WithMany(p => p.PasajerosPasajeroVehiculos)
                    .HasForeignKey(d => d.PasajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_pasajero_v_pasajero_id_abc3b340_fk_pasajeros");

                entity.HasOne(d => d.Tipovehicle)
                    .WithMany(p => p.PasajerosPasajeroVehiculos)
                    .HasForeignKey(d => d.TipovehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_pasajero_v_tipovehicle_id_50fa7b85_fk_vehicles_");
            });

            modelBuilder.Entity<PasajerosPasajerolog>(entity =>
            {
                entity.ToTable("pasajeros_pasajerolog");

                entity.HasIndex(e => e.PasajeroId, "pasajeros_pasajerolog_pasajero_id_7124b493");

                entity.HasIndex(e => e.UsuarioId, "pasajeros_pasajerolog_usuario_id_a2f692bd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accion)
                    .HasMaxLength(50)
                    .HasColumnName("accion");

                entity.Property(e => e.CampoModificado)
                    .HasMaxLength(800)
                    .HasColumnName("campo_modificado");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.PasajeroId).HasColumnName("pasajero_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Pasajero)
                    .WithMany(p => p.PasajerosPasajerologs)
                    .HasForeignKey(d => d.PasajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_pasajerolo_pasajero_id_7124b493_fk_pasajeros");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PasajerosPasajerologs)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("pasajeros_pasajerolog_usuario_id_a2f692bd_fk_auth_user_id");
            });

            modelBuilder.Entity<PasajerosTipodiscapacidad>(entity =>
            {
                entity.ToTable("pasajeros_tipodiscapacidad");

                entity.HasIndex(e => e.EstadoId, "pasajeros_tipodiscapacidad_estado_id_b1ac6814");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.PasajerosTipodiscapacidads)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pasajeros_tipodiscap_estado_id_b1ac6814_fk_pasajeros");
            });

            modelBuilder.Entity<ProcedimientosEstado>(entity =>
            {
                entity.ToTable("procedimientos_estado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ProcedimientosProcedimiento>(entity =>
            {
                entity.ToTable("procedimientos_procedimiento");

                entity.HasIndex(e => e.EstadoId, "procedimientos_procedimiento_estado_id_167851b7");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ProcedimientosProcedimientos)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("procedimientos_proce_estado_id_167851b7_fk_procedimi");
            });

            modelBuilder.Entity<ServiciosEstadoservicio>(entity =>
            {
                entity.ToTable("servicios_estadoservicio");

                entity.HasIndex(e => e.EstadoId, "servicios_estadoservicio_estado_id_1a93bd7f");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.ServiciosEstadoservicios)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_estadoserv_estado_id_1a93bd7f_fk_procedimi");
            });

            modelBuilder.Entity<ServiciosEventosLog>(entity =>
            {
                entity.ToTable("servicios_eventos_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ServiciosHistorycertificado>(entity =>
            {
                entity.ToTable("servicios_historycertificado");

                entity.HasIndex(e => e.UserId, "servicios_historycertificado_user_id_b2460a78");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .HasColumnName("documento");

                entity.Property(e => e.Evento)
                    .HasMaxLength(50)
                    .HasColumnName("evento");

                entity.Property(e => e.FechaEvento).HasColumnName("fecha_evento");

                entity.Property(e => e.FechaFinal).HasColumnName("fecha_final");

                entity.Property(e => e.FechaInicial).HasColumnName("fecha_inicial");

                entity.Property(e => e.Solicitud)
                    .HasMaxLength(50)
                    .HasColumnName("solicitud");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiciosHistorycertificados)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_historycertificado_user_id_b2460a78_fk_auth_user_id");
            });

            modelBuilder.Entity<ServiciosLogService>(entity =>
            {
                entity.ToTable("servicios_log_service");

                entity.HasIndex(e => e.NovedadId, "servicios_log_service_novedad_id_001ff003");

                entity.HasIndex(e => e.ServicioId, "servicios_log_service_servicio_id_1e73dd72");

                entity.HasIndex(e => e.UsuarioId, "servicios_log_service_usuario_id_65283315");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcompañanteServicio)
                    .HasMaxLength(500)
                    .HasColumnName("acompañanteServicio");

                entity.Property(e => e.AutorizacionServicio)
                    .HasMaxLength(500)
                    .HasColumnName("autorizacionServicio");

                entity.Property(e => e.BarrioDestinoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("barrioDestinoServicio");

                entity.Property(e => e.BarrioOrigenServicio)
                    .HasMaxLength(500)
                    .HasColumnName("barrioOrigenServicio");

                entity.Property(e => e.CiudadDestinoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("ciudadDestinoServicio");

                entity.Property(e => e.CiudadOrigenServicio)
                    .HasMaxLength(500)
                    .HasColumnName("ciudadOrigenServicio");

                entity.Property(e => e.ClienteServicio)
                    .HasMaxLength(500)
                    .HasColumnName("clienteServicio");

                entity.Property(e => e.CodigoServicioServicio)
                    .HasMaxLength(500)
                    .HasColumnName("codigoServicioServicio");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .HasColumnName("comentario");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.DestinoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("destinoServicio");

                entity.Property(e => e.DetalleServicio)
                    .HasMaxLength(500)
                    .HasColumnName("detalleServicio");

                entity.Property(e => e.DireccionDestinoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("direccionDestinoServicio");

                entity.Property(e => e.DireccionOrigenServicio)
                    .HasMaxLength(500)
                    .HasColumnName("direccionOrigenServicio");

                entity.Property(e => e.DocumentoAcompañanteServicio)
                    .HasMaxLength(500)
                    .HasColumnName("documentoAcompañanteServicio");

                entity.Property(e => e.DocumentoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("documentoServicio");

                entity.Property(e => e.EstadoServicioServicio)
                    .HasMaxLength(500)
                    .HasColumnName("estadoServicioServicio");

                entity.Property(e => e.FechaRecogidaServicio)
                    .HasMaxLength(500)
                    .HasColumnName("fechaRecogidaServicio");

                entity.Property(e => e.FechaServicioServicio)
                    .HasMaxLength(500)
                    .HasColumnName("fechaServicioServicio");

                entity.Property(e => e.HoraRecogidaServicio)
                    .HasMaxLength(500)
                    .HasColumnName("horaRecogidaServicio");

                entity.Property(e => e.HoraServicioServicio)
                    .HasMaxLength(500)
                    .HasColumnName("horaServicioServicio");

                entity.Property(e => e.IdServicio)
                    .HasMaxLength(500)
                    .HasColumnName("idServicio");

                entity.Property(e => e.IdentificaciónServicio)
                    .HasMaxLength(500)
                    .HasColumnName("identificaciónServicio");

                entity.Property(e => e.LocalidadDestinoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("localidadDestinoServicio");

                entity.Property(e => e.LocalidadOrigenServicio)
                    .HasMaxLength(500)
                    .HasColumnName("localidadOrigenServicio");

                entity.Property(e => e.MedioApoyoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("medioApoyoServicio");

                entity.Property(e => e.NovedadId).HasColumnName("novedad_id");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .HasColumnName("observaciones");

                entity.Property(e => e.OrigenServicio)
                    .HasMaxLength(500)
                    .HasColumnName("origenServicio");

                entity.Property(e => e.RegionalDestinoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("regionalDestinoServicio");

                entity.Property(e => e.RegionalOrigenServicio)
                    .HasMaxLength(500)
                    .HasColumnName("regionalOrigenServicio");

                entity.Property(e => e.SeguimientoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("seguimientoServicio");

                entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

                entity.Property(e => e.SolicitudServicio)
                    .HasMaxLength(500)
                    .HasColumnName("solicitudServicio");

                entity.Property(e => e.Telefono1Servicio)
                    .HasMaxLength(500)
                    .HasColumnName("telefono1Servicio");

                entity.Property(e => e.Telefono2Servicio)
                    .HasMaxLength(500)
                    .HasColumnName("telefono2Servicio");

                entity.Property(e => e.TelefonoAcompañanteServicio)
                    .HasMaxLength(500)
                    .HasColumnName("telefonoAcompañanteServicio");

                entity.Property(e => e.TipoAtencionServicio)
                    .HasMaxLength(500)
                    .HasColumnName("tipoAtencionServicio");

                entity.Property(e => e.TipoAutorizacionServicio)
                    .HasMaxLength(500)
                    .HasColumnName("tipoAutorizacionServicio");

                entity.Property(e => e.TipoProcedimientoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("tipoProcedimientoServicio");

                entity.Property(e => e.TipoRutaServicio)
                    .HasMaxLength(500)
                    .HasColumnName("tipoRutaServicio");

                entity.Property(e => e.TipoServicioServicio)
                    .HasMaxLength(500)
                    .HasColumnName("tipo_servicioServicio");

                entity.Property(e => e.TipoTrayectoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("tipoTrayectoServicio");

                entity.Property(e => e.UpzDestinoServicio)
                    .HasMaxLength(500)
                    .HasColumnName("upzDestinoServicio");

                entity.Property(e => e.UpzOrigenServicio)
                    .HasMaxLength(500)
                    .HasColumnName("upzOrigenServicio");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.Property(e => e.UsuarioServicio)
                    .HasMaxLength(500)
                    .HasColumnName("usuarioServicio");

                entity.Property(e => e.WhatsappServicio)
                    .HasMaxLength(500)
                    .HasColumnName("whatsappServicio");

                entity.HasOne(d => d.Novedad)
                    .WithMany(p => p.ServiciosLogServices)
                    .HasForeignKey(d => d.NovedadId)
                    .HasConstraintName("servicios_log_servic_novedad_id_001ff003_fk_novedades");

                entity.HasOne(d => d.Servicio)
                    .WithMany(p => p.ServiciosLogServices)
                    .HasForeignKey(d => d.ServicioId)
                    .HasConstraintName("servicios_log_servic_servicio_id_1e73dd72_fk_servicios");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ServiciosLogServices)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("servicios_log_service_usuario_id_65283315_fk_auth_user_id");
            });

            modelBuilder.Entity<ServiciosLogServicio>(entity =>
            {
                entity.ToTable("servicios_log_servicios");

                entity.HasIndex(e => e.EventoId, "servicios_log_servicios_evento_id_bf23c74a");

                entity.HasIndex(e => e.ServicioId, "servicios_log_servicios_servicio_id_98942983");

                entity.HasIndex(e => e.UsuarioId, "servicios_log_servicios_usuario_id_4b90cb6a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datos).HasColumnName("datos");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasColumnName("estado");

                entity.Property(e => e.EventoId).HasColumnName("evento_id");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Evento)
                    .WithMany(p => p.ServiciosLogServicios)
                    .HasForeignKey(d => d.EventoId)
                    .HasConstraintName("servicios_log_servic_evento_id_bf23c74a_fk_servicios");

                entity.HasOne(d => d.Servicio)
                    .WithMany(p => p.ServiciosLogServicios)
                    .HasForeignKey(d => d.ServicioId)
                    .HasConstraintName("servicios_log_servic_servicio_id_98942983_fk_servicios");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ServiciosLogServicios)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("servicios_log_servicios_usuario_id_4b90cb6a_fk_auth_user_id");
            });

            modelBuilder.Entity<ServiciosLote>(entity =>
            {
                entity.ToTable("servicios_lote");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaLote).HasColumnName("fecha_lote");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(500)
                    .HasColumnName("nombre_Usuario");

                entity.Property(e => e.NumeroLote)
                    .HasMaxLength(100)
                    .HasColumnName("numero_lote");
            });

            modelBuilder.Entity<ServiciosSeguimiento>(entity =>
            {
                entity.ToTable("servicios_seguimiento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ServiciosServicio>(entity =>
            {
                entity.ToTable("servicios_servicio");

                entity.HasIndex(e => e.CodigoServicioId, "servicios_servicio_codigoServicio_id_51776248");

                entity.HasIndex(e => e.ConductorId, "servicios_servicio_conductor_id_a732fe84");

                entity.HasIndex(e => e.DestinoId, "servicios_servicio_destino_id_fc4dd44a");

                entity.HasIndex(e => e.DocumentoAcompañanteId, "servicios_servicio_documentoAcompañante_id_da920211");

                entity.HasIndex(e => e.EstadoServicioId, "servicios_servicio_estadoServicio_id_37e39c97");

                entity.HasIndex(e => e.NovedadId, "servicios_servicio_novedad_id_8413da2b");

                entity.HasIndex(e => e.OrigenId, "servicios_servicio_origen_id_485e0e4a");

                entity.HasIndex(e => e.PasajeroId, "servicios_servicio_pasajero_id_627c437e");

                entity.HasIndex(e => e.SeguimientoId, "servicios_servicio_seguimiento_id_f008e37a");

                entity.HasIndex(e => e.SolicitudId, "servicios_servicio_solicitud_id_947f7ea8");

                entity.HasIndex(e => e.TipoAtencionId, "servicios_servicio_tipoAtencion_id_ae330385");

                entity.HasIndex(e => e.TipoAutorizacionId, "servicios_servicio_tipoAutorizacion_id_46b28815");

                entity.HasIndex(e => e.TipoProcedimientoId, "servicios_servicio_tipoProcedimiento_id_0d9f264d");

                entity.HasIndex(e => e.TipoRutaId, "servicios_servicio_tipoRuta_id_84a5c61c");

                entity.HasIndex(e => e.TipoTrayectoId, "servicios_servicio_tipoTrayecto_id_381b6f39");

                entity.HasIndex(e => e.TipoServicioId, "servicios_servicio_tipo_servicio_id_287301d5");

                entity.HasIndex(e => e.UsuarioId, "servicios_servicio_usuario_id_47803a39");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.Cierre)
                    .HasMaxLength(50)
                    .HasColumnName("cierre");

                entity.Property(e => e.CodigoServicioId).HasColumnName("codigoServicio_id");

                entity.Property(e => e.Comentario)
                    .HasMaxLength(500)
                    .HasColumnName("comentario");

                entity.Property(e => e.ConductorId).HasColumnName("conductor_id");

                entity.Property(e => e.DateOffline).HasColumnName("date_offline");

                entity.Property(e => e.DestinoId).HasColumnName("destino_id");

                entity.Property(e => e.Detalle).HasColumnName("detalle");

                entity.Property(e => e.DocumentoAcompañanteId).HasColumnName("documentoAcompañante_id");

                entity.Property(e => e.EstadoServicioId).HasColumnName("estadoServicio_id");

                entity.Property(e => e.FechaFinAutorizacion).HasColumnName("fecha_fin_autorizacion");

                entity.Property(e => e.FechaInicioAutorizacion).HasColumnName("fecha_inicio_autorizacion");

                entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");

                entity.Property(e => e.FechaServicio).HasColumnName("fechaServicio");

                entity.Property(e => e.Firma)
                    .HasMaxLength(100)
                    .HasColumnName("firma");

                entity.Property(e => e.HoraRecogida).HasColumnName("horaRecogida");

                entity.Property(e => e.IsAssingMasive).HasColumnName("is_assing_masive");

                entity.Property(e => e.LatitudeFinish)
                    .HasMaxLength(30)
                    .HasColumnName("latitudeFinish");

                entity.Property(e => e.LatitudeStart)
                    .HasMaxLength(30)
                    .HasColumnName("latitudeStart");

                entity.Property(e => e.LongitudeFinish)
                    .HasMaxLength(30)
                    .HasColumnName("longitudeFinish");

                entity.Property(e => e.LongitudeStart)
                    .HasMaxLength(30)
                    .HasColumnName("longitudeStart");

                entity.Property(e => e.Lote)
                    .HasMaxLength(500)
                    .HasColumnName("lote");

                entity.Property(e => e.Modified).HasColumnName("modified");

                entity.Property(e => e.NAutorizacion)
                    .HasMaxLength(500)
                    .HasColumnName("nAutorizacion");

                entity.Property(e => e.NDocumentoAcompañante)
                    .HasMaxLength(500)
                    .HasColumnName("nDocumentoAcompañante");

                entity.Property(e => e.NombreAcompañante)
                    .HasMaxLength(500)
                    .HasColumnName("nombreAcompañante");

                entity.Property(e => e.NovedadId).HasColumnName("novedad_id");

                entity.Property(e => e.ObservacionesOperador)
                    .HasMaxLength(500)
                    .HasColumnName("observacionesOperador");

                entity.Property(e => e.ObservacionesServicio).HasColumnName("observacionesServicio");

                entity.Property(e => e.OrigenId).HasColumnName("origen_id");

                entity.Property(e => e.PasajeroId).HasColumnName("pasajero_id");

                entity.Property(e => e.PreAutorizacion)
                    .HasMaxLength(500)
                    .HasColumnName("pre_autorizacion");

                entity.Property(e => e.SeguimientoId).HasColumnName("seguimiento_id");

                entity.Property(e => e.SolicitudId).HasColumnName("solicitud_id");

                entity.Property(e => e.TelefonoAcompañante)
                    .HasMaxLength(500)
                    .HasColumnName("telefonoAcompañante");

                entity.Property(e => e.TimeInicio).HasColumnName("timeInicio");

                entity.Property(e => e.TipoAtencionId).HasColumnName("tipoAtencion_id");

                entity.Property(e => e.TipoAutorizacionId).HasColumnName("tipoAutorizacion_id");

                entity.Property(e => e.TipoProcedimientoId).HasColumnName("tipoProcedimiento_id");

                entity.Property(e => e.TipoRutaId).HasColumnName("tipoRuta_id");

                entity.Property(e => e.TipoServicioId).HasColumnName("tipo_servicio_id");

                entity.Property(e => e.TipoTrayectoId).HasColumnName("tipoTrayecto_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.CodigoServicio)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.CodigoServicioId)
                    .HasConstraintName("servicios_servicio_codigoServicio_id_51776248_fk_clientes_");

                entity.HasOne(d => d.Conductor)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.ConductorId)
                    .HasConstraintName("servicios_servicio_conductor_id_a732fe84_fk_conductor");

                entity.HasOne(d => d.Destino)
                    .WithMany(p => p.ServiciosServicioDestinos)
                    .HasForeignKey(d => d.DestinoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_destino_id_fc4dd44a_fk_destinos_destino_id");

                entity.HasOne(d => d.DocumentoAcompañante)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.DocumentoAcompañanteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_documentoAcompañante_da920211_fk_usuarios_");

                entity.HasOne(d => d.EstadoServicio)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.EstadoServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_estadoServicio_id_37e39c97_fk_servicios");

                entity.HasOne(d => d.Novedad)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.NovedadId)
                    .HasConstraintName("servicios_servicio_novedad_id_8413da2b_fk_novedades_novedad_id");

                entity.HasOne(d => d.Origen)
                    .WithMany(p => p.ServiciosServicioOrigens)
                    .HasForeignKey(d => d.OrigenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_origen_id_485e0e4a_fk_destinos_destino_id");

                entity.HasOne(d => d.Pasajero)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.PasajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_pasajero_id_627c437e_fk_pasajeros");

                entity.HasOne(d => d.Seguimiento)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.SeguimientoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_seguimiento_id_f008e37a_fk_servicios");

                entity.HasOne(d => d.Solicitud)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.SolicitudId)
                    .HasConstraintName("servicios_servicio_solicitud_id_947f7ea8_fk_servicios");

                entity.HasOne(d => d.TipoAtencion)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.TipoAtencionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_tipoAtencion_id_ae330385_fk_Atencione");

                entity.HasOne(d => d.TipoAutorizacion)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.TipoAutorizacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_tipoAutorizacion_id_46b28815_fk_servicios");

                entity.HasOne(d => d.TipoProcedimiento)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.TipoProcedimientoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_tipoProcedimiento_id_0d9f264d_fk_procedimi");

                entity.HasOne(d => d.TipoRuta)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.TipoRutaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_tipoRuta_id_84a5c61c_fk_servicios");

                entity.HasOne(d => d.TipoServicio)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.TipoServicioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_tipo_servicio_id_287301d5_fk_servicios");

                entity.HasOne(d => d.TipoTrayecto)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.TipoTrayectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_servicio_tipoTrayecto_id_381b6f39_fk_trayectos");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ServiciosServicios)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("servicios_servicio_usuario_id_47803a39_fk_auth_user_id");
            });

            modelBuilder.Entity<ServiciosServicioreasignado>(entity =>
            {
                entity.ToTable("servicios_servicioreasignado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Datos).HasColumnName("datos");
            });

            modelBuilder.Entity<ServiciosSolicitud>(entity =>
            {
                entity.ToTable("servicios_solicitud");

                entity.HasIndex(e => e.ClienteId, "servicios_solicitud_cliente_id_b6beefe8");

                entity.HasIndex(e => e.PasajeroId, "servicios_solicitud_pasajero_id_cf552340");

                entity.HasIndex(e => e.TipoServicioId, "servicios_solicitud_tipo_servicio_id_0de8ea41");

                entity.HasIndex(e => e.UsuarioId, "servicios_solicitud_usuario_id_3d19df5f");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Autorizados).HasColumnName("autorizados");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasColumnName("codigo");

                entity.Property(e => e.Created).HasColumnName("created");

                entity.Property(e => e.FechaFinAutorizacion).HasColumnName("fecha_fin_autorizacion");

                entity.Property(e => e.FechaInicioAutorizacion).HasColumnName("fecha_inicio_autorizacion");

                entity.Property(e => e.Modifised).HasColumnName("modifised");

                entity.Property(e => e.ObservacionesSolicitud).HasColumnName("observacionesSolicitud");

                entity.Property(e => e.PasajeroId).HasColumnName("pasajero_id");

                entity.Property(e => e.Prestados).HasColumnName("prestados");

                entity.Property(e => e.TipoServicioId).HasColumnName("tipo_servicio_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ServiciosSolicituds)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("servicios_solicitud_cliente_id_b6beefe8_fk_clientes_cliente_id");

                entity.HasOne(d => d.Pasajero)
                    .WithMany(p => p.ServiciosSolicituds)
                    .HasForeignKey(d => d.PasajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("servicios_solicitud_pasajero_id_cf552340_fk_pasajeros");

                entity.HasOne(d => d.TipoServicio)
                    .WithMany(p => p.ServiciosSolicituds)
                    .HasForeignKey(d => d.TipoServicioId)
                    .HasConstraintName("servicios_solicitud_tipo_servicio_id_0de8ea41_fk_servicios");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ServiciosSolicituds)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("servicios_solicitud_usuario_id_3d19df5f_fk_auth_user_id");
            });

            modelBuilder.Entity<ServiciosTipoautorizacion>(entity =>
            {
                entity.ToTable("servicios_tipoautorizacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ServiciosTiporutum>(entity =>
            {
                entity.ToTable("servicios_tiporuta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<ServiciosTiposervicio>(entity =>
            {
                entity.ToTable("servicios_tiposervicio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<SolicitudesComentarioSolicitud>(entity =>
            {
                entity.ToTable("solicitudes_comentario_solicitud");

                entity.HasIndex(e => e.SolicitudId, "solicitudes_comentario_solicitud_solicitud_id_172c6745");

                entity.HasIndex(e => e.UsuarioId, "solicitudes_comentario_solicitud_usuario_id_58a93e10");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcpion)
                    .HasMaxLength(500)
                    .HasColumnName("descripcpion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(500)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaComentario).HasColumnName("fecha_comentario");

                entity.Property(e => e.SolicitudId).HasColumnName("solicitud_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Solicitud)
                    .WithMany(p => p.SolicitudesComentarioSolicituds)
                    .HasForeignKey(d => d.SolicitudId)
                    .HasConstraintName("solicitudes_comentar_solicitud_id_172c6745_fk_solicitud");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.SolicitudesComentarioSolicituds)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("solicitudes_comentar_usuario_id_58a93e10_fk_auth_user");
            });

            modelBuilder.Entity<SolicitudesEstadoSolicitud>(entity =>
            {
                entity.ToTable("solicitudes_estado_solicitud");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<SolicitudesLote>(entity =>
            {
                entity.ToTable("solicitudes_lote");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaLote).HasColumnName("fecha_lote");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_Usuario");

                entity.Property(e => e.NumeroLote)
                    .HasMaxLength(100)
                    .HasColumnName("numero_lote");
            });

            modelBuilder.Entity<SolicitudesPrestacion>(entity =>
            {
                entity.ToTable("solicitudes_prestacion");

                entity.HasIndex(e => e.ClienteId, "solicitudes_prestacion_cliente_id_4708edee");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('solicitudes_prestaciones_id_seq'::regclass)");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.DestinoNombre)
                    .HasMaxLength(100)
                    .HasColumnName("destino_nombre");

                entity.Property(e => e.Estado)
                    .HasMaxLength(100)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaFinAutorizacion).HasColumnName("fecha_fin_autorizacion");

                entity.Property(e => e.FechaInicioAutorizacion).HasColumnName("fecha_inicio_autorizacion");

                entity.Property(e => e.FechaServicio).HasColumnName("fecha_Servicio");

                entity.Property(e => e.Lote)
                    .HasMaxLength(100)
                    .HasColumnName("lote");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(100)
                    .HasColumnName("nombre_Usuario");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(100)
                    .HasColumnName("numero_Autorizacion");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(100)
                    .HasColumnName("numero_Documento");

                entity.Property(e => e.ObservacionesServicio).HasColumnName("observacionesServicio");

                entity.Property(e => e.TipoDocumento)
                    .HasMaxLength(100)
                    .HasColumnName("tipo_Documento");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.SolicitudesPrestacions)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("solicitudes_prestaci_cliente_id_4708edee_fk_clientes_");
            });

            modelBuilder.Entity<SolicitudesSolicitud>(entity =>
            {
                entity.ToTable("solicitudes_solicitud");

                entity.HasIndex(e => e.EstadoId, "solicitudes_solicitud_estado_id_368a6767");

                entity.HasIndex(e => e.MedioApoyoId, "solicitudes_solicitud_medio_Apoyo_id_56e867d6");

                entity.HasIndex(e => e.TeleOperadorId, "solicitudes_solicitud_tele_Operador_id_c82af62b");

                entity.HasIndex(e => e.TipoDocumentoId, "solicitudes_solicitud_tipo_Documento_id_e34f1d36");

                entity.HasIndex(e => e.TipoProcedimientoId, "solicitudes_solicitud_tipo_procedimiento_id_0eb974df");

                entity.HasIndex(e => e.TipoSolicitudId, "solicitudes_solicitud_tipo_solicitud_id_2dcbf773");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acompañamte).HasColumnName("acompañamte");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(100)
                    .HasColumnName("apellidos");

                entity.Property(e => e.CiudadDestino)
                    .HasMaxLength(100)
                    .HasColumnName("ciudad_Destino");

                entity.Property(e => e.CiudadOrigen)
                    .HasMaxLength(100)
                    .HasColumnName("ciudad_Origen");

                entity.Property(e => e.DireccionDestino)
                    .HasMaxLength(100)
                    .HasColumnName("direccion_Destino");

                entity.Property(e => e.DireccionOrigen)
                    .HasMaxLength(100)
                    .HasColumnName("direccion_Origen");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.FechaActualizacion).HasColumnName("fecha_Actualizacion");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_Registro");

                entity.Property(e => e.FechaServicio).HasColumnName("fecha_Servicio");

                entity.Property(e => e.HoraCita)
                    .HasMaxLength(50)
                    .HasColumnName("hora_Cita");

                entity.Property(e => e.MedioApoyoId).HasColumnName("medio_Apoyo_id");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(100)
                    .HasColumnName("nombres");

                entity.Property(e => e.NumeroAutorizacion)
                    .HasMaxLength(100)
                    .HasColumnName("numero_Autorizacion");

                entity.Property(e => e.NumeroDocumento)
                    .HasMaxLength(100)
                    .HasColumnName("numero_Documento");

                entity.Property(e => e.NumeroPreAutorizacion)
                    .HasMaxLength(100)
                    .HasColumnName("numero_Pre_Autorizacion");

                entity.Property(e => e.NumeroServicio)
                    .HasMaxLength(100)
                    .HasColumnName("numero_Servicio");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .HasColumnName("observaciones");

                entity.Property(e => e.TeleOperadorId).HasColumnName("tele_Operador_id");

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(100)
                    .HasColumnName("telefono_1");

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(100)
                    .HasColumnName("telefono_2");

                entity.Property(e => e.TipoDocumentoId).HasColumnName("tipo_Documento_id");

                entity.Property(e => e.TipoPeticion).HasColumnName("tipo_peticion");

                entity.Property(e => e.TipoProcedimientoId).HasColumnName("tipo_procedimiento_id");

                entity.Property(e => e.TipoSolicitudId).HasColumnName("tipo_solicitud_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.SolicitudesSolicituds)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("solicitudes_solicitu_estado_id_368a6767_fk_solicitud");

                entity.HasOne(d => d.MedioApoyo)
                    .WithMany(p => p.SolicitudesSolicituds)
                    .HasForeignKey(d => d.MedioApoyoId)
                    .HasConstraintName("solicitudes_solicitu_medio_Apoyo_id_56e867d6_fk_mediosApo");

                entity.HasOne(d => d.TeleOperador)
                    .WithMany(p => p.SolicitudesSolicituds)
                    .HasForeignKey(d => d.TeleOperadorId)
                    .HasConstraintName("solicitudes_solicitu_tele_Operador_id_c82af62b_fk_clientes_");

                entity.HasOne(d => d.TipoDocumento)
                    .WithMany(p => p.SolicitudesSolicituds)
                    .HasForeignKey(d => d.TipoDocumentoId)
                    .HasConstraintName("solicitudes_solicitu_tipo_Documento_id_e34f1d36_fk_usuarios_");

                entity.HasOne(d => d.TipoProcedimiento)
                    .WithMany(p => p.SolicitudesSolicituds)
                    .HasForeignKey(d => d.TipoProcedimientoId)
                    .HasConstraintName("solicitudes_solicitu_tipo_procedimiento_i_0eb974df_fk_procedimi");

                entity.HasOne(d => d.TipoSolicitud)
                    .WithMany(p => p.SolicitudesSolicituds)
                    .HasForeignKey(d => d.TipoSolicitudId)
                    .HasConstraintName("solicitudes_solicitu_tipo_solicitud_id_2dcbf773_fk_solicitud");
            });

            modelBuilder.Entity<SolicitudesTipoSolicitud>(entity =>
            {
                entity.ToTable("solicitudes_tipo_solicitud");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TiposServicioEstado>(entity =>
            {
                entity.ToTable("tiposServicio_estado");

                entity.HasIndex(e => e.Nombre, "tiposServicio_estado_nombre_221517c4_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Nombre, "tiposServicio_estado_nombre_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TiposServicioTiposervicio>(entity =>
            {
                entity.ToTable("tiposServicio_tiposervicio");

                entity.HasIndex(e => e.EstadoId, "tiposServicio_tiposervicio_estado_id_efb9bb60");

                entity.HasIndex(e => e.Nombre, "tiposServicio_tiposervicio_nombre_63935a55_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Nombre, "tiposServicio_tiposervicio_nombre_63935a55_uniq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.TiposServicioTiposervicios)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("tiposServicio_tipose_estado_id_efb9bb60_fk_tiposServ");
            });

            modelBuilder.Entity<TrayectosEstadotrayecto>(entity =>
            {
                entity.ToTable("trayectos_estadotrayecto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TrayectosTrayecto>(entity =>
            {
                entity.ToTable("trayectos_trayecto");

                entity.HasIndex(e => e.EstadoId, "trayectos_trayecto_estado_id_4b058f63");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodigoInterno)
                    .HasMaxLength(50)
                    .HasColumnName("codigoInterno");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.TrayectosTrayectos)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("trayectos_trayecto_estado_id_4b058f63_fk_trayectos");
            });

            modelBuilder.Entity<UsuariosAccion>(entity =>
            {
                entity.ToTable("usuarios_accion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<UsuariosAutorizado>(entity =>
            {
                entity.ToTable("usuarios_autorizado");

                entity.HasIndex(e => e.PermisoId, "usuarios_autorizado_permiso_id_3f004664");

                entity.HasIndex(e => e.RolId, "usuarios_autorizado_rol_id_0f70514a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PermisoId).HasColumnName("permiso_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.HasOne(d => d.Permiso)
                    .WithMany(p => p.UsuariosAutorizados)
                    .HasForeignKey(d => d.PermisoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_autorizado_permiso_id_3f004664_fk_usuarios_permiso_id");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.UsuariosAutorizados)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_autorizado_rol_id_0f70514a_fk_auth_group_id");
            });

            modelBuilder.Entity<UsuariosCategoriausuario>(entity =>
            {
                entity.ToTable("usuarios_categoriausuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<UsuariosDispositivo>(entity =>
            {
                entity.ToTable("usuarios_dispositivo");

                entity.HasIndex(e => e.UserId, "usuarios_dispositivo_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OperatingSystem).HasColumnName("operating_system");

                entity.Property(e => e.PushToken)
                    .HasMaxLength(500)
                    .HasColumnName("push_token");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsuariosDispositivo)
                    .HasForeignKey<UsuariosDispositivo>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_dispositivo_user_id_47c62cc5_fk_auth_user_id");
            });

            modelBuilder.Entity<UsuariosEstadousuario>(entity =>
            {
                entity.ToTable("usuarios_estadousuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<UsuariosFuncionalidad>(entity =>
            {
                entity.ToTable("usuarios_funcionalidad");

                entity.HasIndex(e => e.ModuloPrincipalId, "usuarios_funcionalidad_modulo_principal_id_e6ee3acd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ModuloPrincipalId).HasColumnName("modulo_principal_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.HasOne(d => d.ModuloPrincipal)
                    .WithMany(p => p.UsuariosFuncionalidads)
                    .HasForeignKey(d => d.ModuloPrincipalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_funcionalid_modulo_principal_id_e6ee3acd_fk_usuarios_");
            });

            modelBuilder.Entity<UsuariosGenero>(entity =>
            {
                entity.ToTable("usuarios_genero");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<UsuariosModuloprincipal>(entity =>
            {
                entity.ToTable("usuarios_moduloprincipal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<UsuariosPermiso>(entity =>
            {
                entity.ToTable("usuarios_permiso");

                entity.HasIndex(e => e.AccionId, "usuarios_permiso_accion_id_bebbd2ac");

                entity.HasIndex(e => e.FuncionalidadId, "usuarios_permiso_funcionalidad_id_10c06b57");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccionId).HasColumnName("accion_id");

                entity.Property(e => e.FuncionalidadId).HasColumnName("funcionalidad_id");

                entity.HasOne(d => d.Accion)
                    .WithMany(p => p.UsuariosPermisos)
                    .HasForeignKey(d => d.AccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_permiso_accion_id_bebbd2ac_fk_usuarios_accion_id");

                entity.HasOne(d => d.Funcionalidad)
                    .WithMany(p => p.UsuariosPermisos)
                    .HasForeignKey(d => d.FuncionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_permiso_funcionalidad_id_10c06b57_fk_usuarios_");
            });

            modelBuilder.Entity<UsuariosTipodocumento>(entity =>
            {
                entity.ToTable("usuarios_tipodocumento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(5)
                    .HasColumnName("sigla");
            });

            modelBuilder.Entity<UsuariosUserarea>(entity =>
            {
                entity.ToTable("usuarios_userarea");

                entity.HasIndex(e => e.AreaId, "usuarios_userarea_area_id_cafe0443");

                entity.HasIndex(e => e.UserId, "usuarios_userarea_user_id_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.UsuariosUserareas)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_userarea_area_id_cafe0443_fk_general_area_id");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsuariosUserarea)
                    .HasForeignKey<UsuariosUserarea>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_userarea_user_id_29c60127_fk_auth_user_id");
            });

            modelBuilder.Entity<VehiclesConvenio>(entity =>
            {
                entity.ToTable("vehicles_convenio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VehiclesEstadovehicle>(entity =>
            {
                entity.ToTable("vehicles_estadovehicle");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('vehicles_estadovehicles_id_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VehiclesMarcavehicle>(entity =>
            {
                entity.ToTable("vehicles_marcavehicle");

                entity.HasIndex(e => e.EstadoId, "vehicles_marcavehicle_estado_id_12c411e9");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('vehicles_marcavehicles_id_seq'::regclass)");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.VehiclesMarcavehicles)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("vehicles_marcavehicl_estado_id_12c411e9_fk_vehicles_");
            });

            modelBuilder.Entity<VehiclesPicoplaca>(entity =>
            {
                entity.ToTable("vehicles_picoplaca");

                entity.HasIndex(e => e.MunicipioId, "vehicles_picoplaca_municipio_id_a307bd69");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Digito1).HasColumnName("digito_1");

                entity.Property(e => e.Digito2).HasColumnName("digito_2");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.MunicipioId).HasColumnName("municipio_id");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.VehiclesPicoplacas)
                    .HasForeignKey(d => d.MunicipioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicles_picoplaca_municipio_id_a307bd69_fk_general_ciudad_id");
            });

            modelBuilder.Entity<VehiclesPrincipal>(entity =>
            {
                entity.ToTable("vehicles_principal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VehiclesSecundarium>(entity =>
            {
                entity.ToTable("vehicles_secundaria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VehiclesTipovehicle>(entity =>
            {
                entity.ToTable("vehicles_tipovehicle");

                entity.HasIndex(e => e.Completo, "vehicles_tipovehicle_completo_abaf18cf_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Completo, "vehicles_tipovehicle_completo_abaf18cf_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.EstadoId, "vehicles_tipovehicle_estado_id_8680b1ec");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('vehicles_tipovehicles_id_seq'::regclass)");

                entity.Property(e => e.Capacidad)
                    .HasMaxLength(50)
                    .HasColumnName("capacidad");

                entity.Property(e => e.Completo)
                    .HasMaxLength(100)
                    .HasColumnName("completo");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.VehiclesTipovehicles)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("vehicles_tipovehicle_estado_id_8680b1ec_fk_vehicles_");
            });

            modelBuilder.Entity<VehiclesVehicle>(entity =>
            {
                entity.ToTable("vehicles_vehicle");

                entity.HasIndex(e => e.CaracteristicaPrincipal, "vehicles_vehicle_caracteristica_principal_e813426a_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.CaracteristicaPrincipalId, "vehicles_vehicle_caracteristica_principal_id_2b3c6160");

                entity.HasIndex(e => e.CaracteristicaPrincipal, "vehicles_vehicle_caracteristica_principal_key")
                    .IsUnique();

                entity.HasIndex(e => e.CaracteristicaSecundaria, "vehicles_vehicle_caracteristica_secundaria_9d1bbb6a_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.CaracteristicaSecundariaId, "vehicles_vehicle_caracteristica_secundaria_id_d66f658e");

                entity.HasIndex(e => e.CaracteristicaSecundaria, "vehicles_vehicle_caracteristica_secundaria_key")
                    .IsUnique();

                entity.HasIndex(e => e.ConvenioId, "vehicles_vehicle_convenio_id_b973de07");

                entity.HasIndex(e => e.Placa, "vehicles_vehicle_placa_8b49f643_like")
                    .HasOperators(new[] { "varchar_pattern_ops" });

                entity.HasIndex(e => e.Placa, "vehicles_vehicle_placa_key")
                    .IsUnique();

                entity.HasIndex(e => e.EstadoId, "vehicles_vehicles_estado_id_c550dc29");

                entity.HasIndex(e => e.MarcaId, "vehicles_vehicles_marca_id_6c39ae03");

                entity.HasIndex(e => e.TipoId, "vehicles_vehicles_tipo_id_72539f14");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('vehicles_vehicles_id_seq'::regclass)");

                entity.Property(e => e.CaracteristicaPrincipal)
                    .HasMaxLength(100)
                    .HasColumnName("caracteristica_principal");

                entity.Property(e => e.CaracteristicaPrincipalId).HasColumnName("caracteristica_principal_id");

                entity.Property(e => e.CaracteristicaSecundaria)
                    .HasMaxLength(100)
                    .HasColumnName("caracteristica_secundaria");

                entity.Property(e => e.CaracteristicaSecundariaId).HasColumnName("caracteristica_secundaria_id");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(100)
                    .HasColumnName("codigo");

                entity.Property(e => e.CodigoQr)
                    .HasMaxLength(50)
                    .HasColumnName("codigoQR");

                entity.Property(e => e.ConvenioId).HasColumnName("convenio_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Foto)
                    .HasMaxLength(100)
                    .HasColumnName("foto");

                entity.Property(e => e.MarcaId).HasColumnName("marca_id");

                entity.Property(e => e.Modelo).HasColumnName("modelo");

                entity.Property(e => e.Placa)
                    .HasMaxLength(50)
                    .HasColumnName("placa");

                entity.Property(e => e.TipoId).HasColumnName("tipo_id");

                entity.HasOne(d => d.CaracteristicaPrincipalNavigation)
                    .WithMany(p => p.VehiclesVehicles)
                    .HasForeignKey(d => d.CaracteristicaPrincipalId)
                    .HasConstraintName("vehicles_vehicle_caracteristica_princ_2b3c6160_fk_vehicles_");

                entity.HasOne(d => d.CaracteristicaSecundariaNavigation)
                    .WithMany(p => p.VehiclesVehicles)
                    .HasForeignKey(d => d.CaracteristicaSecundariaId)
                    .HasConstraintName("vehicles_vehicle_caracteristica_secun_d66f658e_fk_vehicles_");

                entity.HasOne(d => d.Convenio)
                    .WithMany(p => p.VehiclesVehicles)
                    .HasForeignKey(d => d.ConvenioId)
                    .HasConstraintName("vehicles_vehicle_convenio_id_b973de07_fk_vehicles_convenio_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.VehiclesVehicles)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicles_vehicle_estado_id_1d8573b4_fk_vehicles_");

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.VehiclesVehicles)
                    .HasForeignKey(d => d.MarcaId)
                    .HasConstraintName("vehicles_vehicle_marca_id_c4109642_fk_vehicles_marcavehicle_id");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.VehiclesVehicles)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehicles_vehicle_tipo_id_af77587c_fk_vehicles_tipovehicle_id");
            });

            modelBuilder.Entity<VehiculosEstadovehiculo>(entity =>
            {
                entity.ToTable("vehiculos_estadovehiculo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<VehiculosTipovehiculo>(entity =>
            {
                entity.ToTable("vehiculos_tipovehiculo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('vehiculos_tipo_id_seq'::regclass)");

                entity.Property(e => e.Capacidad)
                    .HasMaxLength(50)
                    .HasColumnName("capacidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<VehiculosVehiculo>(entity =>
            {
                entity.ToTable("vehiculos_vehiculo");

                entity.HasIndex(e => e.CodigoId, "vehiculos_vehiculo_codigoQR_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.EstadoId, "vehiculos_vehiculo_estado_id_c30c481e");

                entity.HasIndex(e => e.TipoId, "vehiculos_vehiculo_tipo_id_fc06defa");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodigoId).HasColumnName("codigo_id");

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Foto)
                    .HasMaxLength(100)
                    .HasColumnName("foto");

                entity.Property(e => e.Modelo).HasColumnName("modelo");

                entity.Property(e => e.TipoId).HasColumnName("tipo_id");

                entity.HasOne(d => d.Codigo)
                    .WithOne(p => p.VehiculosVehiculo)
                    .HasForeignKey<VehiculosVehiculo>(d => d.CodigoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehiculos_vehiculo_codigo_id_563ffda5_fk_codigosQR_codigosqr_id");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.VehiculosVehiculos)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehiculos_vehiculo_estado_id_c30c481e_fk_vehiculos");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.VehiculosVehiculos)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vehiculos_vehiculo_tipo_id_fc06defa_fk_vehiculos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
