using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeriodCalculator.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Period",
            //     columns: table => new
            //{
            //Id = table.Column<int>(nullable: false)
            //          .Annotation("Sqlite:Autoincrement", true),
            //PeriodCalculated = table.Column<DateTime>(nullable: false),
            //StartDate = table.Column<DateTime>(nullable: false),
            //EndDate = table.Column<DateTime>(nullable: false)
            //},
            //constraints: table =>
            //{
            //table.PrimaryKey("PK_Period", x => x.Id);
            //});


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //name: "Period");
        }
    }
}
