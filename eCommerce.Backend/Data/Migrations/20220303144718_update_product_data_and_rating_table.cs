using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Data.Migrations
{
    public partial class update_product_data_and_rating_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatePoint = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("725efe2e-a534-40c4-ab0d-20c947e6c0eb"),
                column: "ConcurrencyStamp",
                value: "d379edef-0a85-48c9-9c1d-99d4eddf540b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf517a65-75d0-480c-9566-601b1e607d25"),
                columns: new[] { "ConcurrencyStamp", "Dob", "PasswordHash" },
                values: new object[] { "c063d31a-c81f-4626-8d4c-3fb21b7d4631", new DateTime(2022, 3, 3, 21, 47, 18, 263, DateTimeKind.Local).AddTicks(1170), "AQAAAAEAACcQAAAAEDUwHKTufxBPeXT50w5jzz+xI2JfKCuGl5OzWfK6MfubC2cGccz1IsNssqQWcnW1ow==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7090), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7090), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7110), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7110), true });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ProductId",
                table: "Ratings",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    RatePoint = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_Rates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("725efe2e-a534-40c4-ab0d-20c947e6c0eb"),
                column: "ConcurrencyStamp",
                value: "fa0cc195-9f6f-4cf3-9d4b-43c556b375fc");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf517a65-75d0-480c-9566-601b1e607d25"),
                columns: new[] { "ConcurrencyStamp", "Dob", "PasswordHash" },
                values: new object[] { "91d45e1e-f752-462e-859f-43fe16e1cc97", new DateTime(2022, 2, 24, 16, 48, 17, 613, DateTimeKind.Local).AddTicks(8840), "AQAAAAEAACcQAAAAED2y4kGMvjzV4j0QdD8QbV1RsMyYJSjQgs2r6BL+UaJuqr198WgB6XK7qq83auHcmg==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4190), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4190), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4190), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4190), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4200), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4200), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4200), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4200), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "IsFeatured" },
                values: new object[] { new DateTime(2022, 2, 24, 16, 48, 17, 609, DateTimeKind.Local).AddTicks(4210), false });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ProductId",
                table: "Rates",
                column: "ProductId");
        }
    }
}
