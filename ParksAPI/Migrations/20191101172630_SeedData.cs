using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Solution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Miles", "Name", "State" },
                values: new object[,]
                {
                    { 2, 1070, "Zion National Park", "Utah" },
                    { 3, 722, "Yosemite National Park", "California" },
                    { 4, 3360, "Acadia National Park", "Maine" },
                    { 5, 819, "Grand Teton National Park", "Wyoming" },
                    { 6, 991, "Arches National Park", "Utah" },
                    { 7, 1096, "Joshua Tree National Park", "California" },
                    { 8, 829, "Sequoia National Park", "California" },
                    { 9, 647, "Glacier National Park", "Montana" },
                    { 10, 987, "Capitol Reef National Park", "Utah" },
                    { 11, 1254, "Badlands National Park", "South Dakota" },
                    { 12, 1306, "Great Sand Dunes", "Colorado" },
                    { 13, 136, "Mount Rainer National Park", "Washington" },
                    { 14, 3484, "Dry Tortugas National Park", "Florida" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);
        }
    }
}
