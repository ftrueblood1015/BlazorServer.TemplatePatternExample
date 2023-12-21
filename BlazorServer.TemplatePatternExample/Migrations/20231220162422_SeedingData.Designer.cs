﻿// <auto-generated />
using System;
using BlazorServer.TemplatePatternExample.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServer.TemplatePatternExample.Migrations
{
    [DbContext(typeof(TemplatePatternContext))]
    [Migration("20231220162422_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("BlazorServer.TemplatePatternExample.Domain.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ManagerId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "IT",
                            Description = "IT Employee",
                            IsActive = true,
                            ManagerId = 1,
                            Name = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            Department = "IT",
                            Description = "IT Employee",
                            IsActive = true,
                            ManagerId = 1,
                            Name = "Thorton"
                        });
                });

            modelBuilder.Entity("BlazorServer.TemplatePatternExample.Domain.Models.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "IT",
                            Description = "IT Manager",
                            IsActive = true,
                            Name = "Billy "
                        });
                });

            modelBuilder.Entity("BlazorServer.TemplatePatternExample.Domain.Models.Employee", b =>
                {
                    b.HasOne("BlazorServer.TemplatePatternExample.Domain.Models.Manager", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });
#pragma warning restore 612, 618
        }
    }
}
