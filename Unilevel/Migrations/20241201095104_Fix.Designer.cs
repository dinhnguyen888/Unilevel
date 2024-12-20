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
    [Migration("20241201095104_Fix")]
    partial class Fix
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
                            Id = "43fcbc55-62f6-4a6f-b5e3-f022d3a786af",
                            ConcurrencyStamp = "f3d9181e-8329-4b35-94c8-0874ef38102b",
                            GroupRoleId = 1,
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "3a9f6c08-4644-48d6-affc-041a93476fc4",
                            ConcurrencyStamp = "2de1966f-34a6-42a3-925d-e88dbbcc3d64",
                            GroupRoleId = 1,
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "69257004-2ce1-49d2-9c55-06448658946d",
                            ConcurrencyStamp = "a649fcb8-34f0-4f8c-b126-539b41167fcf",
                            GroupRoleId = 2,
                            Name = "VPCD",
                            NormalizedName = "VPCD"
                        },
                        new
                        {
                            Id = "d4d5594d-57e7-4206-a783-32bf35340ab1",
                            ConcurrencyStamp = "3016db24-bd69-4173-af1f-da3319379956",
                            GroupRoleId = 2,
                            Name = "BM",
                            NormalizedName = "BM"
                        },
                        new
                        {
                            Id = "f3b06b85-f565-4cbe-821e-d25fde97a530",
                            ConcurrencyStamp = "9dc4d723-3c68-431f-b8f4-d99bcac953fd",
                            GroupRoleId = 2,
                            Name = "ChannelActivationHead",
                            NormalizedName = "CHANNEL ACTIVATION HEAD"
                        },
                        new
                        {
                            Id = "86e9eb6c-2448-4469-bab7-dca03c15656f",
                            ConcurrencyStamp = "70d8d824-5e35-46cf-807d-d271d99d0991",
                            GroupRoleId = 2,
                            Name = "ASM",
                            NormalizedName = "ASM"
                        },
                        new
                        {
                            Id = "404b9b70-2688-4641-bcf5-86f4e2dc71ff",
                            ConcurrencyStamp = "9052d320-0be0-45b1-84df-70a1f3814b24",
                            GroupRoleId = 2,
                            Name = "BAM",
                            NormalizedName = "BAM"
                        },
                        new
                        {
                            Id = "a20d4863-29f7-44ff-b25a-f187728263e0",
                            ConcurrencyStamp = "6e1fb461-1e4d-45d0-9772-4ac9086db5d8",
                            GroupRoleId = 2,
                            Name = "CE",
                            NormalizedName = "CE – CAPABILITY EXECUTIVE"
                        },
                        new
                        {
                            Id = "b1005c22-2911-448a-9812-f0fefa7c774e",
                            ConcurrencyStamp = "240c8f99-f299-4b06-ad34-8bbd6f7deb31",
                            GroupRoleId = 2,
                            Name = "SaleSUP",
                            NormalizedName = "SALE SUP – SALE SUPERVISOR"
                        },
                        new
                        {
                            Id = "9db239e1-53c1-4006-9dbb-1f1801e8f722",
                            ConcurrencyStamp = "d7ddc588-e2bc-45da-a5a4-efdd72b7e096",
                            GroupRoleId = 3,
                            Name = "distributorOMTL",
                            NormalizedName = "DISTRIBUTOROMTL"
                        },
                        new
                        {
                            Id = "1de05086-75f2-481a-9720-b32d0feb34d6",
                            ConcurrencyStamp = "955d6aa9-cf75-45c0-8657-a388563f8421",
                            GroupRoleId = 4,
                            Name = "OtherDepartment",
                            NormalizedName = "OTHER DEPARTMENT"
                        },
                        new
                        {
                            Id = "2bac841d-f2ad-44e8-b5f8-179b30c5d191",
                            ConcurrencyStamp = "c2889cec-c649-46ac-baa7-4160ed0c62c2",
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
