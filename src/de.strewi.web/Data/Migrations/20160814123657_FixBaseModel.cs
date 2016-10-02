using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace de.strewi.web.Data.Migrations
{
    public partial class FixBaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CrankAxles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CrankAxles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BearingShells");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "BearingShells");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByID",
                table: "Manufactures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByID",
                table: "Manufactures",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByID",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByID",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByID",
                table: "CrankAxles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByID",
                table: "CrankAxles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByID",
                table: "BearingShells",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByID",
                table: "BearingShells",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_CreatedByID",
                table: "Manufactures",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_ModifiedByID",
                table: "Manufactures",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_CreatedByID",
                table: "Headbadges",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Headbadges_ModifiedByID",
                table: "Headbadges",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_CreatedByID",
                table: "CrankAxles",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_CrankAxles_ModifiedByID",
                table: "CrankAxles",
                column: "ModifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_CreatedByID",
                table: "BearingShells",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_BearingShells_ModifiedByID",
                table: "BearingShells",
                column: "ModifiedByID");

            migrationBuilder.AddForeignKey(
                name: "FK_BearingShells_AspNetUsers_CreatedByID",
                table: "BearingShells",
                column: "CreatedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BearingShells_AspNetUsers_ModifiedByID",
                table: "BearingShells",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrankAxles_AspNetUsers_CreatedByID",
                table: "CrankAxles",
                column: "CreatedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CrankAxles_AspNetUsers_ModifiedByID",
                table: "CrankAxles",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headbadges_AspNetUsers_CreatedByID",
                table: "Headbadges",
                column: "CreatedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headbadges_AspNetUsers_ModifiedByID",
                table: "Headbadges",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manufactures_AspNetUsers_CreatedByID",
                table: "Manufactures",
                column: "CreatedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Manufactures_AspNetUsers_ModifiedByID",
                table: "Manufactures",
                column: "ModifiedByID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BearingShells_AspNetUsers_CreatedByID",
                table: "BearingShells");

            migrationBuilder.DropForeignKey(
                name: "FK_BearingShells_AspNetUsers_ModifiedByID",
                table: "BearingShells");

            migrationBuilder.DropForeignKey(
                name: "FK_CrankAxles_AspNetUsers_CreatedByID",
                table: "CrankAxles");

            migrationBuilder.DropForeignKey(
                name: "FK_CrankAxles_AspNetUsers_ModifiedByID",
                table: "CrankAxles");

            migrationBuilder.DropForeignKey(
                name: "FK_Headbadges_AspNetUsers_CreatedByID",
                table: "Headbadges");

            migrationBuilder.DropForeignKey(
                name: "FK_Headbadges_AspNetUsers_ModifiedByID",
                table: "Headbadges");

            migrationBuilder.DropForeignKey(
                name: "FK_Manufactures_AspNetUsers_CreatedByID",
                table: "Manufactures");

            migrationBuilder.DropForeignKey(
                name: "FK_Manufactures_AspNetUsers_ModifiedByID",
                table: "Manufactures");

            migrationBuilder.DropIndex(
                name: "IX_Manufactures_CreatedByID",
                table: "Manufactures");

            migrationBuilder.DropIndex(
                name: "IX_Manufactures_ModifiedByID",
                table: "Manufactures");

            migrationBuilder.DropIndex(
                name: "IX_Headbadges_CreatedByID",
                table: "Headbadges");

            migrationBuilder.DropIndex(
                name: "IX_Headbadges_ModifiedByID",
                table: "Headbadges");

            migrationBuilder.DropIndex(
                name: "IX_CrankAxles_CreatedByID",
                table: "CrankAxles");

            migrationBuilder.DropIndex(
                name: "IX_CrankAxles_ModifiedByID",
                table: "CrankAxles");

            migrationBuilder.DropIndex(
                name: "IX_BearingShells_CreatedByID",
                table: "BearingShells");

            migrationBuilder.DropIndex(
                name: "IX_BearingShells_ModifiedByID",
                table: "BearingShells");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "ModifiedByID",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "ModifiedByID",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "CrankAxles");

            migrationBuilder.DropColumn(
                name: "ModifiedByID",
                table: "CrankAxles");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "BearingShells");

            migrationBuilder.DropColumn(
                name: "ModifiedByID",
                table: "BearingShells");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedBy",
                table: "Manufactures",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedBy",
                table: "Manufactures",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedBy",
                table: "Headbadges",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedBy",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedBy",
                table: "CrankAxles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedBy",
                table: "CrankAxles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedBy",
                table: "BearingShells",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedBy",
                table: "BearingShells",
                nullable: true);
        }
    }
}
