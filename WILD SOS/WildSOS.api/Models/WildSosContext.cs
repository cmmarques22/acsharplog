using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WildSOS.api.Models;

public partial class WildSosContext : DbContext
{
    public WildSosContext()
    {
    }

    public WildSosContext(DbContextOptions<WildSosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CodigoPostal> CodigoPostals { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Especie> Especies { get; set; }




    public virtual DbSet<LinhaSos> LinhaSos { get; set; }

    public virtual DbSet<LinhaSostipoOcorrencia> LinhaSostipoOcorrencia { get; set; }

    public virtual DbSet<Notificacao> Notificacaos { get; set; }

    public virtual DbSet<Ocorrencia> Ocorrencia { get; set; }

    public virtual DbSet<TipoContacto> TipoContactos { get; set; }

    public virtual DbSet<TipoOcorrencia> TipoOcorrencia { get; set; }

    public virtual DbSet<TipologiaUser> TipologiaUsers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=AppConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CodigoPostal>(entity =>
        {
            entity.HasKey(e => e.IdCodigoPostal).HasName("PK__CodigoPo__D1D25CADBDD08D92");

            entity.ToTable("CodigoPostal");

            entity.Property(e => e.IdCodigoPostal).HasColumnName("idCodigoPostal");
            entity.Property(e => e.CodigoPostal1)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("CodigoPostal");
            entity.Property(e => e.Concelho).HasMaxLength(20);
            entity.Property(e => e.Distrito).HasMaxLength(20);
            entity.Property(e => e.Localidade).HasMaxLength(20);
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.HasKey(e => e.IdContacto).HasName("PK__Contacto__4B1329C74B674C50");

            entity.ToTable("Contacto");

            entity.Property(e => e.IdContacto).HasColumnName("idContacto");
            entity.Property(e => e.IdTipoContacto).HasColumnName("idTipoContacto");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Valor).HasMaxLength(200);

            entity.HasOne(d => d.IdTipoContactoNavigation).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.IdTipoContacto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contacto__idTipo__6319B466");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contacto__idUser__6225902D");
        });

        modelBuilder.Entity<Especie>(entity =>
        {
            entity.HasKey(e => e.IdEspecie).HasName("PK__Especie__8E5AC248CFF2205B");

            entity.ToTable("Especie");

            entity.Property(e => e.IdEspecie).HasColumnName("idEspecie");
            entity.Property(e => e.Classe).HasMaxLength(20);
            entity.Property(e => e.Especie1)
                .HasMaxLength(20)
                .HasColumnName("Especie");
        });

        

        modelBuilder.Entity<LinhaSos>(entity =>
        {
            entity.HasKey(e => e.IdLinhaSos).HasName("PK__LinhaSOS__F7ED2CCD5A38A8F7");

            entity.ToTable("LinhaSOS");

            entity.Property(e => e.IdLinhaSos).HasColumnName("idLinhaSOS");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.IdCodigoPostal).HasColumnName("idCodigoPostal");
            entity.Property(e => e.Morada).HasMaxLength(200);
            entity.Property(e => e.Nome).HasMaxLength(200);
            entity.Property(e => e.Telefone)
                .HasMaxLength(9)
                .IsFixedLength();

            entity.HasOne(d => d.IdCodigoPostalNavigation).WithMany(p => p.LinhaSos)
                .HasForeignKey(d => d.IdCodigoPostal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LinhaSOS__idCodi__56B3DD81");
        });

        modelBuilder.Entity<LinhaSostipoOcorrencia>(entity =>
        {
            entity.HasKey(e => new { e.IdLinhaSos, e.IdTipoOcorrencia }).HasName("PK__LinhaSOS__D055B6E8EF26A8D0");

            entity.ToTable("LinhaSOSTipoOcorrencia");

            entity.Property(e => e.IdLinhaSos).HasColumnName("idLinhaSOS");
            entity.Property(e => e.IdTipoOcorrencia).HasColumnName("idTipoOcorrencia");

            entity.HasOne(d => d.IdLinhaSosNavigation).WithMany(p => p.LinhaSostipoOcorrencia)
                .HasForeignKey(d => d.IdLinhaSos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LinhaSOST__idLin__59904A2C");

            entity.HasOne(d => d.IdTipoOcorrenciaNavigation).WithMany(p => p.LinhaSostipoOcorrencia)
                .HasForeignKey(d => d.IdTipoOcorrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LinhaSOST__idTip__5A846E65");
        });

       

        modelBuilder.Entity<Notificacao>(entity =>
        {
            entity.HasKey(e => e.IdNotificacao).HasName("PK__Notifica__4955F61D5CE692AC");

            entity.ToTable("Notificacao", tb => tb.HasTrigger("NotificacaoInsertLog"));

            entity.Property(e => e.IdNotificacao).HasColumnName("idNotificacao");
            entity.Property(e => e.IdOcorrencia).HasColumnName("idOcorrencia");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Texto).HasMaxLength(200);

            entity.HasOne(d => d.IdOcorrenciaNavigation).WithMany(p => p.Notificacaos)
                .HasForeignKey(d => d.IdOcorrencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notificac__idOco__6F7F8B4B");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Notificacaos)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notificac__idUse__7073AF84");
        });

        modelBuilder.Entity<Ocorrencia>(entity =>
        {
            entity.HasKey(e => e.IdOcorrencia).HasName("PK__Ocorrenc__ECFCAEE3C9644321");

            entity.ToTable(tb => tb.HasTrigger("OcorrenciaInsertLog"));

            entity.Property(e => e.IdOcorrencia).HasColumnName("idOcorrencia");
            entity.Property(e => e.DataHora).HasColumnType("datetime");
            entity.Property(e => e.Descricao).HasMaxLength(200);
            entity.Property(e => e.Estado).HasMaxLength(200);
            entity.Property(e => e.IdEspecie).HasColumnName("idEspecie");
            entity.Property(e => e.IdTipoOcorrencia).HasColumnName("idTipoOcorrencia");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Localizacao).HasMaxLength(200);

            entity.HasOne(d => d.IdEspecieNavigation).WithMany(p => p.Ocorrencia)
                .HasForeignKey(d => d.IdEspecie)
                .HasConstraintName("FK__Ocorrenci__idEsp__6CA31EA0");

            entity.HasOne(d => d.IdTipoOcorrenciaNavigation).WithMany(p => p.Ocorrencia)
                .HasForeignKey(d => d.IdTipoOcorrencia)
                .HasConstraintName("FK__Ocorrenci__idTip__6ABAD62E");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Ocorrencia)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ocorrenci__idUse__6BAEFA67");
        });

        modelBuilder.Entity<TipoContacto>(entity =>
        {
            entity.HasKey(e => e.IdTipoContacto).HasName("PK__TipoCont__EF7BE77554F527FA");

            entity.ToTable("TipoContacto");

            entity.Property(e => e.IdTipoContacto).HasColumnName("idTipoContacto");
            entity.Property(e => e.Descricao).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoOcorrencia>(entity =>
        {
            entity.HasKey(e => e.IdTipoOcorrencia).HasName("PK__TipoOcor__7B89A253A5DD104E");

            entity.Property(e => e.IdTipoOcorrencia).HasColumnName("idTipoOcorrencia");
            entity.Property(e => e.Descricao).HasMaxLength(1000);
        });

        modelBuilder.Entity<TipologiaUser>(entity =>
        {
            entity.HasKey(e => e.IdTipoUser).HasName("PK__Tipologi__39DB342FFBE82CF6");

            entity.ToTable("TipologiaUser");

            entity.Property(e => e.IdTipoUser).HasColumnName("idTipoUser");
            entity.Property(e => e.Descricao).HasMaxLength(30);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__User__3717C98284B5DE78");

            entity.ToTable("User");

            entity.HasIndex(e => e.Username, "UQ__User__536C85E4CA315F2A").IsUnique();

            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.DataAtualização).HasColumnType("datetime");
            entity.Property(e => e.IdCodigoPostal).HasColumnName("idCodigoPostal");
            entity.Property(e => e.IdTipoUser).HasColumnName("idTipoUser");
            entity.Property(e => e.Morada).HasMaxLength(200);
            entity.Property(e => e.Nome).HasMaxLength(100);
            entity.Property(e => e.Password)
                .HasMaxLength(8)
                .IsFixedLength();
            entity.Property(e => e.Username).HasMaxLength(30);

            entity.HasOne(d => d.IdCodigoPostalNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdCodigoPostal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__idCodigoPo__5E54FF49");

            entity.HasOne(d => d.IdTipoUserNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdTipoUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__User__idTipoUser__5F492382");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
