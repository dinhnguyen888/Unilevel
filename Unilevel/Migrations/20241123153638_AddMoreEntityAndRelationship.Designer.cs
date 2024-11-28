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
    [Migration("20241123153638_AddMoreEntityAndRelationship")]
    partial class AddMoreEntityAndRelationship
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

                    b.Property<string>("SaleManagementIdId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SaleManagementIdId");

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

                    b.Property<string>("WorkingPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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
                            Id = "7993ec28-e8ad-4275-8b59-633979c25ca1",
                            ConcurrencyStamp = "963fe1d3-a43e-47ea-ba7f-8d98426a34cc",
                            GroupRoleId = 1,
                            Name = "Owner",
                            NormalizedName = "OWNER"
                        },
                        new
                        {
                            Id = "53b61fc1-5d29-42a1-8acc-ad5e18c3cb1e",
                            ConcurrencyStamp = "f6e56b22-7d4d-41da-a67b-67663d1bfcac",
                            GroupRoleId = 1,
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "fb71c2e3-11b5-4530-9dc2-743e062d6a15",
                            ConcurrencyStamp = "bad0ac8c-5a30-4716-943f-58f78b06ae7d",
                            GroupRoleId = 2,
                            Name = "VPCD",
                            NormalizedName = "VPCD"
                        },
                        new
                        {
                            Id = "9c402e7d-7676-4082-8ac6-77e3c43e7e2f",
                            ConcurrencyStamp = "48a94ea6-05e4-4d8a-93eb-a77aca01a23d",
                            GroupRoleId = 2,
                            Name = "BM",
                            NormalizedName = "BM"
                        },
                        new
                        {
                            Id = "8853fb00-5075-4b63-b91e-953fb8ead8b2",
                            ConcurrencyStamp = "83bec652-8e5a-4ee8-a2b5-22b3f2cd859b",
                            GroupRoleId = 2,
                            Name = "ChannelActivationHead",
                            NormalizedName = "CHANNEL ACTIVATION HEAD"
                        },
                        new
                        {
                            Id = "f16de8db-1802-4222-a6a8-b1bc7544fb34",
                            ConcurrencyStamp = "8b901348-a47e-4090-aef9-abf7cdaf7fb9",
                            GroupRoleId = 2,
                            Name = "ASM",
                            NormalizedName = "ASM"
                        },
                        new
                        {
                            Id = "009f42a1-fe16-4293-8e7a-abaf4e288e5f",
                            ConcurrencyStamp = "691097da-fb4e-457e-a5ae-c44f362b8d18",
                            GroupRoleId = 2,
                            Name = "BAM",
                            NormalizedName = "BAM"
                        },
                        new
                        {
                            Id = "afb28b3e-0041-4b12-9554-c2b58ff66cd2",
                            ConcurrencyStamp = "663e8ff5-0524-41ce-92f2-00eb6749c215",
                            GroupRoleId = 2,
                            Name = "CE",
                            NormalizedName = "CE – CAPABILITY EXECUTIVE"
                        },
                        new
                        {
                            Id = "dcc22d99-4021-465a-b139-4c23e0a6d004",
                            ConcurrencyStamp = "2ba03275-d1de-4a7e-bd2d-349f62e9b1fa",
                            GroupRoleId = 2,
                            Name = "SaleSUP",
                            NormalizedName = "SALE SUP – SALE SUPERVISOR"
                        },
                        new
                        {
                            Id = "b7a4ba95-2ee3-41ff-b321-6fe2ebb87562",
                            ConcurrencyStamp = "e5dabd72-f84d-48cb-9d3c-b8ed950afacd",
                            GroupRoleId = 3,
                            Name = "Distributor-OM/TL",
                            NormalizedName = "DISTRIBUTOR - OM/TL"
                        },
                        new
                        {
                            Id = "464a56d5-aa95-4f58-9a10-1869e488d403",
                            ConcurrencyStamp = "f18a7203-dd54-48f2-9280-0403b235e6b8",
                            GroupRoleId = 4,
                            Name = "OtherDepartment",
                            NormalizedName = "OTHER DEPARTMENT"
                        },
                        new
                        {
                            Id = "7f8cfc09-46be-41e5-bcf7-18abb6fe6a3e",
                            ConcurrencyStamp = "ba39b90e-ea45-4150-a45e-1f1e4bef7f5a",
                            GroupRoleId = 4,
                            Name = "Guest",
                            NormalizedName = "GUEST"
                        });
                });

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DistributorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SaleStaffId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SuperiorId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.HasIndex("SaleStaffId");

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

                    b.Property<int>("ImplementationTime")
                        .HasColumnType("int");

                    b.Property<string>("VisitPurpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VisitCalendar");
                });

            modelBuilder.Entity("Unilevel.Models.VisitCalendarDistributor", b =>
                {
                    b.Property<int>("VisitCalendarId")
                        .HasColumnType("int");

                    b.Property<string>("DistributorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("VisitCalendarId", "DistributorId");

                    b.HasIndex("DistributorId");

                    b.ToTable("VisitCalendarDistributor");
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
                        .IsRequired()
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

            modelBuilder.Entity("Unilevel.Models.Distributor", b =>
                {
                    b.HasOne("Unilevel.Models.SaleStaff", "SaleManagementId")
                        .WithMany()
                        .HasForeignKey("SaleManagementIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SaleManagementId");
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

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.HasOne("Unilevel.Models.Distributor", null)
                        .WithMany("SalesId")
                        .HasForeignKey("DistributorId");

                    b.HasOne("Unilevel.Models.SaleStaff", null)
                        .WithMany("InferiorId")
                        .HasForeignKey("SaleStaffId");
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

            modelBuilder.Entity("Unilevel.Models.VisitCalendarDistributor", b =>
                {
                    b.HasOne("Unilevel.Models.Distributor", "Distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Unilevel.Models.VisitCalendar", "VisitCalendar")
                        .WithMany()
                        .HasForeignKey("VisitCalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distributor");

                    b.Navigation("VisitCalendar");
                });

            modelBuilder.Entity("Unilevel.Models.Visitor", b =>
                {
                    b.HasOne("Unilevel.Models.VisitCalendar", "VisitCalendar")
                        .WithMany()
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
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Areas");
                });

            modelBuilder.Entity("Unilevel.Models.Distributor", b =>
                {
                    b.Navigation("SalesId");
                });

            modelBuilder.Entity("Unilevel.Models.SaleStaff", b =>
                {
                    b.Navigation("InferiorId");
                });
#pragma warning restore 612, 618
        }
    }
}
