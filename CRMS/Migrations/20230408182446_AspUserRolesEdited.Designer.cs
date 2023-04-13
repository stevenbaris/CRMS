﻿// <auto-generated />
using System;
using CRMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRMS.Migrations
{
    [DbContext(typeof(CRMSDbContext))]
    [Migration("20230408182446_AspUserRolesEdited")]
    partial class AspUserRolesEdited
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRMS.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
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
                            Id = new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"),
                            AccessFailedCount = 0,
                            Address = "PJ Lhuiller",
                            ConcurrencyStamp = "550845de-7737-44e3-a3f4-b9a0b877f3a9",
                            DOB = new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "su@crms.com",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "SU@CRMS.COM",
                            NormalizedUserName = "SU@CRMS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFEiwAD5xRm802wWM6u3bhwiIJbuNxlamzO29tuENHvxHFSau4SiiqqZ7sEypghojw==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "su@crms.com"
                        },
                        new
                        {
                            Id = new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"),
                            AccessFailedCount = 0,
                            Address = "PJ Lhuiller",
                            ConcurrencyStamp = "ce264be7-91ba-487b-91a0-677395807962",
                            DOB = new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "user@crms.com",
                            EmailConfirmed = true,
                            FirstName = "Regular",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "USER@CRMS.COM",
                            NormalizedUserName = "USER@CRMS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEhSry6yr6Lb4Es+v2ihtBkh3Ap54ieMkwGs0UtkBYnfx3iClOcI/x+4iO498wiCSQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user@crms.com"
                        });
                });

            modelBuilder.Entity("CRMS.Models.Contacts", b =>
                {
                    b.Property<Guid>("Contact_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactCreatorID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactOwnerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DOB")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateAssigned")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Contact_Id");

                    b.HasIndex("ContactCreatorID");

                    b.HasIndex("ContactOwnerID");

                    b.ToTable("CONTACTS", (string)null);

                    b.HasData(
                        new
                        {
                            Contact_Id = new Guid("83a8aed0-5998-4779-a0ef-6a70b51a72d4"),
                            ContactCreatorID = new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"),
                            CreateDate = new DateTime(2023, 4, 8, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1736),
                            DOB = new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "charl.legista@gmail.com",
                            FirstName = "Charl",
                            Gender = 0,
                            LastName = "Legista",
                            PhoneNumber = "09052214812"
                        },
                        new
                        {
                            Contact_Id = new Guid("d2911a8d-c650-4141-94a5-fbf705a49cf1"),
                            ContactCreatorID = new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"),
                            ContactOwnerID = new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"),
                            CreateDate = new DateTime(2023, 4, 3, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1756),
                            DOB = new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAssigned = new DateTime(2023, 4, 5, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1744),
                            Email = "steven.baris14@gmail.com",
                            FirstName = "Steven",
                            Gender = 0,
                            LastName = "Baris",
                            PhoneNumber = "09123456789"
                        },
                        new
                        {
                            Contact_Id = new Guid("ad50001d-1fd0-4534-9508-29e80287c176"),
                            ContactCreatorID = new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"),
                            ContactOwnerID = new Guid("3b547b7b-f063-44b9-b8ba-856c1deddc41"),
                            CreateDate = new DateTime(2023, 4, 5, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1762),
                            DOB = new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAssigned = new DateTime(2023, 4, 7, 18, 24, 46, 86, DateTimeKind.Utc).AddTicks(1761),
                            Email = "cust.no1@gmail.com",
                            FirstName = "Customer",
                            Gender = 1,
                            LastName = "Number1",
                            PhoneNumber = "09987654321"
                        });
                });

            modelBuilder.Entity("CRMS.Models.Customization.AppointmentPurpose", b =>
                {
                    b.Property<Guid>("Purpose_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PurposeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Purpose_Id");

                    b.ToTable("APPOINTMENT_PURPOSES", (string)null);

                    b.HasData(
                        new
                        {
                            Purpose_Id = new Guid("da99752d-08d9-4ef0-a6e4-ce487259a1fb"),
                            PurposeName = "Fact-Find"
                        },
                        new
                        {
                            Purpose_Id = new Guid("25e4728e-a8f3-4466-8c29-a6a383479585"),
                            PurposeName = "Presentation"
                        },
                        new
                        {
                            Purpose_Id = new Guid("bcfab40d-0598-452f-beed-48359e35b497"),
                            PurposeName = "Proposal"
                        },
                        new
                        {
                            Purpose_Id = new Guid("e0d02e62-546b-4b03-a6d8-16ccf0aa5343"),
                            PurposeName = "Sales Closing"
                        },
                        new
                        {
                            Purpose_Id = new Guid("5eb69a76-c5dd-4822-a56e-82fdd868a93b"),
                            PurposeName = "Others"
                        });
                });

            modelBuilder.Entity("CRMS.Models.Customization.CommunicationMethod", b =>
                {
                    b.Property<Guid>("CommunicationMethod_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommunicationMethodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommunicationMethod_Id");

                    b.ToTable("ENGAGEMENT_COMMUNICATION METHODS", (string)null);

                    b.HasData(
                        new
                        {
                            CommunicationMethod_Id = new Guid("57c1a456-e15a-4f84-acc4-d75786abb659"),
                            CommunicationMethodName = "Facebook"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("e6f76b03-fa87-4cf2-85f4-b266148e1cee"),
                            CommunicationMethodName = "Instagram"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("af28c14c-9ca9-4b1f-bc7b-444a59180d02"),
                            CommunicationMethodName = "WhatsApp"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("d15cef8f-35c5-4d4d-9186-a2d9300c6c33"),
                            CommunicationMethodName = "Line"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("ed493ee1-6d49-4471-a5f1-8b3580a79f2c"),
                            CommunicationMethodName = "Phone Call"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("2a1d81f5-ba15-479d-bf59-f39538525a8f"),
                            CommunicationMethodName = "Test Message"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("16ef823e-e015-4551-9bc0-9a9826611f35"),
                            CommunicationMethodName = "Email"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("78d3accc-d07d-4635-a20f-25b8aa635ce6"),
                            CommunicationMethodName = "Others"
                        });
                });

            modelBuilder.Entity("CRMS.Models.Customization.Effectivity", b =>
                {
                    b.Property<Guid>("Effectivity_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Effectivity_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Effectivity_Id");

                    b.ToTable("ENGAGEMENT_EFFECTIVITY", (string)null);

                    b.HasData(
                        new
                        {
                            Effectivity_Id = new Guid("74c620e9-f4bb-4c76-80cc-22ffef60e3f1"),
                            Effectivity_Name = "Not Read"
                        },
                        new
                        {
                            Effectivity_Id = new Guid("29107401-13af-4681-bb13-b27ea66816f7"),
                            Effectivity_Name = "Read but no response"
                        },
                        new
                        {
                            Effectivity_Id = new Guid("1e138c9d-3a4e-49cf-b538-258c2b756d03"),
                            Effectivity_Name = "Simple Response"
                        },
                        new
                        {
                            Effectivity_Id = new Guid("72308380-7145-4f34-b9db-4183d53fa697"),
                            Effectivity_Name = "Good Engagement"
                        });
                });

            modelBuilder.Entity("CRMS.Models.Customization.EngagementType", b =>
                {
                    b.Property<Guid>("EType_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EngagementName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EType_Id");

                    b.ToTable("ENGAGEMENT_ENGAGEMENT-TYPES", (string)null);

                    b.HasData(
                        new
                        {
                            EType_Id = new Guid("0adcca05-230a-4342-8f90-89caefb87396"),
                            EngagementName = "Congratulations"
                        },
                        new
                        {
                            EType_Id = new Guid("364afaed-7310-4305-93dc-4e989d665868"),
                            EngagementName = "Birthday"
                        },
                        new
                        {
                            EType_Id = new Guid("bf273959-811f-4bb7-9009-8d696180cb7a"),
                            EngagementName = "Anniversary"
                        },
                        new
                        {
                            EType_Id = new Guid("361adbbc-31e1-4614-a03e-6df584b4e2e4"),
                            EngagementName = "Holiday"
                        },
                        new
                        {
                            EType_Id = new Guid("a28b47ba-505d-42ef-ada2-572ffa5c01bd"),
                            EngagementName = "Discount"
                        },
                        new
                        {
                            EType_Id = new Guid("04e9b149-4cfc-4e2b-9160-3caf0f08af7d"),
                            EngagementName = "Company News"
                        },
                        new
                        {
                            EType_Id = new Guid("cb1d89d5-6372-4a88-b000-f103e5246205"),
                            EngagementName = "New Product"
                        },
                        new
                        {
                            EType_Id = new Guid("28b0aef6-a9b7-4590-a0c5-0280e55eebc5"),
                            EngagementName = "Others"
                        });
                });

            modelBuilder.Entity("CRMS.Models.Customization.LeadStatus", b =>
                {
                    b.Property<Guid>("LeadStatus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LeadStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeadStatus_Id");

                    b.ToTable("LEADS_STATUSES", (string)null);

                    b.HasData(
                        new
                        {
                            LeadStatus_Id = new Guid("30e5d123-c2e2-434d-a0b8-ffa48546991f"),
                            LeadStatusName = "Contacted"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("7eefe913-5603-470b-9172-40cbcb0db350"),
                            LeadStatusName = "Met"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("be745c28-48e7-4a4e-83f3-8c084f4cc1c4"),
                            LeadStatusName = "Proposal Generated"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("fa4e7be5-3311-4761-a9e1-98362cfa80e0"),
                            LeadStatusName = "Application Submitted"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("3675979a-8589-4985-90f5-7783aaba8076"),
                            LeadStatusName = "Policy Issued"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("87304a95-0848-4f24-b977-680fa4ead45e"),
                            LeadStatusName = "Lead is Dead"
                        });
                });

            modelBuilder.Entity("CRMS.Models.Customization.Source", b =>
                {
                    b.Property<Guid>("Source_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SourceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Source_Id");

                    b.ToTable("LEADS_SOURCES", (string)null);

                    b.HasData(
                        new
                        {
                            Source_Id = new Guid("6d959845-173c-4689-88d0-f2b240901f2e"),
                            SourceName = "Referral"
                        },
                        new
                        {
                            Source_Id = new Guid("7552d403-bccc-470c-b476-0e94126435a1"),
                            SourceName = "Friend"
                        },
                        new
                        {
                            Source_Id = new Guid("44d5b7de-b1a4-4d21-bc73-7d422296b723"),
                            SourceName = "Compony-Generated"
                        },
                        new
                        {
                            Source_Id = new Guid("4ad90723-5544-42da-8790-5332fdcdf988"),
                            SourceName = "Social Media"
                        },
                        new
                        {
                            Source_Id = new Guid("25c9a3b6-3e71-462d-abc5-59b464fa41e2"),
                            SourceName = "Webinar"
                        },
                        new
                        {
                            Source_Id = new Guid("cc064b8d-8379-4eef-a5a8-afa70fb095ee"),
                            SourceName = "Others"
                        });
                });

            modelBuilder.Entity("CRMS.Models.RollingTransactions", b =>
                {
                    b.Property<Guid?>("RollingTransactions_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("TransacationTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RollingTransactions_ID");

                    b.HasIndex("ContactId")
                        .IsUnique()
                        .HasFilter("[ContactId] IS NOT NULL");

                    b.ToTable("ROLLING TRANSACTIONS", (string)null);
                });

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("8f15d049-10a4-45e8-b47c-5781de36b76c"),
                            ConcurrencyStamp = "4067af35-7b5f-4359-ba3e-39d4319eafcf",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("22077764-7261-4755-8265-d923ae96d0da"),
                            ConcurrencyStamp = "2d5e7ccc-0d38-46ac-b0d4-27f4fd5bd1e5",
                            Name = "User",
                            NormalizedName = "USER"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = new Guid("84d3ddf2-bd16-4a62-994c-fe1d5aba3fe1"),
                            RoleId = new Guid("8f15d049-10a4-45e8-b47c-5781de36b76c")
                        });
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

            modelBuilder.Entity("CRMS.Models.Contacts", b =>
                {
                    b.HasOne("CRMS.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("ContactCreatorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_ContactCreator");

                    b.HasOne("CRMS.Models.ApplicationUser", "Owner")
                        .WithMany("Contacts")
                        .HasForeignKey("ContactOwnerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("FK_ContactOwner");

                    b.Navigation("Creator");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CRMS.Models.RollingTransactions", b =>
                {
                    b.HasOne("CRMS.Models.Contacts", "Contacts")
                        .WithOne("Transactions")
                        .HasForeignKey("CRMS.Models.RollingTransactions", "ContactId")
                        .HasConstraintName("FK_TransactionsOfContact");

                    b.Navigation("Contacts");
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
                    b.HasOne("CRMS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("CRMS.Models.ApplicationUser", null)
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

                    b.HasOne("CRMS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("CRMS.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRMS.Models.ApplicationUser", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("CRMS.Models.Contacts", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}