using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace de.strewi.web.Data.Migrations
{
    public partial class GeneralEnhancements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Manufactures");

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Manufactures",
                type: "ntext",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OvertakenById",
                table: "Manufactures",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StoppedProductionAt",
                table: "Manufactures",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsedColors",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufactures",
                maxLength: 255,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Manufactures",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Manufactures_OvertakenById",
                table: "Manufactures",
                column: "OvertakenById");

            migrationBuilder.AlterColumn<double>(
                name: "VerticalDistance",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidTo",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidForm",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Headbadges",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "HorizontalDistance",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Manufactures_Manufactures_OvertakenById",
                table: "Manufactures",
                column: "OvertakenById",
                principalTable: "Manufactures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Manufactures_Manufactures_OvertakenById",
                table: "Manufactures");

            migrationBuilder.DropIndex(
                name: "IX_Manufactures_OvertakenById",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "OvertakenById",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "StoppedProductionAt",
                table: "Manufactures");

            migrationBuilder.DropColumn(
                name: "UsedColors",
                table: "Headbadges");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Manufactures",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufactures",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Manufactures",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "VerticalDistance",
                table: "Headbadges",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidTo",
                table: "Headbadges",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidForm",
                table: "Headbadges",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "HorizontalDistance",
                table: "Headbadges",
                nullable: false);
        }
    }
}
