using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheHybridWatchStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Watches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Movement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WatchImages",
                columns: table => new
                {
                    ImagesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchImages", x => x.ImagesId);
                    table.ForeignKey(
                        name: "FK_WatchImages_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchSpecs",
                columns: table => new
                {
                    SpecsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrapMaterial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DialColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CaseShape = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CaseDiameter = table.Column<double>(type: "float", nullable: false),
                    CaseThickness = table.Column<double>(type: "float", nullable: false),
                    WaterResistanceDepth = table.Column<int>(type: "int", nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PowerReserve = table.Column<int>(type: "int", nullable: false),
                    WatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchSpecs", x => x.SpecsId);
                    table.ForeignKey(
                        name: "FK_WatchSpecs_Watches_WatchId",
                        column: x => x.WatchId,
                        principalTable: "Watches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WatchImages_WatchId",
                table: "WatchImages",
                column: "WatchId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchSpecs_WatchId",
                table: "WatchSpecs",
                column: "WatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WatchImages");

            migrationBuilder.DropTable(
                name: "WatchSpecs");

            migrationBuilder.DropTable(
                name: "Watches");
        }
    }
}
