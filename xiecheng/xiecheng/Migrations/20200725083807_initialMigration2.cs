using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xiecheng.Migrations
{
    public partial class initialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreatTime", "DepartureTime", "Description", "DiscoutPresent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("a623a7c3-af7a-481d-a9b5-79d08325ca81"), new DateTime(2020, 7, 25, 8, 38, 6, 958, DateTimeKind.Utc).AddTicks(7483), null, "shuoming", null, null, null, null, 0m, "Ceshititle", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("a623a7c3-af7a-481d-a9b5-79d08325ca81"));
        }
    }
}
