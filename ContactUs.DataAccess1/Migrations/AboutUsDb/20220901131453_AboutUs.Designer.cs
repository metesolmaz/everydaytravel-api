﻿// <auto-generated />
using ContactUs.DataAccess1.Admin.AboutUs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactUs.DataAccess1.Migrations.AboutUsDb
{
    [DbContext(typeof(AboutUsDbContext))]
    [Migration("20220901131453_AboutUs")]
    partial class AboutUs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactUs.Entities1.Admin.AboutUs.About", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BottomContent")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("BottomContentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BottomHeader")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("MainHeader")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MainImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MidContentImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MidContentJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopContentDescription")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("TopContentHeader")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("TopContentJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopImageLeft")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopImageRight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("About");
                });
#pragma warning restore 612, 618
        }
    }
}