using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace de.strewi.web.Data.Migrations
{
    public partial class FileNameToImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "BearingShells");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BearingShells",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Headbadges");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "BearingShells");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Headbadges",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "BearingShells",
                nullable: true);
        }
    }
}
