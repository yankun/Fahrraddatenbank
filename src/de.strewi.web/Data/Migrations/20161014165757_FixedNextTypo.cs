using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace de.strewi.web.Data.Migrations
{
    public partial class FixedNextTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BearingShells_Manufactures_ManufactureId",
                table: "BearingShells");

            migrationBuilder.DropForeignKey(
                name: "FK_CrankAxles_Manufactures_ManufactureId",
                table: "CrankAxles");

            migrationBuilder.DropForeignKey(
                name: "FK_Headbadges_Manufactures_ManufactureId",
                table: "Headbadges");

            migrationBuilder.DropIndex(
                name: "IX_Headbadges_ManufactureId",
                table: "Headbadges");

            migrationBuilder.DropIndex(
                name: "IX_CrankAxles_ManufactureId",
                table: "CrankAxles");

            migrationBuilder.DropIndex(
                name: "IX_BearingShells_ManufactureId",
                table: "BearingShells");

            migrationBuilder.DropColumn(
                name: "ManufactureId",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "ManufactureId",
                table: "CrankAxles");

            migrationBuilder.DropColumn(
                name: "ManufactureId",
                table: "BearingShells");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Headbadges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "CrankAxles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "BearingShells",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_ManufacturerId",
                table: "Headbadges",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_ManufacturerId",
                table: "CrankAxles",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_ManufacturerId",
                table: "BearingShells",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BearingShells_Manufactures_ManufacturerId",
                table: "BearingShells",
                column: "ManufacturerId",
                principalTable: "Manufactures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CrankAxles_Manufactures_ManufacturerId",
                table: "CrankAxles",
                column: "ManufacturerId",
                principalTable: "Manufactures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Headbadges_Manufactures_ManufacturerId",
                table: "Headbadges",
                column: "ManufacturerId",
                principalTable: "Manufactures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BearingShells_Manufactures_ManufacturerId",
                table: "BearingShells");

            migrationBuilder.DropForeignKey(
                name: "FK_CrankAxles_Manufactures_ManufacturerId",
                table: "CrankAxles");

            migrationBuilder.DropForeignKey(
                name: "FK_Headbadges_Manufactures_ManufacturerId",
                table: "Headbadges");

            migrationBuilder.DropIndex(
                name: "IX_Headbadges_ManufacturerId",
                table: "Headbadges");

            migrationBuilder.DropIndex(
                name: "IX_CrankAxles_ManufacturerId",
                table: "CrankAxles");

            migrationBuilder.DropIndex(
                name: "IX_BearingShells_ManufacturerId",
                table: "BearingShells");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "CrankAxles");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "BearingShells");

            migrationBuilder.AddColumn<int>(
                name: "ManufactureId",
                table: "Headbadges",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufactureId",
                table: "CrankAxles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufactureId",
                table: "BearingShells",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_ManufactureId",
                table: "Headbadges",
                column: "ManufactureId");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_ManufactureId",
                table: "CrankAxles",
                column: "ManufactureId");

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_ManufactureId",
                table: "BearingShells",
                column: "ManufactureId");

            migrationBuilder.AddForeignKey(
                name: "FK_BearingShells_Manufactures_ManufactureId",
                table: "BearingShells",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CrankAxles_Manufactures_ManufactureId",
                table: "CrankAxles",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Headbadges_Manufactures_ManufactureId",
                table: "Headbadges",
                column: "ManufactureId",
                principalTable: "Manufactures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
