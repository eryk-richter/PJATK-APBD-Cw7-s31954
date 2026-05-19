using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cw7.Migrations
{
    /// <inheritdoc />
    public partial class fixDateTimeErrorAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Stock" },
                values: new object[] { new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 20, 0, 58, 23, 798, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 20, 0, 58, 23, 806, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Stock" },
                values: new object[] { new DateTime(2025, 5, 20, 0, 58, 23, 806, DateTimeKind.Local).AddTicks(9475), 0 });
        }
    }
}
