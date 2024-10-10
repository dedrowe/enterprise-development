﻿// <auto-generated />
using System;
using DistrictEnterpriseStatisticalData.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DistrictEnterpriseStatisticalData.Domain.Migrations
{
    [DbContext(typeof(DistrictDbContext))]
    [Migration("20241007151708_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.Enterprise", b =>
                {
                    b.Property<int>("RegistrationNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RegistrationNumber"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("address");

                    b.Property<int>("EmployeesNumber")
                        .HasColumnType("integer")
                        .HasColumnName("employees_number");

                    b.Property<int>("EnterpriseTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("enterprise_type_id");

                    b.Property<int>("FormId")
                        .HasColumnType("integer")
                        .HasColumnName("form");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("phone_number");

                    b.Property<int>("TotalArea")
                        .HasColumnType("integer")
                        .HasColumnName("total_area");

                    b.HasKey("RegistrationNumber");

                    b.HasIndex("EnterpriseTypeId");

                    b.HasIndex("FormId");

                    b.ToTable("enterprise");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.EnterpriseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("enterprise_type");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.FormOfOwnership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Form")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("form");

                    b.HasKey("Id");

                    b.ToTable("form_of_ownership");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("supplier");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.Supply", b =>
                {
                    b.Property<int>("SupplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SupplyId"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<int>("EnterpriseRegistrationNumber")
                        .HasColumnType("integer")
                        .HasColumnName("enterprise_registration_number");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<int>("SupplierId")
                        .HasColumnType("integer");

                    b.HasKey("SupplyId");

                    b.HasIndex("EnterpriseRegistrationNumber");

                    b.HasIndex("SupplierId");

                    b.ToTable("supply");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.Enterprise", b =>
                {
                    b.HasOne("DistrictEnterpriseStatisticalData.Domain.Entity.EnterpriseType", "Type")
                        .WithMany("Enterprises")
                        .HasForeignKey("EnterpriseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DistrictEnterpriseStatisticalData.Domain.Entity.FormOfOwnership", "Form")
                        .WithMany("Enterprises")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.Supply", b =>
                {
                    b.HasOne("DistrictEnterpriseStatisticalData.Domain.Entity.Enterprise", "Enterprise")
                        .WithMany("Supplies")
                        .HasForeignKey("EnterpriseRegistrationNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DistrictEnterpriseStatisticalData.Domain.Entity.Supplier", "Supplier")
                        .WithMany("Supplies")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enterprise");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.Enterprise", b =>
                {
                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.EnterpriseType", b =>
                {
                    b.Navigation("Enterprises");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.FormOfOwnership", b =>
                {
                    b.Navigation("Enterprises");
                });

            modelBuilder.Entity("DistrictEnterpriseStatisticalData.Domain.Entity.Supplier", b =>
                {
                    b.Navigation("Supplies");
                });
#pragma warning restore 612, 618
        }
    }
}