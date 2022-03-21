﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220321170738_f")]
    partial class f
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DomainLayer.Model.EmployeeDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<int>("AgeInYears")
                        .HasColumnType("INT")
                        .HasColumnName("Employee_Age");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("VARCHAR(250)")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Employee_Designation");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Employee_Education");

                    b.Property<int>("Experience")
                        .HasColumnType("INT")
                        .HasColumnName("Employee_Experience");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("First_Name");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("Last_Name");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("VARCHAR(250)")
                        .HasColumnName("ModifiedBy");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("DateTime")
                        .HasColumnName("ModifiedDate");

                    b.HasKey("Id")
                        .HasName("pk_empId");

                    b.ToTable("EmployeeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
