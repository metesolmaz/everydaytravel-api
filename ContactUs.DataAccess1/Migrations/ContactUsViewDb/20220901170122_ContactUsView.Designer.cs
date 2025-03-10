﻿// <auto-generated />
using ContactUs.DataAccess1.Admin.ContactUsViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactUs.DataAccess1.Migrations.ContactUsViewDb
{
    [DbContext(typeof(ContactUsViewDbContext))]
    [Migration("20220901170122_ContactUsView")]
    partial class ContactUsView
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactUs.Entities1.Admin.ContactUsViews.ContactUsView", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdressDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdressHeader")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ButtonText")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContactDescriptionJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactHeader")
                        .HasColumnType("nvarchar(90)")
                        .HasMaxLength(90);

                    b.Property<string>("InputMailText")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("InputMessageText")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<string>("InputNameText")
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("InputPhoneText")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<string>("MainHeader")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("MainImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("ContactUsView");
                });
#pragma warning restore 612, 618
        }
    }
}
