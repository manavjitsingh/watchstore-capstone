using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheHybridWatchStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class moreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Watches",
                columns: new[] { "Id", "Brand", "Description", "Features", "Gender", "Movement", "Name", "Price" },
                values: new object[,]
                {
                    { 6, "Breitling", "A classic aviation-inspired timepiece.", "[\"Chronograph\",\"Slide Rule Bezel\",\"Water Resistant\"]", "Men", "Automatic", "Breitling Navitimer", 7000.00m },
                    { 7, "IWC", "A sophisticated dress watch with a modern design.", "[\"Chronograph\",\"Sapphire Crystal\",\"Water Resistant\"]", "Men", "Automatic", "IWC Portugieser", 12500.00m },
                    { 8, "Panerai", "A bold and rugged timepiece with Italian flair.", "[\"Power Reserve Indicator\",\"Date Display\",\"Water Resistant\"]", "Men", "Automatic", "Panerai Luminor", 8500.00m },
                    { 9, "Jaeger-LeCoultre", "An iconic watch with a reversible case.", "[\"Sapphire Crystal\",\"Water Resistant\",\"Reversible Case\"]", "Men", "Manual", "Jaeger-LeCoultre Reverso", 10000.00m },
                    { 10, "Audemars Piguet", "A luxury sports watch with an iconic design.", "[\"Sapphire Crystal\",\"Chronograph\",\"Water Resistant\"]", "Men", "Automatic", "Audemars Piguet Royal Oak", 22000.00m },
                    { 11, "Chanel", "A stylish and modern ceramic watch.", "[\"Ceramic Case\",\"Sapphire Crystal\",\"Water Resistant\"]", "Women", "Automatic", "Chanel J12", 5000.00m },
                    { 12, "Bulgari", "An elegant and distinctive watch with a snake motif.", "[\"Diamond Bezel\",\"Sapphire Crystal\",\"Water Resistant\"]", "Women", "Quartz", "Bulgari Serpenti", 8000.00m },
                    { 13, "Rolex", "A timeless and elegant watch for women.", "[\"Date Display\",\"Sapphire Crystal\",\"Water Resistant\"]", "Women", "Automatic", "Rolex Lady-Datejust", 9000.00m },
                    { 14, "Omega", "A luxurious and refined timepiece.", "[\"Diamond Bezel\",\"Sapphire Crystal\",\"Water Resistant\"]", "Women", "Automatic", "Omega Constellation", 7500.00m },
                    { 15, "Cartier", "A graceful and iconic watch with a unique shape.", "[\"Sapphire Crystal\",\"Water Resistant\",\"Diamond Markers\"]", "Women", "Automatic", "Cartier Ballon Bleu", 6000.00m },
                    { 16, "Apple", "The latest Apple Watch with advanced health features.", "[\"Heart Rate Monitor\",\"GPS\",\"Water Resistant\"]", "Unisex", "Smart", "Apple Watch Series 7", 399.99m },
                    { 17, "Samsung", "A powerful smartwatch with fitness tracking.", "[\"Sleep Tracking\",\"GPS\",\"Water Resistant\"]", "Unisex", "Smart", "Samsung Galaxy Watch 5", 349.99m },
                    { 18, "Garmin", "A rugged smartwatch for outdoor adventures.", "[\"GPS\",\"Pulse Ox Sensor\",\"Water Resistant\"]", "Unisex", "Smart", "Garmin Fenix 6", 599.99m },
                    { 19, "Fitbit", "A smartwatch with advanced health and fitness features.", "[\"Heart Rate Monitor\",\"ECG App\",\"Water Resistant\"]", "Unisex", "Smart", "Fitbit Sense", 329.99m },
                    { 20, "Fossil", "A stylish smartwatch with Wear OS.", "[\"Google Assistant\",\"GPS\",\"Water Resistant\"]", "Unisex", "Smart", "Fossil Gen 6", 299.99m }
                });

            migrationBuilder.InsertData(
                table: "WatchImages",
                columns: new[] { "ImagesId", "ImagePath", "WatchId" },
                values: new object[,]
                {
                    { 11, "assets/imgs/watches/6-1.jpg", 6 },
                    { 12, "assets/imgs/watches/6-2.jpg", 6 },
                    { 13, "assets/imgs/watches/7-1.jpg", 7 },
                    { 14, "assets/imgs/watches/7-2.jpg", 7 },
                    { 15, "assets/imgs/watches/8-1.jpg", 8 },
                    { 16, "assets/imgs/watches/8-2.jpg", 8 },
                    { 17, "assets/imgs/watches/9-1.jpg", 9 },
                    { 18, "assets/imgs/watches/9-2.jpg", 9 },
                    { 19, "assets/imgs/watches/10-1.jpg", 10 },
                    { 20, "assets/imgs/watches/10-2.jpg", 10 },
                    { 21, "assets/imgs/watches/11-1.jpg", 11 },
                    { 22, "assets/imgs/watches/11-2.jpg", 11 },
                    { 23, "assets/imgs/watches/12-1.jpg", 12 },
                    { 24, "assets/imgs/watches/12-2.jpg", 12 },
                    { 25, "assets/imgs/watches/13-1.jpg", 13 },
                    { 26, "assets/imgs/watches/13-2.jpg", 13 },
                    { 27, "assets/imgs/watches/14-1.jpg", 14 },
                    { 28, "assets/imgs/watches/14-2.jpg", 14 },
                    { 29, "assets/imgs/watches/15-1.jpg", 15 },
                    { 30, "assets/imgs/watches/15-2.jpg", 15 },
                    { 31, "assets/imgs/watches/16-1.jpg", 16 },
                    { 32, "assets/imgs/watches/16-2.jpg", 16 },
                    { 33, "assets/imgs/watches/17-1.jpg", 17 },
                    { 34, "assets/imgs/watches/17-2.jpg", 17 },
                    { 35, "assets/imgs/watches/18-1.jpg", 18 },
                    { 36, "assets/imgs/watches/18-2.jpg", 18 },
                    { 37, "assets/imgs/watches/19-1.jpg", 19 },
                    { 38, "assets/imgs/watches/19-2.jpg", 19 },
                    { 39, "assets/imgs/watches/20-1.jpg", 20 },
                    { 40, "assets/imgs/watches/20-1.jpg", 20 }
                });

            migrationBuilder.InsertData(
                table: "WatchSpecs",
                columns: new[] { "SpecsId", "CaseDiameter", "CaseMaterial", "CaseShape", "CaseThickness", "DialColor", "Engine", "PowerReserve", "StrapMaterial", "WatchId", "WaterResistanceDepth" },
                values: new object[,]
                {
                    { 6, 43.0, "Stainless Steel", "Round", 14.5, "Black", "Caliber Breitling 01", 70, "Leather", 6, 30 },
                    { 7, 41.0, "18K Rose Gold", "Round", 12.300000000000001, "Silver", "Caliber 69355", 46, "Leather", 7, 30 },
                    { 8, 44.0, "Titanium", "Cushion", 15.6, "Black", "Caliber P.9010", 72, "Rubber", 8, 300 },
                    { 9, 28.800000000000001, "Stainless Steel", "Rectangle", 9.5, "Silver", "Caliber 822", 45, "Leather", 9, 30 },
                    { 10, 41.0, "Stainless Steel", "Octagonal", 10.4, "Blue", "Caliber 2385", 40, "Stainless Steel", 10, 50 },
                    { 11, 38.0, "Ceramic", "Round", 11.5, "White", "Caliber 12.1", 70, "Ceramic", 11, 200 },
                    { 12, 35.0, "18K Rose Gold", "Teardrop", 7.5, "Pink", "Caliber B033", 42, "Leather", 12, 30 },
                    { 13, 28.0, "Stainless Steel", "Round", 10.5, "Silver", "Caliber 2235", 48, "Oyster Steel", 13, 100 },
                    { 14, 32.0, "Stainless Steel", "Round", 10.5, "Mother of Pearl", "Caliber 8800", 55, "Leather", 14, 100 },
                    { 15, 36.600000000000001, "Stainless Steel", "Round", 12.1, "Silver", "Caliber 076", 36, "Leather", 15, 30 },
                    { 16, 45.0, "Aluminum", "Rectangle", 10.699999999999999, "Black", "Apple S7", 18, "Fluoroelastomer", 16, 50 },
                    { 17, 44.0, "Stainless Steel", "Round", 11.1, "Silver", "Exynos W920", 40, "Leather", 17, 50 },
                    { 18, 47.0, "Fiber-reinforced polymer", "Round", 15.800000000000001, "Black", "Garmin", 336, "Silicone", 18, 100 },
                    { 19, 40.5, "Stainless Steel", "Square", 12.4, "Black", "Fitbit OS", 72, "Silicone", 19, 50 },
                    { 20, 44.0, "Stainless Steel", "Round", 12.5, "Black", "Snapdragon Wear 4100+", 24, "Leather", 20, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
