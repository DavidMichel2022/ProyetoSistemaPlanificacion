using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaPlanificacion.Entity;

namespace SistemaPlanificacion.DAL.DBContext;

public partial class BasePlanificacionContext : DbContext
{
    public BasePlanificacionContext()
    {
    }

    public BasePlanificacionContext(DbContextOptions<BasePlanificacionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividad> Actividad { get; set; }

    public virtual DbSet<CabeceraCarpetaCompra> CabeceraCarpetaCompra { get; set; }

    public virtual DbSet<CabeceraCarpetaPlanificacion> CabeceraCarpetaPlanificacion { get; set; }

    public virtual DbSet<CabeceraCarpetaPresupuesto> CabeceraCarpetaPresupuesto { get; set; }

    public virtual DbSet<CentroSalud> CentroSalud { get; set; }

    public virtual DbSet<CierreCarpeta> CierreCarpeta { get; set; }

    public virtual DbSet<Configuracion> Configuracion { get; set; }

    public virtual DbSet<DetalleCarpetaPlanificacion> DetalleCarpetaPlanificacion { get; set; }

    public virtual DbSet<Empresa> Empresa { get; set; }

    public virtual DbSet<MenuPrincipal> MenuPrincipal { get; set; }

    public virtual DbSet<PartidaPresupuestaria> PartidaPresupuestaria { get; set; }

    public virtual DbSet<Programa> Programa { get; set; }

    public virtual DbSet<RolGeneral> RolGeneral { get; set; }

    public virtual DbSet<RolMenu> RolMenu { get; set; }

    public virtual DbSet<Transferencia> Transferencia { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.HasKey(e => e.IdActividad);

            entity.ToTable("Actividad");

            entity.Property(e => e.IdActividad)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Actividad");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NombreActividad)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("Nombre_Actividad");
        });

        modelBuilder.Entity<CabeceraCarpetaCompra>(entity =>
        {
            entity.HasKey(e => e.IdCarpPlanif);

            entity.ToTable("Cabecera_Carpeta_Compra");

            entity.Property(e => e.IdCarpPlanif)
                .ValueGeneratedNever()
                .HasColumnName("Id_CarpPlanif");
            entity.Property(e => e.CuceCarpCompra)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Cuce_CarpCompra");
            entity.Property(e => e.FechaBienContratado)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_BienContratado");
            entity.Property(e => e.FechaCarpCompra)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_CarpCompra");
            entity.Property(e => e.ModalidadCarpCompra)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("Modalidad_CarpCompra");
            entity.Property(e => e.MontoAdjuCarpCompra).HasColumnName("MontoAdju_CarpCompra");
            entity.Property(e => e.NroCarpPlanif).HasColumnName("Nro_CarpPlanif");
            entity.Property(e => e.NroFacturaCarpCompra)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("NroFactura_CarpCompra");
            entity.Property(e => e.ObjContratoCarpCompra)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("ObjContrato_CarpCompra");

            entity.HasOne(d => d.IdCarpPlanifNavigation).WithOne(p => p.CabeceraCarpetaCompra)
                .HasForeignKey<CabeceraCarpetaCompra>(d => d.IdCarpPlanif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cabecera_Carpeta_Compra_Cabecera_Carpeta_Planificacion");
        });

        modelBuilder.Entity<CabeceraCarpetaPlanificacion>(entity =>
        {
            entity.HasKey(e => e.IdCarpPlanif);

            entity.ToTable("Cabecera_Carpeta_Planificacion");

            entity.Property(e => e.IdCarpPlanif)
                .ValueGeneratedNever()
                .HasColumnName("Id_CarpPlanif");
            entity.Property(e => e.CodCertPoa)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("CodCert_Poa");
            entity.Property(e => e.FechaCarpPlanif)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_CarpPlanif");
            entity.Property(e => e.IdActividad)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Actividad");
            entity.Property(e => e.IdCentro)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Centro");
            entity.Property(e => e.IdPrograma)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Programa");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.MontoPlanifCarpPlanif).HasColumnName("MontoPlanif_CarpPlanif");
            entity.Property(e => e.MontoPoaCarpPlanif).HasColumnName("MontoPoa_CarpPlanif");
            entity.Property(e => e.NroCarpPlanif).HasColumnName("Nro_CarpPlanif");
            entity.Property(e => e.ReferenciaCarpPlanif)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Referencia_CarpPlanif");
            entity.Property(e => e.UbicacionCarpPlanif)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Ubicacion_CarpPlanif");

            entity.HasOne(d => d.IdActividadNavigation).WithMany(p => p.CabeceraCarpetaPlanificacions)
                .HasForeignKey(d => d.IdActividad)
                .HasConstraintName("FK_Cabecera_Carpeta_Planificacion_Actividad1");

            entity.HasOne(d => d.IdCentroNavigation).WithMany(p => p.CabeceraCarpetaPlanificacions)
                .HasForeignKey(d => d.IdCentro)
                .HasConstraintName("FK_Cabecera_Carpeta_Planificacion_Centro_Salud1");

            entity.HasOne(d => d.IdProgramaNavigation).WithMany(p => p.CabeceraCarpetaPlanificacions)
                .HasForeignKey(d => d.IdPrograma)
                .HasConstraintName("FK_Cabecera_Carpeta_Planificacion_Programa1");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.CabeceraCarpetaPlanificacions)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_Cabecera_Carpeta_Planificacion_Usuarios");
        });

        modelBuilder.Entity<CabeceraCarpetaPresupuesto>(entity =>
        {
            entity.HasKey(e => e.IdCarpPlanif);

            entity.ToTable("Cabecera_Carpeta_Presupuesto");

            entity.Property(e => e.IdCarpPlanif)
                .ValueGeneratedNever()
                .HasColumnName("Id_CarpPlanif");
            entity.Property(e => e.CodCertPresup)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("CodCert_Presup");
            entity.Property(e => e.FechaCarpPresup)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_CarpPresup");
            entity.Property(e => e.IdActividad)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Actividad");
            entity.Property(e => e.IdPrograma)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Programa");
            entity.Property(e => e.MontoPresupCarpPresup).HasColumnName("MontoPresup_CarpPresup");
            entity.Property(e => e.NroCarpPlanif).HasColumnName("Nro_CarpPlanif");

            entity.HasOne(d => d.IdCarpPlanifNavigation).WithOne(p => p.CabeceraCarpetaPresupuesto)
                .HasForeignKey<CabeceraCarpetaPresupuesto>(d => d.IdCarpPlanif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cabecera_Carpeta_Presupuesto_Cabecera_Carpeta_Planificacion");
        });

        modelBuilder.Entity<CentroSalud>(entity =>
        {
            entity.HasKey(e => e.IdCentro);

            entity.ToTable("Centro_Salud");

            entity.Property(e => e.IdCentro)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Centro");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NombreCentro)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("Nombre_Centro");
        });

        modelBuilder.Entity<CierreCarpeta>(entity =>
        {
            entity.HasKey(e => e.IdCarpPlanif);

            entity.ToTable("Cierre_Carpeta");

            entity.Property(e => e.IdCarpPlanif)
                .ValueGeneratedNever()
                .HasColumnName("Id_CarpPlanif");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NroCarpPlanif).HasColumnName("Nro_CarpPlanif");
            entity.Property(e => e.PartPresuCarpeta)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PartPresu_Carpeta");
            entity.Property(e => e.SaldoFinal).HasColumnName("Saldo_Final");
            entity.Property(e => e.TipoCierre)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Tipo_Cierre");

            entity.HasOne(d => d.IdCarpPlanifNavigation).WithOne(p => p.CierreCarpetum)
                .HasForeignKey<CierreCarpeta>(d => d.IdCarpPlanif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cierre_Carpeta_Cabecera_Carpeta_Planificacion");
        });

        modelBuilder.Entity<Configuracion>(entity =>
        {
            entity.HasKey(e => e.Recurso);

            entity.ToTable("Configuracion");

            entity.Property(e => e.Recurso)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Propiedad)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<DetalleCarpetaPlanificacion>(entity =>
        {
            entity.HasKey(e => e.IdCarpPlanif);

            entity.ToTable("Detalle_Carpeta_Planificacion");

            entity.Property(e => e.IdCarpPlanif)
                .ValueGeneratedNever()
                .HasColumnName("Id_CarpPlanif");
            entity.Property(e => e.IdEmpresa).HasColumnName("Id_Empresa");
            entity.Property(e => e.IdPartida).HasColumnName("Id_Partida");
            entity.Property(e => e.MontoCompra).HasColumnName("Monto_Compra");
            entity.Property(e => e.MontoPlanif).HasColumnName("Monto_Planif");
            entity.Property(e => e.MontoPoa).HasColumnName("Monto_Poa");
            entity.Property(e => e.MontoPresup).HasColumnName("Monto_Presup");
            entity.Property(e => e.NombreItemCarpeta)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("NombreItem_Carpeta");
            entity.Property(e => e.NroCarpPlanif).HasColumnName("Nro_CarpPlanif");

            entity.HasOne(d => d.IdCarpPlanifNavigation).WithOne(p => p.DetalleCarpetaPlanificacion)
                .HasForeignKey<DetalleCarpetaPlanificacion>(d => d.IdCarpPlanif)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Detalle_Carpeta_Planificacion_Cabecera_Carpeta_Planificacion1");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.DetalleCarpetaPlanificacions)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK_Detalle_Carpeta_Planificacion_Empresas");

            entity.HasOne(d => d.IdPartidaNavigation).WithMany(p => p.DetalleCarpetaPlanificacions)
                .HasForeignKey(d => d.IdPartida)
                .HasConstraintName("FK_Detalle_Carpeta_Planificacion_Partida_Presupuestaria");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.Property(e => e.IdEmpresa)
                .ValueGeneratedNever()
                .HasColumnName("Id_Empresa");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Nombre_Empresa");
        });

        modelBuilder.Entity<MenuPrincipal>(entity =>
        {
            entity.HasKey(e => e.IdMenu);

            entity.ToTable("Menu_Principal");

            entity.Property(e => e.IdMenu)
                .ValueGeneratedNever()
                .HasColumnName("Id_Menu");
            entity.Property(e => e.Controlador)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdMenuPadre).HasColumnName("Id_Menu_Padre");
            entity.Property(e => e.PaginaAccion)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Pagina_Accion");
        });

        modelBuilder.Entity<PartidaPresupuestaria>(entity =>
        {
            entity.HasKey(e => e.IdPartida);

            entity.ToTable("Partida_Presupuestaria");

            entity.Property(e => e.IdPartida)
                .ValueGeneratedNever()
                .HasColumnName("Id_Partida");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NombrePartida)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("Nombre_Partida");
        });

        modelBuilder.Entity<Programa>(entity =>
        {
            entity.HasKey(e => e.IdPrograma);

            entity.ToTable("Programa");

            entity.Property(e => e.IdPrograma)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Programa");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.NombrePrograma)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("Nombre_Programa");
        });

        modelBuilder.Entity<RolGeneral>(entity =>
        {
            entity.HasKey(e => e.IdRol);

            entity.ToTable("Rol_General");

            entity.Property(e => e.IdRol)
                .ValueGeneratedNever()
                .HasColumnName("Id_Rol");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
        });

        modelBuilder.Entity<RolMenu>(entity =>
        {
            entity.HasKey(e => e.IdRolMenu);

            entity.ToTable("Rol_Menu");

            entity.Property(e => e.IdRolMenu)
                .ValueGeneratedNever()
                .HasColumnName("Id_Rol_Menu");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdMenu).HasColumnName("Id_Menu");
            entity.Property(e => e.IdRol).HasColumnName("Id_Rol");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.RolMenus)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK_Rol_Menu_Menu_Principal");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolMenus)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK_Rol_Menu_Rol_General");
        });

        modelBuilder.Entity<Transferencia>(entity =>
        {
            entity.HasKey(e => e.IdTransf);

            entity.Property(e => e.IdTransf)
                .ValueGeneratedNever()
                .HasColumnName("Id_Transf");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdDestino)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Id_Destino");
            entity.Property(e => e.IdOrigen)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Id_Origen");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK_Tabla_Usuarios");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("Id_Usuario");
            entity.Property(e => e.ActivoUsuario).HasColumnName("Activo_Usuario");
            entity.Property(e => e.CargoUsuario)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Cargo_Usuario");
            entity.Property(e => e.CarnetUsuario)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Carnet_Usuario");
            entity.Property(e => e.ClaveUsuario)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("Clave_Usuario");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Registro");
            entity.Property(e => e.IdRol).HasColumnName("Id_Rol");
            entity.Property(e => e.MailUsuario)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Mail_Usuario");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Nombre_Usuario");
            entity.Property(e => e.ProfesionUsuario)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Profesion_Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
