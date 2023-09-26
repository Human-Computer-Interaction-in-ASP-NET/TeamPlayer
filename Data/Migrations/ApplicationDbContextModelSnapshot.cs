﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamPlayer.Models;

#nullable disable

namespace TeamPlayer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeamPlayer.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamName");

                    b.ToTable("Player", (string)null);

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            FirstName = "Sven",
                            LastName = "Baertschi",
                            Position = "Forward",
                            TeamName = "Canucks"
                        },
                        new
                        {
                            PlayerId = 2,
                            FirstName = "Hendrik",
                            LastName = "Sedin",
                            Position = "Left Wing",
                            TeamName = "Canucks"
                        },
                        new
                        {
                            PlayerId = 3,
                            FirstName = "John",
                            LastName = "Rooster",
                            Position = "Right Wing",
                            TeamName = "Flames"
                        },
                        new
                        {
                            PlayerId = 4,
                            FirstName = "Bob",
                            LastName = "Plumber",
                            Position = "Defense",
                            TeamName = "Oilers"
                        });
                });

            modelBuilder.Entity("TeamPlayer.Models.Team", b =>
                {
                    b.Property<string>("TeamName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamName");

                    b.ToTable("Team", (string)null);

                    b.HasData(
                        new
                        {
                            TeamName = "Canucks",
                            City = "Vancouver",
                            Country = "Canada",
                            Province = "BC"
                        },
                        new
                        {
                            TeamName = "Sharks",
                            City = "San Jose",
                            Country = "USA",
                            Province = "CA"
                        },
                        new
                        {
                            TeamName = "Oilers",
                            City = "Edmonton",
                            Country = "Canada",
                            Province = "AB"
                        },
                        new
                        {
                            TeamName = "Flames",
                            City = "Calgary",
                            Country = "Canada",
                            Province = "AB"
                        },
                        new
                        {
                            TeamName = "Leafs",
                            City = "Toronto",
                            Country = "Canada",
                            Province = "ON"
                        },
                        new
                        {
                            TeamName = "Ducks",
                            City = "Anaheim",
                            Country = "USA",
                            Province = "CA"
                        },
                        new
                        {
                            TeamName = "Lightening",
                            City = "Tampa Bay",
                            Country = "USA",
                            Province = "FL"
                        },
                        new
                        {
                            TeamName = "Blackhawks",
                            City = "Chicago",
                            Country = "USA",
                            Province = "IL"
                        });
                });

            modelBuilder.Entity("TeamPlayer.Models.Player", b =>
                {
                    b.HasOne("TeamPlayer.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("TeamPlayer.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
