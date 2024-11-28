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
    [Migration("20241124145856_FixCalendar")]
    partial class FixCalendar
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

            modelBuilder.Entity("Unilevel.Models.Distributor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SaleManagementId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Distributor");
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

            modelBuilder.Entity("Unilevel.Models.JobForVisitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

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
                            Id = "f08cf211-45cf-4d6d-88cf-252ccb39bfbd",
                            ConcurrencyStamp = "d8d630a6-c805-4be2-9bc7-9726d8922c76",
                            GroupRoleId = 1,
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "8d73a2b6-0cb2-4858-8fa0-72693b44f9ec",
                            ConcurrencyStamp = "a7ffa22d-e7fc-4770-b22a-3e05ee77ba3c",
                            GroupRoleId = 1,
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "9d1c2d8e-fa23-484b-b053-8889d5e4577a",
                            ConcurrencyStamp = "e51fc4b1-2c39-4bd4-af63-0a9879a71b0e",
                            GroupRoleId = 2,
                            Name = "VPCD",
                            NormalizedName = "VPCD"
                        },
                        new
                        {
                            Id = "5265a80b-ffc5-451e-b532-6aa38ecf14b4",
                            ConcurrencyStamp = "d063776a-6808-4004-8e71-65315890e089",
                            GroupRoleId = 2,
                            Name = "BM",
                            NormalizedName = "BM"
                        },
                        new
                        {
                            Id = "50e1ce95-89ea-4df6-9d93-724d7df4b8a3",
                            ConcurrencyStamp = "ba79620f-07fb-4f2f-aee0-89ecb55f1701",
                            GroupRoleId = 2,
                            Name = "ChannelActivationHead",
                            NormalizedName = "CHANNEL ACTIVATION HEAD"
                        },
                        new
                        {
                            Id = "08e5eeed-42ef-4524-ae08-46bea02626bf",
                            ConcurrencyStamp = "adcf057f-ee5b-4ca5-b450-d94ae3886211",
                            GroupRoleId = 2,
                            Name = "ASM",
                            NormalizedName = "ASM"
                        },
                        new
                        {
                            Id = "7a67daf6-aae8-4fd4-a807-ab9939d95a9b",
                            ConcurrencyStamp = "83695d2c-42b6-488a-832c-03d7b9680bdc",
                            GroupRoleId = 2,
                            Name = "BAM",
                            NormalizedName = "BAM"
                        },
                        new
                        {
                            Id = "c3f79afa-019c-4516-a02f-a413ab296abd",
                            ConcurrencyStamp = "fbdc12b3-142c-4e79-880e-2038f3d3b6b9",
                            GroupRoleId = 2,
                            Name = "CE",
                            NormalizedName = "CE – CAPABILITY EXECUTIVE"
                        },
                        new
                        {
                            Id = "abd0f2c6-5a2a-409e-ac6f-0cf5cf30062b",
                            ConcurrencyStamp = "19fbea32-a2c9-412f-8b73-d296a5384029",
                            GroupRoleId = 2,
                            Name = "SaleSUP",
                            NormalizedName = "SALE SUP – SALE SUPERVISOR"
                        },
                        new
                        {
                            Id = "bb938050-b0d9-4b62-af5c-2d33e4765262",
                            ConcurrencyStamp = "70f416c5-b7a0-46b3-9ad4-482d2ed99bc6",
                            GroupRoleId = 3,
                            Name = "Distributor-OM/TL",
                            NormalizedName = "DISTRIBUTOR - OM/TL"
                        },
                        new
                        {
                            Id = "3f1f9fe0-5a9e-458f-939c-d6e275b934fa",
                            ConcurrencyStamp = "1b8ff8ae-8517-4f2d-9977-7add6040179f",
                            GroupRoleId = 4,
                            Name = "OtherDepartment",
                            NormalizedName = "OTHER DEPARTMENT"
                        },
                        new
                        {
                            Id = "7f13c7cf-8092-44d2-872a-518475a37af5",
                            ConcurrencyStamp = "cf573150-aeac-417c-b1df-85132c0fcdf3",
                            GroupRoleId = 4,
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        });
                });

            modelBuilder.Entity("Unilevel.Models.SaleDistributor", b =>
                {
                    b.Property<string>("DistributorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SaleStaffId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DistributorId", "SaleStaffId");

                    b.HasIndex("SaleStaffId");

                    b.ToTable("SaleDistributor");
                });

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SuperiorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SuperiorId");

                    b.ToTable("SaleStaff");
                });

            modelBuilder.Entity("Unilevel.Models.UserPermission", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("UserPermissions");
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

            modelBuilder.Entity("ImplementationDate", b =>
                {
                    b.HasOne("Unilevel.Models.VisitCalendar", "VisitCalendar")
                        .WithMany()
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

            modelBuilder.Entity("Unilevel.Models.SaleDistributor", b =>
                {
                    b.HasOne("Unilevel.Models.Distributor", "Distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unilevel.Models.SaleStaff", "SaleStaff")
                        .WithMany()
                        .HasForeignKey("SaleStaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");

                    b.Navigation("SaleStaff");
                });

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.HasOne("Unilevel.Models.SaleStaff", "Superior")
                        .WithMany("Inferiors")
                        .HasForeignKey("SuperiorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Superior");
                });

            modelBuilder.Entity("Unilevel.Models.UserPermission", b =>
                {
                    b.HasOne("Unilevel.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("User");
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

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.Navigation("Inferiors");
                });

            modelBuilder.Entity("Unilevel.Models.VisitCalendar", b =>
                {
                    b.Navigation("Visitors");
                });
#pragma warning restore 612, 618
        }
    }
}