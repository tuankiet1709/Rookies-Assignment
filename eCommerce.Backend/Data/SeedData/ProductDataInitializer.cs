using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Data.SeedData
{
    public static class ProductDataInitializer
    {
        public static void SeedProductData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="jcpal-5in1-premium-cleaning-set-for-macbook-laptop-phone-camera",
                    SeoDescription="JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera",
                    SeoTitle="JCPAL 5in1 Premium Cleaning Set For Macbook, Laptop, Phone, Camera",
                    OriginalPrice=180000,
                    Price=200000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=7
                },new Product
                {
                    Id = 2,
                    Name = "Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="hyperdrive-dual-4k-hdmi-10in1-usbc-hubport-2-monitors-macbook-m1",
                    SeoDescription="Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1",
                    SeoTitle="Hyperdrive Dual 4K HDMI 10in1 USB-C Hub/Port (2 monitors) Macbook M1",
                    OriginalPrice=180000,
                    Price=200000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=6
                },new Product
                {
                    Id = 3,
                    Name = "Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="andora-6in1-macbook-stickers-for-macbook-pro-16-inch-2021",
                    SeoDescription="Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021",
                    SeoTitle="Andora 6in1 Macbook Stickers For Macbook Pro 16 inch 2021",
                    OriginalPrice=600000,
                    Price=650000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=1
                },new Product
                {
                    Id = 4,
                    Name = "Apple 20W USB Type-C Charger",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="apple-20w-usb-typec-charger",
                    SeoDescription="Apple 20W USB Type-C Charger",
                    SeoTitle="Apple 20W USB Type-C Charger",
                    OriginalPrice=650000,
                    Price=700000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=2
                },new Product
                {
                    Id = 5,
                    Name = "Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="standaluminum-elevator-stand-for-iphone-ipad-phone-with-adjustable-tilt-angle-wiwu",
                    SeoDescription="Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU",
                    SeoTitle="Stand/Aluminum Elevator Stand for iPhone, iPad, Phone with Adjustable Tilt Angle WIWU",
                    OriginalPrice=210000,
                    Price=250000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=15
                },new Product
                {
                    Id = 6,
                    Name = "WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="hwiwu-waltz-rotating-keyboard-case--bluetooth-keyboard-with-tracpad-360-degree-rotating-screen-wiwu-waltz-rotating-keyboard-for-ipad-pro-11-inch-20182021-air-4-and-ipad-gen-789",
                    SeoDescription="WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9",
                    SeoTitle="WIWU Waltz Rotating Keyboard Case / Bluetooth Keyboard With Tracpad 360 Degree Rotating Screen WIWU Waltz Rotating Keyboard For iPad Pro 11 inch 2018-2021, Air 4 and iPad Gen 7/8/9",
                    OriginalPrice=1100000,
                    Price=1300000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=15
                },new Product
                {
                    Id = 7,
                    Name = "9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="9h-antiscratch-antishock-antifingerprint-tempered-glass-for-all-ipad-jcpal-iclara-ipad-pro-11-pro-129-air-1234-mini-6-gen-234-56789",
                    SeoDescription="9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)",
                    SeoTitle="9H Anti-Scratch, Anti-Shock, Anti-Fingerprint Tempered Glass For All iPad JCPAL iClara (iPad Pro 11', Pro 12'9, Air 1/2/3/4, Mini 6, Gen 2/3/4/ 5/6/7/8/9)",
                    OriginalPrice=300000,
                    Price=350000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=7
                },new Product
                {
                    Id = 8,
                    Name = "KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="keychron-k6-mechanical-keyboard-aluminum-–-no-led-–-hotswap",
                    SeoDescription="KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP",
                    SeoTitle="KEYCHRON K6 Mechanical Keyboard Aluminum – No LED – HOTSWAP",
                    OriginalPrice=16000000,
                    Price=1890000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=8
                },new Product
                {
                    Id = 9,
                    Name = "LOFREE Maus Blue Pearl Bluetooth Mouse",
                    Description="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Details="Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    SeoAlias="lofree-maus-blue-pearl-bluetooth-mouse",
                    SeoDescription="LOFREE Maus Blue Pearl Bluetooth Mouse",
                    SeoTitle="LOFREE Maus Blue Pearl Bluetooth Mouse",
                    OriginalPrice=1200000,
                    Price=1500000,
                    DecreasedPrice=0,
                    Stock=10,
                    ViewCount=0,
                    DateCreated=DateTime.Now,
                    IsFeatured=true,
                    BrandId=9
                }
            );
        }
    }
}