﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cwiczenie11.Models;

namespace cwiczenie11.Migrations
{
    [DbContext(typeof(MediDbContext))]
    [Migration("20200527164022_SeedAll")]
    partial class SeedAll
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cwiczenie11.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "doktor1@wp.pl",
                            FirstName = "Pati",
                            LastName = "Dan"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "doktor2@wp.pl",
                            FirstName = "Stefan",
                            LastName = "Bran"
                        });
                });

            modelBuilder.Entity("cwiczenie11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "heh",
                            Name = "Lewatywa",
                            Type = "niebezpieczne"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "nic",
                            Name = "wizyta",
                            Type = "normalna"
                        });
                });

            modelBuilder.Entity("cwiczenie11.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MyProperty")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPatient");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            IdPatient = 100,
                            FirstName = "Pit",
                            LastName = "Adamczyk",
                            MyProperty = new DateTime(2020, 5, 27, 18, 40, 22, 148, DateTimeKind.Local).AddTicks(6903)
                        },
                        new
                        {
                            IdPatient = 101,
                            FirstName = "Artur",
                            LastName = "Potep",
                            MyProperty = new DateTime(2020, 5, 27, 18, 40, 22, 152, DateTimeKind.Local).AddTicks(5876)
                        });
                });

            modelBuilder.Entity("cwiczenie11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoctorIdDoctor")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<int?>("PatientIdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("DoctorIdDoctor");

                    b.HasIndex("PatientIdPatient");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2020, 5, 27, 18, 40, 22, 153, DateTimeKind.Local).AddTicks(391),
                            DueDate = new DateTime(2020, 5, 27, 18, 40, 22, 153, DateTimeKind.Local).AddTicks(993),
                            IdDoctor = 1,
                            IdPatient = 100
                        });
                });

            modelBuilder.Entity("cwiczenie11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("IdMedicament");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Details = "cos tam",
                            Dose = 11,
                            IdMedicament = 1,
                            IdPrescription = 1
                        });
                });

            modelBuilder.Entity("cwiczenie11.Models.Prescription", b =>
                {
                    b.HasOne("cwiczenie11.Models.Doctor", null)
                        .WithMany("Prescription")
                        .HasForeignKey("DoctorIdDoctor");

                    b.HasOne("cwiczenie11.Models.Patient", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientIdPatient");
                });

            modelBuilder.Entity("cwiczenie11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("cwiczenie11.Models.Medicament", "Medicament")
                        .WithMany("all")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cwiczenie11.Models.Prescription", "Prescription")
                        .WithMany("all")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
