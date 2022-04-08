﻿// <auto-generated />
using System;
using DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VisitedPlaces_razor.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220408170727_FixedSomeProperties")]
    partial class FixedSomeProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CityId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BestMemory")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryRegionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCapital")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("CountryRegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Domain.Entities.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ContinentId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Continents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Asia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Europe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Africa"
                        },
                        new
                        {
                            Id = 4,
                            Name = "North America"
                        },
                        new
                        {
                            Id = 5,
                            Name = "South America"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Antarctica"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Oceania"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("MainLanguage")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TimesVisited")
                        .HasColumnType("int");

                    b.Property<int?>("YearVisited")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Domain.Entities.CountryRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryRegionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("CountryRegions");
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.HasOne("Domain.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.HasOne("Domain.Entities.CountryRegion", "CountryRegion")
                        .WithMany("Cities")
                        .HasForeignKey("CountryRegionId");

                    b.Navigation("Country");

                    b.Navigation("CountryRegion");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.HasOne("Domain.Entities.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId");

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("Domain.Entities.CountryRegion", b =>
                {
                    b.HasOne("Domain.Entities.Country", "Country")
                        .WithMany("CountryRegions")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Domain.Entities.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("CountryRegions");
                });

            modelBuilder.Entity("Domain.Entities.CountryRegion", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
