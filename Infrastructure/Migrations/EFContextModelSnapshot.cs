﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Infrastructure.Persistence.DataBases;

#nullable disable

namespace Infrastructure.Migrations;

[DbContext(typeof(EFContext))]
partial class EFContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.4")
            .HasAnnotation("Relational:MaxIdentifierLength", 63);

        NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

        modelBuilder.Entity("Domain.Entities.Customer", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<string>("Address")
                    .HasColumnType("text");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("character varying(100)");

                b.Property<string>("FullName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("character varying(100)");

                b.Property<string>("PhoneNumber")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("character varying(100)");

                b.HasKey("Id");

                b.ToTable("Customer");
            });

        modelBuilder.Entity("Domain.Entities.MenuItem", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<string>("Category")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnType("character varying(256)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("character varying(100)");

                b.Property<decimal>("Price")
                    .HasPrecision(18, 2)
                    .HasColumnType("numeric(18,2)");

                b.HasKey("Id");

                b.ToTable("MenuItem");
            });

        modelBuilder.Entity("Domain.Entities.Order", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<int>("CustomerId")
                    .HasColumnType("integer");

                b.Property<string>("Location")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("character varying(100)");

                b.Property<DateTime>("OrderTime")
                    .HasColumnType("timestamp with time zone");

                b.Property<int>("TableId")
                    .HasColumnType("integer");

                b.Property<decimal>("TotalPrice")
                    .HasPrecision(18, 2)
                    .HasColumnType("numeric(18,2)");

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("CustomerId");

                b.HasIndex("TableId");

                b.ToTable("Order");
            });

        modelBuilder.Entity("Domain.Entities.OrderItem", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<double>("Count")
                    .HasColumnType("double precision");

                b.Property<int>("MenuItemId")
                    .HasColumnType("integer");

                b.Property<int?>("OrderId")
                    .HasColumnType("integer");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("MenuItemId");

                b.HasIndex("OrderId");

                b.ToTable("OrderItem");
            });

        modelBuilder.Entity("Domain.Entities.Payment", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<int>("OrderId")
                    .HasColumnType("integer");

                b.Property<decimal>("PaymentAmount")
                    .HasPrecision(18, 2)
                    .HasColumnType("numeric(18,2)");

                b.Property<DateTime>("PaymentDate")
                    .HasColumnType("timestamp with time zone");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<string>("Type")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("OrderId")
                    .IsUnique();

                b.ToTable("Payment");
            });

        modelBuilder.Entity("Domain.Entities.Reservation", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<int>("CustomerId")
                    .HasColumnType("integer");

                b.Property<DateTime>("Date")
                    .HasColumnType("timestamp with time zone");

                b.Property<int>("NumberOfGuests")
                    .HasColumnType("integer");

                b.HasKey("Id");

                b.HasIndex("CustomerId");

                b.ToTable("Reservation");
            });

        modelBuilder.Entity("Domain.Entities.Table", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                b.Property<int>("Capacity")
                    .HasColumnType("integer");

                b.Property<int>("Number")
                    .HasColumnType("integer");

                b.Property<int?>("OrderId")
                    .HasColumnType("integer");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("OrderId");

                b.ToTable("Table");
            });

        modelBuilder.Entity("Domain.Entities.Order", b =>
            {
                b.HasOne("Domain.Entities.Customer", "Customer")
                    .WithMany("Orders")
                    .HasForeignKey("CustomerId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("Domain.Entities.Table", "Table")
                    .WithMany("Orders")
                    .HasForeignKey("TableId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Customer");

                b.Navigation("Table");
            });

        modelBuilder.Entity("Domain.Entities.OrderItem", b =>
            {
                b.HasOne("Domain.Entities.MenuItem", "MenuItem")
                    .WithMany("Items")
                    .HasForeignKey("MenuItemId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("Domain.Entities.Order", null)
                    .WithMany("Items")
                    .HasForeignKey("OrderId");

                b.Navigation("MenuItem");
            });

        modelBuilder.Entity("Domain.Entities.Payment", b =>
            {
                b.HasOne("Domain.Entities.Order", "Order")
                    .WithOne("Payment")
                    .HasForeignKey("Domain.Entities.Payment", "OrderId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Order");
            });

        modelBuilder.Entity("Domain.Entities.Reservation", b =>
            {
                b.HasOne("Domain.Entities.Customer", "Customer")
                    .WithMany("Reservations")
                    .HasForeignKey("CustomerId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Customer");
            });

        modelBuilder.Entity("Domain.Entities.Table", b =>
            {
                b.HasOne("Domain.Entities.Order", null)
                    .WithMany("Tables")
                    .HasForeignKey("OrderId");
            });

        modelBuilder.Entity("Domain.Entities.Customer", b =>
            {
                b.Navigation("Orders");

                b.Navigation("Reservations");
            });

        modelBuilder.Entity("Domain.Entities.MenuItem", b =>
            {
                b.Navigation("Items");
            });

        modelBuilder.Entity("Domain.Entities.Order", b =>
            {
                b.Navigation("Items");

                b.Navigation("Payment");

                b.Navigation("Tables");
            });

        modelBuilder.Entity("Domain.Entities.Table", b =>
            {
                b.Navigation("Orders");
            });
#pragma warning restore 612, 618
    }
}
