﻿// <auto-generated />
using EFRelationships2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFRelationships2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFRelationships2.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Buses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Volvo",
                            NumberOfSeats = 40
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Mercedes",
                            NumberOfSeats = 45
                        });
                });

            modelBuilder.Entity("EFRelationships2.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusId = 1,
                            Name = "John"
                        },
                        new
                        {
                            Id = 2,
                            BusId = 2,
                            Name = "Mark"
                        },
                        new
                        {
                            Id = 3,
                            BusId = 1,
                            Name = "Sam"
                        },
                        new
                        {
                            Id = 4,
                            BusId = 1,
                            Name = "Linda"
                        },
                        new
                        {
                            Id = 5,
                            BusId = 2,
                            Name = "Frank"
                        });
                });

            modelBuilder.Entity("EFRelationships2.Passenger", b =>
                {
                    b.HasOne("EFRelationships2.Bus", "Bus")
                        .WithMany("PassengersList")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("EFRelationships2.Bus", b =>
                {
                    b.Navigation("PassengersList");
                });
#pragma warning restore 612, 618
        }
    }
}
