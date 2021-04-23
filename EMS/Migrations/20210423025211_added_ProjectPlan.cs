using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMS.Migrations
{
    public partial class added_ProjectPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProjectPlan",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectPlan",
                table: "Projects");
        }
    }
}
