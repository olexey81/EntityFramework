﻿// <auto-generated />
using System;
using Library_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library_DAL.Migrations
{
    [DbContext(typeof(HomeWorkContext))]
    [Migration("20230828093055_GenreToBooks")]
    partial class GenreToBooks
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Library_DAL.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("AuthorId")
                        .HasName("PK__Authors__70DAFC14F077345E");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library_DAL.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Genre")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("PublCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("PublCodeType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BookId")
                        .HasName("PK__Books__3DE0C22788BED084");

                    b.HasIndex("Author");

                    b.HasIndex("PublCodeType");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library_DAL.BooksAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    b.HasKey("Id")
                        .HasName("PK__BooksAut__3214EC272168C6C5");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BooksAuthors");
                });

            modelBuilder.Entity("Library_DAL.DocumentsType", b =>
                {
                    b.Property<int>("DocTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DocTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("DocTypeId")
                        .HasName("PK__Document__055E26833F954D10");

                    b.ToTable("DocumentsTypes");
                });

            modelBuilder.Entity("Library_DAL.Librarian", b =>
                {
                    b.Property<string>("Login")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Login")
                        .HasName("PK__Libraria__5E55825AC1C3574F");

                    b.ToTable("Librarians");
                });

            modelBuilder.Entity("Library_DAL.PublCodeType", b =>
                {
                    b.Property<int>("PublCodeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PublCodeTypeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublCodeTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("PublCodeTypeId")
                        .HasName("PK__PublCode__3476218387FBBDBC");

                    b.ToTable("PublCodeTypes");
                });

            modelBuilder.Entity("Library_DAL.Reader", b =>
                {
                    b.Property<string>("Login")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("DocumentType")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Login")
                        .HasName("PK__Readers__5E55825A470716D0");

                    b.HasIndex("DocumentType");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("Library_DAL.Book", b =>
                {
                    b.HasOne("Library_DAL.Author", "AuthorNavigation")
                        .WithMany("Books")
                        .HasForeignKey("Author")
                        .IsRequired()
                        .HasConstraintName("FK__Books__Author__412EB0B6");

                    b.HasOne("Library_DAL.PublCodeType", "PublCodeTypeNavigation")
                        .WithMany("Books")
                        .HasForeignKey("PublCodeType")
                        .HasConstraintName("FK__Books__PublCodeT__4222D4EF");

                    b.Navigation("AuthorNavigation");

                    b.Navigation("PublCodeTypeNavigation");
                });

            modelBuilder.Entity("Library_DAL.BooksAuthor", b =>
                {
                    b.HasOne("Library_DAL.Author", "Author")
                        .WithMany("BooksAuthors")
                        .HasForeignKey("AuthorId")
                        .IsRequired()
                        .HasConstraintName("FK__BooksAuth__Autho__45F365D3");

                    b.HasOne("Library_DAL.Book", "Book")
                        .WithMany("BooksAuthors")
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK__BooksAuth__BookI__44FF419A");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Library_DAL.Reader", b =>
                {
                    b.HasOne("Library_DAL.DocumentsType", "DocumentTypeNavigation")
                        .WithMany("Readers")
                        .HasForeignKey("DocumentType")
                        .HasConstraintName("FK__Readers__Documen__3A81B327");

                    b.Navigation("DocumentTypeNavigation");
                });

            modelBuilder.Entity("Library_DAL.Author", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("BooksAuthors");
                });

            modelBuilder.Entity("Library_DAL.Book", b =>
                {
                    b.Navigation("BooksAuthors");
                });

            modelBuilder.Entity("Library_DAL.DocumentsType", b =>
                {
                    b.Navigation("Readers");
                });

            modelBuilder.Entity("Library_DAL.PublCodeType", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
