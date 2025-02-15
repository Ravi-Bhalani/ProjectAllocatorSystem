﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectAllocatorSystemAPI.Data;

#nullable disable

namespace ProjectAllocatorSystemAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Dtos.SPDto", b =>
                {
                    b.Property<DateTime?>("BenchEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BenchStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingId")
                        .HasColumnType("int");

                    b.Property<string>("TrainingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typeId")
                        .HasColumnType("int");

                    b.ToView(null);
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Allocation", b =>
                {
                    b.Property<int>("AllocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllocationId"), 1L, 1);

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InternalProjectId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TrainingId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("AllocationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("InternalProjectId");

                    b.HasIndex("TrainingId");

                    b.HasIndex("TypeId");

                    b.ToTable("Allocations");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.AllocationType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("AllocationTypes");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime?>("BenchEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BenchStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("JobRoleId");

                    b.HasIndex("SkillId");

                    b.HasIndex("TypeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.EmployeeSkills", b =>
                {
                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int>("SId")
                        .HasColumnType("int");

                    b.HasKey("EmpId", "SId");

                    b.HasIndex("SId");

                    b.ToTable("EmployeeSkills");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.InternalProject", b =>
                {
                    b.Property<int>("InternalProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InternalProjectId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InternalProjectId");

                    b.ToTable("InternalProjects");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.JobRole", b =>
                {
                    b.Property<int>("JobRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobRoleId"), 1L, 1);

                    b.Property<string>("JobRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobRoleId");

                    b.ToTable("JobRoles");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.SecurityQuestion", b =>
                {
                    b.Property<int>("SecurityQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SecurityQuestionId"), 1L, 1);

                    b.Property<string>("SecurityQuestionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SecurityQuestionId");

                    b.ToTable("SecurityQuestions");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Training", b =>
                {
                    b.Property<int>("TrainingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainingId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LoginId")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("SecurityQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserRoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("SecurityQuestionId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleId"), 1L, 1);

                    b.Property<string>("UserRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Allocation", b =>
                {
                    b.HasOne("ProjectAllocatorSystemAPI.Models.Employee", "Employee")
                        .WithMany("Allocations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.InternalProject", "InternalProject")
                        .WithMany()
                        .HasForeignKey("InternalProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.AllocationType", "AllocationType")
                        .WithMany("Allocations")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllocationType");

                    b.Navigation("Employee");

                    b.Navigation("InternalProject");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Employee", b =>
                {
                    b.HasOne("ProjectAllocatorSystemAPI.Models.JobRole", "JobRole")
                        .WithMany("Employees")
                        .HasForeignKey("JobRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId");

                    b.HasOne("ProjectAllocatorSystemAPI.Models.AllocationType", "Allocationtype")
                        .WithMany("Employees")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Allocationtype");

                    b.Navigation("JobRole");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.EmployeeSkills", b =>
                {
                    b.HasOne("ProjectAllocatorSystemAPI.Models.Employee", "Employees")
                        .WithMany("EmployeeSkills")
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.Skill", "Skill")
                        .WithMany("EmployeeSkills")
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.User", b =>
                {
                    b.HasOne("ProjectAllocatorSystemAPI.Models.SecurityQuestion", "SecurityQuestion")
                        .WithMany()
                        .HasForeignKey("SecurityQuestionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ProjectAllocatorSystemAPI.Models.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("SecurityQuestion");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.AllocationType", b =>
                {
                    b.Navigation("Allocations");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Employee", b =>
                {
                    b.Navigation("Allocations");

                    b.Navigation("EmployeeSkills");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.JobRole", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ProjectAllocatorSystemAPI.Models.Skill", b =>
                {
                    b.Navigation("EmployeeSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
