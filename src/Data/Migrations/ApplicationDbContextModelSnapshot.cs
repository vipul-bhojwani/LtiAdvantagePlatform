﻿// <auto-generated />
using System;
using AdvantagePlatform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvantagePlatform.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvantagePlatform.Data.AdvantagePlatformUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int?>("CourseId");

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

                    b.Property<int?>("PlatformId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PlatformId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("SisId");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.GradebookColumn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId");

                    b.Property<DateTime?>("EndDateTime");

                    b.Property<string>("Label");

                    b.Property<string>("ResourceId");

                    b.Property<int?>("ResourceLinkId");

                    b.Property<double?>("ScoreMaximum");

                    b.Property<DateTime?>("StartDateTime");

                    b.Property<string>("Tag");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("ResourceLinkId");

                    b.ToTable("GradebookColumns");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.GradebookRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityProgress");

                    b.Property<string>("Comment");

                    b.Property<int?>("GradebookColumnId");

                    b.Property<int>("GradingProgress");

                    b.Property<int>("PersonId");

                    b.Property<double>("ScoreGiven");

                    b.Property<double>("ScoreMaximum");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.HasIndex("GradebookColumnId");

                    b.ToTable("GradebookRows");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdvantagePlatformUserId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Roles");

                    b.Property<string>("SisId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("AdvantagePlatformUserId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail");

                    b.Property<string>("Description");

                    b.Property<string>("Guid");

                    b.Property<string>("Name");

                    b.Property<string>("ProductFamilyCode");

                    b.Property<string>("Url");

                    b.Property<string>("Version");

                    b.HasKey("Id");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.ResourceLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId");

                    b.Property<string>("CustomProperties");

                    b.Property<string>("Description");

                    b.Property<int?>("PlatformId");

                    b.Property<string>("Title");

                    b.Property<int?>("ToolId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("PlatformId");

                    b.HasIndex("ToolId");

                    b.ToTable("ResourceLinks");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.Tool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdvantagePlatformUserId");

                    b.Property<string>("CustomProperties");

                    b.Property<string>("DeepLinkingLaunchUrl");

                    b.Property<string>("DeploymentId");

                    b.Property<int>("IdentityServerClientId");

                    b.Property<string>("LaunchUrl");

                    b.Property<string>("LoginUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AdvantagePlatformUserId");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.AdvantagePlatformUser", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("AdvantagePlatform.Data.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformId");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.GradebookColumn", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.Course")
                        .WithMany("GradebookColumns")
                        .HasForeignKey("CourseId");

                    b.HasOne("AdvantagePlatform.Data.ResourceLink", "ResourceLink")
                        .WithMany()
                        .HasForeignKey("ResourceLinkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdvantagePlatform.Data.GradebookRow", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.GradebookColumn")
                        .WithMany("Scores")
                        .HasForeignKey("GradebookColumnId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdvantagePlatform.Data.Person", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.AdvantagePlatformUser")
                        .WithMany("People")
                        .HasForeignKey("AdvantagePlatformUserId");
                });

            modelBuilder.Entity("AdvantagePlatform.Data.ResourceLink", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.Course")
                        .WithMany("ResourceLinks")
                        .HasForeignKey("CourseId");

                    b.HasOne("AdvantagePlatform.Data.Platform")
                        .WithMany("ResourceLinks")
                        .HasForeignKey("PlatformId");

                    b.HasOne("AdvantagePlatform.Data.Tool", "Tool")
                        .WithMany()
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdvantagePlatform.Data.Tool", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.AdvantagePlatformUser")
                        .WithMany("Tools")
                        .HasForeignKey("AdvantagePlatformUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.AdvantagePlatformUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.AdvantagePlatformUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AdvantagePlatform.Data.AdvantagePlatformUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AdvantagePlatform.Data.AdvantagePlatformUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
