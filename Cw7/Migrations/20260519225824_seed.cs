using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cw7.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComponentManufacturers",
                columns: new[] { "Id", "Abbreviation", "FoundationDate", "FullName" },
                values: new object[,]
                {
                    { 1, "MSI", new DateTime(1986, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Micro-Star-International" },
                    { 2, "Apple", new DateTime(1976, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Inc." },
                    { 3, "Asus", new DateTime(1989, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asus Inc." },
                    { 4, "Intel", new DateTime(1968, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intel Inc." },
                    { 5, "Nvidia", new DateTime(1993, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nvidia Inc." }
                });

            migrationBuilder.InsertData(
                table: "ComponentTypes",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 1, "cpu", "Central processing unit" },
                    { 2, "gpu", "Graphics processing unit" },
                    { 3, "mobo", "Mother Board" }
                });

            migrationBuilder.InsertData(
                table: "PCs",
                columns: new[] { "Id", "CreatedAt", "Name", "Stock", "Warranty", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 20, 0, 58, 23, 798, DateTimeKind.Local).AddTicks(1396), "Gaming Beast X", 5, 36, 12.5f },
                    { 2, new DateTime(2026, 4, 20, 0, 58, 23, 806, DateTimeKind.Local).AddTicks(9374), "Office Mini Pro", 12, 24, 4.2f },
                    { 3, new DateTime(2025, 5, 20, 0, 58, 23, 806, DateTimeKind.Local).AddTicks(9475), "Macbook pro", 0, 12, 1.55f }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Code", "ComponentManufacturersId", "ComponentTypesId", "Description", "Name" },
                values: new object[,]
                {
                    { "abc1", 5, 2, "flagship gpu", "RTX4090" },
                    { "abc2", 4, 2, "dedicated intel gpu", "ArcB580" },
                    { "abc3", 5, 1, "flagship intel consumer cpu", "ultra 9" },
                    { "abc4", 2, 1, "Apple silicon cpu", "M5" },
                    { "abc5", 1, 3, "Great gaming motherboard", "super gaming mobo" },
                    { "abc6", 1, 3, "budget motherboard", "epic shadow mobo" }
                });

            migrationBuilder.InsertData(
                table: "PCComponents",
                columns: new[] { "ComponentCode", "PCId", "Amount" },
                values: new object[,]
                {
                    { "abc1", 1, 1 },
                    { "abc3", 1, 1 },
                    { "abc5", 1, 1 },
                    { "abc2", 2, 0 },
                    { "abc3", 2, 0 },
                    { "abc6", 2, 1 },
                    { "abc4", 3, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "abc1", 1 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "abc3", 1 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "abc5", 1 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "abc2", 2 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "abc3", 2 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "abc6", 2 });

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumns: new[] { "ComponentCode", "PCId" },
                keyValues: new object[] { "abc4", 3 });

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "abc1");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "abc2");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "abc3");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "abc4");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "abc5");

            migrationBuilder.DeleteData(
                table: "Components",
                keyColumn: "Code",
                keyValue: "abc6");

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ComponentManufacturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ComponentTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
