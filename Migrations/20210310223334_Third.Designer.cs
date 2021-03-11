﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitorManagementSystem.Data;

namespace VisitorManagementSystem.Migrations
{
    [DbContext(typeof(VisitorDbContext))]
    [Migration("20210310223334_Third")]
    partial class Third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VisitorManagementSystem.Models.StaffNames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitorCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StaffNames");
                });

            modelBuilder.Entity("VisitorManagementSystem.Models.Visitors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Business")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StaffNameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StaffNameId");

                    b.ToTable("Visitor");
                });

            modelBuilder.Entity("VisitorManagementSystem.Models.Visitors", b =>
                {
                    b.HasOne("VisitorManagementSystem.Models.StaffNames", "StaffName")
                        .WithMany()
                        .HasForeignKey("StaffNameId");

                    b.Navigation("StaffName");
                });
#pragma warning restore 612, 618
        }
    }
}
