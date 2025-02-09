﻿// <auto-generated />
using System;
using Axity.DataAccessEntity.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Axity.DataAccessEntity.Entities.Data.Migration
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231122184359_Primer_Migracion2.0")]
    partial class Primer_Migracion20
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.Menu.MenuModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Pk_Menu");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Codigo");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icono");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Estado");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.Page.ActionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Pk_Action");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Codigo");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icono");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Estado");

                    b.HasKey("Id");

                    b.ToTable("Acciones");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.Page.PageModel", b =>
                {
                    b.Property<int>("IdPage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Pk_Page");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPage"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Codigo");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icono");

                    b.Property<int>("IdSubMenu")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Estado");

                    b.HasKey("IdPage");

                    b.HasIndex("IdSubMenu");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.Page.SubActionModel", b =>
                {
                    b.Property<int>("IdSubActin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Pk_SubAccion");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSubActin"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Codigo");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icono");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.Property<int>("IdPage")
                        .HasColumnType("int");

                    b.Property<int>("IdSubMenu")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Estado");

                    b.HasKey("IdSubActin");

                    b.HasIndex("IdAction");

                    b.HasIndex("IdPage");

                    b.HasIndex("IdSubMenu");

                    b.ToTable("AccPagSubMenu");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.Rols.RolModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Pk_Rol");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Codigo");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nombre");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Estado");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.SubMenu.SubMenuModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Pk_SubMenu");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Codigo");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icono");

                    b.Property<int>("IdMenu")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("Estado");

                    b.HasKey("Id");

                    b.HasIndex("IdMenu");

                    b.ToTable("SubMenu");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.User.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(120)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(120)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(120)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecondLastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.User.UserRolModel", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RolId");

                    b.ToTable("UserRols");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.Page.PageModel", b =>
                {
                    b.HasOne("Axity.DataAccessEntity.Entities.Model.SubMenu.SubMenuModel", "Pk_SubMenu")
                        .WithMany()
                        .HasForeignKey("IdSubMenu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pk_SubMenu");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.Page.SubActionModel", b =>
                {
                    b.HasOne("Axity.DataAccessEntity.Entities.Model.Page.ActionModel", "Pk_Action")
                        .WithMany()
                        .HasForeignKey("IdAction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Axity.DataAccessEntity.Entities.Model.Page.PageModel", "Pk_Page")
                        .WithMany()
                        .HasForeignKey("IdPage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Axity.DataAccessEntity.Entities.Model.SubMenu.SubMenuModel", "Pk_SubMenu")
                        .WithMany()
                        .HasForeignKey("IdSubMenu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pk_Action");

                    b.Navigation("Pk_Page");

                    b.Navigation("Pk_SubMenu");
                });

            modelBuilder.Entity("Axity.DataAccessEntity.Entities.Model.SubMenu.SubMenuModel", b =>
                {
                    b.HasOne("Axity.DataAccessEntity.Entities.Model.Menu.MenuModel", "Pk_Menu")
                        .WithMany()
                        .HasForeignKey("IdMenu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pk_Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
