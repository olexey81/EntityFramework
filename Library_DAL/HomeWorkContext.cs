using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library_DAL;

public partial class HomeWorkContext : DbContext
{
    public HomeWorkContext()
    {
    }

    public HomeWorkContext(DbContextOptions<HomeWorkContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BooksAuthor> BooksAuthors { get; set; }

    public virtual DbSet<DocumentsType> DocumentsTypes { get; set; }

    public virtual DbSet<Librarian> Librarians { get; set; }

    public virtual DbSet<PublCodeType> PublCodeTypes { get; set; }

    public virtual DbSet<Reader> Readers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=OLEKSII_HP\\SQLEXPRESS;Initial Catalog=HomeWork;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Authors__70DAFC14F077345E");

            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C22788BED084");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PublCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.Author)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Books__Author__412EB0B6");

            entity.HasOne(d => d.PublCodeTypeNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.PublCodeType)
                .HasConstraintName("FK__Books__PublCodeT__4222D4EF");
        });

        modelBuilder.Entity<BooksAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BooksAut__3214EC272168C6C5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
            entity.Property(e => e.BookId).HasColumnName("BookID");

            entity.HasOne(d => d.Author).WithMany(p => p.BooksAuthors)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BooksAuth__Autho__45F365D3");

            entity.HasOne(d => d.Book).WithMany(p => p.BooksAuthors)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BooksAuth__BookI__44FF419A");
        });

        modelBuilder.Entity<DocumentsType>(entity =>
        {
            entity.HasKey(e => e.DocTypeId).HasName("PK__Document__055E26833F954D10");

            entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Librarian>(entity =>
        {
            entity.HasKey(e => e.Login).HasName("PK__Libraria__5E55825AC1C3574F");

            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PublCodeType>(entity =>
        {
            entity.HasKey(e => e.PublCodeTypeId).HasName("PK__PublCode__3476218387FBBDBC");

            entity.Property(e => e.PublCodeTypeId).HasColumnName("PublCodeTypeID");
            entity.Property(e => e.TypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reader>(entity =>
        {
            entity.HasKey(e => e.Login).HasName("PK__Readers__5E55825A470716D0");

            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.DocumentTypeNavigation).WithMany(p => p.Readers)
                .HasForeignKey(d => d.DocumentType)
                .HasConstraintName("FK__Readers__Documen__3A81B327");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
