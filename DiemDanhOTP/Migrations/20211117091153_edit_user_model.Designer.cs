﻿// <auto-generated />
using System;
using DiemDanhOTP.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiemDanhOTP.Migrations
{
    [DbContext(typeof(DiemDanhDBContext))]
    [Migration("20211117091153_edit_user_model")]
    partial class edit_user_model
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NOC")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.GroupSubject", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTeacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte?>("Semester")
                        .HasColumnType("tinyint");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("IdTeacher");

                    b.ToTable("GroupSubjects");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Session", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Classroom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdGroup")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PeriodEnd")
                        .HasColumnType("int");

                    b.Property<int?>("PeriodStart")
                        .HasColumnType("int");

                    b.Property<int?>("SessionNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGroup");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.SessionDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdSession")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdStuddent")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdSession");

                    b.HasIndex("IdStuddent");

                    b.ToTable("SessionDetails");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Student", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdUser")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IdUser")
                        .IsUnique()
                        .HasFilter("[IdUser] IS NOT NULL");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Study", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdGroupSubject")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdStudent")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte?>("Stt")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("IdGroupSubject");

                    b.HasIndex("IdStudent");

                    b.ToTable("Studies");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Teacher", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdUser")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IdUser")
                        .IsUnique()
                        .HasFilter("[IdUser] IS NOT NULL");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.GroupSubject", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("DiemDanhOTP.Core.Domain.Teacher", "Teacher")
                        .WithMany("GroupSubjects")
                        .HasForeignKey("IdTeacher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Session", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.GroupSubject", "GroupSubject")
                        .WithMany("Sessions")
                        .HasForeignKey("IdGroup");

                    b.Navigation("GroupSubject");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.SessionDetail", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.Session", "Session")
                        .WithMany("SessionDetails")
                        .HasForeignKey("IdSession");

                    b.HasOne("DiemDanhOTP.Core.Domain.Student", "Student")
                        .WithMany("SessionDetails")
                        .HasForeignKey("IdStuddent")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Session");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Student", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("DiemDanhOTP.Core.Domain.Student", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Study", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.GroupSubject", "GroupSubject")
                        .WithMany("Studies")
                        .HasForeignKey("IdGroupSubject");

                    b.HasOne("DiemDanhOTP.Core.Domain.Student", "Student")
                        .WithMany("Studies")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("GroupSubject");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Teacher", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("DiemDanhOTP.Core.Domain.Teacher", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiemDanhOTP.Core.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DiemDanhOTP.Core.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.GroupSubject", b =>
                {
                    b.Navigation("Sessions");

                    b.Navigation("Studies");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Session", b =>
                {
                    b.Navigation("SessionDetails");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Student", b =>
                {
                    b.Navigation("SessionDetails");

                    b.Navigation("Studies");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.Teacher", b =>
                {
                    b.Navigation("GroupSubjects");
                });

            modelBuilder.Entity("DiemDanhOTP.Core.Domain.User", b =>
                {
                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
