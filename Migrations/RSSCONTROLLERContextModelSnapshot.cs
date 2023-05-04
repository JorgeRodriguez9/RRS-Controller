﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RRS_Controller.DAL;

#nullable disable

namespace RRS_Controller.Migrations
{
    [DbContext(typeof(RSSCONTROLLERContext))]
    partial class RSSCONTROLLERContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RRS_Controller.Models.ADMIN_PAE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_User")
                        .IsUnique();

                    b.ToTable("ADMIN_PAEs");
                });

            modelBuilder.Entity("RRS_Controller.Models.CATEGORY", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CATEGORYS");
                });

            modelBuilder.Entity("RRS_Controller.Models.EVALUATION", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Correct_Quantity")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime>("Date_Received")
                        .HasColumnType("Date");

                    b.Property<int>("Id_Secretary_Inst")
                        .HasColumnType("int");

                    b.Property<int>("Id_Shipment")
                        .HasColumnType("int");

                    b.Property<string>("Received")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Secretary_Inst");

                    b.HasIndex("Id_Shipment")
                        .IsUnique();

                    b.ToTable("EVALUATIONS");
                });

            modelBuilder.Entity("RRS_Controller.Models.FOOD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Id_Nutritionits_Pae")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Nutritionits_Pae");

                    b.ToTable("FOODS");
                });

            modelBuilder.Entity("RRS_Controller.Models.FOOD_PRODUCT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Id_Food")
                        .HasColumnType("int");

                    b.Property<int>("Id_Product")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Id_Food");

                    b.HasIndex("Id_Product");

                    b.ToTable("FOOD_PRODUCTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.INSTITUTION", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_Manager")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Id_Manager");

                    b.ToTable("INSTITUTIONS");
                });

            modelBuilder.Entity("RRS_Controller.Models.MANAGER_PAE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_User")
                        .IsUnique();

                    b.ToTable("MANAGER_PAEs");
                });

            modelBuilder.Entity("RRS_Controller.Models.MENU", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Id_Category")
                        .HasColumnType("int");

                    b.Property<int>("Id_Nutritionits_Pae")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Category");

                    b.HasIndex("Id_Nutritionits_Pae");

                    b.ToTable("MENUS");
                });

            modelBuilder.Entity("RRS_Controller.Models.MENU_FOOD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Id_Food")
                        .HasColumnType("int");

                    b.Property<int>("Id_Menu")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Id_Food");

                    b.HasIndex("Id_Menu");

                    b.ToTable("MENU_FOODS");
                });

            modelBuilder.Entity("RRS_Controller.Models.NUTRITIONITS_INTS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_Admin_Pae")
                        .HasColumnType("int");

                    b.Property<int>("Id_Institution")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Admin_Pae");

                    b.HasIndex("Id_Institution");

                    b.HasIndex("Id_User")
                        .IsUnique();

                    b.ToTable("NUTRITIONITS_INTSs");
                });

            modelBuilder.Entity("RRS_Controller.Models.NUTRITIONITS_PAE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_User")
                        .IsUnique();

                    b.ToTable("NUTRITIONITS_PAEs");
                });

            modelBuilder.Entity("RRS_Controller.Models.PRODUCT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Id_Admin_Pae")
                        .HasColumnType("int");

                    b.Property<int>("Id_Supplier")
                        .HasColumnType("int");

                    b.Property<int>("Id_Unit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Admin_Pae");

                    b.HasIndex("Id_Supplier");

                    b.HasIndex("Id_Unit");

                    b.ToTable("PRODUCTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.REQUEST", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<DateTime>("Desired_Delivery_Date")
                        .HasColumnType("Date");

                    b.Property<int>("Id_Nutritionits_Ints")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Nutritionits_Ints");

                    b.ToTable("REQUESTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.REQUEST_MENU", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Id_Menu")
                        .HasColumnType("int");

                    b.Property<int>("Id_Request")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Id_Menu");

                    b.HasIndex("Id_Request");

                    b.ToTable("REQUEST_MENUS");
                });

            modelBuilder.Entity("RRS_Controller.Models.ROLE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name_Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("ROLES");
                });

            modelBuilder.Entity("RRS_Controller.Models.SECRETARY_INTS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id_Admin_Pae")
                        .HasColumnType("int");

                    b.Property<int>("Id_Institution")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Admin_Pae");

                    b.HasIndex("Id_Institution");

                    b.HasIndex("Id_User")
                        .IsUnique();

                    b.ToTable("SECRETARY_INTSs");
                });

            modelBuilder.Entity("RRS_Controller.Models.SHIPMENT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<int>("Id_Admin_Pae")
                        .HasColumnType("int");

                    b.Property<int>("Id_Request")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Transport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Admin_Pae");

                    b.HasIndex("Id_Request")
                        .IsUnique();

                    b.ToTable("SHIPMENTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.SUPPLIER", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("SUPPLIERS");
                });

            modelBuilder.Entity("RRS_Controller.Models.UNIT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name_Unit")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("UNITS");
                });

            modelBuilder.Entity("RRS_Controller.Models.USER", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Id_Role")
                        .HasColumnType("int");

                    b.Property<string>("Name_User")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("Id_Role");

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("RRS_Controller.Models.ADMIN_PAE", b =>
                {
                    b.HasOne("RRS_Controller.Models.USER", "USER")
                        .WithOne("ADMIN_PAE")
                        .HasForeignKey("RRS_Controller.Models.ADMIN_PAE", "Id_User")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("USER");
                });

            modelBuilder.Entity("RRS_Controller.Models.EVALUATION", b =>
                {
                    b.HasOne("RRS_Controller.Models.SECRETARY_INTS", "SECRETARY_INTS")
                        .WithMany("EVALUATIONS")
                        .HasForeignKey("Id_Secretary_Inst")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.SHIPMENT", "SHIPMENT")
                        .WithOne("EVALUATION")
                        .HasForeignKey("RRS_Controller.Models.EVALUATION", "Id_Shipment")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("SECRETARY_INTS");

                    b.Navigation("SHIPMENT");
                });

            modelBuilder.Entity("RRS_Controller.Models.FOOD", b =>
                {
                    b.HasOne("RRS_Controller.Models.NUTRITIONITS_PAE", "NUTRITIONITS_PAE")
                        .WithMany("FOODS")
                        .HasForeignKey("Id_Nutritionits_Pae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NUTRITIONITS_PAE");
                });

            modelBuilder.Entity("RRS_Controller.Models.FOOD_PRODUCT", b =>
                {
                    b.HasOne("RRS_Controller.Models.FOOD", "FOOD")
                        .WithMany("FOOD_PRODUCTS")
                        .HasForeignKey("Id_Food")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.PRODUCT", "PRODUCT")
                        .WithMany("FOOD_PRODUCTS")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FOOD");

                    b.Navigation("PRODUCT");
                });

            modelBuilder.Entity("RRS_Controller.Models.INSTITUTION", b =>
                {
                    b.HasOne("RRS_Controller.Models.MANAGER_PAE", "MANAGER_PAE")
                        .WithMany("INSTITUTIONS")
                        .HasForeignKey("Id_Manager")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MANAGER_PAE");
                });

            modelBuilder.Entity("RRS_Controller.Models.MANAGER_PAE", b =>
                {
                    b.HasOne("RRS_Controller.Models.USER", "USER")
                        .WithOne("MANAGER_PAE")
                        .HasForeignKey("RRS_Controller.Models.MANAGER_PAE", "Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("USER");
                });

            modelBuilder.Entity("RRS_Controller.Models.MENU", b =>
                {
                    b.HasOne("RRS_Controller.Models.CATEGORY", "CATEGORY")
                        .WithMany("MENUS")
                        .HasForeignKey("Id_Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.NUTRITIONITS_PAE", "NUTRITIONITS_PAE")
                        .WithMany("MENUS")
                        .HasForeignKey("Id_Nutritionits_Pae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CATEGORY");

                    b.Navigation("NUTRITIONITS_PAE");
                });

            modelBuilder.Entity("RRS_Controller.Models.MENU_FOOD", b =>
                {
                    b.HasOne("RRS_Controller.Models.FOOD", "FOOD")
                        .WithMany("MENU_FOODS")
                        .HasForeignKey("Id_Food")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.MENU", "MENU")
                        .WithMany("MENU_FOODS")
                        .HasForeignKey("Id_Menu")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FOOD");

                    b.Navigation("MENU");
                });

            modelBuilder.Entity("RRS_Controller.Models.NUTRITIONITS_INTS", b =>
                {
                    b.HasOne("RRS_Controller.Models.ADMIN_PAE", "ADMIN_PAE")
                        .WithMany("NUTRITIONITS_INTSs")
                        .HasForeignKey("Id_Admin_Pae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.INSTITUTION", "INSTITUTION")
                        .WithMany("NUTRITIONITS_INTSs")
                        .HasForeignKey("Id_Institution")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.USER", "USER")
                        .WithOne("NUTRITIONITS_INTS")
                        .HasForeignKey("RRS_Controller.Models.NUTRITIONITS_INTS", "Id_User")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ADMIN_PAE");

                    b.Navigation("INSTITUTION");

                    b.Navigation("USER");
                });

            modelBuilder.Entity("RRS_Controller.Models.NUTRITIONITS_PAE", b =>
                {
                    b.HasOne("RRS_Controller.Models.USER", "USER")
                        .WithOne("NUTRITIONITS_PAE")
                        .HasForeignKey("RRS_Controller.Models.NUTRITIONITS_PAE", "Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("USER");
                });

            modelBuilder.Entity("RRS_Controller.Models.PRODUCT", b =>
                {
                    b.HasOne("RRS_Controller.Models.ADMIN_PAE", "ADMIN_PAE")
                        .WithMany("PRODUCTS")
                        .HasForeignKey("Id_Admin_Pae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.SUPPLIER", "SUPPLIER")
                        .WithMany("PRODUCTS")
                        .HasForeignKey("Id_Supplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.UNIT", "UNIT")
                        .WithMany("PRODUCTS")
                        .HasForeignKey("Id_Unit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ADMIN_PAE");

                    b.Navigation("SUPPLIER");

                    b.Navigation("UNIT");
                });

            modelBuilder.Entity("RRS_Controller.Models.REQUEST", b =>
                {
                    b.HasOne("RRS_Controller.Models.NUTRITIONITS_INTS", "NUTRITIONITS_INTS")
                        .WithMany("REQUESTS")
                        .HasForeignKey("Id_Nutritionits_Ints")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NUTRITIONITS_INTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.REQUEST_MENU", b =>
                {
                    b.HasOne("RRS_Controller.Models.MENU", "MENU")
                        .WithMany("REQUEST_MENUS")
                        .HasForeignKey("Id_Menu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.REQUEST", "REQUEST")
                        .WithMany("REQUEST_MENUS")
                        .HasForeignKey("Id_Request")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MENU");

                    b.Navigation("REQUEST");
                });

            modelBuilder.Entity("RRS_Controller.Models.SECRETARY_INTS", b =>
                {
                    b.HasOne("RRS_Controller.Models.ADMIN_PAE", "ADMIN_PAE")
                        .WithMany("SECRETARY_INTSs")
                        .HasForeignKey("Id_Admin_Pae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.INSTITUTION", "INSTITUTION")
                        .WithMany("SECRETARY_INTSs")
                        .HasForeignKey("Id_Institution")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.USER", "USER")
                        .WithOne("SECRETARY_INTS")
                        .HasForeignKey("RRS_Controller.Models.SECRETARY_INTS", "Id_User")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ADMIN_PAE");

                    b.Navigation("INSTITUTION");

                    b.Navigation("USER");
                });

            modelBuilder.Entity("RRS_Controller.Models.SHIPMENT", b =>
                {
                    b.HasOne("RRS_Controller.Models.ADMIN_PAE", "ADMIN_PAE")
                        .WithMany("SHIPMENTS")
                        .HasForeignKey("Id_Admin_Pae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RRS_Controller.Models.REQUEST", "REQUEST")
                        .WithOne("SHIPMENT")
                        .HasForeignKey("RRS_Controller.Models.SHIPMENT", "Id_Request")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ADMIN_PAE");

                    b.Navigation("REQUEST");
                });

            modelBuilder.Entity("RRS_Controller.Models.USER", b =>
                {
                    b.HasOne("RRS_Controller.Models.ROLE", "ROLE")
                        .WithMany("USERS")
                        .HasForeignKey("Id_Role")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ROLE");
                });

            modelBuilder.Entity("RRS_Controller.Models.ADMIN_PAE", b =>
                {
                    b.Navigation("NUTRITIONITS_INTSs");

                    b.Navigation("PRODUCTS");

                    b.Navigation("SECRETARY_INTSs");

                    b.Navigation("SHIPMENTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.CATEGORY", b =>
                {
                    b.Navigation("MENUS");
                });

            modelBuilder.Entity("RRS_Controller.Models.FOOD", b =>
                {
                    b.Navigation("FOOD_PRODUCTS");

                    b.Navigation("MENU_FOODS");
                });

            modelBuilder.Entity("RRS_Controller.Models.INSTITUTION", b =>
                {
                    b.Navigation("NUTRITIONITS_INTSs");

                    b.Navigation("SECRETARY_INTSs");
                });

            modelBuilder.Entity("RRS_Controller.Models.MANAGER_PAE", b =>
                {
                    b.Navigation("INSTITUTIONS");
                });

            modelBuilder.Entity("RRS_Controller.Models.MENU", b =>
                {
                    b.Navigation("MENU_FOODS");

                    b.Navigation("REQUEST_MENUS");
                });

            modelBuilder.Entity("RRS_Controller.Models.NUTRITIONITS_INTS", b =>
                {
                    b.Navigation("REQUESTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.NUTRITIONITS_PAE", b =>
                {
                    b.Navigation("FOODS");

                    b.Navigation("MENUS");
                });

            modelBuilder.Entity("RRS_Controller.Models.PRODUCT", b =>
                {
                    b.Navigation("FOOD_PRODUCTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.REQUEST", b =>
                {
                    b.Navigation("REQUEST_MENUS");

                    b.Navigation("SHIPMENT")
                        .IsRequired();
                });

            modelBuilder.Entity("RRS_Controller.Models.ROLE", b =>
                {
                    b.Navigation("USERS");
                });

            modelBuilder.Entity("RRS_Controller.Models.SECRETARY_INTS", b =>
                {
                    b.Navigation("EVALUATIONS");
                });

            modelBuilder.Entity("RRS_Controller.Models.SHIPMENT", b =>
                {
                    b.Navigation("EVALUATION")
                        .IsRequired();
                });

            modelBuilder.Entity("RRS_Controller.Models.SUPPLIER", b =>
                {
                    b.Navigation("PRODUCTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.UNIT", b =>
                {
                    b.Navigation("PRODUCTS");
                });

            modelBuilder.Entity("RRS_Controller.Models.USER", b =>
                {
                    b.Navigation("ADMIN_PAE")
                        .IsRequired();

                    b.Navigation("MANAGER_PAE")
                        .IsRequired();

                    b.Navigation("NUTRITIONITS_INTS")
                        .IsRequired();

                    b.Navigation("NUTRITIONITS_PAE")
                        .IsRequired();

                    b.Navigation("SECRETARY_INTS")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
