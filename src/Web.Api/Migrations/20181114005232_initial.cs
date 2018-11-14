using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Api.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    HeightCm = table.Column<int>(nullable: false),
                    WeightKg = table.Column<decimal>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "HeightCm", "LastName", "Modified", "WeightKg" },
                values: new object[] { 1, new DateTime(1987, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 14, 0, 52, 32, 562, DateTimeKind.Utc), "Sidney", 180, "Crosby", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 91m });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "HeightCm", "LastName", "Modified", "WeightKg" },
                values: new object[] { 2, new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 14, 0, 52, 32, 563, DateTimeKind.Utc), "Connor", 185, "McDavid", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 88m });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "HeightCm", "LastName", "Modified", "WeightKg" },
                values: new object[] { 3, new DateTime(1997, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 14, 0, 52, 32, 563, DateTimeKind.Utc), "Auston", 191, "Matthews", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "HeightCm", "LastName", "Modified", "WeightKg" },
                values: new object[] { 4, new DateTime(1988, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 14, 0, 52, 32, 563, DateTimeKind.Utc), "Patrick", 180, "Kane", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 177m });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "HeightCm", "LastName", "Modified", "WeightKg" },
                values: new object[] { 5, new DateTime(1989, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 14, 0, 52, 32, 563, DateTimeKind.Utc), "Drew", 185, "Doughty", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "HeightCm", "LastName", "Modified", "WeightKg" },
                values: new object[] { 6, new DateTime(1990, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 14, 0, 52, 32, 563, DateTimeKind.Utc), "Erik", 183, "Karlsson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
