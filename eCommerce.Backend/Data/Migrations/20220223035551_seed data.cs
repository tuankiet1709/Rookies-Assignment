using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Backend.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ShipName",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ShipEmail",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ShipAddress",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Discounts",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Brands",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Appconfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeDescription", "This is description of eCommerceWebsite" },
                    { "HomeKeyword", "This is keyword of eCommerceWebsite" },
                    { "HomeTitle", "This is home page of eCommerceWebsite" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "DateCreated", "DateModified", "Image", "IsShowOnHome", "Name", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6600), null, "", true, "Andora", "Andora", "Andora's accessories", "Andora's accessories", 0, 1 },
                    { 2, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6620), null, "", true, "Apple", "Apple", "Apple's accessories", "Apple's accessories", 0, 1 },
                    { 3, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6620), null, "", true, "Anker", "Anker", "Anker's accessories", "Anker's accessories", 0, 1 },
                    { 4, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6620), null, "", true, "Baseus", "Baseus", "Baseus's accessories", "Baseus's accessories", 0, 1 },
                    { 5, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6620), null, "", true, "Hyper", "Hyper", "Hyper's accessories", "Hyper's accessories", 0, 1 },
                    { 6, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6630), null, "", true, "Filco", "Filco", "Filco's accessories", "Filco's accessories", 0, 1 },
                    { 7, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6630), null, "", true, "JCPAL", "JCPAL", "JCPAL's accessories", "JCPAL's accessories", 0, 1 },
                    { 8, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6630), null, "", true, "Keychrone", "Keychrone", "Keychrone's accessories", "Keychrone's accessories", 0, 1 },
                    { 9, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6630), null, "", true, "Lofree", "Lofree", "Lofree's accessories", "Lofree's accessories", 0, 1 },
                    { 10, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6630), null, "", true, "Logitech", "Logitech", "Logitech's accessories", "Logitech's accessories", 0, 1 },
                    { 11, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6630), null, "", true, "Mocoll", "Mocoll", "Mocoll's accessories", "Mocoll's accessories", 0, 1 },
                    { 13, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6630), null, "", true, "Philips", "Philips", "Philips's accessories", "Philips's accessories", 0, 1 },
                    { 14, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6640), null, "", true, "Tucano", "Tucano", "Tucano's accessories", "Tucano's accessories", 0, 1 },
                    { 15, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6640), null, "", true, "WIWU", "WIWU", "WIWU's accessories", "WIWU's accessories", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsShowOnHome", "Name", "ParentId", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6840), null, true, "Macbook's Accessories", null, "Macbook-accessories", "The accessories products for Macbook", "The accessories products for Macbook", 0, 1 },
                    { 2, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6850), null, true, "Iphone's Accessories", null, "Iphone-accessories", "The accessories product for Iphone", "The accessories product for Iphone", 0, 1 },
                    { 3, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6850), null, true, "Ipad's Accessories", null, "Ipad-accessories", "The accessories product for Ipad", "The accessories product for Ipad", 0, 1 },
                    { 4, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6850), null, true, "Mechanical", null, "Mechanical", "The Mechanical products for Apple devices", "The Mechanical products for Apple devices", 0, 1 },
                    { 5, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6850), null, true, "Macbook sticker", 1, "macbook-sticker", "Sticker for Macbook", "Macbook sticker", 0, 1 },
                    { 6, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6850), null, true, "Usb-c Hub", 1, "usb-c-hub", "Usb-c Hub", "Usb-c Hub", 0, 1 },
                    { 7, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6850), null, true, "Iphone Charging Cable", 2, "iphone-charging-cable", "The charging cable for Iphone", "Iphone Charging Cable", 0, 1 },
                    { 8, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6850), null, true, "Iphone Stand", 2, "iphone-stand", "Stand for Iphone", "Iphone Stand", 0, 1 },
                    { 9, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6860), null, true, "Ipad Case", 3, "ipad-case", "Case for Ipad", "Ipad Case", 0, 1 },
                    { 10, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6860), null, true, "Ipad Tempered Glass", 3, "ipad-tempered-glass", "Tempered glass for Ipad", "Ipad Tempered Glass", 0, 1 },
                    { 11, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6860), null, true, "Ipad Stand", 3, "ipad-stand", "Stand for Ipad", "Ipad Stand", 0, 1 },
                    { 12, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6860), null, true, "Mechanical Keyboard", 4, "mechanical-keyboard", "Mechanical Keyboard", "Mechanical Keyboard", 0, 1 },
                    { 13, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6860), null, true, "Mechanical Mouse", 4, "mechanical-mouse", "Mechanical Mouse", "Mechanical Mouse", 0, 1 },
                    { 14, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6860), null, true, "Macbook Cleaning Kit", 1, "macbook-cleaning-kit", "Macbook Cleaning Kit", "Macbook Cleaning Kit", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "DateCreated", "DateModified", "DecreasedPrice", "Description", "Details", "IsFeatured", "Name", "OriginalPrice", "Price", "SeoAlias", "SeoDescription", "SeoTitle", "Stock" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6890), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera", 180000m, 200000m, "jcpal-5in1-premium-cleaning-set-for-macbook-laptop-phone-camera", "JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera", "JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera", 10 },
                    { 2, 6, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6890), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1", 180000m, 200000m, "hyperdrive-dual-4k-hdmi-10in1-usbc-hubport-2-monitors-macbook-m1", "Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1", "Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1", 10 },
                    { 3, 1, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6890), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021", 600000m, 650000m, "andora-6in1-macbook-stickers-for-macbook-pro-16-inch-2021", "Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021", "Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021", 10 },
                    { 4, 2, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6890), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "Apple 20W USB Type-C Charger", 650000m, 700000m, "apple-20w-usb-typec-charger", "Apple 20W USB Type-C Charger", "Apple 20W USB Type-C Charger", 10 },
                    { 5, 15, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6900), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU", 210000m, 250000m, "standaluminum-elevator-stand-for-iphone-ipad-phone-with-adjustable-tilt-angle-wiwu", "Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU", "Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU", 10 },
                    { 6, 15, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6900), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9", 1100000m, 1300000m, "hwiwu-waltz-rotating-keyboard-case--bluetooth-keyboard-with-tracpad-360-degree-rotating-screen-wiwu-waltz-rotating-keyboard-for-ipad-pro-11-inch-20182021-air-4-and-ipad-gen-789", "WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9", "WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9", 10 },
                    { 7, 7, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6900), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)", 300000m, 350000m, "9h-antiscratch-antishock-antifingerprint-tempered-glass-for-all-ipad-jcpal-iclara-ipad-pro-11-pro-129-air-1234-mini-6-gen-234-56789", "9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)", "9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)", 10 },
                    { 8, 8, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6900), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP", 16000000m, 1890000m, "keychron-k6-mechanical-keyboard-aluminum-–-no-led-–-hotswap", "KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP", "KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP", 10 },
                    { 9, 9, new DateTime(2022, 2, 23, 10, 55, 51, 429, DateTimeKind.Local).AddTicks(6900), null, 0m, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", false, "LOFREE Maus Blue Pearl Bluetooth Mouse", 1200000m, 1500000m, "lofree-maus-blue-pearl-bluetooth-mouse", "LOFREE Maus Blue Pearl Bluetooth Mouse", "LOFREE Maus Blue Pearl Bluetooth Mouse", 10 }
                });

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
                    { 11, 5 },
                    { 3, 6 },
                    { 9, 6 },
                    { 3, 7 },
                    { 10, 7 },
                    { 4, 8 },
                    { 12, 8 },
                    { 4, 9 },
                    { 13, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "Appconfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShipName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ShipEmail",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ShipAddress",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Discounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "Brands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
