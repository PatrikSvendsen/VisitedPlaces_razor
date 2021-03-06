// <auto-generated />
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
    [Migration("20220402224159_AddedDataToWorldRegion")]
    partial class AddedDataToWorldRegion
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

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryRegionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCapital")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Population")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("CountryRegionId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MainLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Population")
                        .HasColumnType("int");

                    b.Property<string>("SecondLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimesVisited")
                        .HasColumnType("int");

                    b.Property<int?>("WorldRegionId")
                        .HasColumnType("int");

                    b.Property<int?>("YearVisited")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorldRegionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Domain.Entities.CountryRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CountryRegionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Population")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("CountryRegions");
                });

            modelBuilder.Entity("Domain.Entities.WorldRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WorldRegionId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Population")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("WorldRegions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Asia",
                            Population = 4400000000L
                        },
                        new
                        {
                            Id = 2,
                            Name = "Europe",
                            Population = 746419440L
                        });
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
                    b.HasOne("Domain.Entities.WorldRegion", "WorldRegion")
                        .WithMany("Countries")
                        .HasForeignKey("WorldRegionId");

                    b.Navigation("WorldRegion");
                });

            modelBuilder.Entity("Domain.Entities.CountryRegion", b =>
                {
                    b.HasOne("Domain.Entities.Country", "Country")
                        .WithMany("CountryRegions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
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

            modelBuilder.Entity("Domain.Entities.WorldRegion", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
