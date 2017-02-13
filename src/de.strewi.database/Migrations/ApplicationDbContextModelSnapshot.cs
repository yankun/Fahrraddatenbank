using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using de.strewi.database;
using de.strewi.database.Models;

namespace de.strewi.database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("de.strewi.database.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Firstname")
                        .IsRequired();

                    b.Property<bool>("IsActivated");

                    b.Property<string>("Lastname");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int>("MemberNumber");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("Points");

                    b.Property<DateTime>("RegisteredAt");

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
                });

            modelBuilder.Entity("de.strewi.database.Models.BearingShell", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<double>("CrankHoleDiameter");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid?>("CreatedByID");

                    b.Property<double>("Depth");

                    b.Property<string>("Image");

                    b.Property<double>("InnerDiameter");

                    b.Property<bool>("IsThreaded");

                    b.Property<Guid>("ManufacturerId");

                    b.Property<int>("ModerationState");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<Guid?>("ModifiedByID");

                    b.Property<double>("OuterDiamteter");

                    b.Property<int>("Position");

                    b.Property<int>("Side");

                    b.Property<string>("UsedAt");

                    b.Property<int?>("UsedAtValidFrom");

                    b.Property<int?>("UsedAtValidTo");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("BearingShells");
                });

            modelBuilder.Entity("de.strewi.database.Models.CrankAxle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid?>("CreatedByID");

                    b.Property<Guid>("ManufacturerId");

                    b.Property<int>("ModerationState");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<Guid?>("ModifiedByID");

                    b.Property<double>("ThreadDiameter");

                    b.Property<int>("ThreadPitch");

                    b.Property<string>("UsedAt");

                    b.Property<int?>("UsedAtValidFrom");

                    b.Property<int?>("UsedAtValidTo");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("CrankAxles");
                });

            modelBuilder.Entity("de.strewi.database.Models.Framenumber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<string>("Comment")
                        .HasMaxLength(3000);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid?>("CreatedByID");

                    b.Property<Guid>("ManufacturerId");

                    b.Property<int>("ModerationState");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<Guid?>("ModifiedByID");

                    b.Property<int>("Number");

                    b.Property<int>("ProvenBy");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("Framenumbers");
                });

            modelBuilder.Entity("de.strewi.database.Models.HeadBadge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid?>("CreatedByID");

                    b.Property<int>("HeadbadgeMaterial");

                    b.Property<double?>("HorizontalDistance");

                    b.Property<string>("Image");

                    b.Property<Guid>("ManufacturerId");

                    b.Property<int>("ModerationState");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<Guid?>("ModifiedByID");

                    b.Property<int>("MountingPoints");

                    b.Property<string>("Notes")
                        .HasMaxLength(500);

                    b.Property<int?>("NumberOfMountingPoints");

                    b.Property<string>("UsedAt");

                    b.Property<int?>("UsedAtValidFrom");

                    b.Property<int?>("UsedAtValidTo");

                    b.Property<string>("UsedColors");

                    b.Property<double?>("VerticalDistance");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("Headbadges");
                });

            modelBuilder.Entity("de.strewi.database.Models.Manufacturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<string>("City")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid?>("CreatedByID");

                    b.Property<string>("FoundedAt");

                    b.Property<int?>("FoundedAtValidFrom");

                    b.Property<int?>("FoundedAtValidTo");

                    b.Property<string>("History")
                        .HasColumnType("ntext");

                    b.Property<int>("ModerationState");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<Guid?>("ModifiedByID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("OvertakenAt");

                    b.Property<int?>("OvertakenAtValidFrom");

                    b.Property<int?>("OvertakenAtValidTo");

                    b.Property<Guid?>("OvertakenById");

                    b.Property<string>("StoppedProductionAt");

                    b.Property<int?>("StoppedProductionAtValidFrom");

                    b.Property<int?>("StoppedProductionAtValidTo");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ModifiedByID");

                    b.HasIndex("OvertakenById");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("de.strewi.database.Models.ModerationItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<string>("Action");

                    b.Property<string>("Controller");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<Guid?>("CreatedByID");

                    b.Property<int>("ModerationState");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<Guid?>("ModifiedByID");

                    b.Property<string>("Name");

                    b.Property<string>("Reason");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("ModerationQueue");
                });

            modelBuilder.Entity("de.strewi.database.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

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

            modelBuilder.Entity("de.strewi.database.Models.ValueChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:DefaultValueSql", "newsequentialid()");

                    b.Property<string>("EntityName")
                        .IsRequired();

                    b.Property<string>("NewValue");

                    b.Property<string>("PropertyName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ValueChanges");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("de.strewi.database.Models.BearingShell", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.database.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.database.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("de.strewi.database.Models.CrankAxle", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.database.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.database.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("de.strewi.database.Models.Framenumber", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.database.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.database.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("de.strewi.database.Models.HeadBadge", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.database.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.database.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("de.strewi.database.Models.Manufacturer", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.database.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");

                    b.HasOne("de.strewi.database.Models.Manufacturer", "OvertakenBy")
                        .WithMany()
                        .HasForeignKey("OvertakenById");
                });

            modelBuilder.Entity("de.strewi.database.Models.ModerationItem", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.database.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("de.strewi.database.Models.Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("de.strewi.database.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("de.strewi.database.Models.Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.database.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
