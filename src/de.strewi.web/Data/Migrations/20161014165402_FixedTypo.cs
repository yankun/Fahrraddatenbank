using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace de.strewi.web.Data.Migrations
{
    public partial class FixedTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidForm",
                table: "Headbadges");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidFrom",
                table: "Headbadges",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Headbadges");

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidForm",
                table: "Headbadges",
                nullable: true);
        }
    }
}
