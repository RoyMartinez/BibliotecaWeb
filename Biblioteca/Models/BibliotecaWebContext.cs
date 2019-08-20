using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Biblioteca.Models
{
    public partial class BibliotecaWebContext : DbContext
    {
        public BibliotecaWebContext()
        {
        }

        public BibliotecaWebContext(DbContextOptions<BibliotecaWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<LibroXautor> LibroXautor { get; set; }
        public virtual DbSet<Nacionalidad> Nacionalidad { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*Favor cambiar la cadena de conexion por la de la ip local si el sistema accede sin usuario ni contraseña*/
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=BibliotecaWeb;Integrated Security=True");

                /*Favor cambiar la cadena de conexion por la de la ip del servidor y brindar acceso de usuario y contraseña*/
                /*reemplazar lo que esta en corchetes con la variable requerida Ejemplo:[ServidorIp]=>127.0.0.1 y hacer asi con el resto*/
                //optionsBuilder.UseSqlServer("data source = [ServidorIp]; initial catalog = BibliotecaWeb; user id = [Usuario]; password = [Contraseña]");

                /*Cadena de conexion ocupada por mi computadora*/
                // optionsBuilder.UseSqlServer("Data Source=ROY-PC\\SQLEXPRESS;Initial Catalog=BibliotecaWeb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("UQ__Area__75E3EFCF6DBF8AA9")
                    .IsUnique();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("UQ__Autor__75E3EFCF44FAFCCC")
                    .IsUnique();

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.HasOne(d => d.NacionalidadNavigation)
                    .WithMany(p => p.Autor)
                    .HasForeignKey(d => d.Nacionalidad)
                    .HasConstraintName("fkAutorNacionalidad");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("UQ__Carrera__75E3EFCF3E8B31FA")
                    .IsUnique();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("UQ__Editoria__75E3EFCF7A54A46B")
                    .IsUnique();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasIndex(e => e.Carnet)
                    .HasName("UQ__Estudian__5E387B4DF872A538")
                    .IsUnique();

                entity.Property(e => e.Carnet)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.HasOne(d => d.CarreraNavigation)
                    .WithMany(p => p.Estudiante)
                    .HasForeignKey(d => d.Carrera)
                    .HasConstraintName("fkEstudianteCarrera");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.Property(e => e.Titulo).HasMaxLength(100);

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Libro)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("fkLibroArea");

                entity.HasOne(d => d.EditorialNavigation)
                    .WithMany(p => p.Libro)
                    .HasForeignKey(d => d.Editorial)
                    .HasConstraintName("fkLibroEditorial");
            });

            modelBuilder.Entity<LibroXautor>(entity =>
            {
                entity.HasKey(e => new { e.Autor, e.Libro })
                    .HasName("pkLibroXAutor");

                entity.ToTable("LibroXAutor");

                entity.HasOne(d => d.AutorNavigation)
                    .WithMany(p => p.LibroXautor)
                    .HasForeignKey(d => d.Autor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkLibroXAutorAutor");

                entity.HasOne(d => d.LibroNavigation)
                    .WithMany(p => p.LibroXautor)
                    .HasForeignKey(d => d.Libro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkLibroXAutorLibro");
            });

            modelBuilder.Entity<Nacionalidad>(entity =>
            {
                entity.HasIndex(e => e.Nacionalidad1)
                    .HasName("UQ__Nacional__BA69CB790BD3D18E")
                    .IsUnique();

                entity.Property(e => e.Nacionalidad1)
                    .IsRequired()
                    .HasColumnName("Nacionalidad")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => new { e.Estudiante, e.Libro })
                    .HasName("pkPrestamo");

                entity.Property(e => e.Devuelto)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaDevolucion)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(CONVERT([date],getdate()+(7)))");

                entity.Property(e => e.FechaPrestamo)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.EstudianteNavigation)
                    .WithMany(p => p.Prestamo)
                    .HasForeignKey(d => d.Estudiante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkPrestamoEstudiante");

                entity.HasOne(d => d.LibroNavigation)
                    .WithMany(p => p.Prestamo)
                    .HasForeignKey(d => d.Libro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkPrestamoLibro");
            });
        }
    }
}
