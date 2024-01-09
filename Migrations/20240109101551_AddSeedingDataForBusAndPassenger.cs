using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFRelationships2.Migrations
{
    public partial class AddSeedingDataForBusAndPassenger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Brand", "NumberOfSeats" },
                values: new object[] { 1, "Volvo", 40 });

            migrationBuilder.InsertData(
                table: "Buses",
                columns: new[] { "Id", "Brand", "NumberOfSeats" },
                values: new object[] { 2, "Mercedes", 45 });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "BusId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "John" },
                    { 2, 2, "Mark" },
                    { 3, 1, "Sam" },
                    { 4, 1, "Linda" },
                    { 5, 2, "Frank" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
