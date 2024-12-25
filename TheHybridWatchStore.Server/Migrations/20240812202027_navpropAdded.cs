using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheHybridWatchStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class navpropAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WatchSpecs_WatchId",
                table: "WatchSpecs");

            migrationBuilder.CreateIndex(
                name: "IX_WatchSpecs_WatchId",
                table: "WatchSpecs",
                column: "WatchId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WatchSpecs_WatchId",
                table: "WatchSpecs");

            migrationBuilder.CreateIndex(
                name: "IX_WatchSpecs_WatchId",
                table: "WatchSpecs",
                column: "WatchId");
        }
    }
}
