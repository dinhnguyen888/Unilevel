﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Unilevel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241201080812_fixSomething")]
    partial class fixSomething
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ImplementationDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitCalendarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisitCalendarId");

                    b.ToTable("ImplementationDate");
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

            modelBuilder.Entity("Unilevel.Models.Area", b =>
                {
                    b.Property<string>("AreaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AreaId");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("Unilevel.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ArticleUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Unilevel.Models.CommentForJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("UserComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("CommentForJob");
                });

            modelBuilder.Entity("Unilevel.Models.GroupRole", b =>
                {
                    b.Property<int>("GroupRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupRoleId"), 1L, 1);

                    b.Property<string>("GroupRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupRoleId");

                    b.ToTable("GroupRole");

                    b.HasData(
                        new
                        {
                            GroupRoleId = 1,
                            GroupRoleName = "SystemUser"
                        },
                        new
                        {
                            GroupRoleId = 2,
                            GroupRoleName = "Sale"
                        },
                        new
                        {
                            GroupRoleId = 3,
                            GroupRoleName = "Distributor"
                        },
                        new
                        {
                            GroupRoleId = 4,
                            GroupRoleName = "Guest"
                        });
                });

            modelBuilder.Entity("Unilevel.Models.JobDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LinkFileForCreatorReporter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkFileForWorkingPerson")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobDetail");
                });

            modelBuilder.Entity("Unilevel.Models.JobForVisitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Creator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobStatus")
                        .HasColumnType("int");

                    b.Property<string>("Reporter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitCalendarId")
                        .HasColumnType("int");

                    b.Property<string>("WorkingPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("VisitCalendarId");

                    b.ToTable("JobForVisitation");
                });

            modelBuilder.Entity("Unilevel.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ImportTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MediaLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MediaTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Unilevel.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PermissionId"), 1L, 1);

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("Unilevel.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValue("Unknown");

                    b.HasKey("Id");

                    b.HasIndex("GroupRoleId");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d9f42387-0e28-4457-9f80-36a688d9cdc8",
                            ConcurrencyStamp = "cec2f83a-be9f-44df-a275-1c866b76a2e7",
                            GroupRoleId = 1,
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "cfc93bc2-433a-484b-a297-350318a8c12a",
                            ConcurrencyStamp = "97f93ca9-9f65-4680-b22e-95bb9822a772",
                            GroupRoleId = 1,
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "9eac5a62-2bbb-4496-8735-813a40b73e92",
                            ConcurrencyStamp = "8440827b-b89c-40c0-bebf-6943fedd2d76",
                            GroupRoleId = 2,
                            Name = "VPCD",
                            NormalizedName = "VPCD"
                        },
                        new
                        {
                            Id = "15cb3fb3-454a-4810-99e7-d125ecfe7a78",
                            ConcurrencyStamp = "9a446dcf-6217-451f-86d6-c24f6fde250e",
                            GroupRoleId = 2,
                            Name = "BM",
                            NormalizedName = "BM"
                        },
                        new
                        {
                            Id = "caa8f5da-16ae-40bd-ad7f-056d2a8e3888",
                            ConcurrencyStamp = "f190f3ba-6fec-4173-9c2d-061f3e251df9",
                            GroupRoleId = 2,
                            Name = "ChannelActivationHead",
                            NormalizedName = "CHANNEL ACTIVATION HEAD"
                        },
                        new
                        {
                            Id = "5dc4641b-0268-4670-87e5-04aa7db716e7",
                            ConcurrencyStamp = "afca3e99-e010-4797-a3f1-3c33b892b6a6",
                            GroupRoleId = 2,
                            Name = "ASM",
                            NormalizedName = "ASM"
                        },
                        new
                        {
                            Id = "e27b4a54-2d10-4f09-b2e0-3c6704389807",
                            ConcurrencyStamp = "4e4247e5-0c67-40de-9f24-af6b4f22702e",
                            GroupRoleId = 2,
                            Name = "BAM",
                            NormalizedName = "BAM"
                        },
                        new
                        {
                            Id = "5790efdd-fdbd-41f5-9767-44263c589dd8",
                            ConcurrencyStamp = "d160d201-0c21-494a-86ae-49287c7cc76f",
                            GroupRoleId = 2,
                            Name = "CE",
                            NormalizedName = "CE – CAPABILITY EXECUTIVE"
                        },
                        new
                        {
                            Id = "36723cae-7b7d-4758-8676-2d55df5e4ffa",
                            ConcurrencyStamp = "27e18e22-35fc-442f-99a6-01ca207b68a4",
                            GroupRoleId = 2,
                            Name = "SaleSUP",
                            NormalizedName = "SALE SUP – SALE SUPERVISOR"
                        },
                        new
                        {
                            Id = "72317f3f-5d5e-4311-816f-281d53d4070a",
                            ConcurrencyStamp = "b62a0f77-9623-497c-aced-e60d6948f9a4",
                            GroupRoleId = 3,
                            Name = "distributorOMTL",
                            NormalizedName = "DISTRIBUTOROMTL"
                        },
                        new
                        {
                            Id = "e3b307e0-e720-4c6e-9d24-8205694a90c6",
                            ConcurrencyStamp = "2f582d4d-0fa1-48b2-98e8-b85d172f1861",
                            GroupRoleId = 4,
                            Name = "OtherDepartment",
                            NormalizedName = "OTHER DEPARTMENT"
                        },
                        new
                        {
                            Id = "2176c1ea-536b-4761-8ba5-ba49780bf3d2",
                            ConcurrencyStamp = "d4ab2a0a-a2c9-4009-90e4-c0a18257de5a",
                            GroupRoleId = 4,
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        });
                });

            modelBuilder.Entity("Unilevel.Models.RolePermission", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("Unilevel.Models.SaleDistributor", b =>
                {
                    b.Property<string>("DistributorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SaleStaffId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DistributorId", "SaleStaffId");

                    b.HasIndex("SaleStaffId");

                    b.ToTable("SaleDistributors", (string)null);
                });

            modelBuilder.Entity("Unilevel.Models.VisitCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CalendarCreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DistributorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImplementationTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VisitCalendarStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VisitPurpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CalendarCreatorId");

                    b.HasIndex("DistributorId");

                    b.ToTable("VisitCalendar");
                });

            modelBuilder.Entity("Unilevel.Models.Visitor", b =>
                {
                    b.Property<string>("VisitorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VisitCalendarId")
                        .HasColumnType("int");

                    b.HasKey("VisitorId", "VisitCalendarId");

                    b.HasIndex("VisitCalendarId");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AreaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("JoinDate")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("PathPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Reporter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Unilevel.Models.Distributor", b =>
                {
                    b.HasBaseType("User");

                    b.Property<string>("SaleManagementId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Distributors", (string)null);
                });

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.HasBaseType("User");

                    b.Property<string>("ManagerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("SaleStaff", (string)null);
                });

            modelBuilder.Entity("ImplementationDate", b =>
                {
                    b.HasOne("Unilevel.Models.VisitCalendar", "VisitCalendar")
                        .WithMany("ImplementationDates")
                        .HasForeignKey("VisitCalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisitCalendar");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Unilevel.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Unilevel.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Unilevel.Models.CommentForJob", b =>
                {
                    b.HasOne("Unilevel.Models.JobDetail", "JobDetail")
                        .WithMany("CommentForJob")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobDetail");
                });

            modelBuilder.Entity("Unilevel.Models.JobDetail", b =>
                {
                    b.HasOne("Unilevel.Models.JobForVisitation", null)
                        .WithOne("JobDetail")
                        .HasForeignKey("Unilevel.Models.JobDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Unilevel.Models.JobForVisitation", b =>
                {
                    b.HasOne("Unilevel.Models.VisitCalendar", "VisitCalendar")
                        .WithMany()
                        .HasForeignKey("VisitCalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisitCalendar");
                });

            modelBuilder.Entity("Unilevel.Models.Role", b =>
                {
                    b.HasOne("Unilevel.Models.GroupRole", "GroupRole")
                        .WithMany()
                        .HasForeignKey("GroupRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GroupRole");
                });

            modelBuilder.Entity("Unilevel.Models.RolePermission", b =>
                {
                    b.HasOne("Unilevel.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unilevel.Models.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Unilevel.Models.SaleDistributor", b =>
                {
                    b.HasOne("Unilevel.Models.Distributor", "Distributor")
                        .WithMany("SaleDistributors")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unilevel.Models.SaleStaff", "SaleStaff")
                        .WithMany("SaleDistributors")
                        .HasForeignKey("SaleStaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");

                    b.Navigation("SaleStaff");
                });

            modelBuilder.Entity("Unilevel.Models.VisitCalendar", b =>
                {
                    b.HasOne("User", "User")
                        .WithMany()
                        .HasForeignKey("CalendarCreatorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Unilevel.Models.Distributor", "Distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Unilevel.Models.Visitor", b =>
                {
                    b.HasOne("Unilevel.Models.VisitCalendar", "VisitCalendar")
                        .WithMany("Visitors")
                        .HasForeignKey("VisitCalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany()
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("VisitCalendar");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.HasOne("Unilevel.Models.Area", "Areas")
                        .WithMany()
                        .HasForeignKey("AreaId");

                    b.Navigation("Areas");
                });

            modelBuilder.Entity("Unilevel.Models.Distributor", b =>
                {
                    b.HasOne("User", null)
                        .WithOne()
                        .HasForeignKey("Unilevel.Models.Distributor", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.HasOne("User", null)
                        .WithOne()
                        .HasForeignKey("Unilevel.Models.SaleStaff", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Unilevel.Models.JobDetail", b =>
                {
                    b.Navigation("CommentForJob");
                });

            modelBuilder.Entity("Unilevel.Models.JobForVisitation", b =>
                {
                    b.Navigation("JobDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Unilevel.Models.Role", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("Unilevel.Models.VisitCalendar", b =>
                {
                    b.Navigation("ImplementationDates");

                    b.Navigation("Visitors");
                });

            modelBuilder.Entity("Unilevel.Models.Distributor", b =>
                {
                    b.Navigation("SaleDistributors");
                });

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.Navigation("SaleDistributors");
                });
#pragma warning restore 612, 618
        }
    }
}