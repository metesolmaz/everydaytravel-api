﻿// <auto-generated />
using ContactUs.DataAccess1.Admin.AllTours.TourDetail;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactUs.DataAccess1.Migrations.TourDetailsDb
{
    [DbContext(typeof(TourDetailsDbContext))]
    [Migration("20221004180707_TourDetails")]
    partial class TourDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactUs.Entities1.Admin.AllTours.TourDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("TourContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TourHeader")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("TourHeaderImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.Property<string>("TourImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ısPopular")
                        .HasColumnType("bit");

                    b.Property<bool>("ısVip")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("TourDetails");
                });
#pragma warning restore 612, 618
        }
    }
}