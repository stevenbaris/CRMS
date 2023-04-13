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
    [Migration("20230408144348_addedUserRole")]
    partial class addedUserRole
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
                            Id = new Guid("05614079-4a66-4ea5-9c1e-8feea31374e6"),
                            AccessFailedCount = 0,
                            Address = "PJ Lhuiller",
                            ConcurrencyStamp = "abd2feba-b411-4a77-a954-5e85abad0290",
                            DOB = new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "su@crms.com",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            LastName = "User",
                            LockoutEnabled = true,
                            PasswordHash = "AQAAAAEAACcQAAAAEFPOHlU5ljarAm9NU1DmDdMrTFuf7R946ZoiluQzMhHygPUjP8ndLHHaxuL72K1rrA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "su@crms.com"
                        },
                        new
                        {
                            Id = new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"),
                            AccessFailedCount = 0,
                            Address = "PJ Lhuiller",
                            ConcurrencyStamp = "fd1a2dcf-66e0-4447-8054-6dc4ab1a6ce5",
                            DOB = new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "user@crms.com",
                            EmailConfirmed = true,
                            FirstName = "Regular",
                            LastName = "User",
                            LockoutEnabled = true,
                            PasswordHash = "AQAAAAEAACcQAAAAECZmqhry/4Y6iScPvJK0tcoPltww0S3KDo/gY4Is0ialAjFZ1sjXs/f8qybuE/UoNg==",
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
                            Contact_Id = new Guid("b47a2aef-b052-498a-9290-e688edc428c0"),
                            ContactCreatorID = new Guid("05614079-4a66-4ea5-9c1e-8feea31374e6"),
                            CreateDate = new DateTime(2023, 4, 8, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2288),
                            DOB = new DateTime(1994, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "charl.legista@gmail.com",
                            FirstName = "Charl",
                            Gender = 0,
                            LastName = "Legista",
                            PhoneNumber = "09052214812"
                        },
                        new
                        {
                            Contact_Id = new Guid("731ffa68-1eba-41df-a2c8-c4e36c1c23f9"),
                            ContactCreatorID = new Guid("05614079-4a66-4ea5-9c1e-8feea31374e6"),
                            ContactOwnerID = new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"),
                            CreateDate = new DateTime(2023, 4, 3, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2340),
                            DOB = new DateTime(1999, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAssigned = new DateTime(2023, 4, 5, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2335),
                            Email = "steven.baris14@gmail.com",
                            FirstName = "Steven",
                            Gender = 0,
                            LastName = "Baris",
                            PhoneNumber = "09123456789"
                        },
                        new
                        {
                            Contact_Id = new Guid("acf0c40b-a314-448f-bf8f-a34a4875bc1d"),
                            ContactCreatorID = new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"),
                            ContactOwnerID = new Guid("a9091087-9c9e-4a1d-9e0c-bdb10c97d3e0"),
                            CreateDate = new DateTime(2023, 4, 5, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2344),
                            DOB = new DateTime(1996, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateAssigned = new DateTime(2023, 4, 7, 14, 43, 47, 715, DateTimeKind.Utc).AddTicks(2343),
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
                            Purpose_Id = new Guid("66260d6c-9320-4865-b9ac-37a3c2a9679f"),
                            PurposeName = "Fact-Find"
                        },
                        new
                        {
                            Purpose_Id = new Guid("ab06e970-7d3d-48c6-8153-620c81540654"),
                            PurposeName = "Presentation"
                        },
                        new
                        {
                            Purpose_Id = new Guid("153157d4-1b89-4df9-b946-c1eef0ad79c5"),
                            PurposeName = "Proposal"
                        },
                        new
                        {
                            Purpose_Id = new Guid("db4c23d9-02fe-4a4f-8260-abcbe4d47ace"),
                            PurposeName = "Sales Closing"
                        },
                        new
                        {
                            Purpose_Id = new Guid("82999b2f-72cc-49b7-ba5d-a9da43bba95b"),
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
                            CommunicationMethod_Id = new Guid("bf8c9d19-8098-4590-801a-33f4af87429e"),
                            CommunicationMethodName = "Facebook"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("24726c5f-8159-4437-8f27-a31adc83a404"),
                            CommunicationMethodName = "Instagram"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("aee7553e-f369-414f-ba7b-88e96f576e80"),
                            CommunicationMethodName = "WhatsApp"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("cccfcc23-3b8a-4d48-80ae-79dd4db9c301"),
                            CommunicationMethodName = "Line"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("8b4dd61e-c431-43fc-8548-8e96f35172fb"),
                            CommunicationMethodName = "Phone Call"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("c71360c7-fac1-4e12-a233-4f1dac6fb236"),
                            CommunicationMethodName = "Test Message"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("417e9bba-0ccd-49e3-ab65-a7c7545ddcdf"),
                            CommunicationMethodName = "Email"
                        },
                        new
                        {
                            CommunicationMethod_Id = new Guid("1eb1d725-831f-434b-97d2-733e63023ed1"),
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
                            Effectivity_Id = new Guid("0eab5b4e-aef8-469d-b19d-ec4a0bdd88dd"),
                            Effectivity_Name = "Not Read"
                        },
                        new
                        {
                            Effectivity_Id = new Guid("fd625ec7-ff91-4bac-84e6-3604b14b6945"),
                            Effectivity_Name = "Read but no response"
                        },
                        new
                        {
                            Effectivity_Id = new Guid("a56b1387-6f3c-47b6-9142-020f24b0f98b"),
                            Effectivity_Name = "Simple Response"
                        },
                        new
                        {
                            Effectivity_Id = new Guid("a00c701a-6531-4562-b797-0618ad8b7a3d"),
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
                            EType_Id = new Guid("16be768f-3596-40af-8da3-996a96105bd5"),
                            EngagementName = "Congratulations"
                        },
                        new
                        {
                            EType_Id = new Guid("15bcbf4b-18e4-4874-91cf-6ea7b4ae1d96"),
                            EngagementName = "Birthday"
                        },
                        new
                        {
                            EType_Id = new Guid("83ab06e7-be5a-40f7-876b-3b5e756de2e9"),
                            EngagementName = "Anniversary"
                        },
                        new
                        {
                            EType_Id = new Guid("8590b048-5fd1-4cdc-9da2-446d99528c0f"),
                            EngagementName = "Holiday"
                        },
                        new
                        {
                            EType_Id = new Guid("88ca8fb3-a5d8-477d-9398-04b264b4cdaa"),
                            EngagementName = "Discount"
                        },
                        new
                        {
                            EType_Id = new Guid("97918d84-9fc0-4f91-a561-5fe06347b805"),
                            EngagementName = "Company News"
                        },
                        new
                        {
                            EType_Id = new Guid("df40bf69-76f6-4577-871a-ca9d2612ada3"),
                            EngagementName = "New Product"
                        },
                        new
                        {
                            EType_Id = new Guid("aea3554b-e96c-4e4d-8a61-fb82a4993d46"),
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
                            LeadStatus_Id = new Guid("f78888a7-155d-4642-aab5-6d49e5e4324d"),
                            LeadStatusName = "Contacted"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("c6d261f9-1090-4118-b7c3-8718a2624fef"),
                            LeadStatusName = "Met"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("55cdc5e2-e052-44eb-9f4b-cf31ea318d28"),
                            LeadStatusName = "Proposal Generated"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("a8352e2e-f523-4105-bca1-19773067b657"),
                            LeadStatusName = "Application Submitted"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("81c9a988-8718-4437-822e-b4a2fc75517f"),
                            LeadStatusName = "Policy Issued"
                        },
                        new
                        {
                            LeadStatus_Id = new Guid("8028f285-ca41-42ef-88d4-5fbe84ff8bec"),
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
                            Source_Id = new Guid("1c0c6814-91b3-491c-a0fd-11a6363439e3"),
                            SourceName = "Referral"
                        },
                        new
                        {
                            Source_Id = new Guid("bfc381cb-24ad-4e88-93d9-5ee9d4d79394"),
                            SourceName = "Friend"
                        },
                        new
                        {
                            Source_Id = new Guid("4cd61380-7458-4c37-bd53-b3e37670eec6"),
                            SourceName = "Compony-Generated"
                        },
                        new
                        {
                            Source_Id = new Guid("6d241113-b946-4f62-9f1a-484eaff08112"),
                            SourceName = "Social Media"
                        },
                        new
                        {
                            Source_Id = new Guid("6c1e24ec-0d6d-4696-882b-9e0e12ec34f8"),
                            SourceName = "Webinar"
                        },
                        new
                        {
                            Source_Id = new Guid("9969b413-ffdc-47c7-8751-28f28264a937"),
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
                            Id = new Guid("9cdb2ac5-0bd8-4644-a0a5-6f547f69d4e0"),
                            ConcurrencyStamp = "a7439c9a-ea40-4f4c-b33a-193c8cc68335",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("9897b960-b78a-4dcb-8dbb-5aa4774a7c67"),
                            ConcurrencyStamp = "cff24225-afb8-4cf3-9ef0-061013df60e5",
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