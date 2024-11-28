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
    [Migration("20241122143510_ChangeSomeEntity")]
    partial class ChangeSomeEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasDefaultValue("Unknown");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
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

            modelBuilder.Entity("Unilevel.Models.UserPermission", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("UserPermission");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Unilevel.Models.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<int>("GroupRoleId")
                        .HasColumnType("int");

                    b.HasIndex("GroupRoleId");

                    b.HasDiscriminator().HasValue("Role");

                    b.HasData(
                        new
                        {
                            Id = "08635918-20b8-40d9-8a32-687bffab632c",
                            ConcurrencyStamp = "7da8f71f-b67f-4634-a2fc-51bd39bd154c",
                            Name = "Owner",
                            NormalizedName = "OWNER",
                            GroupRoleId = 1
                        },
                        new
                        {
                            Id = "cf10eda2-ec57-448c-8efc-060e9d8b3c4c",
                            ConcurrencyStamp = "a0b6fe6b-7c85-4949-aefe-4df08292a6a2",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR",
                            GroupRoleId = 1
                        },
                        new
                        {
                            Id = "bba6d57f-58c5-48fc-975d-6194f94c092d",
                            ConcurrencyStamp = "ddda53a4-66b7-4513-8429-fa193e922c7f",
                            Name = "VPCD",
                            NormalizedName = "VPCD",
                            GroupRoleId = 2
                        },
                        new
                        {
                            Id = "04254319-bd83-4ae0-ab15-e668d8ec2d60",
                            ConcurrencyStamp = "a4c22144-5db8-4283-810e-bc12443a4bfb",
                            Name = "BM",
                            NormalizedName = "BM",
                            GroupRoleId = 2
                        },
                        new
                        {
                            Id = "b0a34ef7-39f5-40a2-8b0c-535c428fcab4",
                            ConcurrencyStamp = "9df06dd6-f7bc-4554-a4ad-0b79b50eedf3",
                            Name = "ChannelActivationHead",
                            NormalizedName = "CHANNEL ACTIVATION HEAD",
                            GroupRoleId = 2
                        },
                        new
                        {
                            Id = "d795568c-c96c-4c9d-a72a-fdfa4ef9ea04",
                            ConcurrencyStamp = "e197449d-52d6-434d-affa-d0c10b09eb23",
                            Name = "ASM",
                            NormalizedName = "ASM",
                            GroupRoleId = 2
                        },
                        new
                        {
                            Id = "9401aa7c-11ad-4a83-a905-214e6e18e041",
                            ConcurrencyStamp = "5e42e06a-e318-467e-9666-0ede9e7bc379",
                            Name = "BAM",
                            NormalizedName = "BAM",
                            GroupRoleId = 2
                        },
                        new
                        {
                            Id = "bba507ea-8af0-42e4-b5c3-0e845c1092be",
                            ConcurrencyStamp = "1664c1e2-1025-4b88-9a67-4ad9887c9b65",
                            Name = "CE",
                            NormalizedName = "CE – CAPABILITY EXECUTIVE",
                            GroupRoleId = 2
                        },
                        new
                        {
                            Id = "ff9447e2-44af-4af4-ab0f-58624c59d666",
                            ConcurrencyStamp = "d35de113-6d07-4cf6-9bae-227f5e2540f4",
                            Name = "SaleSUP",
                            NormalizedName = "SALE SUP – SALE SUPERVISOR",
                            GroupRoleId = 2
                        },
                        new
                        {
                            Id = "1398f135-30a4-4312-a83c-893bca742d2e",
                            ConcurrencyStamp = "290b3856-c605-478a-b34e-070b17cf72a3",
                            Name = "Distributor-OM/TL",
                            NormalizedName = "DISTRIBUTOR - OM/TL",
                            GroupRoleId = 3
                        },
                        new
                        {
                            Id = "7bf3818c-0c6d-4967-b8ed-e59f234f6df4",
                            ConcurrencyStamp = "9ba66be1-b5b7-47d0-85b1-ee7e16684fd4",
                            Name = "OtherDepartment",
                            NormalizedName = "OTHER DEPARTMENT",
                            GroupRoleId = 4
                        },
                        new
                        {
                            Id = "4f684f94-d893-4928-8756-563fc1b012db",
                            ConcurrencyStamp = "0435b00f-39fc-4356-9ebc-e974d269bc3b",
                            Name = "Guest",
                            NormalizedName = "GUEST",
                            GroupRoleId = 4
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
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

            modelBuilder.Entity("Unilevel.Models.Role", b =>
                {
                    b.HasOne("Unilevel.Models.GroupRole", null)
                        .WithMany()
                        .HasForeignKey("GroupRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}