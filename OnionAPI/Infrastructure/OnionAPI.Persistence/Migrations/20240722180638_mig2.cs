using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 570, DateTimeKind.Utc).AddTicks(3282), "Electronics, Music & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 570, DateTimeKind.Utc).AddTicks(3293), "Computers & Grocery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 570, DateTimeKind.Utc).AddTicks(3301), "Baby & Baby" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 18, 6, 38, 570, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 18, 6, 38, 570, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 18, 6, 38, 570, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 18, 6, 38, 570, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 572, DateTimeKind.Utc).AddTicks(211), "Magnam omnis quaerat omnis maiores.", "Occaecati." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 572, DateTimeKind.Utc).AddTicks(247), "Repellendus laudantium quasi dolore soluta.", "Illum rerum." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 572, DateTimeKind.Utc).AddTicks(271), "Maiores corrupti sed dicta repellendus.", "Dolor." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 574, DateTimeKind.Utc).AddTicks(1280), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3.936355604978390m, 947.14m, "Handcrafted Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 18, 6, 38, 574, DateTimeKind.Utc).AddTicks(1303), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8.903103683205910m, 900.00m, "Licensed Frozen Soap" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 167, DateTimeKind.Utc).AddTicks(677), "Shoes & Toys" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 167, DateTimeKind.Utc).AddTicks(684), "Garden" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 167, DateTimeKind.Utc).AddTicks(700), "Computers, Movies & Garden" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 16, 27, 47, 167, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 16, 27, 47, 167, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 16, 27, 47, 167, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 22, 16, 27, 47, 167, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 168, DateTimeKind.Utc).AddTicks(7398), "Placeat et veritatis dolorum est.", "Et." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 168, DateTimeKind.Utc).AddTicks(7428), "Et aliquid voluptas autem eaque.", "Nihil natus." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 168, DateTimeKind.Utc).AddTicks(7456), "Quia autem hic quam iusto.", "Dolorem." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 173, DateTimeKind.Utc).AddTicks(6501), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8.180205667256060m, 330.54m, "Ergonomic Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 27, 47, 173, DateTimeKind.Utc).AddTicks(6526), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9.299734183535780m, 433.45m, "Handcrafted Plastic Car" });
        }
    }
}
