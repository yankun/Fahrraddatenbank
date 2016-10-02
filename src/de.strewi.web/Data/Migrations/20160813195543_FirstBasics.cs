using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace de.strewi.web.Data.Migrations
{
    public partial class FirstBasics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufactures",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false),
                    FoundedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufactures", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BearingShells",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CrankHoleDiameter = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false),
                    Depth = table.Column<double>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    InnerDiameter = table.Column<double>(nullable: false),
                    IsThreaded = table.Column<bool>(nullable: false),
                    ManufactureId = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<DateTime>(nullable: true),
                    OuterDiamteter = table.Column<double>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Side = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BearingShells", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BearingShells_Manufactures_ManufactureId",
                        column: x => x.ManufactureId,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrankAxles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false),
                    ManufactureId = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<DateTime>(nullable: true),
                    ThreadDiameter = table.Column<double>(nullable: false),
                    ThreadPitch = table.Column<int>(nullable: false),
                    Width = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrankAxles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CrankAxles_Manufactures_ManufactureId",
                        column: x => x.ManufactureId,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Headbadges",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<DateTime>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    HorizontalDistance = table.Column<double>(nullable: false),
                    ManufactureId = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<DateTime>(nullable: true),
                    MountingPoints = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    ValidForm = table.Column<DateTime>(nullable: false),
                    ValidTo = table.Column<DateTime>(nullable: false),
                    VerticalDistance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headbadges", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Headbadges_Manufactures_ManufactureId",
                        column: x => x.ManufactureId,
                        principalTable: "Manufactures",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_ManufactureId",
                table: "BearingShells",
                column: "ManufactureId");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_ManufactureId",
                table: "CrankAxles",
                column: "ManufactureId");

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_ManufactureId",
                table: "Headbadges",
                column: "ManufactureId");
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
                name: "Manufactures");
        }
    }
}
