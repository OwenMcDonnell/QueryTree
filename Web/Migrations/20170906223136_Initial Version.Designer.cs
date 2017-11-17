﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using QueryTree.Models;
using QueryTree.Enums;

namespace Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170906223136_Initial Version")]
    partial class InitialVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QueryTree.Models.DatabaseConnection", b =>
                {
                    b.Property<int>("DatabaseConnectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DatabaseName")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OrganisationId");

                    b.Property<int>("Port");

                    b.Property<string>("Server")
                        .IsRequired();

                    b.Property<int?>("SshKeyFileID");

                    b.Property<int?>("SshPort");

                    b.Property<string>("SshUsername");

                    b.Property<int>("Type");

                    b.Property<string>("UniqueIdentifier")
                        .HasMaxLength(22);

                    b.Property<bool>("UseSsh");

                    b.Property<bool>("UseSshKey");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("DatabaseConnectionID");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("SshKeyFileID");

                    b.HasIndex("UniqueIdentifier");

                    b.ToTable("DatabaseConnections");
                });

            modelBuilder.Entity("QueryTree.Models.Organisation", b =>
                {
                    b.Property<int>("OrganisationId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("NumberOfConnections");

                    b.Property<int>("NumberOfUsers");

                    b.Property<string>("OrganisationName");

                    b.HasKey("OrganisationId");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("QueryTree.Models.OrganisationInvite", b =>
                {
                    b.Property<int>("OrganisationInviteId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AcceptedOn");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("InviteEmail");

                    b.Property<int>("OrganisationId");

                    b.Property<DateTime?>("RejectedOn");

                    b.HasKey("OrganisationInviteId");

                    b.HasIndex("CreatedById");

                    b.ToTable("OrganisationInvites");
                });

            modelBuilder.Entity("QueryTree.Models.Query", b =>
                {
                    b.Property<int>("QueryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedById");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<int>("DatabaseConnectionID");

                    b.Property<string>("Description");

                    b.Property<bool>("IsSimpleQuery");

                    b.Property<string>("LastEditedById");

                    b.Property<DateTime?>("LastEditedOn");

                    b.Property<string>("Name");

                    b.Property<string>("QueryDefinition");

                    b.HasKey("QueryID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DatabaseConnectionID");

                    b.HasIndex("LastEditedById");

                    b.ToTable("Queries");
                });

            modelBuilder.Entity("QueryTree.Models.ScheduledReport", b =>
                {
                    b.Property<int>("ScheduleID");

                    b.Property<int?>("DayOfMonth");

                    b.Property<int?>("DayOfWeek");

                    b.Property<int>("FrequencyScheduled");

                    b.Property<string>("Recipients");

                    b.Property<TimeSpan?>("Time");

                    b.HasKey("ScheduleID");

                    b.ToTable("ScheduledReports");
                });

            modelBuilder.Entity("QueryTree.Models.SshKeyFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContentType");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Filename");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("SshKeyFiles");
                });

            modelBuilder.Entity("QueryTree.Models.UserDatabaseConnection", b =>
                {
                    b.Property<int>("UserDatabaseConnectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserID");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("DatabaseConnectionID");

                    b.Property<string>("InviteEmail");

                    b.Property<int>("Type");

                    b.HasKey("UserDatabaseConnectionID");

                    b.HasIndex("ApplicationUserID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DatabaseConnectionID");

                    b.ToTable("UserDatabaseConnections");
                });

            modelBuilder.Entity("QueryTree.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("OrganisationId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QueryTree.Models.DatabaseConnection", b =>
                {
                    b.HasOne("QueryTree.Models.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QueryTree.Models.SshKeyFile", "SshKeyFile")
                        .WithMany()
                        .HasForeignKey("SshKeyFileID");
                });

            modelBuilder.Entity("QueryTree.Models.OrganisationInvite", b =>
                {
                    b.HasOne("QueryTree.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");
                });

            modelBuilder.Entity("QueryTree.Models.Query", b =>
                {
                    b.HasOne("QueryTree.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("QueryTree.Models.DatabaseConnection", "DatabaseConnection")
                        .WithMany("Queries")
                        .HasForeignKey("DatabaseConnectionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QueryTree.Models.ApplicationUser", "LastEditedBy")
                        .WithMany()
                        .HasForeignKey("LastEditedById");
                });

            modelBuilder.Entity("QueryTree.Models.ScheduledReport", b =>
                {
                    b.HasOne("QueryTree.Models.Query", "Query")
                        .WithOne("ScheduledReport")
                        .HasForeignKey("QueryTree.Models.ScheduledReport", "ScheduleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QueryTree.Models.SshKeyFile", b =>
                {
                    b.HasOne("QueryTree.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");
                });

            modelBuilder.Entity("QueryTree.Models.UserDatabaseConnection", b =>
                {
                    b.HasOne("QueryTree.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserID");

                    b.HasOne("QueryTree.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("QueryTree.Models.DatabaseConnection", "DatabaseConnection")
                        .WithMany()
                        .HasForeignKey("DatabaseConnectionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QueryTree.Models.ApplicationUser", b =>
                {
                    b.HasOne("QueryTree.Models.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
