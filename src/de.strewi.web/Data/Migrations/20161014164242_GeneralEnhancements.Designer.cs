using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using de.strewi.web.Data;

namespace de.strewi.web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161014164242_GeneralEnhancements")]
    partial class GeneralEnhancements
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("de.strewi.web.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("de.strewi.web.Models.BearingShell", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CrankHoleDiameter");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedByID");

                    b.Property<double>("Depth");

                    b.Property<string>("Image");

                    b.Property<double>("InnerDiameter");

                    b.Property<bool>("IsThreaded");

                    b.Property<int>("ManufactureId");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedByID");

                    b.Property<double>("OuterDiamteter");

                    b.Property<int>("Position");

                    b.Property<int>("Side");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ManufactureId");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("BearingShells");
                });

            modelBuilder.Entity("de.strewi.web.Models.CrankAxle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedByID");

                    b.Property<int>("ManufactureId");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedByID");

                    b.Property<double>("ThreadDiameter");

                    b.Property<int>("ThreadPitch");

                    b.Property<double>("Width");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ManufactureId");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("CrankAxles");
                });

            modelBuilder.Entity("de.strewi.web.Models.HeadBadge", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedByID");

                    b.Property<double?>("HorizontalDistance");

                    b.Property<string>("Image");

                    b.Property<int>("ManufactureId");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedByID");

                    b.Property<int>("MountingPoints");

                    b.Property<string>("Notes")
                        .HasAnnotation("MaxLength", 500);

                    b.Property<string>("UsedColors");

                    b.Property<DateTime?>("ValidForm");

                    b.Property<DateTime?>("ValidTo");

                    b.Property<double?>("VerticalDistance");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ManufactureId");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("Headbadges");
                });

            modelBuilder.Entity("de.strewi.web.Models.Manufacture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedByID");

                    b.Property<DateTime>("FoundedAt");

                    b.Property<string>("History")
                        .HasColumnType("ntext");

                    b.Property<DateTime?>("ModifiedAt");

                    b.Property<string>("ModifiedByID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<int?>("OvertakenById");

                    b.Property<DateTime>("StoppedProductionAt");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ModifiedByID");

                    b.HasIndex("OvertakenById");

                    b.ToTable("Manufactures");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
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

                    b.HasIndex("UserId");

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

            modelBuilder.Entity("de.strewi.web.Models.BearingShell", b =>
                {
                    b.HasOne("de.strewi.web.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.web.Models.Manufacture", "Manufacture")
                        .WithMany()
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.web.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("de.strewi.web.Models.CrankAxle", b =>
                {
                    b.HasOne("de.strewi.web.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.web.Models.Manufacture", "Manufacture")
                        .WithMany()
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.web.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("de.strewi.web.Models.HeadBadge", b =>
                {
                    b.HasOne("de.strewi.web.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.web.Models.Manufacture", "Manufacture")
                        .WithMany()
                        .HasForeignKey("ManufactureId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("de.strewi.web.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");
                });

            modelBuilder.Entity("de.strewi.web.Models.Manufacture", b =>
                {
                    b.HasOne("de.strewi.web.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID");

                    b.HasOne("de.strewi.web.Models.ApplicationUser", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID");

                    b.HasOne("de.strewi.web.Models.Manufacture", "OvertakenBy")
                        .WithMany()
                        .HasForeignKey("OvertakenById");
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
                    b.HasOne("de.strewi.web.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("de.strewi.web.Models.ApplicationUser")
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

                    b.HasOne("de.strewi.web.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
