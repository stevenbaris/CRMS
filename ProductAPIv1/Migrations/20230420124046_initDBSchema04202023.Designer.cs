﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAPI.Data;

#nullable disable

namespace ProductAPI.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20230420124046_initDBSchema04202023")]
    partial class initDBSchema04202023
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProductAPI.Model.Product", b =>
                {
                    b.Property<Guid>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Benefits")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Product_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Product_Id = new Guid("2c9d2bac-f013-4a1e-bdff-40aedd23112f"),
                            Benefits = "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Cash Assistance Due to Food Poisoning",
                            CreateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5045),
                            ProductDescription = "CL Personal Accident Nano Insurance covers loss for Accidental Death, Disablement, or Dismemberment, and Cash Assistance due to Food Poisoning.",
                            ProductName = "CL Personal Accident Nano",
                            UpdateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5066)
                        },
                        new
                        {
                            Product_Id = new Guid("61ad2344-a718-4c75-966f-19b935cd63ef"),
                            Benefits = "Accidental Death, Accidental Dismemberment and/or Disablement, Accident Medical Reimbursement, Accidental Burial Benefit, Cash Assistance Benefit, Fire Cash Assistance",
                            CreateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5084),
                            ProductDescription = "CL Personal Accident Nano Plus Insurance covers Accidental Death, Disablement, or Dismemberment, Accident Medical Reimbursement, Accident Burial Benefit, Cash Assistance benefit, and Fire Cash Assistance.",
                            ProductName = "CL Personal Accident Nano Plus",
                            UpdateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5085)
                        },
                        new
                        {
                            Product_Id = new Guid("ffae8fdd-c105-4b2d-84e2-29545dee107a"),
                            Benefits = "Earthquake, Typhoon, Flood, Windstorm, Volcanic Eruption and other Acts of Nature, Extended Coverage, BOWTAP, BWD, SL and other water related damages, Vandalism/Spontaneous Combustion, All Other Losses",
                            CreateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5087),
                            ProductDescription = "CL MicroEnterpriseProtekis a Property Insurance Program specially designed for Cebuana Lhuillier clients. It covers loss “ALL Risks” of physical loss, destruction of or damage to the property of the insured and wholly attributable to any sudden and unforeseen cause, except as hereinafter excluded, occurring during the currency of the policy.",
                            ProductName = "CL MicroEnterpriseProtek",
                            UpdateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5087)
                        },
                        new
                        {
                            Product_Id = new Guid("a6550e4d-4c99-4759-be55-0c195db4d13a"),
                            Benefits = "Death Benefit, Accident or Sickness Emergency Cash Assistance, Accidental Dismemberment and/or Disablement, Murder and Unprovoked Assault and Residential Fire Reconstruction cash assistance",
                            CreateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5089),
                            ProductDescription = "For as low as P50, each certificate is valid for four (4) months from the date of issuance and can be availed up to a maximum of 5 certificates per insured.",
                            ProductName = "ProtectMAX",
                            UpdateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5089)
                        },
                        new
                        {
                            Product_Id = new Guid("a77635db-1952-4d3d-99c3-2c83feaa245c"),
                            Benefits = "24/7 Call-a-doc, OP ER One Time use (All causes), Daily Hospital Income Benefit (All Causes)",
                            CreateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5107),
                            ProductDescription = "An Individual Personal Accident Insurance specifically designed for Cebuana Lhuillier clients.It covers Accidental Death and Disability (AD&D), Double Indemnity, 24/7 Call-a-doc, OP ER One Time use and Daily Hospital Income Benefit.",
                            ProductName = "CL Health Care",
                            UpdateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5107)
                        },
                        new
                        {
                            Product_Id = new Guid("cea685a6-d03f-4feb-a1dd-8e5000e4ecf7"),
                            Benefits = "Accidental Death, Accidental Dismemberment and/or Disablement",
                            CreateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5114),
                            ProductDescription = "Covers Accidental Death and Accidental Dismemberment and/or Disablement Benefit.",
                            ProductName = "CL Personal Accident Basic",
                            UpdateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5115)
                        },
                        new
                        {
                            Product_Id = new Guid("6eb73177-f9a5-4ce3-9131-10225f1e766d"),
                            Benefits = "The Policy is Effective for one (1) year from the date of issuance or after payment of claim,whichever comes first.",
                            CreateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5116),
                            ProductDescription = "covers the medical expenses incurred within a year from the date of issuance or purchase by the InsuredPerson for the treatment of an eligible emergency condition, availment of which caneither be as an Out-Patient in the Emergency Room Department or as an In-Patient of aHospital via cash assistance.",
                            ProductName = "CL ER Care",
                            UpdateDate = new DateTime(2023, 2, 19, 20, 40, 46, 787, DateTimeKind.Local).AddTicks(5117)
                        });
                });

            modelBuilder.Entity("ProductAPI.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CityAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba9e9cfa-7cbd-48a7-8cae-b15ad678719d"),
                            AccessFailedCount = 0,
                            CityAddress = "Makati",
                            ConcurrencyStamp = "e611aa71-10fe-4231-9d1d-ba1a6654850c",
                            DOB = new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "su@crms.com",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "SU@CRMS.COM",
                            NormalizedUserName = "SU@CRMS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIfvfjq6jFKlx/rrtdU9RUQ5nqSaDOWaEDcT9Uif2VZx+xUcJff8TQaImheFHRV4yw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "su@crms.com"
                        },
                        new
                        {
                            Id = new Guid("17a0e293-4f2b-49fe-9f22-f7d358fd13b5"),
                            AccessFailedCount = 0,
                            CityAddress = "Makati",
                            ConcurrencyStamp = "66262a57-d107-4675-905d-51803a7a5bd0",
                            DOB = new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "user@crms.com",
                            EmailConfirmed = true,
                            FirstName = "Regular",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "USER@CRMS.COM",
                            NormalizedUserName = "USER@CRMS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP6CAZjuplXF/OAFh6q18dwq7hQC+Sn1iIQCDt77SbBvM+qC+tCy5hDK8UECtaOquQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user@crms.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ProductAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ProductAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ProductAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}