using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xiecheng.Migrations
{
    public partial class initialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"),
                column: "DiscountPresent",
                value: 0.8m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"),
                column: "DiscountPresent",
                value: null);
        }
    }
}
