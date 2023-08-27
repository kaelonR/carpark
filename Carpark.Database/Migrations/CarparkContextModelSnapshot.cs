﻿// <auto-generated />
using Carpark.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carpark.Database.Migrations
{
    [DbContext(typeof(CarparkContext))]
    partial class CarparkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Carpark.Database.Entities.Car", b =>
                {
                    b.Property<string>("LicensePlate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CarStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ConstructionYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LicensePlate");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
