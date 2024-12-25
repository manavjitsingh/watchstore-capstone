using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheHybridWatchStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Watches",
                columns: new[] { "Id", "Brand", "Description", "Features", "Gender", "Movement", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Tissot", "A classic watch with a modern touch.", "[\"23 Jewels\",\"Date Display\",\"Water Resistant\"]", "Unisex", "Automatic", "Tissot T-Classic", 899.99m },
                    { 2, "Rolex", "The Rolex Submariner is an iconic timepiece.", "[\"Water Resistant\",\"Chronometer\",\"Cerachrom Bezel\"]", "Men", "Automatic", "Rolex Submariner", 12500.00m },
                    { 3, "Omega", "The first watch worn on the moon.", "[\"Chronograph\",\"Tachymeter\",\"Hesalite Crystal\"]", "Men", "Manual", "Omega Speedmaster", 5200.00m },
                    { 4, "Tag Heuer", "A racing-inspired watch with a contemporary design.", "[\"Chronograph\",\"Sapphire Crystal\",\"Water Resistant\"]", "Men", "Automatic", "Tag Heuer Carrera", 4500.00m },
                    { 5, "Cartier", "An elegant and timeless piece.", "[\"Sapphire Crystal\",\"Water Resistant\",\"Diamond Bezel\"]", "Women", "Quartz", "Cartier Tank", 3100.00m }
                });

            migrationBuilder.InsertData(
                table: "WatchImages",
                columns: new[] { "ImagesId", "ImagePath", "WatchId" },
                values: new object[,]
                {
                    { 1, "assets/imgs/watches/1-1.jpg", 1 },
                    { 2, "assets/imgs/watches/1-2.jpg", 1 },
                    { 3, "assets/imgs/watches/2-1.jpg", 2 },
                    { 4, "assets/imgs/watches/2-2.jpg", 2 },
                    { 5, "assets/imgs/watches/3-1.jpg", 3 },
                    { 6, "assets/imgs/watches/3-2.jpg", 3 },
                    { 7, "assets/imgs/watches/4-1.jpg", 4 },
                    { 8, "assets/imgs/watches/4-2.jpg", 4 },
                    { 9, "assets/imgs/watches/5-1.jpg", 5 },
                    { 10, "assets/imgs/watches/5-2.jpg", 5 }
                });

            migrationBuilder.InsertData(
                table: "WatchSpecs",
                columns: new[] { "SpecsId", "CaseDiameter", "CaseMaterial", "CaseShape", "CaseThickness", "DialColor", "Engine", "PowerReserve", "StrapMaterial", "WatchId", "WaterResistanceDepth" },
                values: new object[,]
                {
                    { 1, 40.0, "Stainless Steel", "Round", 10.0, "Blue", "Caliber: ETA C07.111", 80, "Leather", 1, 50 },
                    { 2, 41.0, "Stainless Steel", "Round", 12.5, "Black", "Caliber 3230", 70, "Oyster Steel", 2, 300 },
                    { 3, 42.0, "Stainless Steel", "Round", 14.300000000000001, "Black", "Caliber 1861", 48, "Stainless Steel", 3, 50 },
                    { 4, 43.0, "Stainless Steel", "Round", 15.0, "Black", "Caliber Heuer 02", 80, "Leather", 4, 100 },
                    { 5, 29.5, "18K Yellow Gold", "Square", 6.5999999999999996, "White", "Caliber 076", 36, "Leather", 5, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WatchImages",
                keyColumn: "ImagesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WatchSpecs",
                keyColumn: "SpecsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Watches",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
