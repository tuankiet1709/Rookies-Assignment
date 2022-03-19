using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Data.Migrations
{
    public partial class Update_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropColumn(
                name: "DecreasedPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoTitle",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SeoTitle",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "SeoDescription",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "SeoTitle",
                table: "Brands");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "Products",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Products",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "SeoDescription",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "Categories",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Categories",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "Brands",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Brands",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsShowOnHome",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("725efe2e-a534-40c4-ab0d-20c947e6c0eb"),
                column: "ConcurrencyStamp",
                value: "7db8366a-3b48-4080-b1fb-fd18fd4c1601");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf517a65-75d0-480c-9566-601b1e607d25"),
                columns: new[] { "ConcurrencyStamp", "Dob", "PasswordHash" },
                values: new object[] { "2bbb265e-a5df-42ed-b314-d69628a77939", new DateTime(2022, 3, 13, 16, 15, 54, 120, DateTimeKind.Local).AddTicks(2030), "AQAAAAEAACcQAAAAEATEUIP6Oyd/XvoQoSO6ENHarrmTAl7GVOIMwyktYkRxuXasl9RrvuDYgt1tIe7hYg==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(940), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(950), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(950), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(950), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(950), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(950), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(960), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(960), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(960), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(960), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(960), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(960), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(960), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(970), "Lorem Ipsum is simply dummy text of the printing and typesetting industry." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 14, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 12, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2022, 3, 13, 16, 15, 54, 116, DateTimeKind.Local).AddTicks(1000) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Products",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Products",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Categories",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "SeoDescription");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Brands",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Brands",
                newName: "DateCreated");

            migrationBuilder.AlterColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<decimal>(
                name: "DecreasedPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoDescription",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoTitle",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "IsShowOnHome",
                table: "Categories",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Categories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoTitle",
                table: "Categories",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoDescription",
                table: "Brands",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeoTitle",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ApplyAll = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LimitedOrderPrice = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discounts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExternalTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
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
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6940), "Andora", "Andora's accessories", "Andora's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6960), "Apple", "Apple's accessories", "Apple's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6960), "Anker", "Anker's accessories", "Anker's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6960), "Baseus", "Baseus's accessories", "Baseus's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970), "Hyper", "Hyper's accessories", "Hyper's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970), "Filco", "Filco's accessories", "Filco's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970), "JCPAL", "JCPAL's accessories", "JCPAL's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970), "Keychrone", "Keychrone's accessories", "Keychrone's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970), "Lofree", "Lofree's accessories", "Lofree's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970), "Logitech", "Logitech's accessories", "Logitech's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6970), "Mocoll", "Mocoll's accessories", "Mocoll's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6980), "Philips", "Philips's accessories", "Philips's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6980), "Tucano", "Tucano's accessories", "Tucano's accessories" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(6980), "WIWU", "WIWU's accessories", "WIWU's accessories" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000), "Macbook-accessories", "The accessories products for Macbook", "The accessories products for Macbook" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000), "Iphone-accessories", "The accessories product for Iphone", "The accessories product for Iphone" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000), "Ipad-accessories", "The accessories product for Ipad", "The accessories product for Ipad" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7000), "Mechanical", "The Mechanical products for Apple devices", "The Mechanical products for Apple devices" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010), "macbook-sticker", "Sticker for Macbook", "Macbook sticker" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010), "usb-c-hub", "Usb-c Hub", "Usb-c Hub" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010), "iphone-charging-cable", "The charging cable for Iphone", "Iphone Charging Cable" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7010), "iphone-stand", "Stand for Iphone", "Iphone Stand" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060), "ipad-case", "Case for Ipad", "Ipad Case" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060), "ipad-tempered-glass", "Tempered glass for Ipad", "Ipad Tempered Glass" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060), "ipad-stand", "Stand for Ipad", "Ipad Stand" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060), "mechanical-keyboard", "Mechanical Keyboard", "Mechanical Keyboard" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060), "mechanical-mouse", "Mechanical Mouse", "Mechanical Mouse" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7060), "macbook-cleaning-kit", "Macbook Cleaning Kit", "Macbook Cleaning Kit" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 14, 1 },
                    { 1, 2 },
                    { 6, 2 },
                    { 1, 3 },
                    { 5, 3 },
                    { 2, 4 },
                    { 7, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 8, 5 },
                    { 11, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 3, 6 },
                    { 9, 6 },
                    { 3, 7 },
                    { 10, 7 },
                    { 4, 8 },
                    { 12, 8 },
                    { 4, 9 },
                    { 13, 9 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7090), "jcpal-5in1-premium-cleaning-set-for-macbook-laptop-phone-camera", "JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera", "JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7090), "hyperdrive-dual-4k-hdmi-10in1-usbc-hubport-2-monitors-macbook-m1", "Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1", "Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), "andora-6in1-macbook-stickers-for-macbook-pro-16-inch-2021", "Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021", "Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), "apple-20w-usb-typec-charger", "Apple 20W USB Type-C Charger", "Apple 20W USB Type-C Charger" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), "standaluminum-elevator-stand-for-iphone-ipad-phone-with-adjustable-tilt-angle-wiwu", "Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU", "Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), "hwiwu-waltz-rotating-keyboard-case--bluetooth-keyboard-with-tracpad-360-degree-rotating-screen-wiwu-waltz-rotating-keyboard-for-ipad-pro-11-inch-20182021-air-4-and-ipad-gen-789", "WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9", "WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7100), "9h-antiscratch-antishock-antifingerprint-tempered-glass-for-all-ipad-jcpal-iclara-ipad-pro-11-pro-129-air-1234-mini-6-gen-234-56789", "9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)", "9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7110), "keychron-k6-mechanical-keyboard-aluminum-–-no-led-–-hotswap", "KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP", "KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { new DateTime(2022, 3, 3, 21, 47, 18, 258, DateTimeKind.Local).AddTicks(7110), "lofree-maus-blue-pearl-bluetooth-mouse", "LOFREE Maus Blue Pearl Bluetooth Mouse", "LOFREE Maus Blue Pearl Bluetooth Mouse" });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_CategoryId",
                table: "Discounts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ProductId",
                table: "Discounts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");
        }
    }
}
