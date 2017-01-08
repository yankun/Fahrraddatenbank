using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace de.strewi.database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    IsActivated = table.Column<bool>(nullable: false),
                    Lastname = table.Column<string>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    MemberNumber = table.Column<int>(nullable: false),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    RegisteredAt = table.Column<DateTime>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValueChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NewValue = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueChanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Manufactures",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedByID = table.Column<string>(nullable: true),
                    FoundedAt = table.Column<DateTime>(nullable: false),
                    History = table.Column<string>(type: "ntext", nullable: true),
                    ModerationState = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedByID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    OvertakenAt = table.Column<DateTime>(nullable: true),
                    OvertakenById = table.Column<Guid>(nullable: true),
                    StoppedProductionAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufactures", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Manufactures_AspNetUsers_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Manufactures_AspNetUsers_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Manufactures_Manufactures_OvertakenById",
                        column: x => x.OvertakenById,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModerationQueue",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Action = table.Column<string>(nullable: true),
                    Controller = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedByID = table.Column<string>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    ModerationState = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedByID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModerationQueue", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ModerationQueue_AspNetUsers_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModerationQueue_AspNetUsers_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BearingShells",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CrankHoleDiameter = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedByID = table.Column<string>(nullable: true),
                    Depth = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    InnerDiameter = table.Column<double>(nullable: false),
                    IsThreaded = table.Column<bool>(nullable: false),
                    ManufacturerId = table.Column<Guid>(nullable: false),
                    ModerationState = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedByID = table.Column<string>(nullable: true),
                    OuterDiamteter = table.Column<double>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Side = table.Column<int>(nullable: false),
                    TimePeriod = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<int>(nullable: false),
                    ValidTo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BearingShells", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BearingShells_AspNetUsers_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BearingShells_Manufactures_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BearingShells_AspNetUsers_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrankAxles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedByID = table.Column<string>(nullable: true),
                    ManufacturerId = table.Column<Guid>(nullable: false),
                    ModerationState = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedByID = table.Column<string>(nullable: true),
                    ThreadDiameter = table.Column<double>(nullable: false),
                    ThreadPitch = table.Column<int>(nullable: false),
                    TimePeriod = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<int>(nullable: false),
                    ValidTo = table.Column<int>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrankAxles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CrankAxles_AspNetUsers_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrankAxles_Manufactures_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrankAxles_AspNetUsers_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Headbadges",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedByID = table.Column<string>(nullable: true),
                    HeadbadgeMaterial = table.Column<int>(nullable: false),
                    HorizontalDistance = table.Column<double>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    ManufacturerId = table.Column<Guid>(nullable: false),
                    ModerationState = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedByID = table.Column<string>(nullable: true),
                    MountingPoints = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    NumberOfMountingPoints = table.Column<int>(nullable: true),
                    TimePeriod = table.Column<string>(nullable: true),
                    UsedColors = table.Column<string>(nullable: true),
                    ValidFrom = table.Column<int>(nullable: false),
                    ValidTo = table.Column<int>(nullable: false),
                    VerticalDistance = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headbadges", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Headbadges_AspNetUsers_CreatedByID",
                        column: x => x.CreatedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Headbadges_Manufactures_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Headbadges_AspNetUsers_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_CreatedByID",
                table: "BearingShells",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_ManufacturerId",
                table: "BearingShells",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_ModifiedByID",
                table: "BearingShells",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_CreatedByID",
                table: "CrankAxles",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_ManufacturerId",
                table: "CrankAxles",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_ModifiedByID",
                table: "CrankAxles",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_CreatedByID",
                table: "Headbadges",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_ManufacturerId",
                table: "Headbadges",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_ModifiedByID",
                table: "Headbadges",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_CreatedByID",
                table: "Manufactures",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_ModifiedByID",
                table: "Manufactures",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_OvertakenById",
                table: "Manufactures",
                column: "OvertakenById");

            migrationBuilder.CreateIndex(
                name: "IX_ModerationQueue_CreatedByID",
                table: "ModerationQueue",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_ModerationQueue_ModifiedByID",
                table: "ModerationQueue",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BearingShells");

            migrationBuilder.DropTable(
                name: "CrankAxles");

            migrationBuilder.DropTable(
                name: "Headbadges");

            migrationBuilder.DropTable(
                name: "ModerationQueue");

            migrationBuilder.DropTable(
                name: "ValueChanges");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Manufactures");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
