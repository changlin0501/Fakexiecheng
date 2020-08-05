using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace xiecheng.Migrations
{
    public partial class initialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatTime",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "DiscoutPresent",
                table: "TouristRoutes");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "TouristRoutes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DepartureCity",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPresent",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TravelDays",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TripType",
                table: "TouristRoutes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("2430bf64-fd56-460c-8b75-da0a1d1cd74c"),
                columns: new[] { "DepartureCity", "DiscountPresent", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 0.1m, 5.0, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47110"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 3.2000000000000002, 2, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47111"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47112"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 5.0, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47113"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47114"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47115"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47116"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47117"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47118"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47119"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 4.5, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("39996f34-013c-4fc6-b1b3-0c1036c47169"),
                columns: new[] { "DepartureCity", "Rating", "TravelDays", "TripType" },
                values: new object[] { 3, 2.1000000000000001, 6, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("3ecbcd92-a9e0-45f7-9b29-e03272cb0862"),
                columns: new[] { "DepartureCity", "DiscountPresent", "Rating", "TravelDays", "TripType" },
                values: new object[] { 1, 0.1m, 5.0, 4, 3 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("88cf89b9-e4b5-4b42-a5bf-622bd3039601"),
                columns: new[] { "DepartureCity", "DiscountPresent", "Rating", "TravelDays", "TripType" },
                values: new object[] { 2, 0.5m, 3.0, 2, 4 });

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("a1fd0bee-0afc-4586-96c8-f46b7c99d2a0"),
                column: "DiscountPresent",
                value: 0.1m);

            migrationBuilder.UpdateData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("fb6d4f10-79ed-4aff-a915-4ce29dc9c7e1"),
                columns: new[] { "DepartureCity", "DiscountPresent", "Rating", "TravelDays", "TripType" },
                values: new object[] { 0, 0.1m, 3.5, 8, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "DepartureCity",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "DiscountPresent",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "TravelDays",
                table: "TouristRoutes");

            migrationBuilder.DropColumn(
                name: "TripType",
                table: "TouristRoutes");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatTime",
                table: "TouristRoutes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "DiscoutPresent",
                table: "TouristRoutes",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
