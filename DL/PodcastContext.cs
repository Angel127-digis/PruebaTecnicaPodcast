using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DL;

public partial class PodcastContext : DbContext
{
    public PodcastContext()
    {
    }

    public PodcastContext(DbContextOptions<PodcastContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Episodio> Episodios { get; set; }

    public virtual DbSet<Idioma> Idiomas { get; set; }

    public virtual DbSet<Podcast> Podcasts { get; set; }
    public virtual DbSet<PodcastSP> PodcastSP { get; set; }



//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.; Database=Podcast; TrustServerCertificate=True; User ID=sa; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PodcastSP>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<Categorium>(entity =>
        {


            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__A3C02A1087416D75");

            entity.Property(e => e.Categoria)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Episodio>(entity =>
        {
            entity.HasKey(e => e.IdEpisodio).HasName("PK__Episodio__4CD9329EC369D626");

            entity.ToTable("Episodio");

            entity.Property(e => e.NumeroEpisodio)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Idioma>(entity =>
        {
            entity.HasKey(e => e.IdIdioma).HasName("PK__Idioma__C867BD36D42626F2");

            entity.ToTable("Idioma");

            entity.Property(e => e.Idioma1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Idioma");
        });

        modelBuilder.Entity<Podcast>(entity =>
        {
            entity.HasKey(e => e.IdPodcast).HasName("PK__Podcast__D7B8C535A94B2C76");

            entity.ToTable("Podcast");

            entity.Property(e => e.AudioUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("AudioURL");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Podcasts)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Podcast__IdCateg__1BFD2C07");

            entity.HasOne(d => d.IdEpisodioNavigation).WithMany(p => p.Podcasts)
                .HasForeignKey(d => d.IdEpisodio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Podcast__IdEpiso__1B0907CE");

            entity.HasOne(d => d.IdIdiomaNavigation).WithMany(p => p.Podcasts)
                .HasForeignKey(d => d.IdIdioma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Podcast__IdIdiom__1DE57479");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
